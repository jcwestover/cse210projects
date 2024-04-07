public class FatLossPhase : Phase 
{
    public override double CheckIn(float currentWeight, float lastWeight, double tdee)
    {
        float weightDifference = lastWeight - currentWeight;

        // If weight increased by more than 0.7%, decrease tdee by 300
        if (weightDifference > (lastWeight * 0.007))
        {
            tdee -= 300; 
        }
        // If weight decreased by more than 1.6%, increase tdee by 200
        else if (weightDifference < (lastWeight * 0.016))
        {
            tdee += 200;
        }
        // If weight change is within thresholds, do nothing (tdee remains unchanged)
        else 
        {
            // No action required
        }

        return tdee;
    }
}