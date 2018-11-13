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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int sum;
            num1 = Convert.ToInt32(txtbox1.Text);
            num2 = Convert.ToInt32(txtbox2.Text);
            sum = num1 + num2;
            lblResult.Text = "The Sum is " + sum;
            lblSign.Visible = true;
            lblSign.Text = "+";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int diff;
            num1 = Convert.ToInt32(txtbox1.Text);
            num2 = Convert.ToInt32(txtbox2.Text);
            diff = num1 - num2;
            lblResult.Text = "The Difference is " + diff;
            lblSign.Visible = true;
            lblSign.Text = "-";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int product;
            num1 = Convert.ToInt32(txtbox1.Text);
            num2 = Convert.ToInt32(txtbox2.Text);
            product = num1 * num2;
            lblResult.Text = "The Product is " + product;
            lblSign.Visible = true;
            lblSign.Text = "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int quotient;
            num1 = Convert.ToInt32(txtbox1.Text);
            num2 = Convert.ToInt32(txtbox2.Text);
            quotient = num1 / num2;
            lblResult.Text = "The Quotient is " + quotient;
            lblSign.Visible = true;
            lblSign.Text = "/";
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int remmainder;
            num1 = Convert.ToInt32(txtbox1.Text);
            num2 = Convert.ToInt32(txtbox2.Text);
            remmainder = num1 % num2;
            lblResult.Text = "The remainder is " + remmainder;
            lblSign.Visible = true;
            lblSign.Text = "%";
        }
    }
}
