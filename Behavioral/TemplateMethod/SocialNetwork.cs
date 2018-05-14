using System;
using System.Threading;

namespace TemplateMethod
{
    public abstract class SocialNetwork
    {
        protected string _username;
        protected string _password;

        public void Post(string message)
        {
            Login(_username, _password);
            SendMessage(message);
            Logout();
        }

        protected abstract void Login(string username, string password);
        protected abstract void SendMessage(string message);
        protected abstract void Logout();

        protected void FakeLatency()
        {
            Thread.Sleep(1500);
        }

        public SocialNetwork(string username, string password)
        {
            _username = username;
            _password = password;
        }
    }
}