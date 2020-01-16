using HospitalController;
using HospitalModel;
using HospitalModel.ViewModels;
using System;
using System.Collections;
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
        private readonly RoomsController roomService;
        private readonly SickListController service1;
        public int Id { set { id = value; } }
        private int? id;
        public string emptyNumber = "";
        public string patientId = "";
        public FormSicknessHistory(PatientCardController service, SicknessHistoryController serviceHistory, RoomsController roomService, SickListController service1)
        {
            InitializeComponent();
            this.service = service;
            this.serviceHistory = serviceHistory;
            this.roomService = roomService;
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
            loadPeople();
            loadDoctors();
            LoadData();
        }

        private void FormSicknessHistory_Load(object sender, EventArgs e)
        {
            loadPeople();
            loadDoctors();
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
            if ((patientId != null) && (patientId != ""))
            {
                try
                {
                    int patId = Convert.ToInt32(patientId);
                    serviceHistory.findSicknessHistory(patId, dateTimePicker2.Value);
                    loadPeople();
                    loadDoctors();
                    LoadData();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                }                
            }
            else
            {
                MessageBox.Show("Выберите пациента", "Ошибка", MessageBoxButtons.OK,
              MessageBoxIcon.Error);
            }           

        }

        private void LoadData()
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
                    dataGridView1.Columns.Add("Column11", "Палата");
                    int patientsAmount = dataGridView1.Rows.Count - 1;
                    for (int i = 0; i <= patientsAmount; i++)
                    {
                        int patientId = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value.ToString());
                        int roomId = serviceHistory.GetRoomIdByPatientId(patientId);
                        int roomNumber = roomService.GetRoomNumberById(roomId);
                        dataGridView1.Rows[i].Cells[11].Value = roomNumber.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void buttonSort1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Remove("Column11");
            ArrayList empty = new ArrayList();
            dataGridView1.DataSource = empty;
            try
            {
                List<PatientCardViewModel> list1 = serviceHistory.getTreatedNowOrderByFIO();
                if (list1 != null)
                {
                    dataGridView1.DataSource = list1;
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
                    dataGridView1.Columns.Add("Column11", "Палата");
                    int patientsAmount = dataGridView1.Rows.Count - 1;
                    for (int i = 0; i <= patientsAmount; i++)
                    {
                        int patientId = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value.ToString());
                        int roomId = serviceHistory.GetRoomIdByPatientId(patientId);
                        int roomNumber = roomService.GetRoomNumberById(roomId);
                        dataGridView1.Rows[i].Cells[11].Value = roomNumber.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void buttonSort2_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Remove("Column11");
            ArrayList empty = new ArrayList();
            dataGridView1.DataSource = empty;
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //выбрана строка CurrentRow
            int CurrentRow = dataGridView1.SelectedCells[0].RowIndex;
            //получить значение выбранной строки
            patientId = dataGridView1[0, CurrentRow].Value.ToString();
            string patientName = dataGridView1[1, CurrentRow].Value.ToString();
            comboBoxPatient.Text = patientName;

        }

        private void buttonGetSickList_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormSickList>();
            form.ShowDialog();
        }
    }
}
