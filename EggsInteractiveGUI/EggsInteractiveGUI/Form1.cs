using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggsInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int eggs1;
            int eggs2;
            int eggs3;
            int eggs4;
            int eggs5;
            int total;
            int dozen;
            int remainder; 

            eggs1 = Convert.ToInt32(txtBoxChic1.Text);
            eggs2 = Convert.ToInt32(txtBoxChic2.Text);
            eggs3 = Convert.ToInt32(txtBoxChic3.Text);
            eggs4 = Convert.ToInt32(txtBoxChic4.Text);
            eggs5 = Convert.ToInt32(txtBoxChic5.Text);

            total = eggs1 + eggs2 + eggs3 + eggs4 + eggs5;

            lblTotal.Text = "" + total + " eggs ";

            dozen = total/12;

            lblDozen.Text = "" + dozen + " dozen";

            remainder = total % 12;

            lblRemaining.Text = " " + remainder + " remaining ";
        }
    }
}
