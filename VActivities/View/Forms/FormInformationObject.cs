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
using VActivities.DataBase.Tables;

namespace VActivities.View.Forms
{
    public partial class FormInformationObject : Form
    {
        public FormInformationObject()
        {
            InitializeComponent();
        }

        private void toolStripButtonUpdate_Click(object sender, EventArgs e)
        {
            FormBase.Contex.InformationObjects.Load();
            bindingSource.DataSource = FormBase.Contex.InformationObjects.Local.ToBindingList();
            dataGridView.DataSource = bindingSource;
        }

        private void bindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_CurrentCellChanged(object sender, EventArgs e)
        {

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
                    FormBase.AddHistory("Добавление объекта", item.ToString());
            }
            FormBase.Contex.SaveChanges();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //dataGridView.EndEdit();
        }

        private void dataGridView_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {

        }

        private void FormInformationObject_Load(object sender, EventArgs e)
        {
            toolStripButtonUpdate_Click(sender, e);
        }
    }
}
