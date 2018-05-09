namespace FactoryMethod
{
    public class AustralianCommunication : Communication
    {
        protected override IPerson MakePerson()
        {
            return new Australian();
        }
    }
}