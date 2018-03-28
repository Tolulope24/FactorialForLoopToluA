using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created by: Tolulope Adebayo
 * Created on: 28-March-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #22 - Factorial For Loop
 * This program calculates the factorial of a number given by the user
*/

namespace FactorialForLoopToluA
{
    public partial class frmFactorialForLoop : Form
    {
        public frmFactorialForLoop()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Derclare constants and variables 
            Double FactorialAnswer;
            Double FactorialNumber;
            int FactorialCounter;
            // Clear all items from the list box
            this.lstFactorialNumbers.Items.Clear();
            // Set factorial answer to 1
            FactorialAnswer = 1;
            // Get factorial answer from the user
            FactorialNumber = Convert.ToDouble(txtFactorial.Text);
            // Set Loop 
            for (FactorialCounter = 1; FactorialCounter <= FactorialNumber; FactorialCounter++)
            {
                // list the Factorial numbers for the user to see
                this.lstFactorialNumbers.Items.Add(FactorialCounter);
                // Multiply the counter by the answer 
                FactorialAnswer = FactorialCounter * FactorialAnswer;
                //Convert factorial answer to a string and add it to a label
                this.lblAnswer.Text = " The answer is :  " + this.txtFactorial.Text + "!=" + Convert.ToString(FactorialAnswer);
            }
        }
    }
}
