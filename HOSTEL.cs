using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hostel_sm
{
    public partial class HOSTEL : Form
    {
        public HOSTEL()
        {
            InitializeComponent();
        }

        private void rEGISTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            REGISTER ds = new  REGISTER();
            ds.Show();
        }

        private void aLLOTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ROOM ds = new ROOM();
            ds.Show();
        }

        private void aSSIGNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            STAFF ds = new STAFF();
            ds.Show();

        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
           MESS ds = new MESS();
            ds.Show();
        }

        private void aDDToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           INVENTRY ds = new INVENTRY();
            ds.Show();
        }

        private void aDDToolStripMenuItem2_Click(object sender, EventArgs e)
        {
           VISITORS ds = new VISITORS();
            ds.Show();
        }

        private void aDDToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            EVENTS ds = new EVENTS();
            ds.Show();
        }

        private void pAYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FEE ds = new FEE();
            ds.Show();
        }

        private void vIEWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           

        }

        private void sERACHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PROFILE_MANAGE ds = new PROFILE_MANAGE();
            ds.Show();
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            student_report s = new student_report();
            s.Show();
        }

        private void vIEWToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void vIEWToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            ROOM_REPORT DS = new ROOM_REPORT();
            DS.Show();
        }

        private void vIEWToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            VISITORS_REPORT DS = new VISITORS_REPORT();
            DS.Show();
        }

        private void vIEWToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            INVENTRY_REPORT DS = new INVENTRY_REPORT();
            DS.Show();
        }

        private void vIEWToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            EVENTS_REPORT DS = new EVENTS_REPORT();
            DS.Show();

        }

        private void vIEWToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FEE_REPORT DS = new FEE_REPORT();
            DS.Show();
        }

        private void vIEWToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            MESS_REPORT DS = new MESS_REPORT();
            DS.Show();
        }
    }
}
