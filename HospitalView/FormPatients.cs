using HospitalController;
using HospitalModel.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace HospitalView
{
    public partial class FormPatients : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly PatientCardController service;
        public int Id { set { id = value; } }
        private int? id;
        public string emptyNumber = "";

        public FormPatients(PatientCardController service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void FormPatients_Load(object sender, EventArgs e)
        {
            LoadData();
            emptyNumber = maskedTextBoxNumber.Text;
        }

        private void LoadData()
        {
            try
            {
                List<PatientCardViewModel> list = service.GetList();
                if (list != null)
                {
                    dataGridView1.DataSource = list;
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].Visible = true;
                    dataGridView1.Columns[2].Visible = true;
                    dataGridView1.Columns[3].Visible = true;
                    dataGridView1.Columns[4].Visible = true;
                    dataGridView1.Columns[5].Visible = true;
                    dataGridView1.Columns[6].Visible = true;
                    dataGridView1.Columns[7].Visible = true;
                    dataGridView1.Columns[8].Visible = true;
                    dataGridView1.Columns[9].Visible = true;
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormPatient>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxSearchFIO.Text))
            {
                try
                {
                    List<PatientCardViewModel> list = service.getByFIO(textBoxSearchFIO.Text);
                    if (list != null)
                    {
                        dataGridView1.DataSource = list;
                        dataGridView1.Columns[0].Visible = false;
                        dataGridView1.Columns[1].Visible = true;
                        dataGridView1.Columns[2].Visible = true;
                        dataGridView1.Columns[3].Visible = true;
                        dataGridView1.Columns[4].Visible = true;
                        dataGridView1.Columns[5].Visible = true;
                        dataGridView1.Columns[6].Visible = true;
                        dataGridView1.Columns[7].Visible = true;
                        dataGridView1.Columns[8].Visible = true;
                        dataGridView1.Columns[9].Visible = true;
                        dataGridView1.Columns[10].Visible = true;
                        dataGridView1.Columns[1].AutoSizeMode =
                            DataGridViewAutoSizeColumnMode.Fill;
                    }
                    textBoxSearchFIO.Text = "";
                    maskedTextBoxNumber.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Введите ФИО для поиска", "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }            
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonTakePatient_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //выбрана строка CurrentRow
            int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
            //получить значение Name выбранной строки
            string FIO = dataGridView1[1, CurrentRow].Value.ToString();
            textBoxSearchFIO.Text = FIO;
            string Number = dataGridView1[3, CurrentRow].Value.ToString();
            maskedTextBoxNumber.Text = Number;
        }

        private void buttonNowTreated_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormSicknessHistory>();
            form.ShowDialog();
        }

        private void buttonFree_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearchByNumber_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxNumber.Text!=emptyNumber)
            {
                try
                {
                    List<PatientCardViewModel> list = service.getByNumber(maskedTextBoxNumber.Text);
                    if (list != null)
                    {
                        dataGridView1.DataSource = list;
                        dataGridView1.Columns[0].Visible = false;
                        dataGridView1.Columns[1].Visible = true;
                        dataGridView1.Columns[2].Visible = true;
                        dataGridView1.Columns[3].Visible = true;
                        dataGridView1.Columns[4].Visible = true;
                        dataGridView1.Columns[5].Visible = true;
                        dataGridView1.Columns[6].Visible = true;
                        dataGridView1.Columns[7].Visible = true;
                        dataGridView1.Columns[8].Visible = true;
                        dataGridView1.Columns[9].Visible = true;
                        dataGridView1.Columns[10].Visible = true;
                        dataGridView1.Columns[1].AutoSizeMode =
                            DataGridViewAutoSizeColumnMode.Fill;
                    }
                    textBoxSearchFIO.Text = "";
                    maskedTextBoxNumber.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Введите № страховки для поиска", "Ошибка", MessageBoxButtons.OK,
                  MessageBoxIcon.Error);
            }
        }
    }
}
