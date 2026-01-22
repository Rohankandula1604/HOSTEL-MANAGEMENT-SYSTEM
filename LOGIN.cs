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

namespace hostel_sm
{
    public partial class FORM1 : Form
    {
        public FORM1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IQCTD47\\MSSQLSERVER01;Initial Catalog=hostel;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            con.Open();

            string USERNAME = textBox1.Text;
            string PASSWORD = textBox2.Text;

            SqlCommand cmd = new SqlCommand("SELECT USERNAME, PASSWORD FROM USERS WHERE USERNAME=@USERNAME AND PASSWORD=@PASSWORD", con);
            cmd.Parameters.AddWithValue("@USERNAME", USERNAME);
            cmd.Parameters.AddWithValue("@PASSWORD", PASSWORD);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                this.Hide();
                HOSTEL ds = new HOSTEL();
               
                ds.Show();
                MessageBox.Show("LOGGED IN SUCCESSFULL");
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }

            con.Close();



        }
    }
}
