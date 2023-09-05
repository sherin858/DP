namespace DP.BehaviouralPatterns.Observer;

public class ObserverA : IObserver
{
    public void Update(ISubject subject)
    {
      if((subject as Subject).State > 1)
      {
        Console.WriteLine("ConcreteObserverA: Reacted to the event.");
      }
    }
}