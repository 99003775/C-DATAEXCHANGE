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
    public partial class conformation : Form
    {
        public conformation()
        {
            InitializeComponent();
        }

        private void conformation_Load(object sender, EventArgs e)
        {
            lbl1fname.Text = SIGNUP.fname;
            lbl1lname.Text = SIGNUP.lname;
            lbl1email.Text = SIGNUP.email;

            if(SIGNUP.sms)
            {
                lbl1sms.Text = "✔";
            }


            if (SIGNUP.report)
            {
                lbl1report.Text = "✔";
            }


            if (SIGNUP.trans)
            {
                lbl1transtion.Text = "✔";
            }
        }
    }
}
