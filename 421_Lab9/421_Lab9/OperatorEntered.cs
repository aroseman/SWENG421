using System.Windows.Forms;

namespace _421_Lab9
{
    public class OperatorEntered:IState
    {
        char operation;
        public OperatorEntered(char inVal)
        {
            if (inVal == 42)
            {
                operation = '*';
            }
            else if (inVal == 43)
            {
                operation = '+';
            }
            else if (inVal == 45)
            {
                operation = '-';
            }
            else if (inVal == 46)
            {
                operation = '.';
            }
            else if (inVal == 47)
            {
                operation = '/';
            }
            else
            {
                operation = 'X';
            }
        }
        public void DoIt(Context currentState, char action)
        {
            throw new System.NotImplementedException();
        }
    }
}