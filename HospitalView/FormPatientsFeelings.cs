using HospitalController;
using HospitalModel.ViewModels;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace HospitalView
{
    public partial class FormPatientsFeelings : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly PatientCardController service;
        private readonly SicknessHistoryController serviceHistory;
        private readonly RoomsController roomService;
        public FormPatientsFeelings(PatientCardController service, SicknessHistoryController serviceHistory, RoomsController roomService)
        {
            InitializeComponent();
            this.service = service;
            this.serviceHistory = serviceHistory;
            this.roomService = roomService;
        }

        private void FormPatientsFeelings_Load(object sender, EventArgs e)
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
                    dataGridView1.Columns.Add("Column12", "Температура");
                    int patientsAmount = dataGridView1.Rows.Count - 2;
                    for (int i = 0; i <= patientsAmount + 1; i++)
                    {
                        int patientId = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value.ToString());
                        int roomId = serviceHistory.GetRoomIdByPatientId(patientId);
                        int roomNumber = roomService.GetRoomNumberById(roomId);
                        dataGridView1.Rows[i].Cells[11].Value = roomNumber.ToString();
                        string temperature = serviceHistory.GetTemperatureByPatientId(patientId);
                        dataGridView1.Rows[i].Cells[12].Value = temperature;
                    }
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
