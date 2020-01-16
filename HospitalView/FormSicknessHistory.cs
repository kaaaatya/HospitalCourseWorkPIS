using HospitalController;
using HospitalModel.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace HospitalView
{
    public partial class FormSicknessHistory : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly PatientCardController service;
        private readonly SicknessHistoryController serviceHistory;
        public int Id { set { id = value; } }
        private int? id;
        public string emptyNumber = "";
        public FormSicknessHistory(PatientCardController service, SicknessHistoryController serviceHistory)
        {
            InitializeComponent();
            this.service = service;
            this.serviceHistory = serviceHistory;
        }

        private void buttonAddToHistory_Click(object sender, EventArgs e)
        {

        }

        private void FormSicknessHistory_Load(object sender, EventArgs e)
        {
            try
            {
                List<PatientCardViewModel> list = serviceHistory.getTreatedNow();
                if (list != null)
                {
                    dataGridView1.DataSource = list;
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].Visible = true;
                    dataGridView1.Columns[2].Visible = false;
                    dataGridView1.Columns[3].Visible = false;
                    dataGridView1.Columns[4].Visible = false;
                    dataGridView1.Columns[5].Visible = false;
                    dataGridView1.Columns[6].Visible = false;
                    dataGridView1.Columns[7].Visible = false;
                    dataGridView1.Columns[8].Visible = false;
                    dataGridView1.Columns[9].Visible = false;
                    dataGridView1.Columns[10].Visible = true;
                    dataGridView1.Columns[10].ReadOnly = true;
                    dataGridView1.Columns[1].AutoSizeMode =
                        DataGridViewAutoSizeColumnMode.Fill;
                    textBoxSearchFIO.Text = "";
                    maskedTextBoxNumber.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void buttonSearchByFIO_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearchByNumber_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
