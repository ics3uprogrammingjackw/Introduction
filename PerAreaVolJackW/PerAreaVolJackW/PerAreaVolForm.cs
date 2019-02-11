/*
 * Created by: Jack Wright
 * Created on: 11-Feb-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #7 - AreaPerVol
 * This program calculates a perimeter, area, and volume question.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerAreaVolJackW
{
    public partial class frmPerAreaVol : Form
    {
        public frmPerAreaVol()
        {
            InitializeComponent();
        }

        private void frmPerAreaVol_Load(object sender, EventArgs e)
        {

        }

        private void btnQuestion1_Click(object sender, EventArgs e)
        {
            lblAnswer1.Text = Convert.ToString(5 + 5 + 2 + 2);
        }

        private void btnQuestion2_Click(object sender, EventArgs e)
        {
            lblAnswer2.Text = Convert.ToString(Math.Round(100*Math.Pow(5, 2) * Math.PI)/100);
        }

        private void btnQuestion3_Click(object sender, EventArgs e)
        {
            lblAnswer3.Text = Convert.ToString(Math.Round(100*(Double)4/(Double)3 * Math.PI * Math.Pow(4, 3))/100);
        }
    }
}
