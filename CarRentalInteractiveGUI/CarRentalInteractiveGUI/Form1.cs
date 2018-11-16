using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            string daysString;
            int days;
            string milesString;
            double miles;
            double total;
            string totalString;

            daysString = txtBoxDays.Text;
            milesString = txtBoxMiles.Text;

            miles = Convert.ToDouble(milesString);
            days = Convert.ToInt32(daysString);

            total = (days * 20) + (miles * .25);

            totalString = total.ToString("C");

            lblResult.Text = "The final total is " + days + " days and " + miles + " miles, which equates too " + totalString;
        }
    }
}
