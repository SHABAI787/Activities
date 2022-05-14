using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using VActivities.DataBase.Context;
using VActivities.DataBase.Tables;
using VActivities.Exchange;

namespace VActivities.View.Forms
{
    public partial class FormInformationObject : Form
    {
        private VActivitiesContext contex = null;
        public FormInformationObject()
        {
            InitializeComponent();
        }

        private void toolStripButtonUpdate_Click(object sender, EventArgs e)
        {
            contex = new VActivitiesContext();
            contex.InformationObjects.Load();
            bindingSource.DataSource = contex.InformationObjects.Local.ToBindingList();
            dataGridView.DataSource = bindingSource;
        }

        
        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            ((InformationObject)dataGridView.Rows[e.RowIndex].DataBoundItem).DatеUpdated = DateTime.Now;
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            dataGridView.EndEdit();

            foreach (var item in contex.ChangeTracker.Entries())
            {
                if(item.State == EntityState.Deleted)
                    FormBase.AddHistory(contex, "Удаление объекта", item.Entity.ToString());

                if (item.State == EntityState.Added || item.State == EntityState.Detached)
                    FormBase.AddHistory(contex, "Добавление объекта", item.Entity.ToString());

                if (item.State == EntityState.Modified)
                    FormBase.AddHistory(contex, "Изменение объекта", item.Entity.ToString());
            }

            contex.SaveChanges();
        }

        private void FormInformationObject_Load(object sender, EventArgs e)
        {
            toolStripButtonUpdate_Click(sender, e);
        }

        private void toolStripButtonExport_Click(object sender, EventArgs e)
        {
            dataGridView.ExportToXML();
        }

        private void toolStripButtonImport_Click(object sender, EventArgs e)
        {
            bindingSource.ImportFromXML<InformationObject>();
        }
    }
}
