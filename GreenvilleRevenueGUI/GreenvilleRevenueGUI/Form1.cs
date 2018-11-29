using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenvilleRevenueGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRev_Click(object sender, EventArgs e)
        {
            int lastYearNum = Convert.ToInt32(txtBoxLastYear.Text);
            int thisYearNum = Convert.ToInt32(txtBoxThisYear.Text);
            int revenue;
            string moneyform;

            if(lastYearNum > thisYearNum)
            {
                int result; 
           
                lblBigger.Visible = true;
                result = lastYearNum - thisYearNum;
                lblBigger.Text = " Last year the number of participants was larger by " + result + " people. ";

            }

            revenue = thisYearNum * 25;

            moneyform = revenue.ToString("C");

            lblRevenue.Visible = true;

            lblRevenue.Text = "The revenue from this years competition was " + moneyform + " ";
        }
    }
}
