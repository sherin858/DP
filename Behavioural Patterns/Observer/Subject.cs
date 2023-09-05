namespace DP.BehaviouralPatterns.Observer;

public class Subject : ISubject
{
  public int State{get;set;}=0;
  private List<IObserver> _observers= new List<IObserver>();
    public void Attach(IObserver observer)
    {
      Console.WriteLine("Subject: Attached an observer.");
        _observers.Add(observer);
    }

    public void Detatch(IObserver observer)
    {
      Console.WriteLine("Subject: Detached an observer.");
      _observers.Remove(observer);
    }

    public void Notify()
    {
      Console.WriteLine("Subject: Notifying observers...");
      foreach (IObserver o in _observers)
      {
        o.Update(this);
      }
    }

    public void SomeBusinessLogic()
    {
        Console.WriteLine("\nSubject: I'm doing something important.");
        this.State = new Random().Next(0, 10);

        Thread.Sleep(15);

        Console.WriteLine("Subject: My state has just changed to: " + this.State);
        Notify();
    }
}