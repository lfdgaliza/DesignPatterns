using System;

namespace Proxy
{
    public class Beer : IBeer
    {
        public void Drink()
        {
            Console.WriteLine("Cheers!");
        }
    }
}