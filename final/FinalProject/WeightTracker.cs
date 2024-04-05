public class WeightTracker
{
    private List<double> _weights;

    public void AddWeight(double weight)
    {
        _weights.Add(weight);
    }

    public double GetLastWeight(List<double> _weights)
    {
        return _weights.Count -1;
    }
}