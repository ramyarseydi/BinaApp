using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Globalization;

namespace binaiisanji
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        // for encrypting the password 
        public static String Encrypt(string value)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string encpass = Encrypt(tbxPassword.Text);
            var res = Database.Instance().ExecuteQuery($"select * from dbo.[login] l where l.Username='{tbxUsername.Text}' AND l.[Password]='{encpass}'");
            if (res.Rows.Count != 0)
            {
                Session.UserID = int.Parse($"{res.Rows[0][9]}");
                if (res.Rows[0][2].ToString() == "monshi")
                {
                    Session.UserType = UserType.Secretary;
                    formEyeCLinicMain file = new formEyeCLinicMain();
                    this.Hide();
                    file.ShowDialog();
                    
                    PersianCalendar p = new PersianCalendar();
                    DateTime dt = DateTime.Now;
                    String y, m, d,h,min, time = "",hour="";

                    y = p.GetYear(dt).ToString();
                    m = p.GetMonth(dt).ToString();
                    d = p.GetDayOfMonth(dt).ToString();
                    h = p.GetHour(dt).ToString();
                    min = p.GetMinute(dt).ToString();
                    if(h.Length > 1 && min.Length > 1)
                    {
                        hour =  h.ToString() + min.ToString();
                    }
                    else if (h.Length == 1 && min.Length == 1)
                    {
                        hour = "0" + h.ToString() + "/0" + min.ToString();
                    }
                    else if (h.Length > 1 && min.Length == 1)
                    {
                        hour =  h.ToString() + "/0" + min.ToString();
                    }
                    else if (h.Length == 1 && min.Length > 1)
                    {
                        hour = "0" + h.ToString() +min.ToString();
                    }

                    if (m.Length == 1 && d.Length == 1)
                    {
                        time = y.ToString() + "/0"
                        + m.ToString() + "/0"
                         + d.ToString();
                    }
                    else if (m.Length == 1 && d.Length > 1)
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
                    
                    Database.Instance().Use("");

           

                }
                else if (res.Rows[0][2].ToString() == "pezeshk")
                {   Session.UserType = UserType.Doctor;
                    Form_Medic file = new Form_Medic();
                    this.Hide();
                    file.ShowDialog();
                    
                }
                else if (res.Rows[0][2].ToString() == "admin")
                { 
                      formMainAdmin file = new formMainAdmin();
                    this.Hide();
                    file.ShowDialog();
               
                }
            }
            else
            {
                DialogResult re = FarsiMessageBox.MessageBox.Show("خطا ! ", "نام کاربری یا رمز عبور وارد شده صحیح نمیباشد.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);
                if (re == DialogResult.OK)
                { 
                   
                }
            }
        }

   
        private void btnExite_Click(object sender, EventArgs e)
        {
          DialogResult result = FarsiMessageBox.MessageBox.Show("پیام خروج ", "آیا میخواهید از برنامه خارج شوید ؟  ", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Question);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = FarsiMessageBox.MessageBox.Show("پیام خروج ", "آیا میخواهید از برنامه خارج شوید ؟  ", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Question);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            else
                e.Cancel = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

   
        private void tbxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbxPassLogo_Click(object sender, EventArgs e)
        {

        }

     
        private void tbxPassword_Enter(object sender, EventArgs e)
        {
            if (tbxPassword.Text == "رمز عبور")
            {
                tbxPassword.UseSystemPasswordChar = true;
                tbxPassword.Text = "";
                tbxPassword.ForeColor = Color.Black;

            }
        }

        private void tbxPassword_Leave(object sender, EventArgs e)
        {
            if (tbxPassword.Text == "")
            {
                tbxPassword.UseSystemPasswordChar = false;
                tbxPassword.Text = "رمز عبور";
                tbxPassword.ForeColor = Color.DimGray;

            }
        }

        private void tbxUsername_Enter_1(object sender, EventArgs e)
        {
            if (tbxUsername.Text == "نام کاربری")
            {
                tbxUsername.Text = "";
                tbxUsername.ForeColor = Color.Black;

            }
        }

        private void tbxUsername_Leave(object sender, EventArgs e)
        {
            if (tbxUsername.Text == "")
            {
                tbxUsername.Text = "نام کاربری";
                tbxUsername.ForeColor = Color.DimGray;

            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            formLogin file = new formLogin();
            this.Hide();
            file.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblResptionMenu2_Click(object sender, EventArgs e)
        {

        }

        private void cbxShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShowpassword.Checked)
            {
                tbxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbxPassword.UseSystemPasswordChar = true;

            }
        }
    }
}
