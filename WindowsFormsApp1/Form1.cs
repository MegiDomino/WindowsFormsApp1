using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LEROI\SQLEXPRESS;Initial Catalog=LOGIN;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");


        private void Form1_Load(object sender, EventArgs e)
        {
            //AddPassenger.Hide();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logBut_Click(object sender, EventArgs e)
        {
            String username, password;

            username = userBox.Text;
            password = passBox.Text;

            try
            {
                String querry = "SELECT * FROM LOGINS WHERE username = '" + userBox.Text + "' AND password = '" + passBox.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = userBox.Text;
                    password = passBox.Text;

                    AddPassenger AddP = new AddPassenger();
                    AddP.Show();
                    this.Visible = false;
                  
                   /* AddPassenger.TopLevel = false;
                    this.Controls.Add(AddPassenger);

                    AddPassenger.Show();

                    //AddPassenger.Show();
                    this.Hide();*/
                    
                }
                else
                {
                    MessageBox.Show("BAAANNGGGGG BALIK", "nge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    userBox.Clear();
                    passBox.Clear();

                    userBox.Focus();
                  
                }
            }

            catch
            {
                MessageBox.Show("NGE");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
