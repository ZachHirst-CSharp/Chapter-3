using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUICalculator
{
    public partial class LblReultAdd : Form
    {
        public LblReultAdd()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int sum;
            num1 = Convert.ToInt32(txtbox1.Text);
            num2 = Convert.ToInt32(txtbox2.Text);

            sum = num1 + num2;
            lblResultAdd.Text = "The sum is " + sum;
        }

       

        private void BtnSub_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int difference;
            num1 = Convert.ToInt32(txtbox1.Text);
            num2 = Convert.ToInt32(txtbox2.Text);

            difference = num1 - num2;
            lblResultSub.Text = "The difference is " + difference;
        }
    }
}
