using HospitalController;
using HospitalModel.ViewModels;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
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
            if ((maskedTextBoxYear.Text != null)&&(maskedTextBoxYear.Text!=""))
            {
                List<RoomViewModel> list = service.GetList();
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
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "xls|*.xls|xlsx|*.xlsx"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    saveXls(sfd.FileName);
                    MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }
        public void saveXls(string FileName)
        {
            var excel = new Microsoft.Office.Interop.Excel.Application();
            try
            {
                if (File.Exists(FileName))
                {
                    excel.Workbooks.Open(FileName, Type.Missing, Type.Missing,
                   Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                   Type.Missing,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                   Type.Missing,
                    Type.Missing);
                }
                else
                {
                    excel.SheetsInNewWorkbook = 1;
                    excel.Workbooks.Add(Type.Missing);
                    excel.Workbooks[1].SaveAs(FileName, XlFileFormat.xlExcel8,
                    Type.Missing,
                     Type.Missing, false, false, XlSaveAsAccessMode.xlNoChange,
                    Type.Missing,
                     Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                }
                Sheets excelsheets = excel.Workbooks[1].Worksheets;

                var excelworksheet = (Worksheet)excelsheets.get_Item(1);
                excelworksheet.Cells.Clear();
                Microsoft.Office.Interop.Excel.Range excelcells = excelworksheet.get_Range("A1", "H1");
                excelcells.Merge(Type.Missing);
                excelcells.Font.Bold = true;
                string title = "Загрузка палат по месяцам " + maskedTextBoxYear.Text + " года" + "\r\n" + "Составлено " + DateTime.Now.ToString(); 
                excelcells.Value2 = title;
                excelcells.RowHeight = 40;
                excelcells.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                excelcells.VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;
                excelcells.Font.Name = "Times New Roman";
                excelcells.Font.Size = 14;

                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    excelcells = excelworksheet.get_Range("B3", "B3");
                    excelcells = excelcells.get_Offset(0, j);
                    excelcells.ColumnWidth = 15;
                    excelcells.Value2 = dataGridView1.Columns[j].HeaderCell.Value.ToString();
                    excelcells.Font.Bold = true;
                }

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        excelcells = excelworksheet.get_Range("B4", "B4");
                        excelcells = excelcells.get_Offset(i, j);
                        excelcells.ColumnWidth = 15;
                        excelcells.Value2 = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                excelcells = excelcells.get_Offset(1, 0);
                excelcells.Font.Bold = true;
                excel.Workbooks[1].Save();
            }
            catch (Exception)
            {
            }
            finally
            {
                excel.Quit();
            }
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
