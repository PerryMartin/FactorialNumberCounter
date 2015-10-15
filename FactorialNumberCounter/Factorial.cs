/*
 * Created by: Perry Martin
 * Created on: 06-10-2015
 * Created for: ICS3U
 * Daily Assignment – unit 3-05
 * This program displays Factorials
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactorialNumberCounter
{
    public partial class frmFactorial : Form
    {
        public frmFactorial()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Double factorialNumber;
            Double factorialAnswer;
            int factorialCounter;

            this.lstFactorialNumber.Items.Clear();
            factorialAnswer = 1;
            factorialNumber = Convert.ToDouble(this.txtFactorial.Text);
            factorialCounter = 0;

            for ( factorialCounter = 1; factorialCounter <= 10; factorialCounter++);
            {
                factorialCounter = factorialCounter + 1;
                this.lstFactorialNumber.Items.Add(factorialCounter);
                factorialAnswer = factorialAnswer * factorialCounter;
            }  
             
            this.txtAnswer.Text = Convert.ToString(factorialAnswer);

        }
    }
}
