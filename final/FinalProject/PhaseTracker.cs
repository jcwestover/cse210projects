public class PhaseTracker
{
    private int _counter;

    public int Counter
    {
        get { return _counter; }
        set { _counter = value; }
    }

    public PhaseTracker()
    {
        _counter = 0;
    }

    public void CountWeek()
    {
        _counter ++;
    }
}