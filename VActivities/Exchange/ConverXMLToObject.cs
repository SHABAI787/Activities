using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using VActivities.DataBase;
using VActivities.DataBase.Context;
using VActivities.DataBase.Tables;

namespace VActivities.Exchange
{
    /// <summary>
    /// Преобразование XML документа в объект T
    /// </summary>
    public abstract class ConverXMLToObject
    {
        private void SetValue(PropertyInfo prInf, object value)
        {
            DateTime dateTime = DateTime.MinValue;
            DateTime dateTimeNull = DateTime.MinValue;
            bool boolValue = false;
            int intValue = 0;

            if (value == null)
                return;

            if (prInf.PropertyType.Name == "Nullable`1" && DateTime.TryParse(value.ToString(), out dateTimeNull))
                prInf.SetValue(this, (DateTime?)dateTimeNull);

            if (prInf.PropertyType.Name == "DateTime" && DateTime.TryParse(value.ToString(), out dateTime))
                prInf.SetValue(this, dateTime);
            else
                if (prInf.PropertyType.Name == "Boolean" && bool.TryParse(value.ToString(), out boolValue))
                prInf.SetValue(this, boolValue);

            else
                if (prInf.PropertyType.Name == "Int32" && Int32.TryParse(value.ToString(), out intValue))
                prInf.SetValue(this, intValue);

            else
                if (prInf.PropertyType.Name == "Nullable`1" && DateTime.TryParse(value.ToString(), out dateTimeNull))
                prInf.SetValue(this, (DateTime?)dateTimeNull);
            else
                if (prInf.PropertyType.Name == "Nullable`1" && string.IsNullOrEmpty(value.ToString()))
                prInf.SetValue(this, null);
            else
                if (prInf.PropertyType.Name == "String")
                prInf.SetValue(this, (string)value);
            else
                throw new Exception($"Преобрзование для типа данных {prInf.PropertyType.Name} не задано");
        }

        /// <summary>
        /// Простое преобразование типов данных
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="row"></param>
        public virtual void Conver<T>(Row row)
        {
            foreach (var cell in row.Cells)
            {
                DateTime dateTime = DateTime.MinValue;

                PropertyInfo prInf = this.GetType().GetProperty(cell.Name);
                Attribute attribute = prInf.GetCustomAttribute(typeof(NotMappedAttribute));
                if (attribute != null)
                    continue;

                if (cell.Value != null && DateTime.TryParse(cell.Value, out dateTime))
                    prInf.SetValue(this, dateTime);
                else
                    prInf.SetValue(this, cell.Value);
            }
        }

        /// <summary>
        /// Преобразование с поиском объектов в базе данных. При отсутствии объекта выполняется его создание
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="row"></param>
        /// <param name="context"></param>
        public virtual void Conver<T>(Row row, VActivitiesContext context)
        {
            List<Person> persons = null;
            List<User> users = null;
            List<Purpose> purposes = null;
            List<InformationObject> informationObjects = null;
            List<BasisСonducting> basisСonductings = null;
            foreach (var cell in row.Cells)
            {
                DateTime dateTime = DateTime.MinValue;

                PropertyInfo prInf = this.GetType().GetProperty(cell.Name);
                Attribute attribute = prInf.GetCustomAttribute(typeof(NotMappedAttribute));
                if (attribute != null)
                    continue;

                attribute = prInf.GetCustomAttribute(typeof(VActivities.DataBase.ExternalKeyAttribute));
                if (attribute != null)
                {
                    ExternalKeyAttribute atr = attribute as ExternalKeyAttribute;
                    switch (atr.Table)
                    {
                        case TableDB.Person:
                            {
                                if (persons == null)
                                {
                                    context.Persons.Load();
                                    persons = context.Persons.ToList();
                                }

                                Person person = persons.FirstOrDefault(p => p.GetType().GetProperty(atr.Identifier).GetValue(p).ToString() == cell.Value);
                                if(person == null)
                                {
                                    person = new Person();
                                    string[] FIO = cell.Value.Split(' ');
                                    if (FIO.Length > 0)
                                        person.Surname = FIO[0];
                                    if (FIO.Length > 1)
                                        person.Name = FIO[1];
                                    if (FIO.Length > 2)
                                        person.MiddleName = FIO[2];
                                }
                                prInf.SetValue(this, person);
                            }
                            break;
                        case TableDB.User:
                            {
                                if (users == null)
                                {
                                    context.Users.Include(u => u.Person).Load();
                                    users = context.Users.ToList();
                                }
                                User user = users.FirstOrDefault(p => p.GetType().GetProperty(atr.Identifier).GetValue(p).ToString() == cell.Value);
                                if(user == null)
                                {
                                    user = new User();
                                    user.Login = cell.Value;
                                }

                                prInf.SetValue(this, user);
                            }
                            break;
                        case TableDB.Purpose:
                            {
                                if (purposes == null)
                                {
                                    context.Purposes.Load();
                                    purposes = context.Purposes.ToList();
                                }
                                Purpose purpose = purposes.FirstOrDefault(p => p.GetType().GetProperty(atr.Identifier).GetValue(p).ToString() == cell.Value);
                                if(purpose == null)
                                {
                                    purpose = new Purpose();
                                    purpose.Name = cell.Value;
                                }
                                prInf.SetValue(this, purpose);
                            }
                            break;
                        case TableDB.InformationObject:
                            {
                                if (informationObjects == null)
                                {
                                    context.InformationObjects.Load();
                                    informationObjects = context.InformationObjects.ToList();
                                }
                                InformationObject informationObject = informationObjects.FirstOrDefault(p => p.GetType().GetProperty(atr.Identifier).GetValue(p).ToString() == cell.Value);
                                if (informationObject == null)
                                {
                                    informationObject = new InformationObject();
                                    string[] items = cell.Value.Split(new string[] { ", " }, StringSplitOptions.None);
                                    if (items.Length > 0)
                                        informationObject.Num = items[0];
                                    if (items.Length > 1)
                                        informationObject.IMEI = items[1];
                                    if (items.Length > 2)
                                        informationObject.IMSI = items[2];
                                }
                                prInf.SetValue(this, informationObject);
                            }
                            break;
                        case TableDB.BasisСonducting:
                            {
                                if (basisСonductings == null)
                                {
                                    context.InformationObjects.Load();
                                    basisСonductings = context.BasisСonductings.ToList();
                                }
                                BasisСonducting basisСonducting = basisСonductings.FirstOrDefault(p => p.GetType().GetProperty(atr.Identifier).GetValue(p).ToString() == cell.Value);
                                if (basisСonducting == null)
                                {
                                    basisСonducting = new BasisСonducting();
                                    basisСonducting.Name = cell.Value;
                                }
                                prInf.SetValue(this, basisСonducting);
                            }
                            break;
                        default:
                            throw new Exception($"Не задано действие для {Enum.GetName(typeof(TableDB), atr)}");
                    }
                }
                else
                    SetValue(prInf, cell.Value);
            }
        }
    }
}
