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
    public partial class formchanegpassword : Form
    {
        public int UserID { get; set; }
        public formchanegpassword()
        {
            InitializeComponent();
            this.UserID = Session.UserID;
    
        }

        private void formchanegpassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = FarsiMessageBox.MessageBox.Show("پیام خروج ", "آیا میخواهید از برنامه خارج شوید ؟  ", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Question);
            if (result == DialogResult.Yes)
            {
               // Database.Instance().Use("INSERT INTO ReceptionIncome (Date,Timer,IDReC) VALUES ('"+timer.lbl+"')");
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            else
                e.Cancel = true;
        }

    
        
        private void tbxnewpassword_Enter(object sender, EventArgs e)
        {
            if (tbxnewpassword.Text == "  رمز عبور جدید ")
            {
                tbxnewpassword.UseSystemPasswordChar = true;
                tbxnewpassword.Text = "";
                tbxnewpassword.ForeColor = Color.Black;

            }
        }

        private void tbxreenterpassword_Enter(object sender, EventArgs e)
        {
            if (tbxreenterpassword.Text == "  تکرار رمز عبور جدید ")
            {
                tbxnewpassword.UseSystemPasswordChar = true;
                tbxreenterpassword.Text = "";
                tbxreenterpassword.ForeColor = Color.Black;

            }
        }

      

        private void tbxnewpassword_Leave(object sender, EventArgs e)
        {
            if (tbxnewpassword.Text == "")
            {
                tbxnewpassword.UseSystemPasswordChar = false;
                tbxnewpassword.Text = "  رمز عبور جدید ";
                tbxnewpassword.ForeColor = Color.DimGray;

            }
        }

        private void tbxreenterpassword_Leave(object sender, EventArgs e)
        {
            if (tbxreenterpassword.Text == "")
            {
                tbxnewpassword.UseSystemPasswordChar = false;
                tbxreenterpassword.Text = "  تکرار رمز عبور جدید ";
                tbxreenterpassword.ForeColor = Color.DimGray;

            }
        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            string pass = formLogin.Encrypt(tbxnewpassword.Text);
            string reenter = formLogin.Encrypt(tbxreenterpassword.Text);

            int flag = 0;
            if (tbxnewpassword.Text == "  رمز عبور جدید ") flag = 1;
            else if (tbxreenterpassword.Text == "  تکرار رمز عبور جدید ") flag = 1;
            if (flag == 0)
            {
                if (pass == reenter)
                {
                    Database.Instance().Use("UPDATE login SET Password = '" + pass + "'WHERE ID = '" + UserID + "'");
                    DialogResult re = FarsiMessageBox.MessageBox.Show("پیام ", " رمز عبور با موفقیت تغییر یافت.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                    if (Session.UserType == UserType.Admin)
                    {
                        formMainAdmin file = new formMainAdmin();
                        this.Hide();
                        file.ShowDialog();

                    }
                    else if (Session.UserType == UserType.Secretary)
                    {
                        formEyeCLinicMain file = new formEyeCLinicMain();
                        this.Hide();
                        file.ShowDialog();

                    }
                    else if (Session.UserType == UserType.Doctor)
                    {
                        Form_Medic file = new Form_Medic();
                        this.Hide();
                        file.ShowDialog();
                    }
                }
                else
                {
                    DialogResult re = FarsiMessageBox.MessageBox.Show("خطا", " رمز عبور جدید و تکرار آن یکسان نیستند", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);

                }
            }
            else
            {
                DialogResult re = FarsiMessageBox.MessageBox.Show("خطا", " لطفا تمامی فیلد ها را پر نمایید", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);

            }
        }

        private void btnBackChangePassword_Click(object sender, EventArgs e)
        {
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
            if (Session.UserType == UserType.Secretary)
            {
                formEyeCLinicMain file = new formEyeCLinicMain();
                this.Hide();
                file.ShowDialog();
            }
        }

        private void cbxShowpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShowpassword.Checked)
            {
                tbxnewpassword.UseSystemPasswordChar = false;
                tbxreenterpassword.UseSystemPasswordChar = false;
            }
            else
            {
                tbxnewpassword.UseSystemPasswordChar = true;
                tbxreenterpassword.UseSystemPasswordChar = true;
            }
        }
    }
}
