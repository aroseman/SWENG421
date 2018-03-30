using System.Windows.Forms;

namespace _421_Lab9
{
    public interface IState
    {
        
         void DoIt(Context context, char action);
         
    }
}