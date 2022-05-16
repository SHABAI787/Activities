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
            bool boolValue = false;

            if (value == null)
                return;

            if (DateTime.TryParse(value.ToString(), out dateTime))
                prInf.SetValue(this, dateTime);
            else
                if (bool.TryParse(value.ToString(), out boolValue))
                prInf.SetValue(this, boolValue);
            else
                prInf.SetValue(this, (string.IsNullOrEmpty((string)value) ? null : value));
        }
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

        public virtual void Conver<T>(Row row, VActivitiesContext context)
        {
            List<Person> persons = null;
            List<User> users = null;
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
                                prInf.SetValue(this, persons.FirstOrDefault(p => p.GetType().GetProperty(atr.Identifier).GetValue(p).ToString() == cell.Value));
                            }
                            break;
                        case TableDB.User:
                            {
                                if (users == null)
                                {
                                    context.Users.Include(u => u.Person).Load();
                                    users = context.Users.ToList();
                                }
                                prInf.SetValue(this, users.FirstOrDefault(p => p.GetType().GetProperty(atr.Identifier).GetValue(p).ToString() == cell.Value));
                            }
                            break;
                        default:
                            throw new ArgumentOutOfRangeException($"Не задано действие для {Enum.GetName(typeof(TableDB), atr)}");
                    }
                }
                else
                    SetValue(prInf, cell.Value);
            }
        }
    }
}
