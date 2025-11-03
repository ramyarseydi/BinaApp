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
    public partial class formaddrespaccess : Form
    {
        public int userID { get; set; }
        public formaddrespaccess()
        {
            InitializeComponent();
            userID = Session.UserID;
        }

        private void formaddrespaccess_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = FarsiMessageBox.MessageBox.Show("پیام خروج ", "آیا میخواهید از برنامه خارج شوید ؟  ", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Question);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            else
                e.Cancel = true;
        }

        private void tbxrecFname_Enter(object sender, EventArgs e)
        {

            if (tbxrecFname.Text == "  نام  ")
            {
                tbxrecFname.Text = "";
                tbxrecFname.ForeColor = Color.Black;

            }
        }

        private void tbxrecFname_Leave(object sender, EventArgs e)
        {
            if (tbxrecFname.Text == "")
            {
                tbxrecFname.Text = "  نام  ";
                tbxrecFname.ForeColor = Color.DimGray;

            }
        }

        private void tbxrecLname_Enter(object sender, EventArgs e)
        {
            if (tbxrecLname.Text == "  نام خانوادگی   ")
            {
                tbxrecLname.Text = "";
                tbxrecLname.ForeColor = Color.Black;

            }
        }

        private void tbxrecLname_Leave(object sender, EventArgs e)
        {
            if (tbxrecLname.Text == "")
            {
                tbxrecLname.Text = "  نام خانوادگی   ";
                tbxrecLname.ForeColor = Color.DimGray;

            }
        }

        private void tbxrecAge_Enter(object sender, EventArgs e)
        {
            if (tbxrecAge.Text == "  سن")
            {
                tbxrecAge.Text = "";
                tbxrecAge.ForeColor = Color.Black;

            }
        }

        private void tbxrecAge_Leave(object sender, EventArgs e)
        {
            if (tbxrecAge.Text == "")
            {
                tbxrecAge.Text = "  سن";
                tbxrecAge.ForeColor = Color.DimGray;

            }
        }

        private void tbxrecPhoneNumber_Enter(object sender, EventArgs e)
        {
            if (tbxrecPhoneNumber.Text == "  شماره تماس")
            {
                tbxrecPhoneNumber.Text = "";
                tbxrecPhoneNumber.ForeColor = Color.Black;

            }
        }

        private void tbxrecPhoneNumber_Leave(object sender, EventArgs e)
        {
            if (tbxrecPhoneNumber.Text == "")
            {
                tbxrecPhoneNumber.Text = "  شماره تماس";
                tbxrecPhoneNumber.ForeColor = Color.DimGray;

            }
        }

        private void tbxrecusername_Enter(object sender, EventArgs e)
        {
            if (tbxrecusername.Text == "  نام کاربری  ")
            {
                tbxrecusername.Text = "";
                tbxrecusername.ForeColor = Color.Black;

            }
        }

        private void tbxrecusername_Leave(object sender, EventArgs e)
        {
            if (tbxrecusername.Text == "")
            {
                tbxrecusername.Text = "  نام کاربری  ";
                tbxrecusername.ForeColor = Color.DimGray;

            }
        }

        private void tbxrecPassword_Leave(object sender, EventArgs e)
        {
            if (tbxrecPassword.Text == "")
            {
                tbxrecPassword.UseSystemPasswordChar = false;
                tbxrecPassword.Text = "  رمز عبور ";
                tbxrecPassword.ForeColor = Color.DimGray;

            }
        }

        private void tbxrecPassword_Enter(object sender, EventArgs e)
        {

            if (tbxrecPassword.Text == "  رمز عبور ")
            {
                tbxrecPassword.UseSystemPasswordChar = true;
                tbxrecPassword.Text = "";
                tbxrecPassword.ForeColor = Color.Black;

            }
        }

        private void tbxresreenterpassword_Enter(object sender, EventArgs e)
        {
            if (tbxresreenterpassword.Text == "  تکرار رمز عبور ")
            {
                tbxresreenterpassword.UseSystemPasswordChar = true;
                tbxresreenterpassword.Text = "";
                tbxresreenterpassword.ForeColor = Color.Black;

            }
        }

        private void tbxresreenterpassword_Leave(object sender, EventArgs e)
        {
            if (tbxresreenterpassword.Text == "")
            {
                tbxresreenterpassword.UseSystemPasswordChar = false;
                tbxresreenterpassword.Text = "  تکرار رمز عبور ";
                tbxresreenterpassword.ForeColor = Color.DimGray;

            }
        }

        private void btnBackAddresAccess_Click(object sender, EventArgs e)
        {
            if(Session.UserType == UserType.Admin)
            {
                formMainAdmin file = new formMainAdmin();
                this.Hide();
                file.ShowDialog();
            }
            if (Session.UserType == UserType.Doctor)
            {
                Form_Medic file = new Form_Medic();
                this.Hide();
                file.ShowDialog();
            }


        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

            if (tbxSalary.Text == "")
            {
                tbxSalary.Text = "  حقوق ساعتی";
                tbxSalary.ForeColor = Color.DimGray;

            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

            if (tbxSalary.Text == "  حقوق ساعتی")
            {
                tbxSalary.Text = "";
                tbxSalary.ForeColor = Color.Black;

            }
        }

        private void btnsavenewres_Click(object sender, EventArgs e)
        {
            int flag = 0;
            string gender = "";
                if (rdbresGenderM.Checked) gender = "مرد";
                if (rdbresGenderF.Checked) gender = "زن";

            if (tbxrecFname.Text == "  نام  ") flag = 1;
            else if (tbxrecLname.Text == "  نام خانوادگی   ") flag = 1;
            else if (tbxrecAge.Text == "  سن") flag = 1;
            else if (tbxrecPhoneNumber.Text == "  شماره تماس") flag=1;
            else if (tbxrecPassword.Text == "  رمز عبور ") flag = 1;
            else if (tbxresreenterpassword.Text == "  تکرار رمز عبور ") flag = 1;
            else if (tbxrecusername.Text == "  نام کاربری  ") flag = 1;
            else if (tbxSalary.Text == "  حقوق ساعتی") flag = 1;
            else if (gender=="") flag =1;


            if (flag == 0)
            {
                var res = Database.Instance().ExecuteQuery("SELECT Username FROM login WHERE USERNAME = '" + tbxrecusername.Text + "'");
                if (res.Rows.Count == 0)
                {
                    int age = Convert.ToInt32(tbxrecAge.Text);

                    //  int salary = Convert.ToInt32(tbxSalary.Text);
                    if (tbxrecPassword.Text == tbxresreenterpassword.Text)
                    {
                        string encpass = formLogin.Encrypt(tbxrecPassword.Text);
                        Database.Instance().Use("INSERT INTO login(Username,Password,Post,Fname,Lname,Age,Phone_Number,Gender,salary)VALUES('" + tbxrecusername.Text + "','" + encpass + "','monshi','" + tbxrecFname.Text + "','" + tbxrecLname.Text + "','" + age + "','" + tbxrecPhoneNumber.Text + "','" + gender + "','" + tbxSalary.Text + "')");
                        DialogResult re = FarsiMessageBox.MessageBox.Show("", "اطلاعات کاربر جدید با موفقیت ذخیره شد.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                        if (Session.UserType == UserType.Admin)
                        {
                            formMainAdmin file = new formMainAdmin();
                            this.Hide();
                            file.ShowDialog();
                        }
                        if (Session.UserType == UserType.Doctor)
                        {
                            Form_Medic file = new Form_Medic();
                            this.Hide();
                            file.ShowDialog();
                        }
                    }
                    else
                    {
                        DialogResult re = FarsiMessageBox.MessageBox.Show("خطا ! ", "نام کاربری وارد شده تکراری است لظفا نام کابری دیگری وارد کنید", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);
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
                DialogResult re = FarsiMessageBox.MessageBox.Show("خطا ! ", "لطفا تمامی فیلد ها را پر کنید.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);
                if (re == DialogResult.OK)
                {

                }
            }
        }

        private void tbxrecAge_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbxrecPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbxSalary_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbxSalary_TextChanged(object sender, EventArgs e)
        {
            if (tbxSalary.Text != string.Empty)
            {
                try
                {
                    tbxSalary.Text = Int64.Parse(tbxSalary.Text.Replace(",", "")).ToString("#,0");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                tbxSalary.Select(tbxSalary.TextLength, 0);
            }
        }

        private void cbxShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if(cbxShowpassword.Checked)
            {
                tbxrecPassword.UseSystemPasswordChar = false;
                tbxresreenterpassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbxresreenterpassword.UseSystemPasswordChar = true;
                tbxrecPassword.UseSystemPasswordChar = true;
            }
        }
    }
}

