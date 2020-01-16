using HospitalController;
using HospitalModel;
using System;
using System.Windows.Forms;
using Unity;

namespace HospitalView
{
    public partial class FormPatient : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id { set { id = value; } }
        private int? id;
        private readonly PatientCardController service;
        public FormPatient(PatientCardController service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void buttonNewPatient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFIO.Text))
            {
                MessageBox.Show("Заполните ФИО", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxInCompany.Text))
            {
                MessageBox.Show("Заполните страховую компанию", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(maskedTextBoxInNumber.Text))
            {
                MessageBox.Show("Заполните № страховки", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(maskedTextBoxPassport.Text))
            {
                MessageBox.Show("Заполните паспортные данные", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(maskedTextBoxBirthDate.Text))
            {
                MessageBox.Show("Заполните дату рождения", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxAddress.Text))
            {
                MessageBox.Show("Заполните адрес проживания", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(maskedTextBoxPhoneNumber.Text))
            {
                MessageBox.Show("Укажите номер телефона", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(comboBoxStatus.Text))
            {
                MessageBox.Show("Выберите статус", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(comboBoxGender.Text))
            {
                MessageBox.Show("Выберите пол", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            try
            {                
                    service.AddElement(new PatientCard
                    {
                        FIO = textBoxFIO.Text,
                        InsuranceCompany = textBoxInCompany.Text,
                        InsuranceNumber = maskedTextBoxInNumber.Text,
                        Passport = maskedTextBoxPassport.Text,
                        BirthDate = Convert.ToDateTime(maskedTextBoxBirthDate.Text),
                        Address = textBoxAddress.Text,
                        PhoneNumber = maskedTextBoxPhoneNumber.Text,
                        Status = comboBoxStatus.Text,
                        Gender = comboBoxGender.Text,
                        IsTreatedNow = false
                    });
                
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
    }
}
