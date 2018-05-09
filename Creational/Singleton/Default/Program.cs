using System;
using Default;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var myBusiness = MyBusiness.Instance;
            Console.WriteLine(myBusiness.SomeString);
        }
    }

    
}
