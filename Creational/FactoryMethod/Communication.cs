namespace FactoryMethod
{
    public abstract class Communication
    {
        public string GetGreeting()
        {
            var person = MakePerson();
            return $"{person.SayGoodMorning()} (high five)";
        }

        protected abstract IPerson MakePerson();
    }
}