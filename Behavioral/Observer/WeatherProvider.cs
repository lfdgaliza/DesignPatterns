using System;
using System.Collections.Generic;

namespace Observer
{
    public class WeatherProvider : IObservable<int>
    {

        private List<IObserver<int>> _observers;

        public IDisposable Subscribe(IObserver<int> observer)
        {
            _observers.Add(observer);
            return new Unsubscriber(_observers, observer);
        }

        public void Changed(int newTemperature)
        {
            Console.WriteLine($"New temperature: {newTemperature} °C");
            _observers.ForEach(observer => observer.OnNext(newTemperature));
        }

        public WeatherProvider()
        {
            _observers = new List<IObserver<int>>();
        }
    }

    internal class Unsubscriber : IDisposable
    {
        private List<IObserver<int>> _observers;
        private IObserver<int> _observer;

        public Unsubscriber(List<IObserver<int>> observers, IObserver<int> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            if (_observer != null && _observers.Contains(_observer))
                _observers.Remove(_observer);
        }
    }
}