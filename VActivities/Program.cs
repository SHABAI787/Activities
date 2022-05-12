using System;
using System.Linq;
using System.Windows.Forms;
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
                    FormBase.Contex.Database.Initialize(false);

                    if(FormBase.Contex.Users.Count() == 0)
                    {
                        User userAdmin = new User();
                        userAdmin.Login = "admin";
                        userAdmin.SetCryptoPassword("admin");
                        userAdmin.Active = true;
                        FormBase.Contex.Users.Add(userAdmin);
                        FormBase.Contex.SaveChanges();
                    }

                    formBase.User = FormBase.Contex.Users.FirstOrDefault(u => u.Login == formAuthorization.Login);

                    if (formBase.User == null || !formBase.User.ComparePassword(formAuthorization.Password))
                    {
                        formBase.AddHistory("Попытка авторизации", $"Логин - {formAuthorization.Login} или пароль введён не верно");
                        MessageBox.Show($"Логин или пароль введён не верно", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        continue;
                    }

                    if (!formBase.User.Active)
                    {
                        formBase.AddHistory("Попытка авторизации", "Учётная запись не активна");
                        MessageBox.Show($"Учётная запись {formBase.User.Login} не активна. Доступ запрещён. ", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (formBase.User.Active)
                    {
                        formBase.AddHistory("Успешная авторизации", null);
                        Application.Run(new FormBase());
                    }
                }
                else
                    return;
                
            } while (formBase.User == null);
        }
    }
}