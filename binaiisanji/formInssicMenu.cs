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
    public partial class formInssicMenu : Form
    {
        public formInssicMenu()
        {
            InitializeComponent();
        }

        private void btnAddInsurence_Click(object sender, EventArgs e)
        {
            formAddInsurence file = new formAddInsurence();
            this.Hide();
            file.ShowDialog();
        }

        private void btnEditInsurence_Click(object sender, EventArgs e)
        {
            formEditIns file = new formEditIns();
            this.Hide();
            file.ShowDialog();
        }

        private void btnAddSicknessCosts_Click(object sender, EventArgs e)
        {
            formAddSicknessCosts file = new formAddSicknessCosts();
            this.Hide();
            file.ShowDialog();
        }

        private void btnEditSicknessCosts_Click(object sender, EventArgs e)
        {
            formEditSicknessCost file = new formEditSicknessCost();
            this.Hide();
            file.ShowDialog();
        }

        private void btnBackInsMenu_Click(object sender, EventArgs e)
        {
            formEyeCLinicMain file = new formEyeCLinicMain();
            this.Hide();
            file.Show();
        }

        private void formInssicMenu_FormClosing(object sender, FormClosingEventArgs e)
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
