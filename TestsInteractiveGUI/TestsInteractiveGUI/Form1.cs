using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;

namespace TestsInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           double test1 = Convert.ToDouble(txtBoxTest1.Text);
           double test2 = Convert.ToDouble(txtBoxTest2.Text);
           double test3 = Convert.ToDouble(txtBoxTest3.Text);
           double test4 = Convert.ToDouble(txtBoxTest4.Text);
           double test5 = Convert.ToDouble(txtBox5.Text);

            double final = ((test1 + test2 + test3 + test4 + test5) / 5)/100;

            lblResult.Text = "" + final.ToString("P");
        }
    }
}
