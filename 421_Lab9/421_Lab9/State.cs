namespace _421_Lab9
{
    public abstract class State
    {
        public abstract State NextState(State s);
        public abstract void DoIt();
    }
}