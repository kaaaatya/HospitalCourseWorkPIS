using System;
using System.Windows.Forms;
using Unity;

namespace HospitalView
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
            var form = Container.Resolve<FormPatients>();
            form.ShowDialog();
        }

        private void buttonPlan_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormRooms>();
            form.ShowDialog();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В больнице часть медицинских услуг оказывается на платной основе. В учете участвует сотрудник регистратуры, бухгалтерия и медперсонал, оказывающий услуги. В программе реализована автоматизация работы регистратора." + "/n"+ " Автор программы - студентка группы ИСЭбд-31 Перепелицына Е.Е.", "Об авторе и программе",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonArchive_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormSickArchieve>();
            form.ShowDialog();
        }
    }
}
