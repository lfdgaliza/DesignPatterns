using System;
using Builder.ConcreteBuilders;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneBuilder = new Redmi3ProBuilder();
            
            var director = new MobilePhoneDirector(phoneBuilder);
            director.MakePhone();
            
            var myPhone = director.Phone;

            Console.Write($"Name: {myPhone.Name}, OS: {myPhone.Os}, Processor: {myPhone.Processor}, Battery: {myPhone.Battery}");
        }
    }
}
