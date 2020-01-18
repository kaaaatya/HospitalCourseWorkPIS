using HospitalController;
using System;
using System.Windows.Forms;
using Unity;

namespace HospitalView
{
    public partial class FormAuth : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly AuthController service;
        public int Id { set { id = value; } }
        private int? id;
        public FormAuth(AuthController service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLogin.Text))
            {
                MessageBox.Show("Введите логин", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Введите пароль", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            else
            {
                string res = service.CheckAuthInfo(textBoxLogin.Text, textBoxPassword.Text);
                if (res == "ok")
                {
                    this.Visible = false;
                    var form1 = Container.Resolve<FormMain>();
                    form1.ShowDialog();                    
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                }
            }
            
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormSignUp>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                var form1 = Container.Resolve<FormMain>();
                form.Visible = false;
                form1.ShowDialog();
            }
        }
    }
}
