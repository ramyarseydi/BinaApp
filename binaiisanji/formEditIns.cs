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
    public partial class formEditIns : Form
    {
        public formEditIns()
        {
            InitializeComponent();

        }

        private void tbxDeleteInsId_Leave(object sender, EventArgs e)
        {
            if (tbxDeleteInsId.Text == "")
            {
                tbxDeleteInsId.Text = "  شناسه بیمه  ";
                tbxDeleteInsId.ForeColor = Color.DimGray;

            }
        }

        private void tbxDeleteInsName_Leave(object sender, EventArgs e)
        {
            if (tbxDeleteInsName.Text == "")
            {
                tbxDeleteInsName.Text = "  نام بیمه  ";
                tbxDeleteInsName.ForeColor = Color.DimGray;

            }
        }

        private void tbxDeleteInsId_Enter(object sender, EventArgs e)
        {
            if (tbxDeleteInsId.Text == "  شناسه بیمه  ")
            {
                tbxDeleteInsId.Text = "";
                tbxDeleteInsId.ForeColor = Color.Black;

            }
        }

        private void tbxDeleteInsName_Enter(object sender, EventArgs e)
        {
            if (tbxDeleteInsName.Text == "  نام بیمه  ")
            {
                tbxDeleteInsName.Text = "";
                tbxDeleteInsName.ForeColor = Color.Black;

            }
        }

        private void formEditIns_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicDataSet12.insurence' table. You can move, or remove it, as needed.
            this.insurenceTableAdapter1.Fill(this.clinicDataSet12.insurence);
            // TODO: This line of code loads data into the 'clinicDataSet.insurence' table. You can move, or remove it, as needed.
            //this.insurenceTableAdapter.Fill(this.clinicDataSet.insurence);
        

            this.dataGridView1.DefaultCellStyle.Font = new Font("B Roya",16F,FontStyle.Bold,GraphicsUnit.Pixel); ;

            dataGridView1.Columns[2].HeaderText = "درصد بازپرداخت";
            dataGridView1.Columns[1].HeaderText = "عنوان";
            dataGridView1.Columns[0].HeaderText = "شناسه";


            dataGridView1.Columns[2].Width = 72;
            dataGridView1.Columns[1].Width = 90;
            dataGridView1.Columns[0].Width = 40;
            
        }

        private void formEditIns_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult result = FarsiMessageBox.MessageBox.Show("پیام خروج ", "آیا میخواهید از برنامه خارج شوید ؟  ", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Question);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            else
                e.Cancel = true;
        }

        private void btnEditINS_Click(object sender, EventArgs e)
        {
                  int ID = 0;
               int persent = 0;
            try {   
                     ID = Convert.ToInt32(tbxDeleteInsId.Text);
                    persent = Convert.ToInt32(tbxeditInsPersent.Text);
                if (persent < 100)
                {
                    Database.Instance().Use("UPDATE Insurence SET InsName='" + tbxDeleteInsName.Text + "',InsPersent='" + persent + "' WHERE InsID = '" + ID + "'");
                    DialogResult re = FarsiMessageBox.MessageBox.Show(" ", " اطلاعات مورد نظر ویرایش گردید", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                    formEditIns file = new formEditIns();
                    this.Hide();
                    file.ShowDialog();
                }
                else
                {
                    DialogResult re = FarsiMessageBox.MessageBox.Show("خطا", " درصد بازپرداخت توسط بیمه باید کمتر از 100 باشد", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);

                }
            }
            catch (Exception ex)
            {
                DialogResult req = FarsiMessageBox.MessageBox.Show("خطا", "لطفا مقدار مناسب را وارد نمایید", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);

            }

           

        }

        private void btnDeleteInsurence_Click(object sender, EventArgs e)
        {
            int ID = 0;
            try
            {
                ID = Convert.ToInt32(tbxDeleteInsId.Text);
                Database.Instance().Use("DELETE FROM Insurence WHERE InsID ='" + ID + "';");
                DialogResult result = FarsiMessageBox.MessageBox.Show("حذف بیمه ", "آیا میخواهید این بیمه را حذف کنید ؟ ", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Question);
                if (result == DialogResult.Yes)
                {
                    formEditIns file = new formEditIns();
                    this.Hide();
                    file.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                DialogResult req = FarsiMessageBox.MessageBox.Show("خطا", "لطفا مقدار مناسب را وارد نمایید", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);

            }
          

        }

        private void tbxeditInsPersent_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbxDeleteInsId_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dataGridView1.Rows[e.RowIndex];
                tbxDeleteInsId.Text = dgvRow.Cells[0].Value.ToString();
                tbxDeleteInsName.Text = dgvRow.Cells[1].Value.ToString();
                tbxeditInsPersent.Text = dgvRow.Cells[2].Value.ToString();
            }
        }

        private void tbxeditInsPersent_Enter(object sender, EventArgs e)
        {
            if (tbxDeleteInsName.Text == "  درصد بازپرداخت")
            {
                tbxDeleteInsName.Text = "";
                tbxDeleteInsName.ForeColor = Color.Black;

            }
        }

        private void tbxeditInsPersent_Leave(object sender, EventArgs e)
        {
            if (tbxDeleteInsName.Text == "")
            {
                tbxDeleteInsName.Text = "  درصد بازپرداخت";
                tbxDeleteInsName.ForeColor = Color.DimGray;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formInssicMenu file = new formInssicMenu();
            this.Hide();
            file.ShowDialog();
        }
    }
}
