public class User
{
    private int _age;
    private float _weight;
    private int _height;
    private int _activityLevel;
    private string _gender;
    protected Dictionary<int, double> _actDic;

    public User()
    {
        _actDic = new Dictionary<int, double>();
        _actDic.Add(1, 1);
        _actDic.Add(2, 1.12);
        _actDic.Add(3, 1.27);
        _actDic.Add(4, 1.54);
    }

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

    public string Gender
    {
        get { return _gender; }
        set { _gender = value; }
    }

    public virtual double TdeeCalc(int age, float weight, int height, int activityLevel)
    {
        return 0;
    }

    public (double, double, double) MacroCalc(double weight, double tdee)
    {
        double protein = weight * 1.25;
        double fat = weight * 0.5;
        double remainingCals = tdee - ((protein * 4) + (fat * 9));
        double carbs =  Math.Floor(remainingCals / 4);

        return (protein, fat, carbs);
    }
}