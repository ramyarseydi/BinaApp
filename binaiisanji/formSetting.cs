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
    public partial class formSetting : Form
    {
        public formSetting()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnBackSetting_Click(object sender, EventArgs e)
        {
            var mainres = new formEyeCLinicMain();
            this.Hide();
            mainres.ShowDialog();
        }

        private void formSetting_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void formSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = FarsiMessageBox.MessageBox.Show("پیام خروج ", "آیا میخواهید از برنامه خارج شوید ؟  ", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Question);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            else
                e.Cancel = true;
        }

        private void btnChangeUsername_Click(object sender, EventArgs e)
        {
            var file = new formchangeusername();
            this.Hide();
            file.ShowDialog();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            var file = new formchanegpassword();
            this.Hide();
            file.ShowDialog();
        }
    }
}
