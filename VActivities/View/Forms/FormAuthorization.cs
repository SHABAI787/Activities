using System;
using System.Windows.Forms;

namespace VActivities.View.Forms
{
    public partial class FormAuthorization : Form
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public FormAuthorization()
        {
            InitializeComponent();
            Login = "Логин";
            Password = "Пароль";
#if DEBUG
            Login = "admin";
            Password = "admin";
#endif

            textBoxLogin.DataBindings.Add("Text", this, "Login", false, DataSourceUpdateMode.OnPropertyChanged);
            textBoxPassword.DataBindings.Add("Text", this, "Password", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Login))
            {
                MessageBox.Show("Введите логин", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
