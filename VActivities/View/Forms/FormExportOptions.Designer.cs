
namespace VActivities.View.Forms
{
    partial class FormExportOptions
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
            this.radioButtonSelectRow = new System.Windows.Forms.RadioButton();
            this.radioButtonAllRow = new System.Windows.Forms.RadioButton();
            this.buttonStartExport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButtonSelectRow
            // 
            this.radioButtonSelectRow.AutoSize = true;
            this.radioButtonSelectRow.Location = new System.Drawing.Point(15, 26);
            this.radioButtonSelectRow.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radioButtonSelectRow.Name = "radioButtonSelectRow";
            this.radioButtonSelectRow.Size = new System.Drawing.Size(278, 28);
            this.radioButtonSelectRow.TabIndex = 0;
            this.radioButtonSelectRow.TabStop = true;
            this.radioButtonSelectRow.Text = "Только выделенные строки";
            this.radioButtonSelectRow.UseVisualStyleBackColor = true;
            // 
            // radioButtonAllRow
            // 
            this.radioButtonAllRow.AutoSize = true;
            this.radioButtonAllRow.Location = new System.Drawing.Point(15, 70);
            this.radioButtonAllRow.Margin = new System.Windows.Forms.Padding(6);
            this.radioButtonAllRow.Name = "radioButtonAllRow";
            this.radioButtonAllRow.Size = new System.Drawing.Size(128, 28);
            this.radioButtonAllRow.TabIndex = 1;
            this.radioButtonAllRow.TabStop = true;
            this.radioButtonAllRow.Text = "Все строки";
            this.radioButtonAllRow.UseVisualStyleBackColor = true;
            // 
            // buttonStartExport
            // 
            this.buttonStartExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStartExport.Location = new System.Drawing.Point(14, 117);
            this.buttonStartExport.Name = "buttonStartExport";
            this.buttonStartExport.Size = new System.Drawing.Size(339, 37);
            this.buttonStartExport.TabIndex = 2;
            this.buttonStartExport.Text = "Экспортировать";
            this.buttonStartExport.UseVisualStyleBackColor = true;
            this.buttonStartExport.Click += new System.EventHandler(this.buttonStartExport_Click);
            // 
            // FormExportOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(366, 173);
            this.Controls.Add(this.buttonStartExport);
            this.Controls.Add(this.radioButtonAllRow);
            this.Controls.Add(this.radioButtonSelectRow);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormExportOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Параметры экспорта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonSelectRow;
        private System.Windows.Forms.RadioButton radioButtonAllRow;
        private System.Windows.Forms.Button buttonStartExport;
    }
}