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
    public partial class formaddMedicAccess : Form
    {
        public formaddMedicAccess()
        {
            InitializeComponent();
        }

        private void formaddMedicAccess_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = FarsiMessageBox.MessageBox.Show("پیام خروج ", "آیا میخواهید از برنامه خارج شوید ؟  ", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Question);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            else
                e.Cancel = true;
        }
      

        private void btnsavenewMedic_Click(object sender, EventArgs e)
        {
            int flag = 0;
            string gender = "";
            if (rdbmedicGenderM.Checked) gender = "مرد";
            if (rdbmedicGenderF.Checked) gender = "زن";

            if (tbxmedicFname.Text == "  نام  ") flag = 1;
            else if (tbxmedicLname.Text == "  نام خانوادگی   ") flag = 1;
            else if (tbxmedicAge.Text == "  سن") flag = 1;
            else if (tbxmedicPhoneNumber.Text == "  شماره تماس") flag = 1;
            else if (tbxmedicPassword.Text == "  رمز عبور ") flag = 1;
            else if (tbxreenterpassword.Text == "  تکرار رمز عبور ") flag = 1;
            else if (tbxmedicusername.Text == "  نام کاربری  ") flag = 1;
            else if (gender == "") flag = 1;


            if (flag == 0)
            {
                var res = Database.Instance().ExecuteQuery("SELECT Username FROM login WHERE USERNAME = '" + tbxmedicusername.Text + "'");
                if (res.Rows.Count == 0)
                {
                    int age = Convert.ToInt32(tbxmedicAge.Text);


                    if (tbxmedicPassword.Text == tbxreenterpassword.Text)
                    {
                        string encpass = formLogin.Encrypt(tbxmedicPassword.Text);
                        Database.Instance().Use("INSERT INTO login(Username,Password,Post,Fname,Lname,Age,Phone_Number,Gender)VALUES('" + tbxmedicusername.Text + "','" + encpass + "','pezeshk','" + tbxmedicFname.Text + "','" + tbxmedicLname.Text + "','" + age + "','" + tbxmedicPhoneNumber.Text + "','" + gender + "')");
                        DialogResult re = FarsiMessageBox.MessageBox.Show("پیام", "اطلاعات کاربر جدید با موفقیت ذخیره شد.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                        Form_Medic file = new Form_Medic();
                        this.Hide();
                        file.Show();
                    }
                    else
                    {
                        DialogResult re = FarsiMessageBox.MessageBox.Show("خطا ! ", "رمز عبور با تکرار رمز عبور مطابقت ندارد.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);
                        if (re == DialogResult.OK)
                        {

                        }
                    }
                }
                else
                {
                    DialogResult re = FarsiMessageBox.MessageBox.Show("خطا ! ", "نام کاربری تکراری است لطفا نام کاربری جدیدی وارد نمایید .", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);
                    if (re == DialogResult.OK)
                    {

                    }
                }
            }
            else
            {
                DialogResult re = FarsiMessageBox.MessageBox.Show("خطا ! ", "لطفا تمامی فیلد ها را پر کنید  .", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);
                if (re == DialogResult.OK)
                {

                }
            }
        }

        private void tbxmedicFname_Enter(object sender, EventArgs e)
        {
            if (tbxmedicFname.Text == "  نام  ")
            {
                tbxmedicFname.Text = "";
                tbxmedicFname.ForeColor = Color.Black;

            }
        }

        private void tbxmedicFname_Leave(object sender, EventArgs e)
        {
            if (tbxmedicFname.Text == "")
            {
                tbxmedicFname.Text = "  نام  ";
                tbxmedicFname.ForeColor = Color.DimGray;

            }
        }

        private void tbxmedicLname_Enter(object sender, EventArgs e)
        {
            if (tbxmedicLname.Text == "  نام خانوادگی   ")
            {
                tbxmedicLname.Text = "";
                tbxmedicLname.ForeColor = Color.Black;

            }
        }

        private void tbxmedicAge_Enter(object sender, EventArgs e)
        {
            if (tbxmedicAge.Text == "  سن")
            {
                tbxmedicAge.Text = "";
                tbxmedicAge.ForeColor = Color.Black;

            }
        }

        private void tbxmedicPhoneNumber_Enter(object sender, EventArgs e)
        {
            if (tbxmedicPhoneNumber.Text == "  شماره تماس")
            {
                tbxmedicPhoneNumber.Text = "";
                tbxmedicPhoneNumber.ForeColor = Color.Black;

            }
        }

        private void tbxmedicusername_Enter(object sender, EventArgs e)
        {
            if (tbxmedicusername.Text == "  نام کاربری  ")
            {
                tbxmedicusername.Text = "";
                tbxmedicusername.ForeColor = Color.Black;

            }
        }

        private void tbxmedicPassword_Enter(object sender, EventArgs e)
        {
            if (tbxmedicPassword.Text == "  رمز عبور ")
            {
                tbxmedicPassword.UseSystemPasswordChar = true;
                tbxmedicPassword.Text = "";
                tbxmedicPassword.ForeColor = Color.Black;

            }
        }

        private void tbxreenterpassword_Enter(object sender, EventArgs e)
        {
            if (tbxreenterpassword.Text == "  تکرار رمز عبور ")
            {
                tbxreenterpassword.UseSystemPasswordChar = true;
                tbxreenterpassword.Text = "";
                tbxreenterpassword.ForeColor = Color.Black;

            }
        }

        private void tbxmedicLname_Leave(object sender, EventArgs e)
        {
            if (tbxmedicLname.Text == "")
            {
                tbxmedicLname.Text = "  نام خانوادگی   ";
                tbxmedicLname.ForeColor = Color.DimGray;

            }
        }

        private void tbxmedicAge_Leave(object sender, EventArgs e)
        {
            if (tbxmedicAge.Text == "")
            {
                tbxmedicAge.Text = "  سن";
                tbxmedicAge.ForeColor = Color.DimGray;

            }
        }

        private void tbxmedicPhoneNumber_Leave(object sender, EventArgs e)
        {
            if (tbxmedicPhoneNumber.Text == "")
            {
                tbxmedicPhoneNumber.Text = "  شماره تماس";
                tbxmedicPhoneNumber.ForeColor = Color.DimGray;

            }
        }

        private void tbxmedicusername_Leave(object sender, EventArgs e)
        {
            if (tbxmedicusername.Text == "")
            {
                tbxmedicusername.Text = "  نام کاربری  ";
                tbxmedicusername.ForeColor = Color.DimGray;

            }
        }

        private void tbxmedicPassword_Leave(object sender, EventArgs e)
        {
            if (tbxmedicPassword.Text == "")
            {
                tbxmedicPassword.UseSystemPasswordChar = false;
                tbxmedicPassword.Text = "  رمز عبور ";
                tbxmedicPassword.ForeColor = Color.DimGray;

            }
        }

        private void tbxreenterpassword_Leave(object sender, EventArgs e)
        {
            if (tbxreenterpassword.Text == "")
            {
                tbxreenterpassword.UseSystemPasswordChar = false;
                tbxreenterpassword.Text = "  تکرار رمز عبور ";
                tbxreenterpassword.ForeColor = Color.DimGray;

            }
        }

        private void btnBackAddmedicAccess_Click(object sender, EventArgs e)
        {
            formMainAdmin file = new formMainAdmin();
            this.Hide();
            file.ShowDialog();
        }

        private void tbxmedicAge_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbxmedicPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShowpassword.Checked)
            {
                tbxmedicPassword.UseSystemPasswordChar = false;
                tbxreenterpassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbxmedicPassword.UseSystemPasswordChar = true;
                tbxreenterpassword.UseSystemPasswordChar = true;
            }
        }
    }
 }

