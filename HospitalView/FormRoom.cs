using HospitalController;
using HospitalModel;
using HospitalModel.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace HospitalView
{
    public partial class FormRoom : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id { set { id = value; } }
        private int? id;
        private readonly RoomsController service;
        public FormRoom(RoomsController service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maskedTextBoxNumber.Text))
            {
                MessageBox.Show("Введите номер", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(maskedTextBoxCapacity.Text))
            {
                MessageBox.Show("Введите вместимость", "Ошибка", MessageBoxButtons.OK,
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
                service.AddElement(new Room
                {
                    RoomNumber = Convert.ToInt32(maskedTextBoxNumber.Text),
                    Gender = comboBoxGender.Text,
                    Capacity = Convert.ToInt32(maskedTextBoxCapacity.Text),
                    Available = Convert.ToInt32(maskedTextBoxCapacity.Text)
                });

                MessageBox.Show("Добавление прошло успешно", "Сообщение", MessageBoxButtons.OK,
              MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maskedTextBoxNumber.Text))
            {
                MessageBox.Show("Введите номер", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(maskedTextBoxCapacity.Text))
            {
                MessageBox.Show("Введите вместимость", "Ошибка", MessageBoxButtons.OK,
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
                service.UpdElement(new Room
                {
                    id = Convert.ToInt32(textBox1.Text),
                    RoomNumber = Convert.ToInt32(maskedTextBoxNumber.Text),
                    Gender = comboBoxGender.Text,
                    Capacity = Convert.ToInt32(maskedTextBoxCapacity.Text),
                    Available = Convert.ToInt32(maskedTextBoxCapacity.Text)
                });

                MessageBox.Show("Изменение прошло успешно", "Сообщение", MessageBoxButtons.OK,
              MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                service.DelElement(Convert.ToInt32(maskedTextBoxNumber.Text));
                maskedTextBoxNumber.Text = "";
                comboBoxGender.Text = "";
                maskedTextBoxCapacity.Text = "";
                MessageBox.Show("Удаление прошло успешно", "Сообщение", MessageBoxButtons.OK,
              MessageBoxIcon.Information);
                LoadData();

            }
            catch
            {
                MessageBox.Show("Удаление не прошло", "Ошибка", MessageBoxButtons.OK,
              MessageBoxIcon.Error);
            }            
        }

        private void FormRoom_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                List<RoomViewModel> list = service.GetList();
                if (list != null)
                {
                    dataGridView1.DataSource = list;
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.Columns[1].Visible = true;
                    dataGridView1.Columns[2].Visible = true;
                    dataGridView1.Columns[3].Visible = true;
                    dataGridView1.Columns[4].Visible = true;
                    dataGridView1.Columns[1].AutoSizeMode =
                        DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //выбрана строка CurrentRow
            int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
            //получить значение Name выбранной строки
            string roomId = dataGridView1[0, CurrentRow].Value.ToString();
            string numberId = dataGridView1[1, CurrentRow].Value.ToString();
            string genderId = dataGridView1[2, CurrentRow].Value.ToString();
            string capacityId = dataGridView1[3, CurrentRow].Value.ToString();
            maskedTextBoxNumber.Text = numberId;
            comboBoxGender.Text = genderId;
            maskedTextBoxCapacity.Text = capacityId;
            textBox1.Text = roomId;
        }
    }
}
