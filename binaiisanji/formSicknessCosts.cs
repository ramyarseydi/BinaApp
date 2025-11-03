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
    public partial class formAddSicknessCosts : Form
    {
        public formAddSicknessCosts()
        {
            InitializeComponent();
        }

        private void btnBackSickness_Click(object sender, EventArgs e)
        {
            formInssicMenu file = new formInssicMenu();
            this.Hide();
            file.ShowDialog();
        }

   

    
        private void tbxSicknessPersent_Enter(object sender, EventArgs e)
        {
            if (tbxSicknessPersent.Text == "  تعرفه درمانی ")
            {
                tbxSicknessPersent.Text = "";
                tbxSicknessPersent.ForeColor = Color.Black;

            }
        }

       

        private void tbxSicknessPersent_Leave(object sender, EventArgs e)
        {
            if (tbxSicknessPersent.Text == "")
            {
                tbxSicknessPersent.Text = "  تعرفه درمانی ";
                tbxSicknessPersent.ForeColor = Color.DimGray;

            }
        }

    
      

        private void btnAddSickness_Click(object sender, EventArgs e)
        {

            int flag = 0;
            if (tbxSicknessPersent.Text == "  تعرفه درمانی ") flag = 1;
            if (tbxSicknessName.Text == "  نام بیماری  ") flag = 1;
            if (flag == 0)
            {
               try
            {
               Database.Instance().Use("INSERT INTO SicknessCosts (S.SicknessName,S.SicknessCosts)VAlUES('"+tbxSicknessName.Text+"','"+tbxSicknessPersent.Text+"')");
                DialogResult re = FarsiMessageBox.MessageBox.Show("", "تعرفه درمانی با موفقیت ذخیره شد.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                if (re == DialogResult.OK)
                   {
                formAddSicknessCosts file = new formAddSicknessCosts();
                this.Hide();
                file.ShowDialog();

                 }
            }
            catch(Exception ex)
            {
                    DialogResult re = FarsiMessageBox.MessageBox.Show("خطا", "دستور شما به درستی انجام نشد.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);
             }

            }
            else
            {
                DialogResult re = FarsiMessageBox.MessageBox.Show("خطا", "لطفا تمامی فیلد ها را پر کنید.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);
            }
        }
         
       
        

        private void tbxSicknessName_Enter(object sender, EventArgs e)
        {
            if (tbxSicknessName.Text == "  نام بیماری  ")
            {
                tbxSicknessName.Text = "";
                tbxSicknessName.ForeColor = Color.Black;

            }
        }

        private void tbxSicknessName_Leave(object sender, EventArgs e)
        {
            if (tbxSicknessName.Text == "")
            {
                tbxSicknessName.Text = "  نام بیماری  ";
                tbxSicknessName.ForeColor = Color.DimGray;

            }
        }

        private void formAddSicknessCosts_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult result = FarsiMessageBox.MessageBox.Show("پیام خروج ", "آیا میخواهید از برنامه خارج شوید ؟  ", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Question);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            else
                e.Cancel = true;
        }

        private void tbxSicknessPersent_TextChanged(object sender, EventArgs e)
        {
            if (tbxSicknessPersent.Text != string.Empty)
            {
                try
                {
                    tbxSicknessPersent.Text = Int64.Parse(tbxSicknessPersent.Text.Replace(",", "")).ToString("#,0");
                }
                catch (Exception ex)
                {

                }

                tbxSicknessPersent.Select(tbxSicknessPersent.TextLength, 0);
            }
        }

        private void tbxSicknessPersent_KeyPress(object sender, KeyPressEventArgs e)
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

        private void formAddSicknessCosts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicDataSet14.SicknessCosts' table. You can move, or remove it, as needed.
            this.sicknessCostsTableAdapter1.Fill(this.clinicDataSet14.SicknessCosts);
            // TODO: This line of code loads data into the 'clinicDataSet4.SicknessCosts' table. You can move, or remove it, as needed.
            //  this.sicknessCostsTableAdapter.Fill(this.clinicDataSet4.SicknessCosts);
            this.dgvSicknessAdd.DefaultCellStyle.Font = new Font("B Roya", 16F, FontStyle.Bold, GraphicsUnit.Pixel); ;

            dgvSicknessAdd.Columns[2].HeaderText = "هزینه بیماری ";
            dgvSicknessAdd.Columns[1].HeaderText = "عنوان";
            dgvSicknessAdd.Columns[0].HeaderText = "شناسه";


            dgvSicknessAdd.Columns[2].Width = 100;
            dgvSicknessAdd.Columns[1].Width = 90;
            dgvSicknessAdd.Columns[0].Width = 40;
        }
    }
}
