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
    public partial class formchangeusername : Form
    {
        public int userID { get; set; }
        public formchangeusername()
        {
            InitializeComponent();
            this.userID = Session.UserID;
        }

        private void btnBackChangeusername_Click(object sender, EventArgs e)
        {
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

        private void formchangeusername_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = FarsiMessageBox.MessageBox.Show("پیام خروج ", "آیا میخواهید از برنامه خارج شوید ؟  ", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Question);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            else
                e.Cancel = true;
        }

     
        private void tbxnewusername_Enter(object sender, EventArgs e)
        {
            if (tbxnewusername.Text == "  نام کاربری جدید ")
            {
                tbxnewusername.Text = "";
                tbxnewusername.ForeColor = Color.Black;

            }
        }

        private void tbxreenterusername_Enter(object sender, EventArgs e)
        {
            if (tbxreenterusername.Text == "  تکرار نام کاربری جدید   ")
            {
                tbxreenterusername.Text = "";
                tbxreenterusername.ForeColor = Color.Black;

            }
        }

        private void tbxnewusername_Leave(object sender, EventArgs e)
        {
            if (tbxnewusername.Text == "")
            {
                tbxnewusername.Text = "  نام کاربری جدید ";
                tbxnewusername.ForeColor = Color.DimGray;

            }
        }

        private void tbxreenterusername_Leave(object sender, EventArgs e)
        {
            if (tbxreenterusername.Text == "")
            {
                tbxreenterusername.Text = "  تکرار نام کاربری جدید   ";
                tbxreenterusername.ForeColor = Color.DimGray;

            }
        }

        private void btnSaveUsername_Click(object sender, EventArgs e)
        {
            int flag = 0;
            if (tbxnewusername.Text == "  نام کاربری جدید ") flag = 1;
            else if (tbxreenterusername.Text == "  تکرار نام کاربری جدید   ") flag = 1;
            if (flag == 0)
            {
                if (tbxnewusername.Text == tbxreenterusername.Text)
                {
                    Database.Instance().Use("UPDATE login SET Username= '" + tbxnewusername.Text + "'WHERE ID = '" + userID + "'");
                    DialogResult re = FarsiMessageBox.MessageBox.Show("پیام", " نام کاربری با موفقیت تغییر یافت.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
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
                    DialogResult re = FarsiMessageBox.MessageBox.Show("خطا", " نام کاربری جدید و تکرار آن یکسان نیستند", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);

                }
            }
            else
            {
                DialogResult re = FarsiMessageBox.MessageBox.Show("خطا ", " لطفا هر دو فیلد را پر نمایید ", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);

            }
        }

    }
}
