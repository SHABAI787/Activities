using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using VActivities.DataBase.Context;
using VActivities.DataBase.Tables;
using VActivities.Exchange;

namespace VActivities.View.Forms
{
    public partial class FormSimple : Form
    {
        private VActivitiesContext contex = null;
        private SimpleForm simpleForm;

        public FormSimple(SimpleForm form)
        {
            InitializeComponent();
            this.simpleForm = form;
        }

        private void toolStripButtonUpdate_Click(object sender, EventArgs e)
        {
            contex = new VActivitiesContext();

            switch (simpleForm)
            {
                case SimpleForm.InformationObject:
                    {
                        this.Text = "Объекты";
                        contex.InformationObjects.Load();
                        bindingSource.DataSource = contex.InformationObjects.Local.ToBindingList();
                    }
                    break;
                case SimpleForm.BasisСonducting:
                    {
                        this.Text = "Основания для проведения";
                        contex.BasisСonductings.Load();
                        bindingSource.DataSource = contex.BasisСonductings.Local.ToBindingList();
                    }
                    break;
                case SimpleForm.Purpose:
                    {
                        this.Text = "Цели";
                        contex.Purposes.Load();
                        bindingSource.DataSource = contex.Purposes.Local.ToBindingList();
                    }
                    break;
                case SimpleForm.Person:
                    {
                        this.Text = "Физические лица";
                        contex.Persons.Load();
                        bindingSource.DataSource = contex.Persons.Local.ToBindingList();
                    }
                    break;
                case SimpleForm.History:
                    {
                        bindingNavigatorDeleteItem.Enabled = false;
                        bindingNavigatorAddNewItem.Enabled = false;
                        this.Text = "История пользователей БД";
                        contex.History.Include(h => h.User).Load();
                        bindingSource.DataSource = contex.History.Local.ToBindingList();
                    }
                    break;
                default:
                    {
                        throw new Exception($"Не задано действие для " +
                            $"- {Enum.GetName(typeof(SimpleForm), simpleForm)}");
                    }
            }

            dataGridView.DataSource = bindingSource;
        }


        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (simpleForm == SimpleForm.InformationObject)
                ((InformationObject)dataGridView.Rows[e.RowIndex].DataBoundItem).DatеUpdated = DateTime.Now;
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            dataGridView.EndEdit();

            if (contex.ChangeTracker.Entries().Count() == 0 && dataGridView.Rows.Count == 1)
            {
                bindingSource.Add(dataGridView.Rows[0].DataBoundItem);
                contex.SaveChanges();
                toolStripButtonUpdate_Click(sender, e);
            }
            else
            {
                foreach (var item in contex.ChangeTracker.Entries())
                {
                    if (item.State == EntityState.Deleted)
                        FormBase.AddHistory(contex, $"Удаление, форма {this.Text}", item.Entity.ToString());

                    if (item.State == EntityState.Added)
                        FormBase.AddHistory(contex, $"Добавление, форма {this.Text}", item.Entity.ToString());

                    if (item.State == EntityState.Modified)
                        FormBase.AddHistory(contex, $"Изменение, форма {this.Text}", item.Entity.ToString());
                }

                contex.SaveChanges();
            }
        }

        private void FormInformationObject_Load(object sender, EventArgs e)
        {
            toolStripButtonUpdate_Click(sender, e);
        }

        private void toolStripButtonExport_Click(object sender, EventArgs e)
        {
            dataGridView.ExportToXML();
        }

        private void toolStripButtonImport_Click(object sender, EventArgs e)
        {
            switch (simpleForm)
            {
                case SimpleForm.BasisСonducting: bindingSource.ImportFromXML<BasisСonducting>(); break;
                case SimpleForm.InformationObject: bindingSource.ImportFromXML<InformationObject>(); break;
                case SimpleForm.Purpose: bindingSource.ImportFromXML<Purpose>(); break;
                case SimpleForm.Person: bindingSource.ImportFromXML<Person>(); break;
                case SimpleForm.History: bindingSource.ImportFromXML<History>(contex); break;
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            toolStripButtonSave_Click(sender, e);
        }
    }

    /// <summary>
    /// Формы с простым набором данных без необходимости изменять связанные данные
    /// </summary>
    public enum SimpleForm
    {
        InformationObject,
        BasisСonducting,
        Purpose,
        Person,
        History
    }
}
