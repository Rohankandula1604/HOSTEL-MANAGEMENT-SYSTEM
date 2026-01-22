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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hostel_sm
{
    public partial class EVENTS : Form
    {
        string Connectionstring = "Data Source=DESKTOP-IQCTD47\\MSSQLSERVER01;Initial Catalog=hostel;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public EVENTS()
        {
            InitializeComponent();
            LOADEVENTS();
        }
        private void LOADEVENTS()
        {
            using (SqlConnection con = new SqlConnection(Connectionstring))
            {
                con.Open();
                string query = "Select * from EVENTS";
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
                SqlCommand cmd = new SqlCommand("INSERT INTO EVENT VALUES (@SNAME, @ENAME, @EPURPOSE, @DATEOFEVENT, @SID)", con);
                cmd.Parameters.AddWithValue("@SNAME", textBox1.Text);
                cmd.Parameters.AddWithValue("@ENAME", textBox2.Text);
                cmd.Parameters.AddWithValue("@EPURPOSE", textBox3.Text);
                cmd.Parameters.AddWithValue("@DATEOFEVENT", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@SID", textBox5.Text);
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("saved successfully");
                LOADEVENTS();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"an error: {ex.Message}");
            }
        }
    }
}
