using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class ADDTICKET : Form
    {
        public ADDTICKET()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LEROI\SQLEXPRESS;Initial Catalog=BUS_TICKETING;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ADDTICKET_Load(object sender, EventArgs e)
        {

        }

        private void ADD_PAYMENT_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("ADDTICKET", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            string price = PRICE.Text;
            string status = STATUS.Text;
            string bus = BUS_ID.Text;
            string route = ROUTE_ID.Text;
            string schedule = SCHED.Text;


            cmd.Parameters.Add(new SqlParameter("@PRICE", price));
            cmd.Parameters.Add(new SqlParameter("@STATUS", status));
            cmd.Parameters.Add(new SqlParameter("@BUSID", bus));
            cmd.Parameters.Add(new SqlParameter("@ROOTAID", route));
            cmd.Parameters.Add(new SqlParameter("@SCHEDULEID", schedule));

            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}
