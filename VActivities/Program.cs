using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using VActivities.DataBase.Context;
using VActivities.DataBase.Tables;
using VActivities.View.Forms;

namespace VActivities
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormBase formBase = new FormBase();
            FormAuthorization formAuthorization = new FormAuthorization();

            do
            {
                if (formAuthorization.ShowDialog() == DialogResult.OK)
                {

                    VActivitiesContext contex = new VActivitiesContext();

                    // Выполняем создание базы данных только в том случае если ещё не была создана
                    contex.Database.Initialize(false);

                    // Если пользователей нет то добавляем одного пользователя admin
                    if (contex.Users.Count() == 0)
                    {
                        Person personAdm = new Person();
                        personAdm.Surname = "Админов";
                        personAdm.Name = "Админ";
                        personAdm.MiddleName = "Админович";
                        contex.Persons.Add(personAdm);
                        contex.SaveChanges();

                        User userAdmin = new User();
                        userAdmin.Login = "admin";
                        userAdmin.SetCryptoPassword("admin");
                        userAdmin.Person = personAdm;
                        userAdmin.Active = true;
                        contex.Users.Add(userAdmin);
                        contex.SaveChanges();
                    }

                    // Проверка логина и пароля
                    contex.Users.Include(u => u.Person).Load();
                    FormBase.CurrentUser = contex.Users.Local.FirstOrDefault(u => u.Login == formAuthorization.Login);
                    if (FormBase.CurrentUser == null || !FormBase.CurrentUser.ComparePassword(formAuthorization.Password))
                    {
                        FormBase.AddHistory(contex, "Попытка авторизации", $"Логин - {formAuthorization.Login} или пароль введён не верно");
                        MessageBox.Show($"Логин или пароль введён не верно", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        FormBase.CurrentUser = null;
                        continue;
                    }

                    // Проверка активности учётной записи
                    if (!FormBase.CurrentUser.Active)
                    {
                        FormBase.AddHistory(contex, "Попытка авторизации", "Учётная запись не активна");
                        MessageBox.Show($"Учётная запись {FormBase.CurrentUser.Login} не активна. Доступ запрещён. ", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Запуск главной рабочей формы
                    if (FormBase.CurrentUser.Active)
                    {
                        FormBase.AddHistory(contex, "Успешная авторизации", null);
                        contex.Dispose();
                        Application.Run(new FormBase());
                    }
                }
                else
                    return;

            } while (FormBase.CurrentUser == null);
        }
    }
}