public class FemaleUser : User
{
    public FemaleUser(int age, float weight, int height, int activityLevel, string gender)
    {
        Age = age;
        Weight = weight;
        Height = height;
        ActivityLevel = activityLevel;
        Gender = gender;
    }
    public override double TdeeCalc(int age, float weight, int height, int activityLevel)
    {
        double tdee = Math.Floor(387 - 7.31 * age + _actDic[activityLevel] * (10.9 * (weight / 2.205) + 660.7 * (height / 39.37)));

        return tdee;
    }
}