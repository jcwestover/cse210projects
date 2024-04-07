public class MaintenancePhase : Phase 
{
    public override double CheckIn(float currentWeight, float lastWeight, double tdee)
    {
        // Will take weight from the user for the week and compare it to the most recent checkin weight value and if it is within 'x' lbs it will continue with tdee and macros. if it is over it will drop tdee by 'y' and recalc macros. BUT if it is too low it will increase tdee by 'y' and recalc macros.
        if (currentWeight < lastWeight * 1.02)
        {
            return tdee += 250; 
        }
        else if (currentWeight > lastWeight * 1.02)
        {
            return tdee -= 150;
        }
        else 
        {
            return tdee;
        }
    }
}