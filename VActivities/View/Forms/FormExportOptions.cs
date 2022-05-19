using System;
using System.Windows.Forms;

namespace VActivities.View.Forms
{
    public partial class FormExportOptions : Form
    {
        /// <summary>
        /// Все строки
        /// </summary>
        public bool AllRows { get { return radioButtonAllRow.Checked; } }

        public FormExportOptions()
        {
            InitializeComponent();
        }

        private void buttonStartExport_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
