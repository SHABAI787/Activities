using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using VActivities.DataBase.Context;
using VActivities.DataBase.Tables;

namespace VActivities.View.Forms
{
    public partial class FormActivitiesDetail : Form
    {
        private Activities activitie = null;
        private bool edit = false;
        private VActivitiesContext context = null;

        public FormActivitiesDetail(VActivitiesContext context, Activities activitie = null)
        {
            InitializeComponent();

            // Форма открыта для создания нового объекта
            if (activitie == null)
            {
                this.activitie = new Activities();
                this.activitie.Name = "Наименование";
                this.activitie.Place = "Место проведения";
                this.activitie.Customer = "Подразделение, заказчик";
                this.activitie.RegNum = "Рег.номер поступившего документа";
                this.activitie.RegNumIn = "Рег.номер входящего документа";
                this.activitie.Result = "Результат";
                this.activitie.Feedback = "Обратная связь";
                this.Text += " - Добавление";
            }
            else
            {
                this.activitie = activitie;
                edit = true;
                this.Text += " - Изменение";
                buttonAdd.Text = "Сохранить";
            }

            this.context = context;
            numericUpDownNum.DataBindings.Add("Value", this.activitie, "Num");
            textBoxName.DataBindings.Add("Text", this.activitie, "Name");
            textBoxPlace.DataBindings.Add("Text", this.activitie, "Place");

            context.BasisСonductings.Load();
            comboBoxBasisСonducting.Items.AddRange(context.BasisСonductings.Local.ToArray());
            if (this.activitie.BasisСonducting != null)
                comboBoxBasisСonducting.SelectedItem = this.activitie.BasisСonducting;

            context.Purposes.Load();
            comboBoxPurpose.Items.AddRange(context.Purposes.Local.ToArray());
            if (this.activitie.Purpose != null)
                comboBoxPurpose.SelectedItem = this.activitie.Purpose;

            dateTimePickerDateIn.Value = !this.activitie.DateIn.HasValue ? dateTimePickerDateIn.MinDate : this.activitie.DateIn.Value;
            dateTimePickerDateOut.Value = !this.activitie.DateOut.HasValue ? dateTimePickerDateOut.MinDate : this.activitie.DateOut.Value;

            context.InformationObjects.Load();
            comboBoxInformationObject.Items.AddRange(context.InformationObjects.Local.ToArray());
            if (this.activitie.InformationObject != null)
                comboBoxInformationObject.SelectedItem = this.activitie.InformationObject;

            textBoxCustomer.DataBindings.Add("Text", this.activitie, "Customer");

            context.Persons.Load();
            comboBoxResponsible.Items.AddRange(context.Persons.Local.ToArray());
            if (this.activitie.Responsible != null)
                comboBoxResponsible.SelectedItem = this.activitie.Responsible;

            comboBoxExecutor.Items.AddRange(context.Persons.Local.ToArray());
            if (this.activitie.Executor != null)
                comboBoxExecutor.SelectedItem = this.activitie.Executor;

            textBoxRegNum.DataBindings.Add("Text", this.activitie, "RegNum");
            textBoxRegNumIn.DataBindings.Add("Text", this.activitie, "RegNumIn");
            richTextBoxResult.DataBindings.Add("Text", this.activitie, "Result");
            textBoxFeedback.DataBindings.Add("Text", this.activitie, "Feedback");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (dateTimePickerDateOut.Value < dateTimePickerDateIn.Value)
            {
                MessageBox.Show($"Срок проведения выставлен не верно", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            activitie.BasisСonducting = comboBoxBasisСonducting.SelectedItem == null ? null : (BasisСonducting)comboBoxBasisСonducting.SelectedItem;
            activitie.Purpose = comboBoxPurpose.SelectedItem == null ? null : (Purpose)comboBoxPurpose.SelectedItem;
            activitie.InformationObject = comboBoxInformationObject.SelectedItem == null ? null : (InformationObject)comboBoxInformationObject.SelectedItem;
            activitie.Responsible = comboBoxResponsible.SelectedItem == null ? null : (Person)comboBoxResponsible.SelectedItem;
            activitie.Executor = comboBoxExecutor.SelectedItem == null ? null : (Person)comboBoxExecutor.SelectedItem;
            this.activitie.DateIn = dateTimePickerDateIn.Value == dateTimePickerDateIn.MinDate ? null : (DateTime?)dateTimePickerDateIn.Value;
            this.activitie.DateOut = dateTimePickerDateOut.Value == dateTimePickerDateOut.MinDate ? null : (DateTime?)dateTimePickerDateOut.Value;
            if (edit == false)
            {
                context.Activities.Add(activitie);
            }

            context.SaveChanges();
            FormBase.AddHistory(context, $"{(edit ? "Изменение" : "Добавление")} мероприятия", $"{(edit ? "Изменение" : "Добавление")} мероприятие {activitie}");
            this.Close();
        }
    }
}
