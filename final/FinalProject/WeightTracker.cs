public class WeightTracker
{
    private List<float> _weights;

    public WeightTracker()
    {
        _weights = new List<float>();
    }

    public void AddWeight(float weight)
    {
        _weights.Add(weight);
    }

    public float GetLastWeight()
    {
        // Return the last weight added to the _weights list
        return _weights[_weights.Count - 1];
    }
}