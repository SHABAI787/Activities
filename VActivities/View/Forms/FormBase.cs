using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using VActivities.DataBase.Context;
using VActivities.DataBase.Tables;
using VActivities.View.Forms;
using VActivities.Exchange;

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
            toolStripButtonUpdate_Click(sender, e);
            this.Text += $" - {CurrentUser.Login}";
            if (CurrentUser.Person != null)
                this.Text += $" ({ CurrentUser.Person?.ShortFIO})";
        }

        private void toolStripButtonUpdate_Click(object sender, EventArgs e)
        {
            contex = new VActivitiesContext();
            contex.Activities
            .Include(a => a.BasisСonducting)
            .Include(a => a.Purpose)
            .Include(a => a.InformationObject)
            .Include(a => a.Responsible)
            .Include(a => a.Executor).Load();
            bindingSource.DataSource = contex.Activities.Local.ToBindingList();
            dataGridView.DataSource = bindingSource;
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

        private void физлицаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormSimple(SimpleForm.Person).Show();
        }

        private void пользователиБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormUsers().Show();
        }

        private void историяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormSimple(SimpleForm.History).Show();
        }

        private void toolStripButtonExport_Click(object sender, EventArgs e)
        {
            dataGridView.ExportToXML();
        }

        private void toolStripButtonImport_Click(object sender, EventArgs e)
        {
            bindingSource.ImportFromXML<Activities>(contex);
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView.EndEdit();

                if (contex.ChangeTracker.Entries().Count() <= 1 && dataGridView.Rows.Count == 1)
                {
                    bindingSource.Add(dataGridView.Rows[0].DataBoundItem);
                    contex.SaveChanges();
                    toolStripButtonUpdate_Click(sender, e);
                }
                else
                {
                    foreach (var item in contex.ChangeTracker.Entries())
                    {
                        if (item.State == EntityState.Deleted)
                            FormBase.AddHistory(contex, $"Удаление, форма {this.Text}", item.Entity.ToString());

                        if (item.State == EntityState.Added)
                            FormBase.AddHistory(contex, $"Добавление, форма {this.Text}", item.Entity.ToString());

                        if (item.State == EntityState.Modified)
                            FormBase.AddHistory(contex, $"Изменение, форма {this.Text}", item.Entity.ToString());
                    }

                    contex.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            toolStripButtonSave_Click(sender, e);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            new FormActivitiesDetail(contex).Show();
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentCell != null && dataGridView.CurrentCell.RowIndex >= 0)
                new FormActivitiesDetail(contex, (Activities)dataGridView.Rows[dataGridView.CurrentCell.RowIndex].DataBoundItem).Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            new FormSearch(contex, dataGridView).Show();
        }
    }
}
