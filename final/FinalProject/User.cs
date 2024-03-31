public class User
{
    private int _age;
    private float _weight;
    private int _height;
    private int _activityLevel;

    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }

    public float Weight
    {
        get { return _weight; }
        set { _weight = value; }
    }

    public int Height
    {
        get { return _height; }
        set { _height = value; }
    }

    public int ActivityLevel
    {
        get { return _activityLevel; }
        set { _activityLevel = value; }
    }

    public virtual double TdeeCalc()
    {
        return 0;
    }

    public (double, double, double) MacroCalc(double weight, double tdee)
    {
        double protein = weight * 1.25;
        double fat = weight * 0.5;
        double remainingCals = tdee - ((protein * 4) + (fat * 9));
        double carbs =  remainingCals / 4;

        return (protein, fat, carbs);
    }
}