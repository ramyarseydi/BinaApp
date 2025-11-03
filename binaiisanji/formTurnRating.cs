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
    public partial class formTurnRating : Form
    {
        public formTurnRating()
        {

            InitializeComponent();
            tbxrecpFileNum.Enabled = false;
            mtbxTime.Enabled = false;

          
        }

    
        private void btnBackTurnRateing_Click(object sender, EventArgs e)
        {
            var recmenu = new formRecpetMenu();
            this.Hide();
            recmenu.ShowDialog();
        }

        private void formTurnRating_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = FarsiMessageBox.MessageBox.Show("پیام خروج ", "آیا میخواهید از برنامه خارج شوید ؟  ", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Question);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            else
                e.Cancel = true;
        }

 
     

        private void tbxrecpFileNum_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void btnNextTurnRateing_Click_1(object sender, EventArgs e)
        {
            int file = Convert.ToInt32(tbxrecpFileNum.Text);
            Database.Instance().Use("INSERT INTO Nobat (File_Number,Date,Time) VALUES ('"+file+"','"+dtpturnRating.Text+"','"+mtbxTime.Text+"')");
            FarsiMessageBox.MessageBox.Show(" ", " نوبت با موفقیت رزرو گردید  ", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);

        }

        private void formTurnRating_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicDataSet9.Nobat' table. You can move, or remove it, as needed.
           // this.nobatTableAdapter1.Fill(this.clinicDataSet9.Nobat);
            DataTable result = Database.Instance().ExecuteQuery(" SELECT Patient.Fname ,Patient.Lname ,Nobat.File_Number,Nobat.Date,Nobat.Time FROM Patient INNER JOIN Nobat ON Patient.File_number = Nobat.File_Number  ");
            dgvTurnRating.DataSource = result;
            


            this.dgvTurnRating.DefaultCellStyle.Font = new Font("B Roya", 16F, FontStyle.Bold, GraphicsUnit.Pixel); ;
           
            
            dgvTurnRating.Columns[4].HeaderText = "ساعت";
            dgvTurnRating.Columns[3].HeaderText = "تاریخ";
            dgvTurnRating.Columns[2].HeaderText = "شماره پرونده";
            dgvTurnRating.Columns[1].HeaderText = "نام خانوادگی" ;
            dgvTurnRating.Columns[0].HeaderText = " نام";

            dgvTurnRating.Columns[4].Width = 60;
            dgvTurnRating.Columns[3].Width = 100;
            dgvTurnRating.Columns[2].Width = 50;
            dgvTurnRating.Columns[1].Width = 90;
            dgvTurnRating.Columns[0].Width = 90;

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            FarsiMessageBox.MessageBox.Show(" ", " لطفا شماره پرونده و ساعت مراجعه را وارد نمایید   ", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);

            tbxrecpFileNum.Enabled = true;
            mtbxTime.Enabled = true;
            DataTable result = Database.Instance().ExecuteQuery(" SELECT Patient.Fname ,Patient.Lname ,Nobat.File_Number,Nobat.Date,Nobat.Time FROM Patient INNER JOIN Nobat ON Patient.File_number = Nobat.File_Number WHERE Nobat.Date = '"+dtpturnRating.Text+"' ");
            dgvTurnRating.DataSource = result;

        }

        private void tbxrecpFileNum_Enter(object sender, EventArgs e)
        {
            if (tbxrecpFileNum.Text == "  شماره پرونده")
            {
                tbxrecpFileNum.Text = "";
                tbxrecpFileNum.ForeColor = Color.DimGray;

            }
        }

        private void tbxrecpFileNum_Leave(object sender, EventArgs e)
        {
            if (tbxrecpFileNum.Text == "")
            {
                tbxrecpFileNum.Text = "  شماره پرونده";
                tbxrecpFileNum.ForeColor = Color.Black;

            }
        }
    }
}
