using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            SocialNetwork network;

            network = new Twitter("handsomeguy", "pwd");
            network.Post("Hello Twitter!");

            Console.WriteLine("**************************");

            network = new Orkut("handsomeguy", "pwd");
            network.Post("Hello Orkut!");

        }
    }
}
