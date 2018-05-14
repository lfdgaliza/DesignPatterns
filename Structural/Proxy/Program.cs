using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person;
            IBeer beer;

            person = new Person(DateTime.Now.Year - 17);
            beer = new BeerProxy(person);
            beer.Drink();

            person = new Person(DateTime.Now.Year - 18);
            beer = new BeerProxy(person);
            beer.Drink();
        }
    }
}
