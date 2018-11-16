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

            eggs1 = Convert.ToInt32(txtBoxChic1.Text);
            eggs2 = Convert.ToInt32(txtBoxChic2.Text);
            eggs3 = Convert.ToInt32(txtBoxChic3.Text);


        }
    }
}
