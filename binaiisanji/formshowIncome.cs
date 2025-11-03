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
    public partial class formshowIncome : Form
    {
        public formshowIncome()
        {
            InitializeComponent();
        }

        private void formshowIncome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clinicDataSet16.payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter1.Fill(this.clinicDataSet16.payment);
            // TODO: This line of code loads data into the 'clinicDataSet11.payment' table. You can move, or remove it, as needed.
            //this.paymentTableAdapter.Fill(this.clinicDataSet11.payment);


        }

        private void btnShowIncome_Click(object sender, EventArgs e) 
        { 
            string FDate = dtpStart.Text;
            string LDate = dtpEnd.Text;
            var res = Database.Instance().ExecuteQuery("SELECT * FROM Payment WHERE PayDate >= '" + FDate+ "' AND PayDate <= '" + LDate+"' ");
            
            dvgShowIncomeMedic.DataSource = res; 
            DataTable data = res;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBackShowIncom_Click(object sender, EventArgs e)
        {

            if (Session.UserType == UserType.Doctor)
            {
                Form_Medic file = new Form_Medic();
                this.Hide();
                file.ShowDialog();
            }
            if (Session.UserType == UserType.Secretary)
            {
                formEyeCLinicMain file = new formEyeCLinicMain();
                this.Hide();
                file.ShowDialog();
            }
        }
    }
}
