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
using VActivities.View.Forms;

namespace VActivities
{
    public partial class FormBase : Form
    {
        public static User User = null;
        public static VActivitiesContext Contex = new VActivitiesContext();
        public FormBase()
        {
            InitializeComponent();
        }

        public static void AddHistory(string name, string description)
        {
            if(Contex != null)
            {
                History history = new History();
                history.Name = name;
                history.Description = description;
                history.User = User;
                Contex.History.Add(history);
                Contex.SaveChanges();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"Всего физ.лиц- {Contex.Persons.Count()} всего пользователь БД - {Contex.Users.Count()}");

            Person person = new Person();
            person.Surname = "Иванов";
            person.Name = "Иван";
            person.MiddleName = "Батькович";
            Contex.Persons.Add(person);
            Contex.SaveChanges();

            User user = new User();
            user.Login = $"nik{Contex.Users.Count()}";
            user.SetCryptoPassword("123");
            user.Active = true;
            user.Person = person;
            Contex.Users.Add(user);
            Contex.SaveChanges();
           
        }

        private void toolStripButtonUpdate_Click(object sender, EventArgs e)
        {
            Contex.Activities
                .Include("BasisСonducting")
                .Include("Purpose")
                .Include("InformationObject")
                .Include("Responsible")
                .Include("Executor").Load();
            bindingSourceActivities.DataSource = Contex.Activities.Local.ToBindingList();
            dataGridViewActivities.DataSource = bindingSourceActivities;
        }

        private void объектыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormInformationObject().Show();
        }
    }
}
