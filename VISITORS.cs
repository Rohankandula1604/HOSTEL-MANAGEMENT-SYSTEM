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
    public partial class VISITORS : Form
    {
        string Connectionstring = "Data Source=DESKTOP-IQCTD47\\MSSQLSERVER01;Initial Catalog=hostel;Integrated Security=True;Encrypt=True;TrustServerCertificate=True ";
        public VISITORS()
        {
            InitializeComponent();
            LOADVISITOR();
        }
        private void LOADVISITOR()
        {
            using (SqlConnection con = new SqlConnection(Connectionstring))
            {
                con.Open();
                string query = "Select * from VISITOR ";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IQCTD47\\MSSQLSERVER01;Initial Catalog=hostel;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO VISITOR VALUES (@NAME,  @SNAME, @ADDRESS, @CONTACT, @VID,@SID)", con);
                cmd.Parameters.AddWithValue("@NAME", textBox1.Text);
                cmd.Parameters.AddWithValue("@SNAME", textBox2.Text);
              
                cmd.Parameters.AddWithValue("@ADDRESS", textBox4.Text);
                cmd.Parameters.AddWithValue("@CONTACT", textBox5.Text);
                cmd.Parameters.AddWithValue("@VID", textBox6.Text);
                cmd.Parameters.AddWithValue("@SID", textBox7.Text);
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("saved successfully");
                LOADVISITOR();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"an error: {ex.Message}");
            }
        }
    }
}
