using HospitalController;
using HospitalModel.ViewModels;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Unity;

namespace HospitalView
{
    public partial class FormRooms : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly RoomsController service;
        public int Id { set { id = value; } }
        private int? id;
        public FormRooms(RoomsController service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void buttonChangePlan_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormRoom>();
            form.ShowDialog();
        }

        private void FormRooms_Load(object sender, EventArgs e)
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
                    dataGridView1.Columns[4].Visible = false;
                    dataGridView1.Columns[1].AutoSizeMode =
                        DataGridViewAutoSizeColumnMode.Fill;
                }
                label1.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            LoadData();
            label1.Visible = false;
        }

        private void buttonCountPatients_Click(object sender, EventArgs e)
        {
            try
            {
                List<RoomViewModel> list = service.CountPationsInEachRoom();
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
                    dataGridView1.Columns[4].HeaderText = "Занято";
                }
                label1.Text = "Составлено на " + DateTime.Now.ToString();
                label1.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void buttonSelectFreePlaces_Click(object sender, EventArgs e)
        {
            try
            {
                List<RoomViewModel> list = service.CountFreePlacesEachRoom();
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
                    dataGridView1.Columns[4].HeaderText = "Свободно в палате";
                }
                label1.Text = "Составлено на " + DateTime.Now.ToString();
                label1.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void buttonReportWithRooms_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormRoomsReport>();
            form.ShowDialog();
        }
    }
}
