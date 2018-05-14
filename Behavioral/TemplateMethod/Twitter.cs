using System;

namespace TemplateMethod
{
    public class Twitter : SocialNetwork
    {
        private string _token;

        public Twitter(string username, string password)
            : base(username, password) { }

        protected override void Login(string username, string password)
        {
            // Getting fake token

            Console.WriteLine($"Trying to get a Twitter token for the user {_username}...");
            
            FakeLatency();
            
            _token = (username + password).GetHashCode().ToString();
            Console.WriteLine($"Successfully logged in Twitter with token {_token}");
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