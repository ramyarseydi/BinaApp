using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace binaiisanji
{
    public partial class formPatientcosts : Form
    {
        public formPatientcosts()
        {
            InitializeComponent();
        }

        private void formPatientcosts_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = FarsiMessageBox.MessageBox.Show("پیام خروج ", "آیا میخواهید از برنامه خارج شوید ؟  ", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Question);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            else
                e.Cancel = true;
        }

        private void btnShowCost_Click(object sender, EventArgs e)
        {
            PersianCalendar p = new PersianCalendar();
            DateTime dt = DateTime.Now;
            int y, m, d;
            y = p.GetYear(dt);
            m = p.GetMonth(dt);
            d = p.GetDayOfMonth(dt);
            string time = y.ToString() + "-"
            + m.ToString() + "-"
            + d.ToString();
            int file_number = Convert.ToInt32(tbxPatientFileNumber.Text);
            var res = Database.Instance().ExecuteQuery("SELECT Fname,Lname,InsurenceID FROM Patient WHERE File_Number= '"+file_number+"'");
          
            var res2 = Database.Instance().ExecuteQuery("SELECT Cost, PayInsurence, PayBypatient  FROM Payment WHERE PatientID='"+file_number+"'AND PayDate='"+time+"'");
            var insname = Database.Instance().ExecuteQuery("SELECT InsName FROM Insurence WHERE InsID = '"+Convert.ToInt32(res.Rows[0][2].ToString())+"'");
            var sicknessname = Database.Instance().ExecuteQuery("SELECT SicknessName FROM SicknessCosts WHERE SicknessCosts = '"+res2.Rows[0][0].ToString()+"'");
            tbxPatientName.Text = res.Rows[0][0].ToString() + res.Rows[0][1].ToString();
            tbxDateOfRecp.Text = time;
            tbxInsurence.Text = insname.Rows[0][0].ToString();
            tbxSicknessName.Text = sicknessname.Rows[0][0].ToString();
            tbxCost.Text = res2.Rows[0][0].ToString();
            tbxInsurencePay.Text = res2.Rows[0][1].ToString();
            tbxPatientPay.Text = res2.Rows[0][2].ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tbxPatientFileNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnBackPatientCost_Click(object sender, EventArgs e)
        {
            formRecpetMenu file = new formRecpetMenu();
            this.Hide();
            file.Show();

        }

        private void tbxPatientFileNumber_Enter(object sender, EventArgs e)
        {
            if (tbxPatientFileNumber.Text == "شماره پرونده")
            {
                tbxPatientFileNumber.Text = "";
                tbxPatientFileNumber.ForeColor = Color.Black;

            }
        }

        private void tbxPatientFileNumber_Leave(object sender, EventArgs e)
        {
            if (tbxPatientFileNumber.Text == "")
            {
                tbxPatientFileNumber.Text = "شماره پرونده";
                tbxPatientFileNumber.ForeColor = Color.DimGray;

            }
        }
    }
}
