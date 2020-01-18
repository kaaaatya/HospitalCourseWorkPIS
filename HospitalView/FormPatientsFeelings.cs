using HospitalController;
using HospitalModel.ViewModels;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
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
                dataGridView1.Columns.Remove(dataGridView1.Columns[0]);
                for (int i = 0; i < 9; i++)
                {
                    dataGridView1.Columns.Remove(dataGridView1.Columns[1]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "doc|*.doc"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    saveDoc(sfd.FileName);
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

        public void saveDoc(string FileName)
        {
            var winword = new Microsoft.Office.Interop.Word.Application();
            try
            {
                object missing = System.Reflection.Missing.Value;
                //создаем документ
                Microsoft.Office.Interop.Word.Document document =
                winword.Documents.Add(ref missing, ref missing, ref missing, ref
               missing);
                //получаем ссылку на параграф
                var paragraph = document.Paragraphs.Add(missing);
                var range = paragraph.Range;
                string title = "Справка о состоянии больных на " + DateTime.Now.ToString();
                //задаем текст
                range.Text = title;
                //задаем настройки шрифта
                var font = range.Font;
                font.Size = 16;
                font.Name = "Times New Roman";
                font.Bold = 1;
                //задаем настройки абзаца
                var paragraphFormat = range.ParagraphFormat;
                paragraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                paragraphFormat.LineSpacingRule = WdLineSpacing.wdLineSpaceSingle;
                paragraphFormat.SpaceAfter = 10;
                paragraphFormat.SpaceBefore = 0;
                //добавляем абзац в документ
                range.InsertParagraphAfter();
                //создаем таблицу
                var paragraphTable = document.Paragraphs.Add(Type.Missing);
                var rangeTable = paragraphTable.Range;
                var table = document.Tables.Add(rangeTable, dataGridView1.Rows.Count + 1, dataGridView1.Columns.Count, ref
               missing, ref missing);
                font = table.Range.Font;
                font.Size = 14;
                font.Name = "Times New Roman";
                var paragraphTableFormat = table.Range.ParagraphFormat;
                paragraphTableFormat.LineSpacingRule = WdLineSpacing.wdLineSpaceSingle;
                paragraphTableFormat.SpaceAfter = 0;
                paragraphTableFormat.SpaceBefore = 0;
                for (int i = 0; i < dataGridView1.Columns.Count; ++i)
                {
                    if ((dataGridView1.Columns[i].HeaderCell.Value.ToString() != "InsuranceNumber") || (dataGridView1.Columns[i].HeaderCell.Value.ToString() != "BirthDate") || (dataGridView1.Columns[i].HeaderCell.Value.ToString() != "PhoneNumber") || (dataGridView1.Columns[i].HeaderCell.Value.ToString() != "Gender"))
                    {
                        table.Cell(1, i + 1).Range.Text = dataGridView1.Columns[i].HeaderCell.Value.ToString();
                    }                    
                }
                for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; ++j)
                    {
                        if ((dataGridView1.Columns[i].HeaderCell.Value.ToString() != "InsuranceNumber") || (dataGridView1.Columns[i].HeaderCell.Value.ToString() != "BirthDate") || (dataGridView1.Columns[i].HeaderCell.Value.ToString() != "PhoneNumber") || (dataGridView1.Columns[i].HeaderCell.Value.ToString() != "Gender"))
                        {
                            table.Cell(i + 2, j + 1).Range.Text = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }                            
                    }
                }
                //задаем границы таблицы
                table.Borders.InsideLineStyle = WdLineStyle.wdLineStyleInset;
                table.Borders.OutsideLineStyle = WdLineStyle.wdLineStyleSingle;
                paragraph = document.Paragraphs.Add(missing);
                range = paragraph.Range;
                font = range.Font;
                font.Size = 12;
                font.Name = "Times New Roman";
                paragraphFormat = range.ParagraphFormat;
                paragraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight;
                paragraphFormat.LineSpacingRule = WdLineSpacing.wdLineSpaceSingle;
                paragraphFormat.SpaceAfter = 10;
                paragraphFormat.SpaceBefore = 10;
                range.InsertParagraphAfter();
                //сохраняем
                object fileFormat = WdSaveFormat.wdFormatXMLDocument;
                document.SaveAs(FileName, ref fileFormat, ref missing,
                ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing,
                ref missing, ref missing, ref missing, ref missing,
                ref missing);
                document.Close(ref missing, ref missing, ref missing);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                winword.Quit();
            }

        }
    }
}
