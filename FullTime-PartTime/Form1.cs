using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullTime_PartTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            decimal credits = trkCredits.Value;
            lblCredits.Text = credits.ToString();

            if (credits >= 12)
            {
                lblStatus.Text = "Full time";
            }
            else if (credits >= 6)
            {
                lblStatus.Text = "Half time";
            }
            else if (credits >= 0)

            {
                lblStatus.Text = "Less than half time";

            }
        }

        

        
    }
}

