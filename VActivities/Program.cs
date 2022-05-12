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
            User user = null;

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

                    user = FormBase.Contex.Users.FirstOrDefault(u => u.Login == formAuthorization.Login);

                    if (user == null || !user.ComparePassword(formAuthorization.Password))
                    {
                        MessageBox.Show($"Логин или пароль введён не верно", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        continue;
                    }

                    if (!user.Active)
                    {
                        MessageBox.Show($"Учётная запись {user.Login} не активна. Доступ запрещён. ", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (user.Active)
                    {
                        Application.Run(new FormBase());
                    }
                }
                else
                    return;
                
            } while (user == null);
        }
    }
}