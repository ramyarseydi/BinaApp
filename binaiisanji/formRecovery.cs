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
    public partial class formRecovery : Form
    {
        public formRecovery()
        {
            InitializeComponent();
          
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter ="Backup Files(*.bak)|*.bak|All files(*.*)|*.*";
            dlg.FilterIndex = 0;
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                tbxRestorePath.Text = dlg.FileName;
            }
           
        }

        private void btnSaveRestore_Click(object sender, EventArgs e)
        {
            if( tbxRestorePath.Text != "  محل ذخیره فایل پشتیبان  ")
            {
                String sql = "";
            try
            {
                sql = "Alter Database clinic Set SINGLE_USER WITH ROLL BACK IMMEDIATE; ";
                sql += "Restore Database clinic FROM Disk = '"+tbxRestorePath.Text+"' WITH REPLACE ;";
                DialogResult re = FarsiMessageBox.MessageBox.Show(" ", " بازیابی اطلاعات با موفقیت انجام گردید", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
                else
                {
                DialogResult re = FarsiMessageBox.MessageBox.Show(" خطا", " لطفا محل فایل را مشخص نماید ", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);

            }

        }

        private void btnBackRestore_Click(object sender, EventArgs e)
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

        private void tbxRestorePath_Leave(object sender, EventArgs e)
        {
            if (tbxRestorePath.Text == "")
            {
                tbxRestorePath.Text = "  محل ذخیره فایل پشتیبان  ";
                tbxRestorePath.ForeColor = Color.DimGray;

            }
        }

        private void tbxRestorePath_Enter(object sender, EventArgs e)
        {
            if (tbxRestorePath.Text == "  محل ذخیره فایل پشتیبان  ")
            {
                tbxRestorePath.Text = "";
                tbxRestorePath.ForeColor = Color.Black;

            }
        }

        private void formRecovery_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = FarsiMessageBox.MessageBox.Show("پیام خروج ", "آیا میخواهید از برنامه خارج شوید ؟  ", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Question);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            else
                e.Cancel = true;
        }
    }
}
