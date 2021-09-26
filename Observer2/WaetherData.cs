using System.Collections.Generic;

namespace Observer2
{
    public class WaetherData : ISubject
    {
        public IList<IObserver> Observers { get; private set; }

        public WaetherData()
        {
            Observers = new List<IObserver>();
        }

        private void NotifyObserver()
        {
            foreach (var observer in Observers)
            {
                observer.Update();
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void SetMeasurements() 
        {
            NotifyObserver();
        }
    }
}
