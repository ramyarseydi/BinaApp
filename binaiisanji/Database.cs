using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace binaiisanji
{

    public class Database
    {
        public SqlConnection Connection { get; set; }
        public DataTable Result { get; set; }

        private static Database instance = null;
        public static Database Instance()
        {
            return instance ?? (instance = new Database());
        }

        public Database()
        {
            Connection = new SqlConnection("Data Source=DESKTOP-EF09N5I\\RSQL2021;Initial Catalog=clinic;Integrated Security=True");
            Connection.Open();
        }

       
        public void Use(string sql)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, Connection);
                cmd.ExecuteNonQuery();
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ورودی را میگیرد و اجرا میکند
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        /// 
       
        public DataTable ExecuteQuery(string sql)
        {
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(sql, Connection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Result = dt;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            return Result;
        }

    }
}
