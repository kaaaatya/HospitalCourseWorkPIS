using HospitalController;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Unity;
using Image = iTextSharp.text.Image;

namespace HospitalView
{
    public partial class FormDiagramm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly SicknessHistoryController serviceHistory;
        public FormDiagramm(SicknessHistoryController serviceHistory)
        {
            InitializeComponent();
            this.serviceHistory = serviceHistory;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            chart1.Series.Clear();
            DateTime chosen = dateTimePicker1.Value.Date;
            dataGridView1.Rows.Add();
            dataGridView1.Rows[0].Cells[0].Value = 0;
            dataGridView1.Rows[0].Cells[1].Value = 0;
            int historiesAmount = serviceHistory.getTreatedNowFromHistory().Count;
            int firstHistoryId = serviceHistory.getFirstHistoryId();            
            for (int j = firstHistoryId; j < (firstHistoryId + historiesAmount); j++)
            {
                DateTime firstDate = serviceHistory.getFirstDateInTreatment(j).Date;
                DateTime lastDate = serviceHistory.getLastDateInTreatment(j).Date;
                if (firstDate == chosen)
                {
                    int inPeople = Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value.ToString()) + 1;
                    dataGridView1.Rows[0].Cells[0].Value = inPeople.ToString();
                }
                if ((lastDate == chosen)&&(lastDate!=firstDate))
                {
                    int outPeople = Convert.ToInt32(dataGridView1.Rows[0].Cells[1].Value.ToString()) + 1;
                    dataGridView1.Rows[0].Cells[1].Value = outPeople.ToString();
                }
            }
            chart1.Series.Clear();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Series S = chart1.Series.Add("Кол-во пациентов");
                S.ChartType = SeriesChartType.Column;
                S.IsVisibleInLegend = true;
                S.IsXValueIndexed = true;
            }

            // and fill in all the values from the dgv to the chart:
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    int p = chart1.Series[i].Points.AddXY(dataGridView1.Columns[j].HeaderText, dataGridView1[j, i].Value);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string title = "Кол-во принятых и выписанных пациентов на " + dateTimePicker1.Value.ToString(); 
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "pdf|*.pdf"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string FONT_LOCATION = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.TTF"); //определяем В СИСТЕМЕ(чтобы не копировать файл) расположение шрифта arial.ttf
                    BaseFont baseFont = BaseFont.CreateFont(FONT_LOCATION, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED); //создаем шрифт
                    iTextSharp.text.Font fontParagraph = new iTextSharp.text.Font(baseFont, 17, iTextSharp.text.Font.NORMAL); //регистрируем + можно задать параметры для него(17 - размер, последний параметр - стиль)

                    var phraseTitle = new Phrase(title,
            new iTextSharp.text.Font(baseFont, 18, iTextSharp.text.Font.BOLD));
                    iTextSharp.text.Paragraph paragraph = new
                   iTextSharp.text.Paragraph(phraseTitle)
                    {
                        Alignment = Element.ALIGN_CENTER,
                        SpacingAfter = 12
                    };

                    chart1.SaveImage(sfd.FileName + ".png", System.Drawing.Imaging.ImageFormat.Png);                 

                    Document document = new Document();
                    using (var stream = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        PdfWriter.GetInstance(document, stream);
                        document.Open();
                        using (var imageStream = new FileStream(sfd.FileName + ".png", FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                        {
                            var image = Image.GetInstance(imageStream);
                            document.Add(paragraph);
                            document.Add(image);
                        }
                        document.Close();
                        File.Delete(sfd.FileName + ".png");
                    }
                }
                catch
                {
                    MessageBox.Show("ERROR");
                }
            }
        }

        private void FormDiagramm_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("0", "Принято");
            dataGridView1.Columns.Add("1", "Выписано");
        }
    }
}
