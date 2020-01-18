using HospitalController;
using HospitalModel.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace HospitalView
{
    public partial class FormSickArchieve : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly SicknessHistoryController service;
        private readonly ArchieveController service1;
        public int Id { set { id = value; } }
        private int? id;
        public FormSickArchieve(SicknessHistoryController service, ArchieveController service1)
        {
            InitializeComponent();
            this.service = service;
            this.service1 = service1;
        }

        public void LoadData()
        {
            try
            {
                List<SicknessHistoryViewModel> list = service.getTreatedNowFromHistory();
                if (list != null)
                {
                    dataGridView1.DataSource = list;
                    dataGridView1.Columns[0].Visible = true;
                    dataGridView1.Columns[1].Visible = true;
                    dataGridView1.Columns[2].Visible = true;
                    dataGridView1.Columns[3].Visible = true;
                    dataGridView1.Columns[4].Visible = true;
                    dataGridView1.Columns[5].Visible = true;
                    dataGridView1.Columns[6].Visible = true;
                    dataGridView1.Columns[1].AutoSizeMode =
                        DataGridViewAutoSizeColumnMode.Fill;
                }
                label1.Visible = true;
                label1.Text = "Составлено на " + DateTime.Now.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
        private void FormSickArchieve_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //выбрана строка CurrentRow
            int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
            //получить значение Name выбранной строки
            string Id = dataGridView1[0, CurrentRow].Value.ToString();
            label2.Text = Id;
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id =
                   Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        service1.SaveToJsonAsync("D:\\BackupDeleteClient" + id + ".json");
                        MessageBox.Show("Данные скопированы в архив", "Успех", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        service1.delElement(id);
                        MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                }
                LoadData();
            }
        }
    }
}
