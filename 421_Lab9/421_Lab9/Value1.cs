using System.Windows.Forms;

namespace _421_Lab9
{
    public class Value1:IState
    {
        public void DoIt(Context context, char action)
        {
            // Check if the action is 0-9
            if (action >= 48 && action <= 57)
            {
                // Do some action here and then transtion.
                context.State = new Value1();
            }
            // Check if the action is a basic operation ( +, -, *, ., /)
            else if ((action >= 42 && action <= 43) || (action >= 45 && action <= 47))
            {
                // Do some action here and then transition.
                context.State = new OperatorEntered();
            }
            // Special Operations (sqrt, 1/x, = etc...)
            else if (action == 251)
            {

            }
        }
    }
}