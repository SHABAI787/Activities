
namespace VActivities.View.Forms
{
    partial class FormUserDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.comboBoxPerson = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.checkBoxActive = new System.Windows.Forms.CheckBox();
            this.buttonShowPanelSetPassword = new System.Windows.Forms.Button();
            this.panelSetPassword = new System.Windows.Forms.Panel();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxPasswordDub = new System.Windows.Forms.TextBox();
            this.buttonSetPassword = new System.Windows.Forms.Button();
            this.buttonClosePanel = new System.Windows.Forms.Button();
            this.buttonSetNullPerson = new System.Windows.Forms.Button();
            this.panelSetPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(27, 29);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(362, 29);
            this.textBoxLogin.TabIndex = 0;
            this.textBoxLogin.Text = "Логин";
            // 
            // comboBoxPerson
            // 
            this.comboBoxPerson.FormattingEnabled = true;
            this.comboBoxPerson.Location = new System.Drawing.Point(27, 67);
            this.comboBoxPerson.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.comboBoxPerson.Name = "comboBoxPerson";
            this.comboBoxPerson.Size = new System.Drawing.Size(362, 32);
            this.comboBoxPerson.TabIndex = 2;
            this.comboBoxPerson.Text = "Физическое лицо";
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Location = new System.Drawing.Point(27, 166);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(362, 59);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // checkBoxActive
            // 
            this.checkBoxActive.AutoSize = true;
            this.checkBoxActive.Location = new System.Drawing.Point(27, 116);
            this.checkBoxActive.Name = "checkBoxActive";
            this.checkBoxActive.Size = new System.Drawing.Size(105, 28);
            this.checkBoxActive.TabIndex = 4;
            this.checkBoxActive.Text = "Активен";
            this.checkBoxActive.UseVisualStyleBackColor = true;
            // 
            // buttonShowPanelSetPassword
            // 
            this.buttonShowPanelSetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonShowPanelSetPassword.Location = new System.Drawing.Point(214, 112);
            this.buttonShowPanelSetPassword.Name = "buttonShowPanelSetPassword";
            this.buttonShowPanelSetPassword.Size = new System.Drawing.Size(175, 34);
            this.buttonShowPanelSetPassword.TabIndex = 5;
            this.buttonShowPanelSetPassword.Text = "Задать пароль";
            this.buttonShowPanelSetPassword.UseVisualStyleBackColor = true;
            this.buttonShowPanelSetPassword.Click += new System.EventHandler(this.buttonShowPanelSetPassword_Click);
            // 
            // panelSetPassword
            // 
            this.panelSetPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSetPassword.Controls.Add(this.buttonClosePanel);
            this.panelSetPassword.Controls.Add(this.buttonSetPassword);
            this.panelSetPassword.Controls.Add(this.textBoxPasswordDub);
            this.panelSetPassword.Controls.Add(this.textBoxPassword);
            this.panelSetPassword.Location = new System.Drawing.Point(38, 45);
            this.panelSetPassword.Name = "panelSetPassword";
            this.panelSetPassword.Size = new System.Drawing.Size(332, 153);
            this.panelSetPassword.TabIndex = 6;
            this.panelSetPassword.Visible = false;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(14, 26);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(294, 29);
            this.textBoxPassword.TabIndex = 0;
            this.textBoxPassword.Text = "Пароль";
            // 
            // textBoxPasswordDub
            // 
            this.textBoxPasswordDub.Location = new System.Drawing.Point(14, 65);
            this.textBoxPasswordDub.Name = "textBoxPasswordDub";
            this.textBoxPasswordDub.Size = new System.Drawing.Size(294, 29);
            this.textBoxPasswordDub.TabIndex = 1;
            this.textBoxPasswordDub.Text = "Повторите пароль";
            // 
            // buttonSetPassword
            // 
            this.buttonSetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSetPassword.Location = new System.Drawing.Point(67, 107);
            this.buttonSetPassword.Name = "buttonSetPassword";
            this.buttonSetPassword.Size = new System.Drawing.Size(175, 34);
            this.buttonSetPassword.TabIndex = 6;
            this.buttonSetPassword.Text = "Установить";
            this.buttonSetPassword.UseVisualStyleBackColor = true;
            this.buttonSetPassword.Click += new System.EventHandler(this.buttonSetPassword_Click);
            // 
            // buttonClosePanel
            // 
            this.buttonClosePanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClosePanel.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonClosePanel.Location = new System.Drawing.Point(309, -1);
            this.buttonClosePanel.Name = "buttonClosePanel";
            this.buttonClosePanel.Size = new System.Drawing.Size(23, 27);
            this.buttonClosePanel.TabIndex = 7;
            this.buttonClosePanel.Text = "X";
            this.buttonClosePanel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonClosePanel.UseVisualStyleBackColor = true;
            this.buttonClosePanel.Click += new System.EventHandler(this.buttonClosePanel_Click);
            // 
            // buttonSetNullPerson
            // 
            this.buttonSetNullPerson.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSetNullPerson.ForeColor = System.Drawing.Color.DarkRed;
            this.buttonSetNullPerson.Location = new System.Drawing.Point(388, 67);
            this.buttonSetNullPerson.Name = "buttonSetNullPerson";
            this.buttonSetNullPerson.Size = new System.Drawing.Size(23, 32);
            this.buttonSetNullPerson.TabIndex = 8;
            this.buttonSetNullPerson.Text = "X";
            this.buttonSetNullPerson.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSetNullPerson.UseVisualStyleBackColor = true;
            this.buttonSetNullPerson.Click += new System.EventHandler(this.buttonSetNullPerson_Click);
            // 
            // FormUserDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(422, 252);
            this.Controls.Add(this.buttonSetNullPerson);
            this.Controls.Add(this.panelSetPassword);
            this.Controls.Add(this.buttonShowPanelSetPassword);
            this.Controls.Add(this.checkBoxActive);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxPerson);
            this.Controls.Add(this.textBoxLogin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "FormUserDetail";
            this.Text = "Пользователь базы данных";
            this.panelSetPassword.ResumeLayout(false);
            this.panelSetPassword.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.ComboBox comboBoxPerson;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.CheckBox checkBoxActive;
        private System.Windows.Forms.Button buttonShowPanelSetPassword;
        private System.Windows.Forms.Panel panelSetPassword;
        private System.Windows.Forms.Button buttonClosePanel;
        private System.Windows.Forms.Button buttonSetPassword;
        private System.Windows.Forms.TextBox textBoxPasswordDub;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonSetNullPerson;
    }
}