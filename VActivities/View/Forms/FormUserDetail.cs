using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VActivities.DataBase.Context;
using VActivities.DataBase.Tables;

namespace VActivities.View.Forms
{
    public partial class FormUserDetail : Form
    {
        // True - форма открыта для редактирования объекта
        private bool edit = false;
        private User user = null;
        private VActivitiesContext context = null;
        public FormUserDetail(VActivitiesContext context, User user = null)
        {
            InitializeComponent();
            // Форма открыта для создания нового объекта
            if(user == null)
            {
                this.user = new User();
                this.user.Login = "Логин";
                this.user.Password = "Пароль";
                this.Text += " - Добавление";
            }
            else
            {
                this.user = user;
                edit = true;
                textBoxLogin.Enabled = false;
                this.Text += " - Изменение";
                buttonAdd.Text = "Сохранить";
            }
            this.context = context;
            textBoxLogin.DataBindings.Add("Text", this.user, "Login");
            checkBoxActive.DataBindings.Add("Checked", this.user, "Active");

            context.Persons.Load();
            comboBoxPerson.Items.AddRange(context.Persons.Local.ToArray());
            if (this.user.Person != null)
                comboBoxPerson.SelectedItem = this.user.Person;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                user.Person = comboBoxPerson.SelectedItem == null ? null : (Person)comboBoxPerson.SelectedItem;
                if (edit == false)
                {
                    if (context.Users.Any(u => u.Login == user.Login))
                    {
                        MessageBox.Show($"Пользователь с логином {user.Login} уже существует", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    context.Users.Add(user);
                }

                user.DatеUpdated = DateTime.Now;
                context.SaveChanges();
                FormBase.AddHistory(context, $"{(edit ? "Изменение" : "Добавление")} пользователя БД", $"{(edit ? "Изменение" : "Добавление")} пользователь {user.Login}");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonSetPassword_Click(object sender, EventArgs e)
        {
            if(textBoxPassword.Text != textBoxPasswordDub.Text)
            {
                MessageBox.Show($"Пароли не совпадают", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            user.SetCryptoPassword(textBoxPassword.Text);
            FormBase.AddHistory(context, "Установка пароля пользователя БД", $"Пользователь {user.Login}");
            buttonClosePanel_Click(sender, e);
        }

        private void buttonClosePanel_Click(object sender, EventArgs e)
        {
            panelSetPassword.Visible = false;
        }

        private void buttonShowPanelSetPassword_Click(object sender, EventArgs e)
        {
            panelSetPassword.Visible = true;
        }

        private void buttonSetNullPerson_Click(object sender, EventArgs e)
        {
            comboBoxPerson.SelectedItem = null;
        }
    }
}
