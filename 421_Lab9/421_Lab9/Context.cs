using System.Windows.Forms;

namespace _421_Lab9
{
    public class Context
    {
        public IState State { get; set; }

        public Context()
        {
            State = new Value1();
            
        }

        public void DoIt(Button button)
        {
            State.DoIt(this, button);
        }
    }
}