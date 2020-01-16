using HospitalController;
using HospitalModel;
using System;
using System.Windows.Forms;
using Unity;

namespace HospitalView
{
    public partial class FormSignUp : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id { set { id = value; } }
        private int? id;
        private readonly AuthController service;
        public FormSignUp(AuthController service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFIO.Text))
            {
                MessageBox.Show("Заполните ФИО", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(comboBoxRole.Text))
            {
                MessageBox.Show("Нужно выбрать роль", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxPosition.Text))
            {
                MessageBox.Show("Заполните должность", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxLogin.Text))
            {
                MessageBox.Show("Придумайте логин", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Придумайте пароль", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            try
            {
                service.AddElement(new Worker
                {
                    FIO = textBoxFIO.Text,
                    Role = comboBoxRole.Text,
                    Position = textBoxPosition.Text,
                    Login = textBoxLogin.Text,
                    Password = textBoxPassword.Text
                });

                MessageBox.Show("Регистрация прошла успешно", "Сообщение",
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
