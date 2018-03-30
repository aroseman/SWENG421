using System.Windows.Forms;

namespace _421_Lab9
{
    public class Value1:IState
    {
        public void DoIt(Context context, char action)
        {
            // Check if the action is 0-9.
            if (action >= 48 && action <= 57)
            {
                // Do some action here and then transtion.
                context.Buffer =  action - '0';
                context.State = new Value1();
            }
            // Check if the action is a basic operation ( +, -, *, ., /).
            else if ((action >= 42 && action <= 43) || (action >= 45 && action <= 47))
            {
                // Do some action here and then transition.
                /*Idea is to store what we have into Value 2, and reset buffer1 to 0. */

                context.State = new OperatorEntered(action);

            }
            // Special Operations (sqrt, 1/x, = etc...).
            else if (action == 251 || action == 61 || action == 171)
            {
                context.State = new PrintResult();
            }
            // Clear and backspace operation.
            else if (action == 67 || action == 66)
            {
                context.Buffer = 0;
                context.State = new Value1();
            }
        }
    }
}