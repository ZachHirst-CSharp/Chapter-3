using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIMadLib
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompile_Click(object sender, EventArgs e)
        {
            string Color = txtBoxColor.Text;
            string Est = txtBoxEst.Text;
            string PBP = txtBoxBPP.Text;
            string Animal = txtBoxAnimal.Text;
            string Noun = txtBoxNoun.Text;
            string PluralNoun = txtBoxPluralNoun.Text;
            int num1;
            int num2;
            int difference;

            num1 = Convert.ToInt32(txtBoxInteger.Text);
            num2 = Convert.ToInt32(txtBoxAnotherInteger.Text);
            difference = num1 - num2;

            // welcome to the ,color, Story about a man and his ,animal, his , animal , is the , est, in the , num1, universe(s). His ,animal, was 
        }
    }
}
