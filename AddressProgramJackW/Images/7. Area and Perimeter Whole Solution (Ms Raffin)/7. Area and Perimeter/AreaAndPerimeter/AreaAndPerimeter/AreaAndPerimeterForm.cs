/*
 * Created by: Ms Raffin
 * Created on: 11-02-2013
 * Created for: ICS3U Programming
 * Daily Assignment – Day #5 - Area and Perimeter
 * This program calculates the area and perimeter of a rectangle of length 5 cm and width 3 cm and displays it when the "Answer" button is clicked.
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

namespace AreaAndPerimeter
{
    public partial class frmAreaAndPerimeter : Form
    {
        public frmAreaAndPerimeter()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblAreaAnswer_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            lblAreaAnswer.Text = Convert.ToString(5 * 3) + " cm squared";
            lblPerimeterAnswer.Text = Convert.ToString(2 * 5 + 3 * 2) + " cm";
        }

        private void frmAreaAndPerimeter_Load(object sender, EventArgs e)
        {

        }
    }
}
