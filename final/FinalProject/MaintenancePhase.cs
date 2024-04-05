public class MaintenancePhase : Phase 
{
    public override double CheckIn(double currentWeight, double lastWeight)
    {
        // Will take weight from the user for the week and compare it to the most recent checkin weight value and if it is within 'x' lbs it will continue with tdee and macros. if it is over it will drop tdee by 'y' and recalc macros. BUT if it is too low it will increase tdee by 'y' and recalc macros.
        return 0;
    }
}