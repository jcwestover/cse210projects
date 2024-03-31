public class FatLossPhase : Phase 
{
    public override void CheckIn(double weight)
    {
        // Will compare users weigh in to the most previous one and if it did not decrese by 'x' then it will drop the tdee and recalc macros
    }
}