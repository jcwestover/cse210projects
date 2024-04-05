using System;

class Program
{
    static void Main(string[] args)
    {
        // Get user input
        Console.Write("Age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Weight: ");
        float weight = float.Parse(Console.ReadLine());

        Console.Write("Height (inches): ");
        int height = int.Parse(Console.ReadLine());

        Console.Write("\nSedentary: 1\nLightly Active: 2\nModerately Active: 3\nVery Active: 4\nExtremely Active: 5\n\nActivity Level: ");
        int activityLevel = int.Parse(Console.ReadLine());

        string gender;

        do
        {
            Console.Write("Gender (M or F): ");
            gender = Console.ReadLine().ToUpper();
        }
        while (gender != "M" && gender != "F");
        

        if (gender == "M")
        {
            // Create a male user instance
            MaleUser newMaleUser = new MaleUser(age, weight, height, activityLevel, gender);

            // calc tdee
            double tdee = newMaleUser.TdeeCalc(age, weight, height, activityLevel);
            Console.WriteLine($"Your total calorie goal is {tdee}.");

            // Calculate Macros
            (double protein, double fat, double carbs) = newMaleUser.MacroCalc(weight, tdee);
            Console.WriteLine($"Your macro goals are:\nProtein: {protein}g\nFat: {fat}g\nCarbs: {carbs}g");

            // Do check in
            Console.Write("Enter your weight for this week (to the nearest decimal): ");
            float checkInWeight = float.Parse(Console.ReadLine());

            // if check in is too much drop cals (inverse)
        }
        else if (gender == "F")
        {
            // Create a female user instance
            FemaleUser newFemaleUser = new FemaleUser(age, weight, height, activityLevel, gender);

            // calc tdee

            // Calculate Macros

            // Do check in

            // if check in is too much drop cals (inverse)
        }
        else
        {
            Console.WriteLine("Error: Gender is not valid.");
        }
    }
}