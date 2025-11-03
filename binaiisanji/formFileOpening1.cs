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
    public partial class formFileOpening1 : Form
    {
        public formFileOpening1()
        {
            InitializeComponent();
            refreshdata();
        }

        private void btnBackFileGen_Click(object sender, EventArgs e)
        {
            int flag = 0;
            string gender = "";
            if (rdbPatientGenderM.Checked) gender = "مرد";
            if (rdbPatientGenderF.Checked) gender = "زن";

            if (cmbInsourence.SelectedValue.ToString() == "0") flag = 1;

            else if (tbxPatientFname.Text != "  نام  ") flag = 1;
            else if (tbxPatientLname.Text != "  نام خانوادگی   ") flag = 1;
            else if (tbxPatientAge.Text != "  سن") flag = 1;
            else if (tbxPatientPhoneNumber.Text != "  شماره تماس") flag = 1;
            else if (tbxPatientSickness.Text != "  شرح بیماری    ") flag = 1;
            else if (tbxPatientAddress.Text != "  آدرس     ") flag = 1;
            else if (gender != "") flag = 1;
            if (flag == 1)
            {
                DialogResult dr = FarsiMessageBox.MessageBox.Show("هشدار", " آیا میخواهید به صفحه منو بازگردید ؟ ", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Question);
                if (dr == DialogResult.Yes)
                {
                    var recmenu = new formRecpetMenu();
                    this.Hide();
                    recmenu.ShowDialog();
                }
            }
            else
            {
                var recmenu = new formRecpetMenu();
                this.Hide();
                recmenu.ShowDialog();
            }

        }

        private void formFileOpening1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = FarsiMessageBox.MessageBox.Show("پیام خروج ", "آیا میخواهید از برنامه خارج شوید ؟  ", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Question);
            if (result == DialogResult.Yes)
            {
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
            else
                e.Cancel = true;
        }

        private void tbxPatientFname_Enter(object sender, EventArgs e)
        {
            if (tbxPatientFname.Text == "  نام  ")
            {
                tbxPatientFname.Text = "";
                tbxPatientFname.ForeColor = Color.Black;

            }
        }

        private void tbxPatientLname_Enter(object sender, EventArgs e)
        {
            if (tbxPatientLname.Text == "  نام خانوادگی   ")
            {
                tbxPatientLname.Text = "";
                tbxPatientLname.ForeColor = Color.Black;

            }
        }

        private void tbxPatientAge_Enter(object sender, EventArgs e)
        {
            if (tbxPatientAge.Text == "  سن")
            {
                tbxPatientAge.Text = "";
                tbxPatientAge.ForeColor = Color.Black;

            }
        }

        private void tbxPatientPhoneNumber_Enter(object sender, EventArgs e)
        {
            if (tbxPatientPhoneNumber.Text == "  شماره تماس")
            {
                tbxPatientPhoneNumber.Text = "";
                tbxPatientPhoneNumber.ForeColor = Color.Black;

            }
        }

        private void tbxPatientAddress_Enter(object sender, EventArgs e)
        {
            if (tbxPatientAddress.Text == "  آدرس     ")
            {
                tbxPatientAddress.Text = "";
                tbxPatientAddress.ForeColor = Color.Black;

            }
        }

        private void tbxPatientFname_Leave(object sender, EventArgs e)
        {
            if (tbxPatientFname.Text == "")
            {
                tbxPatientFname.Text = "  نام  ";
                tbxPatientFname.ForeColor = Color.DimGray;

            }
        }

        private void tbxPatientLname_Leave(object sender, EventArgs e)
        {
            if (tbxPatientLname.Text == "")
            {
                tbxPatientLname.Text = "  نام خانوادگی   ";
                tbxPatientLname.ForeColor = Color.DimGray;

            }
        }

        private void tbxPatientAge_Leave(object sender, EventArgs e)
        {
            if (tbxPatientAge.Text == "")
            {
                tbxPatientAge.Text = "  سن";
                tbxPatientAge.ForeColor = Color.DimGray;

            }
        }

        private void tbxPatientPhoneNumber_Leave(object sender, EventArgs e)
        {
            if (tbxPatientPhoneNumber.Text == "")
            {
                tbxPatientPhoneNumber.Text = "  شماره تماس";
                tbxPatientPhoneNumber.ForeColor = Color.DimGray;

            }
        }

        private void tbxPatientAddress_Leave(object sender, EventArgs e)
        {
            if (tbxPatientAddress.Text == "")
            {
                tbxPatientAddress.Text = "  آدرس     ";
                tbxPatientAddress.ForeColor = Color.DimGray;

            }
        }
        public void refreshdata()
        {
            var res = Database.Instance().ExecuteQuery("select * from insurence");
            DataRow dr = res.NewRow();
            dr.ItemArray = new object[] {0 ," --نوع بیمه--" };
            res.Rows.InsertAt(dr, 0);
            cmbInsourence.ValueMember = "InsID";
            cmbInsourence.DisplayMember = "InsName";
            cmbInsourence.DataSource = res;

        }
        private void btnSaveFIleGen_Click(object sender, EventArgs e)
        {
            int flag = 0;
            string gender = "";
            if (rdbPatientGenderM.Checked) gender = "مرد";
            if (rdbPatientGenderF.Checked) gender = "زن";

            if (cmbInsourence.SelectedValue.ToString() == "0") flag = 1;

            else if (tbxPatientFname.Text == "  نام  ") flag = 1;
            else if (tbxPatientLname.Text == "  نام خانوادگی   ") flag = 1;
            else if (tbxPatientAge.Text == "  سن") flag = 1;
            else if (tbxPatientPhoneNumber.Text == "  شماره تماس") flag = 1;
            else if (tbxPatientSickness.Text == "  شرح بیماری    ") flag = 1;
            else if (tbxPatientAddress.Text == "  آدرس     ") flag = 1;
            else if (gender == "") flag = 1;


            if (flag == 0) {
                try
                {

                    var res = Database.Instance().ExecuteQuery("SELECT * FROM Patient WHERE Fname = '" + tbxPatientFname.Text + "'AND Lname = '" + tbxPatientLname.Text + "'");
                    if (res.Rows.Count == 0)
                    {
                     
                        if (cmbInsourence.SelectedValue.ToString() != "0")
                        {
                             int InsID = Convert.ToInt32(cmbInsourence.SelectedValue.ToString());
                            int age = Convert.ToInt32(tbxPatientAge.Text);
                           
                                Database.Instance().Use("INSERT INTO Patient(Fname,Lname,Age,Phone_Number,Gender,Address,Explain,InsurenceID,F_date,L_date)VALUES('" + tbxPatientFname.Text + "','" + tbxPatientLname.Text + "','" + age + "','" + tbxPatientPhoneNumber.Text + "','" + gender + "','" + tbxPatientAddress.Text + "','" + tbxPatientSickness.Text + "','" + InsID + "','" + dtpFappointment.Text + "','" + dtpNextAppointment.Text + "')");
                           FarsiMessageBox.MessageBox.Show("", "اطلاعات بیمار جدید با موفقیت ذخیره شد.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
 
                          

                        }
                        else
                        {
                            FarsiMessageBox.MessageBox.Show("خطا", "لطفا نوع بیمه را وارد کنید ", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);

                        }
                        

                    }
                    else
                    {
                         DialogResult r =  FarsiMessageBox.MessageBox.Show("هشدار", "بیمار دیگری با همین نام وجود دارد آیا میخواهید ادامه دهید ؟ ", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Question);
                        if(r == DialogResult.Yes)
                        {
                            if (cmbInsourence.SelectedValue.ToString() != "0")
                            {
                                int InsID = Convert.ToInt32(cmbInsourence.SelectedValue.ToString());
                                int age = Convert.ToInt32(tbxPatientAge.Text);
                               
                                    Database.Instance().Use("INSERT INTO Patient(Fname,Lname,Age,Phone_Number,Gender,Address,Explain,InsurenceID,F_date,L_date)VALUES('" + tbxPatientFname.Text + "','" + tbxPatientLname.Text + "','" + age + "','" + tbxPatientPhoneNumber.Text + "','" + gender + "','" + tbxPatientAddress.Text + "','" + tbxPatientSickness.Text + "','" + InsID + "','" + dtpFappointment.Text + "','" + dtpNextAppointment.Text + "')");
                                    FarsiMessageBox.MessageBox.Show("", "اطلاعات بیمار جدید با موفقیت ذخیره شد.", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                             
                            }
                            else
                            {
                                FarsiMessageBox.MessageBox.Show("خطا", "لطفا نوع بیمه را وارد کنید ", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    FarsiMessageBox.MessageBox.Show("خطا", "لطفا اطلاعات را به درستی وارد نمایید  ", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);

                }

            }
            else
            {
                FarsiMessageBox.MessageBox.Show("خطا", "لطفا تمامی فیلد ها را پر کنید  ", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Error);

            }
        }
       

   

        private void tbxPatientSickness_Leave(object sender, EventArgs e)
        {
            if (tbxPatientSickness.Text == "")
            {
                tbxPatientSickness.Text = "  شرح بیماری    ";
                tbxPatientSickness.ForeColor = Color.DimGray;

            }
        }

        private void tbxPatientSickness_Enter(object sender, EventArgs e)
        {
            if (tbxPatientSickness.Text == "  شرح بیماری    ")
            {
                tbxPatientSickness.Text = "";
                tbxPatientSickness.ForeColor = Color.Black;

            }
        }

      

        private void mtbxFirstAppointment_Enter(object sender, EventArgs e)
        {

        }

        private void mtbxFirstAppointment_Leave(object sender, EventArgs e)
        {

        }

        private void mtbxNextAppointment_Leave(object sender, EventArgs e)
        {

        }

        private void mtbxNextAppointment_Enter(object sender, EventArgs e)
        {

        }

        private void cmbInsourence_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void tbxPatientAge_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tbxPatientPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}

