/*
 * Created by: Jack Wright
 * Created on: 8-Feb-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #6 - Hello World International
 * This program gives the user the option to have the phrase "Hello, World" displayed in a variety of languages.
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

namespace HelloWorldInt2
{
    public partial class frmHelloWorldInt : Form
    {
        public frmHelloWorldInt()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radEnglish_CheckedChanged(object sender, EventArgs e)
        {
            lblGreetings.Text = "Hello, World!";
        }

        private void radSpanish_CheckedChanged(object sender, EventArgs e)
        {
            lblGreetings.Text = "Hola Mundo!";
        }

        private void radPortugese_CheckedChanged(object sender, EventArgs e)
        {
            lblGreetings.Text = "Olá Mundo!";
        }

        private void radGerman_CheckedChanged(object sender, EventArgs e)
        {
            lblGreetings.Text = "Hallo Welt!";
        }
    }
}
