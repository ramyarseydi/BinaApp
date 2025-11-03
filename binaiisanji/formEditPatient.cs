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
    public partial class formEditPatient : Form
    {
        public formEditPatient()
        {
            InitializeComponent();
            refreshdata();
            dtpNextAppointment.Enabled = false;
            dtpFappointment.Enabled = false;
            rdbPatientGenderM.Enabled = false;
            rdbPatientGenderF.Enabled = false;
            cmbInsourence.Enabled = false;
            tbxPatientFname.Enabled = false;
            tbxPatientLname.Enabled = false;
            tbxPatientAge.Enabled = false;
            tbxPatientPhoneNumber.Enabled = false;
            tbxPatientSickness.Enabled = false;
            tbxPatientAddress.Enabled = false;


        }

        private void formEditPatient_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult result = FarsiMessageBox.MessageBox.Show("پیام خروج ", "آیا میخواهید از برنامه خارج شوید ؟  ", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Question);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            else
                e.Cancel = true;
        }

     
      

        
      
        public void refreshdata()
        {
            var res = Database.Instance().ExecuteQuery("select * from Insurence");
            DataRow dr = res.NewRow();
            dr.ItemArray = new object[] { 0 ," --نوع بیمه--" };
            res.Rows.InsertAt(dr, 0);
            cmbInsourence.ValueMember = "InsID";
            cmbInsourence.DisplayMember = "InsName";
            cmbInsourence.DataSource = res;

        }
        private void btnEditShow_Click(object sender, EventArgs e)
        {
            if (tbxfileNumber.Text == string.Empty || tbxfileNumber.Text == "  شماره پرونده")
            {
                FarsiMessageBox.MessageBox.Show("خطا", "لطفا فیلد مربوط به شماره پروندده را پر کنید  ", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);

            }
            else {
                dtpNextAppointment.Enabled = true;
                dtpFappointment.Enabled = true;
                rdbPatientGenderM.Enabled = true;
            rdbPatientGenderF.Enabled = true;
            cmbInsourence.Enabled = true;
            tbxPatientFname.Enabled = true;
            tbxPatientLname.Enabled = true;
            tbxPatientAge.Enabled = true;
            tbxPatientPhoneNumber.Enabled = true;
            tbxPatientSickness.Enabled = true;
            tbxPatientAddress.Enabled = true;

            int filenum = Convert.ToInt32(tbxfileNumber.Text);
            var res = Database.Instance().ExecuteQuery("SELECT * FROM Patient WHERE File_number = '" + filenum + "'");
            var ins = Database.Instance().ExecuteQuery("SELECT InsName FROM Insurence WHERE InsID = '"+Convert.ToInt32(res.Rows[0][8].ToString())+"'");
            tbxPatientFname.Text = res.Rows[0][0].ToString();
            tbxPatientLname.Text = res.Rows[0][1].ToString();
            tbxPatientAge.Text = res.Rows[0][2].ToString();
            tbxPatientPhoneNumber.Text = res.Rows[0][3].ToString();
            tbxPatientSickness.Text = res.Rows[0][6].ToString();
            tbxPatientAddress.Text = res.Rows[0][5].ToString();
            cmbInsourence.Text = ins.Rows[0][0].ToString();
            if (res.Rows[0][4].ToString() == "مرد")
            {
                rdbPatientGenderM.Select();

            }
            if (res.Rows[0][4].ToString() == "زن")
            {
                rdbPatientGenderF.Select();

            }
            dtpFappointment.Text = res.Rows[0][9].ToString();
            dtpNextAppointment.Text = res.Rows[0][10].ToString(); }
           

        }

        private void tbxPatientFname_Enter_1(object sender, EventArgs e)
        {
            if (tbxPatientFname.Text == "  نام  ")
            {
                tbxPatientFname.Text = "";
                tbxPatientFname.ForeColor = Color.Black;

            }
        }

        private void tbxPatientFname_Leave_1(object sender, EventArgs e)
        {
            if (tbxPatientFname.Text == "")
            {
                tbxPatientFname.Text = "  نام  ";
                tbxPatientFname.ForeColor = Color.DimGray;

            }
        }

        private void tbxPatientLname_Leave_1(object sender, EventArgs e)
        {
            if (tbxPatientLname.Text == "")
            {
                tbxPatientLname.Text = "  نام خانوادگی   ";
                tbxPatientLname.ForeColor = Color.DimGray;

            }
        }

        private void tbxPatientLname_Enter_1(object sender, EventArgs e)
        {
            if (tbxPatientLname.Text == "  نام خانوادگی   ")
            {
                tbxPatientLname.Text = "";
                tbxPatientLname.ForeColor = Color.Black;

            }
        }

        private void tbxPatientAge_Leave_1(object sender, EventArgs e)
        {
            if (tbxPatientAge.Text == "")
            {
                tbxPatientAge.Text = "  سن";
                tbxPatientAge.ForeColor = Color.DimGray;

            }
        }
    

        private void tbxPatientAge_Enter_1(object sender, EventArgs e)
        {
            if (tbxPatientAge.Text == "  سن")
            {
                tbxPatientAge.Text = "";
                tbxPatientAge.ForeColor = Color.Black;

            }
        }

        private void tbxPatientPhoneNumber_Leave_1(object sender, EventArgs e)
        {
            if (tbxPatientPhoneNumber.Text == "")
            {
                tbxPatientPhoneNumber.Text = "  شماره تماس";
                tbxPatientPhoneNumber.ForeColor = Color.DimGray;

            }
        }

        private void tbxPatientPhoneNumber_Enter_1(object sender, EventArgs e)
        {
            if (tbxPatientPhoneNumber.Text == "  شماره تماس")
            {
                tbxPatientPhoneNumber.Text = "";
                tbxPatientPhoneNumber.ForeColor = Color.Black;

            }
        }

        private void tbxPatientAddress_Leave_1(object sender, EventArgs e)
        {
            if (tbxPatientAddress.Text == "")
            {
                tbxPatientAddress.Text = "  آدرس     ";
                tbxPatientAddress.ForeColor = Color.DimGray;

            }
        }

        private void tbxPatientAddress_Enter_1(object sender, EventArgs e)
        {
        if (tbxPatientAddress.Text == "  آدرس     ")
        {
            tbxPatientAddress.Text = "";
            tbxPatientAddress.ForeColor = Color.Black;

        }
    }

        private void tbxPatientSickness_Leave(object sender, EventArgs e)
        {
            if (tbxPatientSickness.Text == "")
            {
                tbxPatientSickness.Text = "  شرح بیماری    ";
                tbxPatientSickness.ForeColor = Color.Black;

            }
        }

        private void tbxPatientSickness_Enter(object sender, EventArgs e)
        {
            if (tbxPatientSickness.Text == "  شرح بیماری    ")
            {
                tbxPatientSickness.Text = "";
                tbxPatientSickness.ForeColor = Color.DimGray;

            }
        }

        private void btnEditBack_Click(object sender, EventArgs e)
        {
            int flag = 0;
            string gender = "";
            if (rdbPatientGenderM.Checked) gender = "مرد";
            if (rdbPatientGenderF.Checked) gender = "زن";

            if (cmbInsourence.SelectedValue.ToString() == "0") flag = 1;

            else if (tbxPatientFname.Text != "  نام  ") flag = 1;
            else if (tbxPatientLname.Text != "  نام خانوادگی   ") flag = 1;
            else if (tbxPatientAge.Text != "  سن") flag = 1;
            else if (tbxPatientPhoneNumber.Text != "  شماره تماس") flag = 1;
            else if (tbxPatientSickness.Text != "  شرح بیماری    ") flag = 1;
            else if (tbxPatientAddress.Text != "  آدرس     ") flag = 1;
            else if (gender != "") flag = 1;
            if(flag == 1) 
            { 
                DialogResult dr = FarsiMessageBox.MessageBox.Show("هشدار", "تغییرات داده شده ذخیره نشده اند، آیا میخواهید به صفحه منو بازگردید ؟ ", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Question);
            if (dr == DialogResult.Yes)
            {
              var recmenu = new formRecpetMenu();
            this.Hide();
            recmenu.ShowDialog();
                }
            }
            else
            {
                this.Hide();
                var recmenu = new formRecpetMenu();
                recmenu.ShowDialog();
            }
          
        
        }

        private void btnEditSave_Click(object sender, EventArgs e)
        {
            if (tbxfileNumber.Text != string.Empty || tbxfileNumber.Text != "  شماره پرونده")
            {

                int flag = 0;
                string gender = "";
                if (rdbPatientGenderM.Checked) gender = "مرد";
                if (rdbPatientGenderF.Checked) gender = "زن";

                if (cmbInsourence.SelectedValue.ToString() == "0") flag = 1;

                else if (tbxPatientFname.Text == "  نام  ") flag = 1;
                else if (tbxPatientLname.Text == "  نام خانوادگی   ") flag = 1;
                else if (tbxPatientAge.Text == "  سن") flag = 1;
                else if (tbxPatientPhoneNumber.Text == "  شماره تماس") flag = 1;
                else if (tbxPatientSickness.Text == "  شرح بیماری    ") flag = 1;
                else if (tbxPatientAddress.Text == "  آدرس     ") flag = 1;
                else if (gender == "") flag = 1;
                if (flag == 0)
                {
                    int file = Convert.ToInt32(tbxfileNumber.Text);
                    int InsID = 0;
                    if (cmbInsourence.SelectedValue.ToString() != "0")
                    {
                        InsID = Convert.ToInt32(cmbInsourence.SelectedValue.ToString());
                    }
                    int age = Convert.ToInt32(tbxPatientAge.Text);


                    Database.Instance().Use("UPDATE Patient SET Fname = '" + tbxPatientFname.Text + "',Lname = '" + tbxPatientLname.Text + "',Age ='" + age + "' ,Phone_Number = '" + tbxPatientPhoneNumber.Text + "',Gender = '" + gender + "',Address ='" + tbxPatientAddress.Text + "' ,Explain = '" + tbxPatientSickness.Text + "',InsurenceID ='" + InsID + "' ,F_date ='" + dtpFappointment.Text + "' ,L_date='" + dtpNextAppointment.Text + "' WHERE File_number='" + file + "'");
                    FarsiMessageBox.MessageBox.Show("", "اطلاعات بیمار  با موفقیت ویرایش شد.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                }
                else
                {
                    FarsiMessageBox.MessageBox.Show("خطا", "لطفا تمامی فیلد ها را پر کنید  ", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);

                }
            
        }
            else
            {
                FarsiMessageBox.MessageBox.Show("خطا", "لطفا فیلد مربوط به شماره پروندده را پر کنید  ", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);

            }
        }

        private void btnDeletepatient_Click(object sender, EventArgs e)
        {
            if (tbxfileNumber.Text != string.Empty || tbxfileNumber.Text != "  شماره پرونده")
            { 
                int file = Convert.ToInt32(tbxfileNumber.Text);
           
            DialogResult dr= FarsiMessageBox.MessageBox.Show("حذف", "آیا میخواهید اطلاعات بیمار را پاک نمایید ؟ .", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Question);
            if( dr == DialogResult.Yes)
            {
                Database.Instance().Use("DELETE FROM Patient WHERE File_number = '"+file+"'");
                    DialogResult dr1 = FarsiMessageBox.MessageBox.Show("تایید", "عملیات حذف با موفقیت انجام شد. .", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);

                }
            }
            else
            {
                DialogResult dr = FarsiMessageBox.MessageBox.Show("هشدار", "عملیات حذف اطلاعات بیمار لغو شد .", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);

            }

        }

        private void tbxfileNumber_Enter(object sender, EventArgs e)
        {
            if (tbxfileNumber.Text == "  شماره پرونده")
            {
                tbxfileNumber.Text = "";
                tbxfileNumber.ForeColor = Color.DimGray;

            }
        }

        private void tbxfileNumber_Leave(object sender, EventArgs e)
        {
            if (tbxfileNumber.Text == "")
            {
                tbxfileNumber.Text = "  شماره پرونده";
                tbxfileNumber.ForeColor = Color.Black;

            }
        }

        private void tbxfileNumber_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbxPatientAge_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbxPatientPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
