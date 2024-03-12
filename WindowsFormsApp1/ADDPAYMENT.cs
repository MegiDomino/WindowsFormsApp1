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
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class ADDPAYMENT : Form
    {
        public ADDPAYMENT()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LEROI\SQLEXPRESS;Initial Catalog=BUS_TICKETING;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");
        private void ADDPAYMENT_Load(object sender, EventArgs e)
        {
            
        }

        private void PAY_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("ADDPAYMENT", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            string payment = PAYMENTOPTION.Text;
            cmd.Parameters.Add(new SqlParameter("@PAYMENTMETHOD", payment));
            cmd.ExecuteNonQuery();
            conn.Close();

            ADDPAYMENT AddPay = new ADDPAYMENT();
            AddPay.Hide();
            MessageBox.Show("PAYMENT METHOD ADDEDD SUCCESSFULLY","SUCCESS",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
