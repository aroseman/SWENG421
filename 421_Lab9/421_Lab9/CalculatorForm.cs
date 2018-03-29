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
        public State State { get; private set; }
        public double Value1 { get; private set; }
        public double Value2 { get; private set; }
        public double Result { get; private set; }
        
        public CalculatorForm()
        {
            
            State = new Value1();
            Value1 = 0;
            InitializeComponent();
        }
    }
}
