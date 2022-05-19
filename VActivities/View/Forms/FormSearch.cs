using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
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
            || (a.DateIn != null && a.DateIn.ToString().Contains(textBox.Text))
            || (a.DateOut != null && a.DateOut.ToString().Contains(textBox.Text))
            || (a.DatеCreated != null && a.DatеCreated.ToString().Contains(textBox.Text))
            || (a.BasisСonducting != null && a.BasisСonducting.ToString().ToUpper().Contains(textBox.Text))
            || (a.Purpose != null && a.Purpose.ToString().ToUpper().Contains(textBox.Text))
            || (a.InformationObject != null && a.InformationObject.ToString().ToUpper().Contains(textBox.Text))
            || (a.Responsible != null && a.Responsible.ToString().ToUpper().Contains(textBox.Text))
            || (a.Executor != null && a.Executor.ToString().ToUpper().Contains(textBox.Text))
            || (a.Feedback != null && a.Feedback.ToUpper().ToUpper().Contains(textBox.Text)));
            dataGridView.DataSource = bindingSource;
        }
    }
}
