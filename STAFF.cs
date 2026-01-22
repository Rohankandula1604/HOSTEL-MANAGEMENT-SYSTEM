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

namespace hostel_sm
{
    public partial class STAFF : Form
    {
        string Connectionstring = "Data Source=DESKTOP-IQCTD47\\MSSQLSERVER01;Initial Catalog=hostel;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public STAFF()
        {
            InitializeComponent();
            LOADSTAFF();
        }
        private void LOADSTAFF()
        {
            using (SqlConnection con = new SqlConnection(Connectionstring))
            {
                con.Open();
                string query = "Select * from STAFF ";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IQCTD47\\MSSQLSERVER01;Initial Catalog=hostel;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO STAFF VALUES (@SNAME, @STAFFID, @STAFFWORK, @ASSIGNWORK, @CONTACT)", con);
                cmd.Parameters.AddWithValue("@SNAME", textBox1.Text);
                cmd.Parameters.AddWithValue("@STAFFID", textBox2.Text);
                cmd.Parameters.AddWithValue("@STAFFWORK", textBox3.Text);
                cmd.Parameters.AddWithValue("@ASSIGNWORK", textBox4.Text);
                cmd.Parameters.AddWithValue("@CONTACT", textBox5.Text);
                cmd.ExecuteNonQuery();
                

                con.Close();
                MessageBox.Show("saved successfully");
                LOADSTAFF();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"an error: {ex.Message}");
            }
        }
    }
}
