using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hostel_sm
{
    public partial class ROOM : Form  

       
    {

        string Connectionstring = "Data Source=DESKTOP-IQCTD47\\MSSQLSERVER01;Initial Catalog=hostel;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
        public ROOM()
        {
            InitializeComponent();
            LoadRoom();
        }
        private void LoadRoom()
        {
            using(SqlConnection con=new SqlConnection(Connectionstring))
            {
                con.Open();
                string query = "Select * from Room";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;

            }
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IQCTD47\\MSSQLSERVER01;Initial Catalog=hostel;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO ROOM VALUES (@SNAME, @RNO, @OCCUPIED, @CAPACITY, @SID, @RTYPE)", con);
                cmd.Parameters.AddWithValue("@SNAME", textBox1.Text);
                cmd.Parameters.AddWithValue("@RNO", textBox2.Text);
                cmd.Parameters.AddWithValue("@OCCUPIED", textBox3.Text);
                cmd.Parameters.AddWithValue("@CAPACITY", textBox4.Text);
                cmd.Parameters.AddWithValue("@SID", textBox5.Text);
                cmd.Parameters.AddWithValue("@RTYPE", textBox6.Text);
                cmd.ExecuteNonQuery();
               
                con.Close();
                MessageBox.Show("saved successfully");
                LoadRoom();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"an error: {ex.Message}");
            }


            


        }

        
    }
}
