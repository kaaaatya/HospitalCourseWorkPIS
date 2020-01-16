using System;
using System.Windows.Forms;
using Unity;

namespace HospitalAdminView
{
    public partial class FormMain : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonPatients_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormCRUDPatients>();
            form.ShowDialog();
        }

        private void buttonPlan_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormHospitalPlan>();
            form.ShowDialog();
        }

        private void buttonArchive_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormArchive>();
            form.ShowDialog();
        }
    }
}
