using System.Windows.Forms;

namespace _421_Lab9
{
    public class OperatorEntered:IState
    {
        
        public OperatorEntered(Context mycontext, char inVal)
        {
            if (inVal == 42)
            {
                mycontext.storedOperation = '*';
            }
            else if (inVal == 43)
            {
                mycontext.storedOperation = '+';
            }
            else if (inVal == 45)
            {
                mycontext.storedOperation = '-';
            }
            else if (inVal == 46)
            {
                mycontext.storedOperation = '.';
            }
            else if (inVal == 47)
            {
                mycontext.storedOperation = '/';
            }
            else
            {
                mycontext.storedOperation = 'X';
            }

           
        }
        public void DoIt(Context currentState, char action)
        {
            /*Only does this when it is pressed for the second time. */
            currentState.storedOperation = action;
        }
    }
}