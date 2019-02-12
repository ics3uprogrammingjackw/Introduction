using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldIntJackW
{
    public partial class frmHelloWorldInt : Form
    {
        public frmHelloWorldInt()
        {
            InitializeComponent();
        }

        private void grbLanguages_Click(object sender, EventArgs e)
        {

        }

        private void radPortugese_CheckedChanged(object sender, EventArgs e)
        {
            lblGreetings.Text = "Olá Mundo!";
        }

        private void radEnglish_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radEnglish_CheckedChanged_1(object sender, EventArgs e)
        {
            lblGreetings.Text = "Hello, World!";
        }

        private void radSpanish_CheckedChanged(object sender, EventArgs e)
        {
            lblGreetings.Text = "Hola Mundo!";
        }

        private void radPortugese_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
