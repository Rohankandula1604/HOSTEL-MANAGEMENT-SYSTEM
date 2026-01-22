using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace hostel_sm
{
    public partial class PROFILE_MANAGE : Form
    {
        public PROFILE_MANAGE()
        {
            InitializeComponent();
        }
        string ConnectionString = "Data Source = DESKTOP - IQCTD47\\MSSQLSERVER01;Initial Catalog = hostel; Integrated Security = True; Encrypt=True;TrustServerCertificate=True";

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using(SqlConnection cn=new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (cn.State == ConnectionState.Closed)
                        cn.Open();
                    using(DataTable dt=new DataTable("STUDENT"))
                    {
                        using(SqlCommand cmd=new SqlCommand("select * from  STUDENT WHERE SID=@SID or NAME like @NAME",cn))
                        {
                            cmd.Parameters.AddWithValue("SID", Convert.ToInt32(textBox1.Text));
                            cmd.Parameters.AddWithValue("NAME",Convert.ToString(textBox1.Text));
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                            cmd.ExecuteReader();
                        
                        
                        
                        }
                    }
                    //if (cn.State == ConnectionState.Closed)
                      //  cn.Open();
                   // using (DataTable dt = new DataTable("FEE"))
                    //{
                     //   using (SqlCommand cmd = new SqlCommand("select * from FEE WHERE FEEID=@FEEID or SID like @SID", cn))
                       /// {
                          //  cmd.Parameters.AddWithValue("FEEID", Convert.ToInt32(textBox1.Text));
                            //cmd.Parameters.AddWithValue("SID", Convert.ToInt32(textBox1.Text));
                            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            //adapter.Fill(dt);
                            //dataGridView1.DataSource = dt;
                            //cmd.ExecuteReader();



                        //}
                    //}
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==(char)13)
            {
                button1.PerformClick();
            }
        }
    }
    
        
           

    

        
    
}
