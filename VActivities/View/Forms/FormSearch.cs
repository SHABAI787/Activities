using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VActivities.DataBase.Context;

namespace VActivities.View.Forms
{
    public partial class FormSearch : Form
    {
        private BindingSource bindingSource = null;
        private DataGridView dataGridView = null;
        private VActivitiesContext context = null;
        public FormSearch(VActivitiesContext context, DataGridView dataGridView)
        {
            InitializeComponent();
            this.bindingSource = (BindingSource)dataGridView.DataSource;
            this.dataGridView = dataGridView;
            this.context = context;
        }

        private void buttonStartSearch_Click(object sender, EventArgs e)
        {
            context = new VActivitiesContext();
            context.Activities
            .Include(a => a.BasisСonducting)
            .Include(a => a.Purpose)
            .Include(a => a.InformationObject)
            .Include(a => a.Responsible)
            .Include(a => a.Executor).Load();

            textBox.Text = textBox.Text.ToUpper();

            bindingSource.DataSource = context.Activities.Local.ToBindingList()
                .Where(a =>
               (a.Num.ToString().ToUpper().Contains(textBox.Text))
            || (a.Name != null && a.Name.ToUpper().Contains(textBox.Text))
            || (a.Place != null && a.Place.ToUpper().Contains(textBox.Text))
            || (a.RegNum != null && a.RegNum.ToUpper().Contains(textBox.Text))
            || (a.RegNumIn != null && a.RegNumIn.ToUpper().Contains(textBox.Text))
            || (a.Result != null && a.Result.ToUpper().Contains(textBox.Text))
            || (a.Feedback != null && a.Feedback.ToUpper().Contains(textBox.Text)));
            dataGridView.DataSource = bindingSource;
        }
    }
}
