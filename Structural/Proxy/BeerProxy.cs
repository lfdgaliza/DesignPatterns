using System;

namespace Proxy
{
    public class BeerProxy : IBeer
    {
        private readonly IBeer _realBeer;
        private readonly Person _person;
        public BeerProxy(Person person)
        {
            _person = person;
            _realBeer = new Beer();
        }
        public void Drink()
        {
            if (_person.Age > 17)
                _realBeer.Drink();
            else
                Console.WriteLine("You cannot drink beer yet. Hold on!");
        }
    }
}