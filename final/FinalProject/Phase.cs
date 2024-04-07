public class Phase
{
    private int _length;

    public int Length
    {
        get { return _length; }
        set { _length = value; }
    }

    public virtual double CheckIn(float currentWeight, float lastWeight, double tdee)
    {
        return 0;
    }
}