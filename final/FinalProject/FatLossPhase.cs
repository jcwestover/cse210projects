public class FatLossPhase : Phase 
{
    public override double CheckIn(double currentWeight, double lastWeight)
    {
        double weightChange = currentWeight - lastWeight;
        return weightChange;
    }
}