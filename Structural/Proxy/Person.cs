using System;

namespace Proxy
{
    public class Person
    {
        public Person(int birthYear)
        {
            this._birthYear = birthYear;
        }
        private int _birthYear;
        public int Age => DateTime.Now.Year - _birthYear;
    }
}