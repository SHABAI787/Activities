using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using VActivities.DataBase.Context;
using VActivities.DataBase.Tables;
using VActivities.Exchange;

namespace VActivities.View.Forms
{
    public partial class FormUsers : Form
    {
        private VActivitiesContext contex = null;

        public FormUsers()
        {
            InitializeComponent();
        }

        private void toolStripButtonUpdate_Click(object sender, EventArgs e)
        {
            contex = new VActivitiesContext();
            contex.Users.Include(p => p.Person).Load();
            bindingSource.DataSource = contex.Users.Local.ToBindingList();
            dataGridView.DataSource = bindingSource;
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            toolStripButtonUpdate_Click(sender, e);
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {

            try
            {
                dataGridView.EndEdit();

                if (contex.ChangeTracker.Entries().Count() == 0 && dataGridView.Rows.Count == 1)
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

        private void toolStripButtonExport_Click(object sender, EventArgs e)
        {
            dataGridView.ExportToXML();
        }

        private void toolStripButtonImport_Click(object sender, EventArgs e)
        {
            bindingSource.ImportFromXML<User>(contex);
        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ((User)dataGridView.Rows[e.RowIndex].DataBoundItem).DatеUpdated = DateTime.Now;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            new FormUserDetail(contex).Show();
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentCell != null && dataGridView.CurrentCell.RowIndex >= 0)
                new FormUserDetail(contex, (User)dataGridView.Rows[dataGridView.CurrentCell.RowIndex].DataBoundItem).Show();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            toolStripButtonSave_Click(sender, e);
        }
    }
}
