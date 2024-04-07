using System;

class Program
{
    static void Main(string[] args)
    {
        // Get user input
        float checkInWeight;
        Console.Write("Age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Weight: ");
        float weight = float.Parse(Console.ReadLine());
        WeightTracker newWeightTracker = new WeightTracker();
        newWeightTracker.AddWeight(weight);

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

            PhaseTracker FatLossPhaseTracker = new PhaseTracker();
            FatLossPhase newFatLossPhase = new FatLossPhase();
            while (FatLossPhaseTracker.Counter < 13)
            {
                // Do check in
                Console.Write("Enter your weight for this week (to the nearest decimal): ");
                FatLossPhaseTracker.CountWeek();
                
                checkInWeight = float.Parse(Console.ReadLine());
                newWeightTracker.AddWeight(checkInWeight);
                tdee = newFatLossPhase.CheckIn(checkInWeight, newWeightTracker.GetLastWeight(), tdee);
                (protein, fat, carbs) = newMaleUser.MacroCalc(checkInWeight, tdee);
                Console.WriteLine($"Your total calorie goal is {tdee}.");
                Console.WriteLine($"Your macro goals are:\nProtein: {protein}g\nFat: {fat}g\nCarbs: {carbs}g");
            }

            Console.WriteLine("You have finished your fat loss phase!\nYou will now begin maintenance phase.");

            PhaseTracker MaintenancePhaseTracker = new PhaseTracker();
            MaintenancePhase newMaintenancePhase = new MaintenancePhase();
            while (MaintenancePhaseTracker.Counter < 7)
            {
                Console.Write("Enter your weight for this week (to the nearest decimal): ");
                MaintenancePhaseTracker.CountWeek();

                checkInWeight = float.Parse(Console.ReadLine());
                newWeightTracker.AddWeight(checkInWeight);
                tdee = newMaintenancePhase.CheckIn(checkInWeight, newWeightTracker.GetLastWeight(), tdee);
                (protein, fat, carbs) = newMaleUser.MacroCalc(checkInWeight, tdee);
                Console.WriteLine($"Your total calorie goal is {tdee}.");
                Console.WriteLine($"Your macro goals are:\nProtein: {protein}g\nFat: {fat}g\nCarbs: {carbs}g");
            }

            Console.WriteLine("You have finished your maintenance phase!\nYou may restart the program if you wish to do another fat loss phase.");
            
        }
        else if (gender == "F")
        {
            // Create a female user instance
            FemaleUser newFemaleUser = new FemaleUser(age, weight, height, activityLevel, gender);

            // calc tdee
            double tdee = newFemaleUser.TdeeCalc(age, weight, height, activityLevel);
            Console.WriteLine($"Your total calorie goal is {tdee}.");

            // Calculate Macros
            (double protein, double fat, double carbs) = newFemaleUser.MacroCalc(weight, tdee);
            Console.WriteLine($"Your macro goals are:\nProtein: {protein}g\nFat: {fat}g\nCarbs: {carbs}g");

            PhaseTracker FatLossPhaseTracker = new PhaseTracker();
            FatLossPhase newFatLossPhase = new FatLossPhase();
            while (FatLossPhaseTracker.Counter < 13)
            {
                // Do check in
                Console.Write("Enter your weight for this week (to the nearest decimal): ");
                FatLossPhaseTracker.CountWeek();
                
                checkInWeight = float.Parse(Console.ReadLine());
                newWeightTracker.AddWeight(checkInWeight);
                tdee = newFatLossPhase.CheckIn(checkInWeight, newWeightTracker.GetLastWeight(), tdee);
                (protein, fat, carbs) = newFemaleUser.MacroCalc(checkInWeight, tdee);
                Console.WriteLine($"Your total calorie goal is {tdee}.");
                Console.WriteLine($"Your macro goals are:\nProtein: {protein}g\nFat: {fat}g\nCarbs: {carbs}g");
            }

            Console.WriteLine("You have finished your fat loss phase!\nYou will now begin maintenance phase.");

            PhaseTracker MaintenancePhaseTracker = new PhaseTracker();
            MaintenancePhase newMaintenancePhase = new MaintenancePhase();
            while (MaintenancePhaseTracker.Counter < 7)
            {
                Console.Write("Enter your weight for this week (to the nearest decimal): ");
                MaintenancePhaseTracker.CountWeek();

                checkInWeight = float.Parse(Console.ReadLine());
                newWeightTracker.AddWeight(checkInWeight);
                tdee = newMaintenancePhase.CheckIn(checkInWeight, newWeightTracker.GetLastWeight(), tdee);
                (protein, fat, carbs) = newFemaleUser.MacroCalc(checkInWeight, tdee);
                Console.WriteLine($"Your total calorie goal is {tdee}.");
                Console.WriteLine($"Your macro goals are:\nProtein: {protein}g\nFat: {fat}g\nCarbs: {carbs}g");
            }

            Console.WriteLine("You have finished your maintenance phase!\nYou may restart the program if you wish to do another fat loss phase.");
        }
        else
        {
            Console.WriteLine("Error: Gender is not valid.");
        }
    }
}