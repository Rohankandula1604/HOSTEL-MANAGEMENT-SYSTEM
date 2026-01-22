using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hostel_sm
{
    public partial class FEE : Form
    {
        public FEE()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text += "**************************\n";
            richTextBox1.Text += "******FEE RECEIPT ******\n";
            richTextBox1.Text += "**************************\n";
            richTextBox1.Text +="DATE :"+DateTime.Now+"\n\n";

            richTextBox1.Text += "STUDENT ID: " + textBox1.Text + "\n\n";
            richTextBox1.Text += "FEE ID: " + textBox2.Text + "\n\n";
            richTextBox1.Text += "AMOUNT : " + textBox3.Text + "\n\n";
            richTextBox1.Text += "PAID AMOUNT : " + textBox3.Text + "\n\n";
            richTextBox1.Text += "DUE AMOUNT : " + textBox4.Text + "\n\n";
            richTextBox1.Text += "ROOM NO : " + textBox5.Text + "\n\n";
            richTextBox1.Text += "DATE : " + dateTimePicker1 + "\n\n";



            richTextBox1.Text += "\n***********THANK OUT PLEASE VISIT AGAIN***************\n";
            richTextBox1.Text += "\n***********SIGNATURE***********\n";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IQCTD47\\MSSQLSERVER01;Initial Catalog=hostel;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO FEE VALUES (@SID, @FEEID, @AMOUNT, @PAMT, @DAMT, @ROOMNO, @DATE,@MESSID)", con);
                cmd.Parameters.AddWithValue("@SID", textBox1.Text);
                cmd.Parameters.AddWithValue("@FEEID", textBox2.Text);
                cmd.Parameters.AddWithValue("@AMOUNT", textBox3.Text);
                cmd.Parameters.AddWithValue("@PAMT", textBox4.Text);
                cmd.Parameters.AddWithValue("@DAMT", textBox5.Text);
                cmd.Parameters.AddWithValue("@ROOMNO", textBox6.Text); // Use the correct textbox for gender
                cmd.Parameters.AddWithValue("@DATE", dateTimePicker1.Value ); // Assuming there's a textBox7 for S
                cmd.Parameters.AddWithValue("MESSID", textBox7.Text);
                

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("saved successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"an error: {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
        
            
    }
}
