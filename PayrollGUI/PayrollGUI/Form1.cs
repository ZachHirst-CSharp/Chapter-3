using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtBoxName.Text;
            double SSN = Convert.ToDouble(txtBoxSSN.Text);
            double hourlypayrate = Convert.ToDouble(txtBoxHourlyPay.Text);
            double hoursworked = Convert.ToDouble(txtBoxHoursWorked.Text);
            double grosspay;
            string money;
            double fedpay;
            string fedtax;
            double statepay;
            string statetax;
            double net;
            string income;
           
            grosspay = hourlypayrate * hoursworked;
            fedpay = (grosspay * .15);
            statepay = (grosspay * .05);
            net = grosspay - (fedpay + statepay);

            fedtax = fedpay.ToString("C");
            statetax = statepay.ToString("C");
            money = grosspay.ToString("C");
            income = net.ToString("C");

            lblFederal.Text = " The taxes that the federal government is taking is " + fedtax;
            lblState.Text = "The taxes the state is taking out are " + statetax;
            lblNet.Text = " Your net pay is " + income;
            lblGrossPay.Text = " Your gross pay for " + hoursworked + " hours worked is " + money;
        }
    }
}
