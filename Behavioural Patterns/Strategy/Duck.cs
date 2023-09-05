namespace DP.BehaviouralPatterns.Strategy;

public abstract class Duck
{
    protected IFlyBehaviour _flyBehaviour;
    public string Fly()
    {
        return _flyBehaviour.Fly();
    }
    public void SetFlyBehaviour(IFlyBehaviour flyBehaviour)
    {
        _flyBehaviour = flyBehaviour;
    }
}