namespace DP.BehaviouralPatterns.Strategy;

public class NormalDuck:Duck
{
    public NormalDuck()
    {
        _flyBehaviour = new FlyWithWings();
    }
}