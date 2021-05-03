using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reportform
{
    public partial class SIGNUP : Form
    {
        public static string fname;
        public static string lname;
        public static string email;

        public static Boolean sms;
        public static Boolean report;
        public static Boolean trans;

        conformation var = new conformation();
        public SIGNUP()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void signup1_Click(object sender, EventArgs e)
        {
            fname = txtfname.Text;
            lname = txtlname.Text;
            email = txtemail.Text;
            var.Show();
        }

        private void chksms_CheckedChanged(object sender, EventArgs e)
        {
            if(chksms.Checked)
            {
               sms = true;
                lblsms.Text = "Services charges may be apply for SMS";
            }
            else
            {
                sms = false;
                lblsms.Text = "............";

            }
        }

        private void chkreport_CheckedChanged(object sender, EventArgs e)
        {
            if (chkreport.Checked)
            {
                report = true;
                lblreport.Text = "Services charges may be apply for Report Status";
            }
            else
            {
                report = false;
                lblreport.Text = "............";

            }

        }

        private void chktran_CheckedChanged(object sender, EventArgs e)
        {


            if (chktran.Checked)
            {
                trans = true;
                lbltran.Text = "Services charges may be apply for Transtion status";
            }
            else
            {
                trans = false;
                lbltran.Text = "............";

            }
        }

        private void txtfname_TextChanged(object sender, EventArgs e)
        {

        }

        private void SIGNUP_Load(object sender, EventArgs e)
        {

        }
    }
}
