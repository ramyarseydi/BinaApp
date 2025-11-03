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
    public partial class formResp : Form
    {
        public formResp()
        {
            InitializeComponent();
           
            refreshsickness();
        }

  

        public void refreshsickness()
        {
            var res = Database.Instance().ExecuteQuery("select * from SicknessCosts");
            DataRow dr = res.NewRow();
            dr.ItemArray = new object[] {  0," --نوع بیماری--" };
            res.Rows.InsertAt(dr, 0);
            cmbSickness.ValueMember = "SicknessCosts";
            cmbSickness.DisplayMember = "SicknessName";
            cmbSickness.DataSource = res;

        }

        private void tbxpaymentNumber_Enter(object sender, EventArgs e)
        {
            if (tbxpaymentNumber.Text == "  شماره پیگیری پرداخت ")
            {
                tbxpaymentNumber.Text = "";
                tbxpaymentNumber.ForeColor = Color.Black;

            }
        }

        private void tbxrecpFileNum_Enter(object sender, EventArgs e)
        {
            if (tbxrecpFileNum.Text == "  شماره پرونده     ")
            {
                tbxrecpFileNum.Text = "";
                tbxrecpFileNum.ForeColor = Color.Black;

            }
        }

      

        private void tbxpaymentNumber_Leave(object sender, EventArgs e)
        {
            if (tbxpaymentNumber.Text == "")
            {
                tbxpaymentNumber.Text = "  شماره پیگیری پرداخت ";
                tbxpaymentNumber.ForeColor = Color.DimGray;

            }
        }

        private void tbxrecpFileNum_Leave(object sender, EventArgs e)
        {
            if (tbxrecpFileNum.Text == "")
            {
                tbxrecpFileNum.Text = "  شماره پرونده     ";
                tbxrecpFileNum.ForeColor = Color.DimGray;

            }
        }

        private void btnSaveFIleGen_Click(object sender, EventArgs e)
        {
           int FileNum = Convert.ToInt32(tbxrecpFileNum.Text);
           int paynum = Convert.ToInt32(tbxpaymentNumber.Text);
            PersianCalendar p = new PersianCalendar();
            DateTime dt = DateTime.Now;
            String y, m, d ,time="";
          
            y = p.GetYear(dt).ToString();
            m = p.GetMonth(dt).ToString();
            d = p.GetDayOfMonth(dt).ToString();
            if(m.Length == 1 && d.Length == 1)
            {
             time = y.ToString() + "/0"
             + m.ToString() + "/0"
              + d.ToString();
            }
            else if(m.Length == 1 && d.Length > 1)
            {
                time = y.ToString() + "/0"
          + m.ToString() + "/"
          + d.ToString();
            }
            else if (m.Length > 1 && d.Length > 1)
            {
                time = y.ToString() + "/"
                  + m.ToString() + "/"
                 + d.ToString();
            }
            else if (m.Length > 1 && d.Length == 1)
            {
                time = y.ToString() + "/"
                  + m.ToString() + "/0"
                + d.ToString();
            }

            var res = Database.Instance().ExecuteQuery("SELECT InsurenceID FROM Patient WHERE File_number='"+FileNum+"'");
            string temp = res.Rows[0][0].ToString();
               var inspersent= Database.Instance().ExecuteQuery("SELECT InsPersent FROM Insurence WHERE InsID = '"+temp+"'");
            int cost = Convert.ToInt32(cmbSickness.SelectedValue.ToString().Replace(",", string.Empty));
            int payByINs = (Convert.ToInt32(inspersent.Rows[0][0].ToString()));
            payByINs = payByINs * cost;
            payByINs = payByINs / 100;
            int patientpay = cost - payByINs;
            string payins = payByINs.ToString();
            payins = Int64.Parse(payins.Replace(",", "")).ToString("#,0");
            string paypati = patientpay.ToString();
            paypati = Int64.Parse(paypati.Replace(",", "")).ToString("#,0");
            Database.Instance().Use("INSERT INTO Payment (Cost,PatientID,PaymentDc,PayInsurence,PayDate,PayBypatient)VALUES('"+ cmbSickness.SelectedValue.ToString() + "','"+FileNum+"','"+paynum+"','"+ payins + "','"+time+"','"+paypati+"')");
            FarsiMessageBox.MessageBox.Show("", "بیمار پذیرش شد ", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);

        }

        private void formResp_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = FarsiMessageBox.MessageBox.Show("پیام خروج ", "آیا میخواهید از برنامه خارج شوید ؟  ", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Question);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            else
                e.Cancel = true;
        }

        private void btnBackFileGen_Click(object sender, EventArgs e)
        {
            formRecpetMenu file = new formRecpetMenu();
            this.Hide();
            file.ShowDialog();
        }
    }
}
