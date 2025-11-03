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
    public partial class Form_Medic : Form
    {
        public Form_Medic()
        {
            InitializeComponent();
        }

        private void lblMenu2_Click(object sender, EventArgs e)
        {

        }

        private void btnExitMedic_Click(object sender, EventArgs e)
        {
            DialogResult result = FarsiMessageBox.MessageBox.Show("پیام خروج ", "آیا میخواهید از برنامه خارج شوید ؟  ", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Question);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
        }

        private void Form_Medic_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = FarsiMessageBox.MessageBox.Show("پیام خروج ", "آیا میخواهید از برنامه خارج شوید ؟  ", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Question);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            else
                e.Cancel = true;
        }

        private void btnShowincomeMedic_Click(object sender, EventArgs e)
        {
            formshowIncome file = new formshowIncome();
            this.Hide();
            file.ShowDialog();
        }

        private void btnAddReceptionAccessMedic_Click(object sender, EventArgs e)
        {
            formaddrespaccess file = new formaddrespaccess();
            this.Hide();
            file.ShowDialog();
        }

        private void btnSettingMedic_Click(object sender, EventArgs e)
        {
            formSetting file = new formSetting();
            this.Hide();
            file.ShowDialog();
        }

        private void btnChangeUserMedic_Click(object sender, EventArgs e)
        {
            formLogin file = new formLogin();
            this.Hide();
            file.ShowDialog();
        }
    }
}
