using HospitalController;
using HospitalModel.ViewModels;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Unity;

namespace HospitalView
{
    public partial class FormSickList : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly SickListController service;
        private readonly PatientCardController patientService;
        public int Id { set { id = value; } }
        private int? id;
        public FormSickList(SickListController service, PatientCardController patientService)
        {
            InitializeComponent();
            this.service = service;
            this.patientService = patientService;
        }

        private void FormSickList_Load(object sender, EventArgs e)
        {
            loadPeople();
        }

        private void loadPeople()
        {
            List<PatientCardViewModel> list1 = patientService.GetList();
            if (list1 != null)
            {
                comboBoxPatient.DisplayMember = "FIO";
                comboBoxPatient.ValueMember = "Id";
                comboBoxPatient.DataSource = list1;
                comboBoxPatient.SelectedItem = null;
            }
        }

        private void comboBoxPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPatient.SelectedItem != null)
            {
                try
                {
                    loadDates();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
              MessageBoxIcon.Error);
                }
            }
        }

        private void loadDates()
        {
            List<SicknessHistoryViewModel> list1 = service.GetDateReceptionForComboBox(comboBoxPatient.Text);
            if (list1 != null)
            {
                comboBoxDateReception.DisplayMember = "DateReception";
                comboBoxDateReception.ValueMember = "Id";
                comboBoxDateReception.DataSource = list1;
                comboBoxDateReception.SelectedItem = null;
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            if ((comboBoxPatient.Text != "") && (comboBoxDateReception.Text!=""))
            {
                DateTime datePrint = DateTime.Now;
                string datePrintList = datePrint.ToString("yyyy-MM-dd");
                string dd = comboBoxDateReception.Text;
                DateTime da = Convert.ToDateTime(dd);
                string date1 = da.ToString("yyyy-MM-dd");
                string patientFIO = comboBoxPatient.Text;
                string birthDate = service.getBirth(patientFIO);
                string Gender = service.getGender(patientFIO);
                string dateRelease = service.getDate2(patientFIO, Convert.ToDateTime(comboBoxDateReception.Text));
                string doctor = service.getDoctor(patientFIO, Convert.ToDateTime(comboBoxDateReception.Text));

                dataGridView1.Columns.Add("Column1", "Медицинская организация ");
                dataGridView1.Columns.Add("Column2", "Моя больница ");

                dataGridView1.Rows.Add();
                dataGridView1.Rows[0].Cells[0].Value = "Адрес организации ";
                dataGridView1.Rows[0].Cells[1].Value = "г. Ульяновск, ул Северный венец, д32";

                dataGridView1.Rows.Add();
                dataGridView1.Rows[1].Cells[0].Value = "Дата выдачи: ";
                dataGridView1.Rows[1].Cells[1].Value = datePrintList;

                dataGridView1.Rows.Add();
                dataGridView1.Rows[2].Cells[0].Value = "ФИО пациента ";
                dataGridView1.Rows[2].Cells[1].Value = patientFIO;

                dataGridView1.Rows.Add();
                dataGridView1.Rows[3].Cells[0].Value = "Дата рождения ";
                dataGridView1.Rows[3].Cells[1].Value = birthDate;

                dataGridView1.Rows.Add();
                dataGridView1.Rows[4].Cells[0].Value = "Пол ";
                dataGridView1.Rows[4].Cells[1].Value = Gender;

                dataGridView1.Rows.Add();
                dataGridView1.Rows[5].Cells[0].Value = "Находился на лечении с ";
                dataGridView1.Rows[5].Cells[1].Value = date1;

                dataGridView1.Rows.Add();
                dataGridView1.Rows[6].Cells[0].Value = "До ";
                dataGridView1.Rows[6].Cells[1].Value = dateRelease;

                dataGridView1.Rows.Add();
                dataGridView1.Rows[7].Cells[0].Value = "Лечащий врач ";
                dataGridView1.Rows[7].Cells[1].Value = doctor;

                dataGridView1.Columns[1].AutoSizeMode =
                        DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[1].AutoSizeMode =
                dataGridView1.Columns[0].AutoSizeMode =
                        DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "pdf|*.pdf"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    savePDF(sfd.FileName);
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

        public void savePDF(string FileName)
        {
            string FONT_LOCATION = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.TTF"); //определяем В СИСТЕМЕ(чтобы не копировать файл) расположение шрифта arial.ttf
            BaseFont baseFont = BaseFont.CreateFont(FONT_LOCATION, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED); //создаем шрифт
            iTextSharp.text.Font fontParagraph = new iTextSharp.text.Font(baseFont, 17, iTextSharp.text.Font.NORMAL); //регистрируем + можно задать параметры для него(17 - размер, последний параметр - стиль)
            string title = "Больничный лист";

            var phraseTitle = new Phrase(title,
            new iTextSharp.text.Font(baseFont, 18, iTextSharp.text.Font.BOLD));
            iTextSharp.text.Paragraph paragraph = new
           iTextSharp.text.Paragraph(phraseTitle)
            {
                Alignment = Element.ALIGN_CENTER,
                SpacingAfter = 12
            };

            PdfPTable table = new PdfPTable(dataGridView1.Columns.Count);

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                table.AddCell(new Phrase(dataGridView1.Columns[i].HeaderCell.Value.ToString(), fontParagraph));
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    table.AddCell(new Phrase(dataGridView1.Rows[i].Cells[j].Value.ToString(), fontParagraph));
                }
            }
            using (FileStream stream = new FileStream(FileName, FileMode.Create))
            {
                iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(paragraph);
                pdfDoc.Add(table);
                pdfDoc.Close();
                stream.Close();
            }

        }

        private void buttonTreatmentInfo_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            if ((comboBoxPatient.Text != "") && (comboBoxDateReception.Text != ""))
            {
                DateTime datePrint = DateTime.Now;
                string datePrintList = datePrint.ToString("yyyy-MM-dd");
                string dd = comboBoxDateReception.Text;
                DateTime da = Convert.ToDateTime(dd);
                string date1 = da.ToString("yyyy-MM-dd");
                string patientFIO = comboBoxPatient.Text;
                string birthDate = service.getBirth(patientFIO);
                string Gender = service.getGender(patientFIO);
                string dateRelease = service.getDate2(patientFIO, Convert.ToDateTime(comboBoxDateReception.Text));
                string doctor = service.getDoctor(patientFIO, Convert.ToDateTime(comboBoxDateReception.Text));
                string status = service.getStatus(patientFIO);
                string address = service.getAddress(patientFIO);

                dataGridView1.Columns.Add("Column1", "Выписка из истории болезни");
                dataGridView1.Columns.Add("Column2", "пациента");

                dataGridView1.Rows.Add();
                dataGridView1.Rows[0].Cells[0].Value = "ФИО пациента ";
                dataGridView1.Rows[0].Cells[1].Value = patientFIO;

                dataGridView1.Rows.Add();
                dataGridView1.Rows[1].Cells[0].Value = "Дата рождения ";
                dataGridView1.Rows[1].Cells[1].Value = birthDate;

                dataGridView1.Rows.Add();
                dataGridView1.Rows[2].Cells[0].Value = "Занятость ";
                dataGridView1.Rows[2].Cells[1].Value = status;

                dataGridView1.Rows.Add();
                dataGridView1.Rows[3].Cells[0].Value = "Находился на лечении с ";
                dataGridView1.Rows[3].Cells[1].Value = date1;

                dataGridView1.Rows.Add();
                dataGridView1.Rows[4].Cells[0].Value = "До ";
                dataGridView1.Rows[4].Cells[1].Value = dateRelease;

                dataGridView1.Rows.Add();
                dataGridView1.Rows[5].Cells[0].Value = "Адрес учреждения ";
                dataGridView1.Rows[5].Cells[1].Value = "г. Ульяновск, ул Северный венец, д32";

                dataGridView1.Rows.Add();
                dataGridView1.Rows[6].Cells[0].Value = "Лечащий врач ";
                dataGridView1.Rows[6].Cells[1].Value = doctor;

                dataGridView1.Rows.Add();
                dataGridView1.Rows[7].Cells[0].Value = "Выписка выдана ";
                dataGridView1.Rows[7].Cells[1].Value = DateTime.Now.ToString("yyyy-MM-dd");

                dataGridView1.Columns[1].AutoSizeMode =
                        DataGridViewAutoSizeColumnMode.Fill;
                dataGridView1.Columns[1].AutoSizeMode =
                dataGridView1.Columns[0].AutoSizeMode =
                        DataGridViewAutoSizeColumnMode.Fill;
            }

        }
    }
}
