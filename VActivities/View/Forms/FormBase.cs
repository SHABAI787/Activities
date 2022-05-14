using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using VActivities.DataBase.Context;
using VActivities.DataBase.Tables;
using VActivities.View.Forms;

namespace VActivities
{
    /// <summary>
    /// Базовое - основное рабочее окно
    /// </summary>
    public partial class FormBase : Form
    {
        private VActivitiesContext contex = null;

        /// <summary>
        /// Текущий пользователь ПО
        /// </summary>
        public static User CurrentUser = null;

        public FormBase()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Добавление истории действий пользователя
        /// </summary>
        /// <param name="contex"></param>
        /// <param name="name">Наименование действия</param>
        /// <param name="description">Описание</param>
        public static void AddHistory(VActivitiesContext contex, string name, string description)
        {
            History history = new History();
            history.Name = name;
            history.Description = description;
            if(CurrentUser != null)
                history.User = contex.Users.FirstOrDefault(u => u.Login == CurrentUser.Login);
            contex.History.Add(history);
            contex.SaveChanges();
        }

        public static void ShowError(string text, string caption = "Ошибка")
        {
            MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void toolStripButtonUpdate_Click(object sender, EventArgs e)
        {
            contex = new VActivitiesContext();
            contex.Activities
            .Include("BasisСonducting")
            .Include("Purpose")
            .Include("InformationObject")
            .Include("Responsible")
            .Include("Executor").Load();
            bindingSourceActivities.DataSource = contex.Activities.Local.ToBindingList();
            dataGridViewActivities.DataSource = bindingSourceActivities;
        }

        private void объектыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormSimple(SimpleForm.InformationObject).Show();
        }

        private void целиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormSimple(SimpleForm.Purpose).Show();
        }

        private void основанияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormSimple(SimpleForm.BasisСonducting).Show();
        }
    }
}
