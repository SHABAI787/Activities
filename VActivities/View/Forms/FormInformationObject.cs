using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using VActivities.DataBase.Context;
using VActivities.DataBase.Tables;

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
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                var item = row.DataBoundItem as InformationObject;
                if (item != null && item.Id == 0)
                    FormBase.AddHistory(contex, "Добавление объекта", item.ToString());
            }
            contex.SaveChanges();
        }

        private void FormInformationObject_Load(object sender, EventArgs e)
        {
            toolStripButtonUpdate_Click(sender, e);
        }
    }
}
