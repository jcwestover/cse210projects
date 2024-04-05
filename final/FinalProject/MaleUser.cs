public class MaleUser : User
{
    public MaleUser(int age, float weight, int height, int activityLevel, string gender)
    {
        Age = age;
        Weight = weight;
        Height = height;
        ActivityLevel = activityLevel;
        Gender = gender;
    }
    public override double TdeeCalc(int age, float weight, int height, int activityLevel)
    {
        double tdee = Math.Floor(864 - 9.72 * age + _actDic[activityLevel] * (14.2 * (weight / 2.205) + 503 * (height / 39.37)));

        return tdee;
    }
}