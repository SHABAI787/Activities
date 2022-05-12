
namespace VActivities
{
    partial class FormBase
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.объектыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.целиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.основанияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.физлицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.историяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.объектыToolStripMenuItem,
            this.целиToolStripMenuItem,
            this.основанияToolStripMenuItem,
            this.физлицаToolStripMenuItem,
            this.пользователиБДToolStripMenuItem,
            this.историяToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // объектыToolStripMenuItem
            // 
            this.объектыToolStripMenuItem.Name = "объектыToolStripMenuItem";
            this.объектыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.объектыToolStripMenuItem.Text = "Объекты";
            // 
            // целиToolStripMenuItem
            // 
            this.целиToolStripMenuItem.Name = "целиToolStripMenuItem";
            this.целиToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.целиToolStripMenuItem.Text = "Цели";
            // 
            // основанияToolStripMenuItem
            // 
            this.основанияToolStripMenuItem.Name = "основанияToolStripMenuItem";
            this.основанияToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.основанияToolStripMenuItem.Text = "Основания";
            // 
            // физлицаToolStripMenuItem
            // 
            this.физлицаToolStripMenuItem.Name = "физлицаToolStripMenuItem";
            this.физлицаToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.физлицаToolStripMenuItem.Text = "Физ.лица";
            // 
            // пользователиБДToolStripMenuItem
            // 
            this.пользователиБДToolStripMenuItem.Name = "пользователиБДToolStripMenuItem";
            this.пользователиБДToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.пользователиБДToolStripMenuItem.Text = "Пользователи БД";
            // 
            // историяToolStripMenuItem
            // 
            this.историяToolStripMenuItem.Name = "историяToolStripMenuItem";
            this.историяToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.историяToolStripMenuItem.Text = "История операции";
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormBase";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem объектыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem целиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem основанияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem физлицаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem историяToolStripMenuItem;
    }
}

