using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace binaiisanji
{
    public partial class formReminder : Form
    {
        public formReminder()
        {
            InitializeComponent();
        }

        private void btnBackReminder_Click(object sender, EventArgs e)
        {
            formEyeCLinicMain file = new formEyeCLinicMain();
            this.Hide();
            file.ShowDialog();
        }

        private void formReminder_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult result = FarsiMessageBox.MessageBox.Show("پیام خروج ", "آیا میخواهید از برنامه خارج شوید ؟  ", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Question);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            else
                e.Cancel = true;
        }

        private void dtpReminder_Load(object sender, EventArgs e)
        {

        }

        private void btnShowReminder_Click(object sender, EventArgs e)
        {
            
            DataTable result = Database.Instance().ExecuteQuery(" SELECT Patient.Fname ,Patient.Lname ,Nobat.Date,Nobat.Time FROM Patient INNER JOIN Nobat ON Patient.File_number = Nobat.File_Number WHERE Nobat.Date = '"+dtpReminder.Text+"' ");
            dgvReminder.DataSource = result;
            dgvReminder.Columns[3].HeaderText = "ساعت";
            dgvReminder.Columns[2].HeaderText = "تاریخ";
            dgvReminder.Columns[1].HeaderText = "نام خانوادگی";
            dgvReminder.Columns[0].HeaderText = " نام";

            dgvReminder.Columns[3].Width = 70;
            dgvReminder.Columns[2].Width = 100;
            dgvReminder.Columns[1].Width = 90;
            dgvReminder.Columns[0].Width = 90;


        }

        private void formReminder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicDataSet10.Nobat' table. You can move, or remove it, as needed.
            //this.nobatTableAdapter.Fill(this.clinicDataSet10.Nobat);
            //DataTable result = Database.Instance().ExecuteQuery(" SELECT Patient.Fname ,Patient.Lname ,Nobat.Date,Nobat.Time FROM Patient INNER JOIN Nobat ON Patient.File_number = Nobat.File_Number  ");
            //dgvReminder.DataSource = result;



            this.dgvReminder.DefaultCellStyle.Font = new Font("B Roya", 16F, FontStyle.Bold, GraphicsUnit.Pixel); ;




        }
    }
}
