using System.Windows.Forms;

namespace _421_Lab9
{
    public class PrintResult:IState
    {
        public PrintResult(Context myContext, char action)
        {
            /*More or less, do the intended operation, and reset buffers as needed. 
             This usually means you will use Buffer 2 (if needed) with Buffer 1, and set the value
             of Buffer1 to your new value. Then the program should handle updating it as inteded. Finish off
             by setting Buffer 2 to 0 regardless.*/

            /*equals*/
            if (action == 61)
            {
                /*Operations that use both buffers. */
                if (myContext.Buffer2 == 0)
                {
                    if (myContext.storedOperation == '+')
                    {
                        /*DO addition*/
                    }
                    else if (myContext.storedOperation == '-')
                    {
                        /*do subtraction*/
                    }
                    else if (myContext.storedOperation == '*')
                    {
                        /*do multiplicaiton*/
                    }
                    else if (myContext.storedOperation == '/')
                    {
                        /*do subtraction*/
                    }
                }
                else
                {
                    /*Operations that use buffer twice*/
                    if (myContext.storedOperation == '+')
                    {
                        /*DO addition*/
                    }
                    else if (myContext.storedOperation == '-')
                    {
                        /*do subtraction*/
                    }
                    else if (myContext.storedOperation == '*')
                    {
                        /*do multiplicaiton*/
                    }
                    else if (myContext.storedOperation == '/')
                    {
                        /*do subtraction*/
                    }
                }
            }
            else if(action == 251)
            {
                /*Do sqrt function*/
            }
            else
            {
                /*do 1/x function.*/
            }
        }
        public void DoIt(Context currentState, char action)
        {
            throw new System.NotImplementedException();
        }
    }
}