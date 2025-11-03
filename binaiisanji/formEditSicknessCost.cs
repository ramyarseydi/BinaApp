using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace binaiisanji
{
    public partial class formEditSicknessCost : Form
    {
        public formEditSicknessCost()
        {
            InitializeComponent();
        }

        private void tbxDeleteSicknessId_Enter(object sender, EventArgs e)
        {
            if (tbxDeleteSicknessId.Text == "  شناسه بیماری  ")
            {
                tbxDeleteSicknessId.Text = "";
                tbxDeleteSicknessId.ForeColor = Color.Black;

            }
        }

        private void tbxDeleteSicknessId_Leave(object sender, EventArgs e)
        {
            if (tbxDeleteSicknessId.Text == "")
            {
                tbxDeleteSicknessId.Text = "  شناسه بیماری  ";
                tbxDeleteSicknessId.ForeColor = Color.DimGray;

            }
        }

        private void tbxDeleteISicknessName_Leave(object sender, EventArgs e)
        {
            if (tbxISicknessName.Text == "")
            {
                tbxISicknessName.Text = "  نام بیماری  ";
                tbxISicknessName.ForeColor = Color.DimGray;

            }
        }

        private void tbxDeleteISicknessName_Enter(object sender, EventArgs e)
        {
            if (tbxISicknessName.Text == "  نام بیماری  ")
            {
                tbxISicknessName.Text = "";
                tbxISicknessName.ForeColor = Color.Black;

            }
        }

        private void formEditSicknessCost_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult result = FarsiMessageBox.MessageBox.Show("پیام خروج ", "آیا میخواهید از برنامه خارج شوید ؟  ", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Question);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            else
                e.Cancel = true;
        }

        private void formEditSicknessCost_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicDataSet15.SicknessCosts' table. You can move, or remove it, as needed.
            this.sicknessCostsTableAdapter2.Fill(this.clinicDataSet15.SicknessCosts);
            // TODO: This line of code loads data into the 'clinicDataSet3.SicknessCosts' table. You can move, or remove it, as needed.
            // this.sicknessCostsTableAdapter1.Fill(this.clinicDataSet3.SicknessCosts);
            this.dgvSickness.DefaultCellStyle.Font = new Font("B Roya", 16F, FontStyle.Bold, GraphicsUnit.Pixel); ;

            dgvSickness.Columns[2].HeaderText = " تعرفه درمانی ";
            dgvSickness.Columns[1].HeaderText = "عنوان";
            dgvSickness.Columns[0].HeaderText = "شناسه";


            dgvSickness.Columns[2].Width = 100;
            dgvSickness.Columns[1].Width = 90;
            dgvSickness.Columns[0].Width = 40;

        }

        private void dgvSickness_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tbxCostEdit_Click(object sender, EventArgs e)
        {

        }

        private void tbxCostEdit_Leave(object sender, EventArgs e)
        {
            if (tbxCostEdit.Text == "")
            {
                tbxCostEdit.Text = "  تعرفه درمانی ";
                tbxCostEdit.ForeColor = Color.DimGray;

            }
        }
        
        private void tbxCostEdit_Enter(object sender, EventArgs e)
        {
            if (tbxCostEdit.Text == "  تعرفه درمانی ")
            {
                tbxCostEdit.Text = "";
                tbxCostEdit.ForeColor = Color.Black;

            }
        }

        private void tbxCostEdit_TextChanged(object sender, EventArgs e)
        {   
            if (tbxCostEdit.Text != string.Empty)
            {
                try
                {
          
                    tbxCostEdit.Text = Int64.Parse(tbxCostEdit.Text.Replace(",", "")).ToString("#,0");
                }
                catch (Exception ex)
                {
                  //  DialogResult result = FarsiMessageBox.MessageBox.Show("خطا ", "خطایی در انجام این دستور رخ داد   ", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);

                }

                tbxCostEdit.Select(tbxCostEdit.TextLength, 0);
            }
           
        }

        private void btnDeleteSickness_Click(object sender, EventArgs e)
        {
            int ID = 0;
            try
            {
                ID = Convert.ToInt32(tbxDeleteSicknessId.Text);
                       DialogResult result = FarsiMessageBox.MessageBox.Show("حذف تعرفه ", "آیا میخواهید این تعرفه را حذف کنید ؟ ", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Question);
                if (result == DialogResult.Yes)
                {
                    Database.Instance().Use("DELETE FROM SicknessCosts WHERE SicknessID ='" + tbxDeleteSicknessId.Text + "';");
                    formEditSicknessCost file = new formEditSicknessCost();
                    this.Hide();
                    file.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                DialogResult result = FarsiMessageBox.MessageBox.Show("خطا ", "لطفا فیلد مربوط به شناسه را پر نماید  ", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);

            }
        }

        private void tbxCostEdit_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbxDeleteSicknessId_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnBackEditSic_Click(object sender, EventArgs e)
        {
            formInssicMenu file = new formInssicMenu();
            this.Hide();
            file.ShowDialog();
        }

        private void btnSicknessEdit_Click(object sender, EventArgs e)
        {   
            int flag= 0;
            if (tbxCostEdit.Text == "  تعرفه درمانی ") flag = 1;
            if (tbxISicknessName.Text == "  نام بیماری  ") flag = 1;

            if(flag == 0)
            {
                try 
                {
           
                Convert.ToInt32(tbxDeleteSicknessId.Text);
            Database.Instance().Use("UPDATE SicknessCosts SET SicknessName='"+tbxISicknessName.Text+"',SicknessCosts='"+tbxCostEdit.Text+"' WHERE SicknessID = '"+tbxDeleteSicknessId.Text+"'");
            DialogResult re = FarsiMessageBox.MessageBox.Show(" ", " اطلاعات مورد نظر ویرایش گردید", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
            formEditSicknessCost file = new formEditSicknessCost();
            this.Hide();
            file.ShowDialog();
                 }
            catch (Exception ex)
            {
                DialogResult result = FarsiMessageBox.MessageBox.Show("خطا ", "لطفا فیلد مربوط به شناسه را پر نماید  ", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);

            } 
            }
            else
            {
                DialogResult result = FarsiMessageBox.MessageBox.Show("خطا ", "لطفا تمامی فیلد ها را پر نمایید   ", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);

            }



        }

        private void dgvSickness_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            }

        private void dgvSickness_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRow = dgvSickness.Rows[e.RowIndex];
                tbxDeleteSicknessId.Text = dgvRow.Cells[0].Value.ToString();
                tbxISicknessName.Text = dgvRow.Cells[1].Value.ToString();
                tbxCostEdit.Text = dgvRow.Cells[2].Value.ToString();
            }
    }
    }
}
