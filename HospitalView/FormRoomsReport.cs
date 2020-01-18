using HospitalController;
using HospitalModel.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace HospitalView
{
    public partial class FormRoomsReport : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly RoomsController service;
        private readonly SicknessHistoryController serviceHistory;
        public int Id { set { id = value; } }
        private int? id;
        public FormRoomsReport(RoomsController service, SicknessHistoryController serviceHistory)
        {
            InitializeComponent();
            this.service = service;
            this.serviceHistory = serviceHistory;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            List<RoomViewModel> list = service.GetList();
            if ((maskedTextBoxYear.Text != null)&&(maskedTextBoxYear.Text!=""))
            {
                int year = Convert.ToInt32(maskedTextBoxYear.Text);
                int firstId = service.getFirstRoomId();
                int roomsAmount = list.Count;
                int historiesAmount = serviceHistory.getTreatedNowFromHistory().Count;
                int firstHistoryId = serviceHistory.getFirstHistoryId();
                for (int i = firstId; i < (firstId + roomsAmount); i++)
                {
                    int roomNumber = service.GetRoomNumberById(i);
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i-3].Cells[0].Value = roomNumber.ToString();
                    for (int m = 1; m < 13; m++)
                    {
                        dataGridView1.Rows[i - 3].Cells[m].Value = 0;
                    }
                    for (int j = firstHistoryId; j < (firstHistoryId + historiesAmount); j++)
                    {
                        int inWhatRoom = serviceHistory.getRoomIdByHistoryId(j);
                        if (inWhatRoom == i)
                        {
                            int firstYear = serviceHistory.getFirstDateInTreatment(j).Year;
                            int lastYear = serviceHistory.getLastDateInTreatment(j).Year;
                            if ((year == firstYear) || (year == lastYear))
                            {
                                int firstMonth = serviceHistory.getFirstDateInTreatment(j).Month;
                                int lastMonth = serviceHistory.getLastDateInTreatment(j).Month;
                                int inRoom = Convert.ToInt32(dataGridView1.Rows[i - 3].Cells[firstMonth].Value.ToString()) + 1;
                                dataGridView1.Rows[i - 3].Cells[firstMonth].Value = inRoom.ToString();
                            }
                        }
                    }
                }                
            }
            else
            {
                MessageBox.Show("Введите год для отчета", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
           
        }

        private void buttonSaveToPDF_Click(object sender, EventArgs e)
        {
            
        }

        private void FormRoomsReport_Load(object sender, EventArgs e)
        {            
            dataGridView1.Columns.Add("0", "Номер палаты");
            dataGridView1.Columns.Add("1", "Январь");
            dataGridView1.Columns.Add("2", "Февраль");
            dataGridView1.Columns.Add("3", "Март");
            dataGridView1.Columns.Add("4", "Апрель");
            dataGridView1.Columns.Add("5", "Май");
            dataGridView1.Columns.Add("6", "Июнь");
            dataGridView1.Columns.Add("7", "Июль");
            dataGridView1.Columns.Add("8", "Август");
            dataGridView1.Columns.Add("9", "Сентябрь");
            dataGridView1.Columns.Add("10", "Октябрь");
            dataGridView1.Columns.Add("11", "Ноябрь");
            dataGridView1.Columns.Add("12", "Декабрь");
        }
    }
}
