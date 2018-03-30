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
    }
}
