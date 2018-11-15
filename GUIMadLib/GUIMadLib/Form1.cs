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
            
            string PBP = txtBoxBPP.Text; //
            string Animal = txtBoxAnimal.Text; //
            string Noun = txtBoxNoun.Text; //
            string PluralNoun = txtBoxPluralNoun.Text; //
            int num1; //
            int num2;
            int difference;

            num1 = Convert.ToInt32(txtBoxInteger.Text);
            num2 = Convert.ToInt32(txtBoxAnotherInteger.Text);
            difference = num1 - num2;

            lbl0.Text = " " + txtBoxColor.Text;
            lbl1.Text = " " + txtBoxAnimal.Text;
            lbl2.Text = " " + txtBoxEst.Text;
            lbl3.Text = " " + txtBoxInteger.Text;
            lbl4.Text = " " + txtBoxAnimal.Text;
            lbl5.Text = " " + txtBoxBPP.Text;
            lbl6.Text = " " + txtBoxNoun.Text;
            lbl7.Text = " " + txtBoxPluralNoun.Text;
            lbl8.Text = " " + txtBoxAnimal.Text;
            lbl9.Text = " " + txtBoxAnotherInteger.Text;
            lbl10.Text = " " + difference;
            lbl11.Text = " " + txtBoxBPP.Text;

            // welcome to the ,color, Story about a man and his ,animal, which is the , est, in the , num1, universe(s). His ,animal, was eating ,body part plural, which had apparently came from a cart that was going to ,noun, , in hopes that 
            // they could sell it to the , plural noun , . Sadly since his , animal , ate ,num2, they were left with , difference , ,body part plural, . 
        }
    }
}
