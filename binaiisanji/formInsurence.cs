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
    public partial class formAddInsurence : Form
    {
        public formAddInsurence()
        {
            InitializeComponent();
        }

 
        private void tbxInsurensePersent_Enter(object sender, EventArgs e)
        {
            if (tbxInsurensePersent.Text == "  درصد بازپرداخت ")
            {
                tbxInsurensePersent.Text = "";
                tbxInsurensePersent.ForeColor = Color.Black;

            }
        }

      

        private void tbxInsurensePersent_Leave(object sender, EventArgs e)
        {
            if (tbxInsurensePersent.Text == "")
            {
                tbxInsurensePersent.Text = "  درصد بازپرداخت ";
                tbxInsurensePersent.ForeColor = Color.DimGray;

            }
        }

   

     
        private void btnAddInsurence_Click(object sender, EventArgs e)
        {
            int persent = 0;
            int flag = 0;
            if (tbxInsurenceName.Text == "  نام بیمه  ") flag = 1;
            if (tbxInsurensePersent.Text == "  درصد بازپرداخت ") flag = 1;
            if (flag == 0) {
                try
                {  
                persent= Convert.ToInt32(tbxInsurensePersent.Text);
                    if (persent < 100) { 
                        Database.Instance().Use("INSERT INTO insurence (InsName,InsPersent)VAlUES('" + tbxInsurenceName.Text + "','" +tbxInsurensePersent.Text+ "')");
                       DialogResult re = FarsiMessageBox.MessageBox.Show("", "اطلاعات بیمه جدید با موفقیت ذخیره شد.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                        if (re == DialogResult.OK)
                              {
                                     formAddInsurence file = new formAddInsurence();
                                         this.Hide();
                                     file.ShowDialog();

                                }
                    }
                    else
                    {
                        DialogResult re = FarsiMessageBox.MessageBox.Show("خطا", "درصد باز پرداخت باید کمتر از 100 باشد ", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);

                    }
                }
          
            catch (Exception ex)
            {
                DialogResult re = FarsiMessageBox.MessageBox.Show("خطا", "لطفا فیلد ها را به درستی پر کنید", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);

            }
            }
            else
            {
                DialogResult re = FarsiMessageBox.MessageBox.Show("خطا", "لطفا تمامی فیلد ها را  پر کنید", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);

            }



        }

        private void btnBackInsurence_Click(object sender, EventArgs e)
        {
          
            formInssicMenu file = new formInssicMenu();
            this.Hide();
            file.ShowDialog();
        }



        private void tbxInsurenceName_Enter(object sender, EventArgs e)
        {

            if (tbxInsurenceName.Text == "  نام بیمه  ")
            {
                tbxInsurenceName.Text = "";
                tbxInsurenceName.ForeColor = Color.Black;

            }
        }

        private void tbxInsurenceName_Leave(object sender, EventArgs e)
        {
            if (tbxInsurenceName.Text == "")
            {
                tbxInsurenceName.Text = "  نام بیمه  ";
                tbxInsurenceName.ForeColor = Color.DimGray;

            }
        }

        private void formAddInsurence_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult result = FarsiMessageBox.MessageBox.Show("پیام خروج ", "آیا میخواهید از برنامه خارج شوید ؟  ", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Question);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            else
                e.Cancel = true;
        }

        private void formAddInsurence_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicDataSet13.insurence' table. You can move, or remove it, as needed.
            this.insurenceTableAdapter1.Fill(this.clinicDataSet13.insurence);
            // TODO: This line of code loads data into the 'clinicDataSet5.insurence' table. You can move, or remove it, as needed.
            // this.insurenceTableAdapter.Fill(this.clinicDataSet5.insurence);
            this.dgvAddsickness.DefaultCellStyle.Font = new Font("B Roya", 16F, FontStyle.Bold, GraphicsUnit.Pixel); ;

            dgvAddsickness.Columns[2].HeaderText = "درصد بازپردخت ";
            dgvAddsickness.Columns[0].HeaderText = "عنوان";
            dgvAddsickness.Columns[1].HeaderText = "شناسه";


            dgvAddsickness.Columns[2].Width = 60;
            dgvAddsickness.Columns[1].Width = 68;
            dgvAddsickness.Columns[0].Width = 90;

        }

        private void tbxInsurensePersent_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbxInsurenceName_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
