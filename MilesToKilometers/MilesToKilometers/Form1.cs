using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilesToKilometers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompile_Click(object sender, EventArgs e)
        {
            double miles;
            double kilometers;

           
            miles = Convert.ToDouble(textBoxmiles.Text);

            kilometers = 0.621371 * miles;

            lblkilo.Text = " " + kilometers;
        }
    }
}
