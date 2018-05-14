using System;

namespace TemplateMethod
{
    public class Orkut : SocialNetwork
    {
        public Orkut(string username, string password)
            : base(username, password) { }

        protected override void Login(string username, string password)
        {
            Console.WriteLine($"Trying to login the user {_username} to Orkut...");
            
            FakeLatency();
            
            Console.WriteLine($"Orkut says hi!");
        }

        protected override void Logout()
        {
            Console.WriteLine($"Trying to close session for the user {_username}...");
            FakeLatency();
            Console.WriteLine("The session has been closed with success.");            
        }

        protected override void SendMessage(string message)
        {
            Console.WriteLine($"Posting this message: \"{message}\"");
            FakeLatency();
            Console.WriteLine($"Post completed!");
        }
    }
}