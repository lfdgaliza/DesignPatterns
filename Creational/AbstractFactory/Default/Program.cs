using System;
using Default.Factories;

namespace AbstractFactory
{
    class Program
    {
        private readonly BusinessAbstractFactory _businessAbstractFactory;
        static void Main(string[] args)
        {
            BusinessAbstractFactory factory = new BusinessConcreteFactory();
            var business = factory.CreateMyBusiness();
            business.DoSomething();
        }
    }
}
