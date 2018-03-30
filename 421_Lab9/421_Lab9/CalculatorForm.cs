using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _421_Lab9
{
    public partial class CalculatorForm : Form
    {
       public static Context Context;
        
        public CalculatorForm()
        {
            Context = new Context();
            InitializeComponent();
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            Context.DoIt('1', displayTB);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            displayTB.Text = null;
            Context.DoIt('C', displayTB);
        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            Context.DoIt('2', displayTB);
        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            Context.DoIt('3', displayTB);
        }
        private void fourBtn_Click(object sender, EventArgs e)
        {
            Context.DoIt('4', displayTB);
        }
        private void fiveBtn_Click(object sender, EventArgs e)
        {
            Context.DoIt('5', displayTB);
        }
        private void sixBtn_Click(object sender, EventArgs e)
        {
            Context.DoIt('6', displayTB);
        }
        private void sevenBtn_Click(object sender, EventArgs e)
        {
            Context.DoIt('7', displayTB);
        }
        private void eightBtn_Click(object sender, EventArgs e)
        {
            Context.DoIt('8', displayTB);
        }
        private void nineBtn_Click(object sender, EventArgs e)
        {
            Context.DoIt('9', displayTB);
        }
        private void multBtn_Click(object sender, EventArgs e)
        {
            Context.DoIt('*', displayTB);
        }
    }
}
