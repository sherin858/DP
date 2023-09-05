namespace DP.BehaviouralPatterns.Observer;

public class ObserverB : IObserver
{
  public void Update(ISubject subject)
  {
    if ((subject as Subject).State == 0 || (subject as Subject).State >= 2)
    {
      Console.WriteLine("ConcreteObserverB: Reacted to the event.");
    }
  }
}