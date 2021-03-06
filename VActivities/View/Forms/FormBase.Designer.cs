
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBase));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.объектыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.целиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.основанияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.физлицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.историяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingNavigatorActivities = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonImport = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExport = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorActivities)).BeginInit();
            this.bindingNavigatorActivities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
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
            this.объектыToolStripMenuItem.Image = global::VActivities.Properties.Resources.icons8_object_23;
            this.объектыToolStripMenuItem.Name = "объектыToolStripMenuItem";
            this.объектыToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.объектыToolStripMenuItem.Text = "Объекты";
            this.объектыToolStripMenuItem.Click += new System.EventHandler(this.объектыToolStripMenuItem_Click);
            // 
            // целиToolStripMenuItem
            // 
            this.целиToolStripMenuItem.Image = global::VActivities.Properties.Resources.icons8_mission_23;
            this.целиToolStripMenuItem.Name = "целиToolStripMenuItem";
            this.целиToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.целиToolStripMenuItem.Text = "Цели";
            this.целиToolStripMenuItem.Click += new System.EventHandler(this.целиToolStripMenuItem_Click);
            // 
            // основанияToolStripMenuItem
            // 
            this.основанияToolStripMenuItem.Image = global::VActivities.Properties.Resources.icons8_bookmark_23;
            this.основанияToolStripMenuItem.Name = "основанияToolStripMenuItem";
            this.основанияToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.основанияToolStripMenuItem.Text = "Основания";
            this.основанияToolStripMenuItem.Click += new System.EventHandler(this.основанияToolStripMenuItem_Click);
            // 
            // физлицаToolStripMenuItem
            // 
            this.физлицаToolStripMenuItem.Image = global::VActivities.Properties.Resources.icons8_persons_23;
            this.физлицаToolStripMenuItem.Name = "физлицаToolStripMenuItem";
            this.физлицаToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.физлицаToolStripMenuItem.Text = "Физ.лица";
            this.физлицаToolStripMenuItem.Click += new System.EventHandler(this.физлицаToolStripMenuItem_Click);
            // 
            // пользователиБДToolStripMenuItem
            // 
            this.пользователиБДToolStripMenuItem.Image = global::VActivities.Properties.Resources.icons8_users_23;
            this.пользователиБДToolStripMenuItem.Name = "пользователиБДToolStripMenuItem";
            this.пользователиБДToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.пользователиБДToolStripMenuItem.Text = "Пользователи БД";
            this.пользователиБДToolStripMenuItem.Click += new System.EventHandler(this.пользователиБДToolStripMenuItem_Click);
            // 
            // историяToolStripMenuItem
            // 
            this.историяToolStripMenuItem.Image = global::VActivities.Properties.Resources.icons8_history_23;
            this.историяToolStripMenuItem.Name = "историяToolStripMenuItem";
            this.историяToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.историяToolStripMenuItem.Text = "История операций";
            this.историяToolStripMenuItem.Click += new System.EventHandler(this.историяToolStripMenuItem_Click);
            // 
            // bindingNavigatorActivities
            // 
            this.bindingNavigatorActivities.AddNewItem = null;
            this.bindingNavigatorActivities.BindingSource = this.bindingSource;
            this.bindingNavigatorActivities.CountItem = null;
            this.bindingNavigatorActivities.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigatorActivities.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.toolStripButtonEdit,
            this.bindingNavigatorDeleteItem,
            this.toolStripButtonImport,
            this.toolStripButtonExport,
            this.toolStripButtonUpdate,
            this.toolStripButtonSave,
            this.toolStripButton1});
            this.bindingNavigatorActivities.Location = new System.Drawing.Point(0, 24);
            this.bindingNavigatorActivities.MoveFirstItem = null;
            this.bindingNavigatorActivities.MoveLastItem = null;
            this.bindingNavigatorActivities.MoveNextItem = null;
            this.bindingNavigatorActivities.MovePreviousItem = null;
            this.bindingNavigatorActivities.Name = "bindingNavigatorActivities";
            this.bindingNavigatorActivities.PositionItem = null;
            this.bindingNavigatorActivities.Size = new System.Drawing.Size(800, 25);
            this.bindingNavigatorActivities.TabIndex = 1;
            this.bindingNavigatorActivities.Text = "bindingNavigator1";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // toolStripButtonEdit
            // 
            this.toolStripButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEdit.Image = global::VActivities.Properties.Resources.icons8_edit_23;
            this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit.Name = "toolStripButtonEdit";
            this.toolStripButtonEdit.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEdit.Text = "Изменить";
            this.toolStripButtonEdit.Click += new System.EventHandler(this.toolStripButtonEdit_Click);
            // 
            // toolStripButtonImport
            // 
            this.toolStripButtonImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonImport.Image = global::VActivities.Properties.Resources.icons8_import_23;
            this.toolStripButtonImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonImport.Name = "toolStripButtonImport";
            this.toolStripButtonImport.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonImport.Text = "Импорт";
            this.toolStripButtonImport.ToolTipText = "Импортировать данные";
            this.toolStripButtonImport.Click += new System.EventHandler(this.toolStripButtonImport_Click);
            // 
            // toolStripButtonExport
            // 
            this.toolStripButtonExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExport.Image = global::VActivities.Properties.Resources.icons8_box_23;
            this.toolStripButtonExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExport.Name = "toolStripButtonExport";
            this.toolStripButtonExport.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonExport.Text = "Экспорт";
            this.toolStripButtonExport.ToolTipText = "Экспортировать данные";
            this.toolStripButtonExport.Click += new System.EventHandler(this.toolStripButtonExport_Click);
            // 
            // toolStripButtonUpdate
            // 
            this.toolStripButtonUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUpdate.Image = global::VActivities.Properties.Resources.icons8_update_23__1_;
            this.toolStripButtonUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUpdate.Name = "toolStripButtonUpdate";
            this.toolStripButtonUpdate.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonUpdate.Text = "Обновить";
            this.toolStripButtonUpdate.Click += new System.EventHandler(this.toolStripButtonUpdate_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = global::VActivities.Properties.Resources.icons8_save_23;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSave.Text = "Сохранить";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::VActivities.Properties.Resources.file1337784276;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Поиск";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 49);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(800, 401);
            this.dataGridView.TabIndex = 2;
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.bindingNavigatorActivities);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormBase";
            this.Text = "Мероприятия";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorActivities)).EndInit();
            this.bindingNavigatorActivities.ResumeLayout(false);
            this.bindingNavigatorActivities.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
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
        private System.Windows.Forms.BindingNavigator bindingNavigatorActivities;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonImport;
        private System.Windows.Forms.ToolStripButton toolStripButtonExport;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpdate;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

