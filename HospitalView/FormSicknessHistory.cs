using HospitalController;
using HospitalModel;
using HospitalModel.ViewModels;
using System;
using System.Collections.Generic;
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
            if (string.IsNullOrEmpty(comboBoxPatient.Text))
            {
                MessageBox.Show("Выберите пациента", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(comboBoxDoctor.Text))
            {
                MessageBox.Show("Выберите врача", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(comboBoxRoom.Text))
            {
                MessageBox.Show("Выберите палату", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(maskedTextBoxTemperature.Text))
            {
                MessageBox.Show("Введите температуру", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (!string.IsNullOrEmpty(maskedTextBoxTemperature.Text))
            {
                try
                {
                    Convert.ToDouble(maskedTextBoxTemperature.Text);
                }
                catch
                {
                    MessageBox.Show("Введен неверный формат числа для температуры", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                    return;
                }
            }
            try
            {
                int roomId = serviceHistory.GetIdByRoomNumber(Convert.ToInt32(comboBoxRoom.Text));
                int patientId = serviceHistory.GetIdByPatientName(comboBoxPatient.Text);
                int doctorId = serviceHistory.GetIdByDoctorName(comboBoxDoctor.Text);

                serviceHistory.AddElement(new SicknessHistory
                {
                    DateReception = Convert.ToDateTime(dateTimePicker1.Text),
                    Temperature = maskedTextBoxTemperature.Text,
                    PatientCardId = patientId,
                    RoomId = roomId,
                    WorkerId = doctorId,
                    Datedischarge = Convert.ToDateTime(dateTimePicker1.Text)
                });

                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
            LoadData();
        }

        private void FormSicknessHistory_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void loadPeople()
        {
            List<PatientCardViewModel> list1 = serviceHistory.GetList();
            if (list1 != null)
            {
                comboBoxPatient.DisplayMember = "FIO";
                comboBoxPatient.ValueMember = "Id";
                comboBoxPatient.DataSource = list1;
                comboBoxPatient.SelectedItem = null;
            }
        }

        private void loadDoctors()
        {
            List<WokerViewModel> list2 = serviceHistory.GetWokersForComboBox();
            if (list2 != null)
            {
                comboBoxDoctor.DisplayMember = "FIO";
                comboBoxDoctor.ValueMember = "Id";
                comboBoxDoctor.DataSource = list2;
                comboBoxDoctor.SelectedItem = null;
            }
        }
        private void loadRooms(string Gender)
        {
            List<RoomViewModel> list3 = serviceHistory.GetRoomsForComboBox(Gender);
            if (list3 != null)
            {
                comboBoxRoom.DisplayMember = "RoomNumber";
                comboBoxRoom.ValueMember = "Id";
                comboBoxRoom.DataSource = list3;
                comboBoxRoom.SelectedItem = null;
            }
        }

        private void comboBoxPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            string PatientFIO = comboBoxPatient.Text;
            string patientGender = service.getGenderByFIO(PatientFIO);
            loadRooms(patientGender);
        }

        private void buttonFree_Click(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            loadPeople();
            loadDoctors();
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
    }
}
