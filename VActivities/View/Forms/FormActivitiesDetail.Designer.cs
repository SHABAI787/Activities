
namespace VActivities.View.Forms
{
    partial class FormActivitiesDetail
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxBasisСonducting = new System.Windows.Forms.ComboBox();
            this.comboBoxPurpose = new System.Windows.Forms.ComboBox();
            this.comboBoxInformationObject = new System.Windows.Forms.ComboBox();
            this.comboBoxResponsible = new System.Windows.Forms.ComboBox();
            this.comboBoxExecutor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPlace = new System.Windows.Forms.TextBox();
            this.textBoxCustomer = new System.Windows.Forms.TextBox();
            this.textBoxRegNum = new System.Windows.Forms.TextBox();
            this.textBoxRegNumIn = new System.Windows.Forms.TextBox();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.textBoxFeedback = new System.Windows.Forms.TextBox();
            this.dateTimePickerDateIn = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerDateOut = new System.Windows.Forms.DateTimePicker();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.numericUpDownNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNum)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(23, 39);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(599, 26);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.Text = "Наименование";
            // 
            // comboBoxBasisСonducting
            // 
            this.comboBoxBasisСonducting.FormattingEnabled = true;
            this.comboBoxBasisСonducting.Location = new System.Drawing.Point(23, 71);
            this.comboBoxBasisСonducting.Name = "comboBoxBasisСonducting";
            this.comboBoxBasisСonducting.Size = new System.Drawing.Size(599, 28);
            this.comboBoxBasisСonducting.TabIndex = 2;
            this.comboBoxBasisСonducting.Text = "Основание для проведения";
            // 
            // comboBoxPurpose
            // 
            this.comboBoxPurpose.FormattingEnabled = true;
            this.comboBoxPurpose.Location = new System.Drawing.Point(23, 105);
            this.comboBoxPurpose.Name = "comboBoxPurpose";
            this.comboBoxPurpose.Size = new System.Drawing.Size(599, 28);
            this.comboBoxPurpose.TabIndex = 3;
            this.comboBoxPurpose.Text = "Цель";
            // 
            // comboBoxInformationObject
            // 
            this.comboBoxInformationObject.FormattingEnabled = true;
            this.comboBoxInformationObject.Location = new System.Drawing.Point(23, 139);
            this.comboBoxInformationObject.Name = "comboBoxInformationObject";
            this.comboBoxInformationObject.Size = new System.Drawing.Size(599, 28);
            this.comboBoxInformationObject.TabIndex = 4;
            this.comboBoxInformationObject.Text = "Объект";
            // 
            // comboBoxResponsible
            // 
            this.comboBoxResponsible.FormattingEnabled = true;
            this.comboBoxResponsible.Location = new System.Drawing.Point(23, 173);
            this.comboBoxResponsible.Name = "comboBoxResponsible";
            this.comboBoxResponsible.Size = new System.Drawing.Size(599, 28);
            this.comboBoxResponsible.TabIndex = 5;
            this.comboBoxResponsible.Text = "Ответственный за проведение";
            // 
            // comboBoxExecutor
            // 
            this.comboBoxExecutor.FormattingEnabled = true;
            this.comboBoxExecutor.Location = new System.Drawing.Point(23, 207);
            this.comboBoxExecutor.Name = "comboBoxExecutor";
            this.comboBoxExecutor.Size = new System.Drawing.Size(599, 28);
            this.comboBoxExecutor.TabIndex = 6;
            this.comboBoxExecutor.Text = "Исполнитель";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Срок проведения: с";
            // 
            // textBoxPlace
            // 
            this.textBoxPlace.Location = new System.Drawing.Point(23, 241);
            this.textBoxPlace.Name = "textBoxPlace";
            this.textBoxPlace.Size = new System.Drawing.Size(599, 26);
            this.textBoxPlace.TabIndex = 8;
            this.textBoxPlace.Text = "Место проведения";
            // 
            // textBoxCustomer
            // 
            this.textBoxCustomer.Location = new System.Drawing.Point(23, 273);
            this.textBoxCustomer.Name = "textBoxCustomer";
            this.textBoxCustomer.Size = new System.Drawing.Size(599, 26);
            this.textBoxCustomer.TabIndex = 9;
            this.textBoxCustomer.Text = "Подразделение, заказчик";
            // 
            // textBoxRegNum
            // 
            this.textBoxRegNum.Location = new System.Drawing.Point(23, 305);
            this.textBoxRegNum.Name = "textBoxRegNum";
            this.textBoxRegNum.Size = new System.Drawing.Size(599, 26);
            this.textBoxRegNum.TabIndex = 10;
            this.textBoxRegNum.Text = "Рег.номер поступившего документ";
            // 
            // textBoxRegNumIn
            // 
            this.textBoxRegNumIn.Location = new System.Drawing.Point(23, 337);
            this.textBoxRegNumIn.Name = "textBoxRegNumIn";
            this.textBoxRegNumIn.Size = new System.Drawing.Size(599, 26);
            this.textBoxRegNumIn.TabIndex = 11;
            this.textBoxRegNumIn.Text = "Рег.номер входящего документа";
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Location = new System.Drawing.Point(23, 432);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(599, 97);
            this.richTextBoxResult.TabIndex = 12;
            this.richTextBoxResult.Text = "Результат";
            // 
            // textBoxFeedback
            // 
            this.textBoxFeedback.Location = new System.Drawing.Point(23, 369);
            this.textBoxFeedback.Name = "textBoxFeedback";
            this.textBoxFeedback.Size = new System.Drawing.Size(599, 26);
            this.textBoxFeedback.TabIndex = 13;
            this.textBoxFeedback.Text = "Обратная связь";
            // 
            // dateTimePickerDateIn
            // 
            this.dateTimePickerDateIn.Location = new System.Drawing.Point(183, 400);
            this.dateTimePickerDateIn.Name = "dateTimePickerDateIn";
            this.dateTimePickerDateIn.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerDateIn.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "по";
            // 
            // dateTimePickerDateOut
            // 
            this.dateTimePickerDateOut.Location = new System.Drawing.Point(422, 400);
            this.dateTimePickerDateOut.Name = "dateTimePickerDateOut";
            this.dateTimePickerDateOut.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerDateOut.TabIndex = 16;
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Location = new System.Drawing.Point(23, 535);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(599, 47);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // numericUpDownNum
            // 
            this.numericUpDownNum.Location = new System.Drawing.Point(193, 7);
            this.numericUpDownNum.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDownNum.Name = "numericUpDownNum";
            this.numericUpDownNum.Size = new System.Drawing.Size(158, 26);
            this.numericUpDownNum.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Номер мероприятия:";
            // 
            // FormActivitiesDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(645, 594);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownNum);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dateTimePickerDateOut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerDateIn);
            this.Controls.Add(this.textBoxFeedback);
            this.Controls.Add(this.richTextBoxResult);
            this.Controls.Add(this.textBoxRegNumIn);
            this.Controls.Add(this.textBoxRegNum);
            this.Controls.Add(this.textBoxCustomer);
            this.Controls.Add(this.textBoxPlace);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxExecutor);
            this.Controls.Add(this.comboBoxResponsible);
            this.Controls.Add(this.comboBoxInformationObject);
            this.Controls.Add(this.comboBoxPurpose);
            this.Controls.Add(this.comboBoxBasisСonducting);
            this.Controls.Add(this.textBoxName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormActivitiesDetail";
            this.Text = "Мероприятие";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxBasisСonducting;
        private System.Windows.Forms.ComboBox comboBoxPurpose;
        private System.Windows.Forms.ComboBox comboBoxInformationObject;
        private System.Windows.Forms.ComboBox comboBoxResponsible;
        private System.Windows.Forms.ComboBox comboBoxExecutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPlace;
        private System.Windows.Forms.TextBox textBoxCustomer;
        private System.Windows.Forms.TextBox textBoxRegNum;
        private System.Windows.Forms.TextBox textBoxRegNumIn;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
        private System.Windows.Forms.TextBox textBoxFeedback;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOut;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.NumericUpDown numericUpDownNum;
        private System.Windows.Forms.Label label3;
    }
}