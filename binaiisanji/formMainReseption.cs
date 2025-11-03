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
    public partial class formEyeCLinicMain : Form
    {
        public formEyeCLinicMain()
        {
            InitializeComponent();
        
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = FarsiMessageBox.MessageBox.Show("پیام خروج ", "میخواهید خارج شوید؟", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Question);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            else
                e.Cancel = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var backup = new FormBackup();
            this.Hide();
            backup.ShowDialog();
        }

        private void btnReception_Click(object sender, EventArgs e)
        {
            var recpmenu = new formRecpetMenu();
            this.Hide();
            recpmenu.ShowDialog();
        }

        private void btnShowincomeRes_Click(object sender, EventArgs e)
        {
            var showincome = new formshowIncome();
            this.Hide();
            showincome.ShowDialog();
        }

        private void formEyeCLinicMain_Load(object sender, EventArgs e)
        {

        }

        private void btnReminder_Click(object sender, EventArgs e)
        {
            var remaind = new formReminder();
            this.Hide();
            remaind.ShowDialog();
        }

        private void btnSettingRes_Click(object sender, EventArgs e)
        {
            var setting = new formSetting();
            this.Hide();
            setting.ShowDialog();
        }

        private void btnChangeUserRes_Click(object sender, EventArgs e)
        {
            var log = new formLogin();
            this.Hide();
            log.ShowDialog();
        }

        private void btnExitRec_Click(object sender, EventArgs e)
        {
            DialogResult result = FarsiMessageBox.MessageBox.Show("پیام خروج ", "آیا میخواهید از برنامه خارج شوید ؟  ", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Question);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
        }

        private void btnInsurence_Click(object sender, EventArgs e)
        {
            formInssicMenu file = new formInssicMenu();
            this.Hide();
            file.ShowDialog();
        }
    }
}
