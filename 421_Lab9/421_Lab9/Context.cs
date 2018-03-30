using System;
using System.Windows.Forms;

namespace _421_Lab9
{
    public class Context
    {
        public IState State { get; set; }
        public int Buffer { get; set; }
        public int Buffer2 { get; set; }
        public char storedOperation { get; set; }

        public Context()
        {
            State = new Value1();
            
        }

        public void DoIt(char action, TextBox display)
        {
            State.DoIt(this, action);
            if (display.Text != "0")
            {
                if (Buffer == -1)
                {
                    Buffer = 0;
                    display.Text = Buffer.ToString();
                }
                else
                {
                    display.Text = display.Text + Buffer.ToString();
                }
            }
            else
            {
                display.Text = Buffer.ToString();   
            }

            try
            {
                Buffer = Int32.Parse(display.Text);
            }
            catch (Exception e)
            {
                display.Text = "ERROR";
            }
            
            Console.WriteLine(Buffer);
        }
    }
}