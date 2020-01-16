using System;
using System.Windows.Forms;
using Unity;

namespace HospitalAdminView
{
    public partial class FormAuth : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public FormAuth()
        {
            InitializeComponent();
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
