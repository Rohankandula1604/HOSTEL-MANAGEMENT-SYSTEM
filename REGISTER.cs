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
    public partial class REGISTER : Form
    {
        string Connectionstring = "Data Source=DESKTOP-IQCTD47\\MSSQLSERVER01;Initial Catalog=hostel;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public REGISTER()
        {
            InitializeComponent();
            STUDENT();
        }
        private void STUDENT()
        {
            using (SqlConnection con = new SqlConnection(Connectionstring))
            {
                con.Open();
                string query = "Select * from STUDENT ";
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
                SqlCommand cmd = new SqlCommand("INSERT INTO STUDENT VALUES (@SID, @NAME, @ADDRESS, @CLASS, @CONTACT, @PCONTACT, @GENDER, @DATEOFADDITION)", con);
                cmd.Parameters.AddWithValue("@SID", textBox1.Text);
                cmd.Parameters.AddWithValue("@NAME", textBox2.Text);
                cmd.Parameters.AddWithValue("@ADDRESS", textBox3.Text);
                cmd.Parameters.AddWithValue("@CLASS", textBox4.Text);
                cmd.Parameters.AddWithValue("@CONTACT", textBox5.Text);
                cmd.Parameters.AddWithValue("@PCONTACT", textBox6.Text); // Use the correct textbox for gender
                cmd.Parameters.AddWithValue("@GENDER", textBox7.Text); // Assuming there's a textBox7 for SID
                cmd.Parameters.AddWithValue("@DATEOFADDITION", dateTimePicker1.Value);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("saved successfully");
                STUDENT();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"an error: {ex.Message}");
            }
        }
    }
}
