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
    public partial class formRecpetMenu : Form
    {
        public formRecpetMenu()
        {
            InitializeComponent();
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            var mainres = new formEyeCLinicMain();
            this.Hide();
            mainres.ShowDialog();
        }

        private void btnFIleGenerting_Click(object sender, EventArgs e)
        {
            formFileOpening1 file = new formFileOpening1();
            this.Hide();
            file.ShowDialog();
        }

        private void btnResiveCosts_Click(object sender, EventArgs e)
        {
            formPatientcosts file = new formPatientcosts();
            this.Hide();
            file.ShowDialog();
        }

        private void formRecpetMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = FarsiMessageBox.MessageBox.Show("پیام خروج ", "آیا میخواهید از برنامه خارج شوید ؟  ", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Question);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            else
                e.Cancel = true;
        }

        private void btnTurnRateing_Click(object sender, EventArgs e)
        {
            formTurnRating file = new formTurnRating();
            this.Hide();
            file.ShowDialog();
        }

        private void btnEditpatient_Click(object sender, EventArgs e)
        {
            formEditPatient file = new formEditPatient();
            this.Hide();
            file.ShowDialog();
        }

        private void btnReception_Click(object sender, EventArgs e)
        {
            formResp file = new formResp();
            this.Hide();
            file.ShowDialog();
        }
    }
}
