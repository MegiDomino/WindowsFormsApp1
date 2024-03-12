using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddPassenger : Form
    {
        public AddPassenger()
        {
            InitializeComponent();
        }
        
        SqlConnection conn = new SqlConnection(@"Data Source=LEROI\SQLEXPRESS;Initial Catalog=BUS_TICKETING;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");
        
        private void AddPassenger_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand("ADDPASSENGER",conn);
            cmd.CommandType = CommandType.StoredProcedure;
            
            string name = NAME.Text;
            string email = EMAIL.Text;
            string address = ADDRESS.Text;
            string mobile = MOBILE.Text;

         
            cmd.Parameters.Add(new SqlParameter("@NAME", name));
            cmd.Parameters.Add(new SqlParameter("@EMAIL", email));
            cmd.Parameters.Add(new SqlParameter("@ADDRESS", address));
            cmd.Parameters.Add(new SqlParameter("@MOBILE", mobile));

            cmd.ExecuteNonQuery();

            conn.Close();

            ADDPAYMENT AddPay = new ADDPAYMENT();
            AddPay.Show();
        }
    }
}
