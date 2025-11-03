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
    public partial class FormBackup : Form
    {
        public FormBackup()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog file = new FolderBrowserDialog();
            if(file.ShowDialog() == DialogResult.OK)
            {
                tbxBackUpPath.Text = file.SelectedPath.ToString();
            }

        }

        private void btnSavePassword_Click(object sender, EventArgs e)
        {
            if (tbxBackUpPath.Text != "  محل ذخیره فایل پشتیبان")
            {
             try
            {
                Database.Instance().Use("BACKUP DATABASE clinic TO DISK = '"+tbxBackUpPath.Text+"\\clinicDatabase-"+DateTime.Now.ToString("yyyy-M-d")+".bak'");
                DialogResult re = FarsiMessageBox.MessageBox.Show("پیام", "فایل پشتیبان در محل مورد نظر شما ذخیره گردید", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
            else
            {
                DialogResult re = FarsiMessageBox.MessageBox.Show("خطا", "لطفا محلی که میخواهید فایل پشتیبان درآن ذخیره گردد را انتخاب کنید", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);

            }

        }

        private void btnBackChangePassword_Click(object sender, EventArgs e)
        {

      
            DialogResult result = FarsiMessageBox.MessageBox.Show("سوال ", "آیا میخواهید به صفحه قبل بازگردید ؟  ", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Question);
            if (result == DialogResult.Yes)
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
            if(Session.UserType == UserType.Secretary)
            {
                formEyeCLinicMain file = new formEyeCLinicMain();
                this.Hide();
                file.ShowDialog();
            }
            }
        }

        private void FormBackup_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = FarsiMessageBox.MessageBox.Show("پیام خروج ", "آیا میخواهید از برنامه خارج شوید ؟  ", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Question);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            else
                e.Cancel = true;
        }

        private void tbxBackUpPath_Leave(object sender, EventArgs e)
        {
            if (tbxBackUpPath.Text == "")
            {
                tbxBackUpPath.Text = "  محل ذخیره فایل پشتیبان";
                tbxBackUpPath.ForeColor = Color.DimGray;

            }
        }

        private void tbxBackUpPath_Enter(object sender, EventArgs e)
        {
            if (tbxBackUpPath.Text == "  محل ذخیره فایل پشتیبان")
            {
                tbxBackUpPath.Text = "";
                tbxBackUpPath.ForeColor = Color.Black;

            }
        }
    }
}
