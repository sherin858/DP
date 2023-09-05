namespace DP.BehaviouralPatterns.Observer;
public interface ISubject
{
  
  void Attach (IObserver observer);
  void Detatch (IObserver observer);
  void Notify();
}

//publisher interface