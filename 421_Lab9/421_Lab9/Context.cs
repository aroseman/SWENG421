using System;
using System.Windows.Forms;

namespace _421_Lab9
{
    public class Context
    {
        public IState State { get; set; }
        public int Buffer { get; set; }

        public Context()
        {
            State = new Value1();
            
        }

        public void DoIt(char action, TextBox display)
        {
            State.DoIt(this, action);
            display.Text = Buffer.ToString();
        }
    }
}