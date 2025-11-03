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
    public partial class formMainAdmin : Form
    {
        public formMainAdmin()
        {
            InitializeComponent();
        }

        private void btnExitAdmin_Click(object sender, EventArgs e)
        {
            DialogResult result = FarsiMessageBox.MessageBox.Show("پیام خروج ", "آیا میخواهید از برنامه خارج شوید ؟  ", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Question);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
        }

        private void formMainAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = FarsiMessageBox.MessageBox.Show("پیام خروج ", "آیا میخواهید از برنامه خارج شوید ؟  ", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Question);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            else
                e.Cancel = true;
        }

        private void btnAddReceptionAccessAdmin_Click(object sender, EventArgs e)
        {
            var file = new formaddrespaccess();
            this.Hide();
            file.ShowDialog();
        }

        private void btnAddMedicAccess_Click(object sender, EventArgs e)
        {
            var file = new formaddMedicAccess();
            this.Hide();
            file.ShowDialog();
        }

        private void btnRecoveryAdmin_Click(object sender, EventArgs e)
        {
            formRecovery file = new formRecovery();
            this.Hide();
            file.ShowDialog();

        }

        private void btnrebackupAdmin_Click(object sender, EventArgs e)
        {
            var file = new FormBackup();
            this.Hide();
            file.ShowDialog();
        }

        private void btnSettingAdmin_Click(object sender, EventArgs e)
        {
            var file = new formSetting();
            this.Hide();
            file.ShowDialog();
        }

        private void btnChangeUserAdmin_Click(object sender, EventArgs e)
        {
            var file = new formLogin();
            this.Hide();
            file.ShowDialog();
        }
    }
}
