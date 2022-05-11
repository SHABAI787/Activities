using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VActivities.DataBase.Context;
using VActivities.DataBase.Tables;

namespace VActivities
{
    public partial class Form1 : Form
    {
        private VActivitiesContext contex = null;
        public Form1()
        {
            InitializeComponent();
            contex = new VActivitiesContext();
            contex.Database.Initialize(false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"Всего физ.лиц- {contex.Persons.Count()} всего пользователь БД - {contex.Users.Count()}");

            Person person = new Person();
            person.Surname = "Иванов";
            person.Name = "Иван";
            person.MiddleName = "Батькович";
            contex.Persons.Add(person);
            contex.SaveChanges();

            User user = new User();
            user.Login = $"nik{contex.Users.Count()}";
            user.SetCryptoPassword("123");
            user.Active = true;
            user.Person = person;
            contex.Users.Add(user);
            contex.SaveChanges();
            if(contex.Users.First().ComparePassword("123"))
                MessageBox.Show("Пароли совпадают");
        }
    }
}
