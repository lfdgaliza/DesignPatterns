using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Communication communication;
            
            communication = new BrazilianCommunication();
            Console.WriteLine(communication.GetGreeting());
            
            communication = new AustralianCommunication();
            Console.WriteLine(communication.GetGreeting());
        }
    }
}
