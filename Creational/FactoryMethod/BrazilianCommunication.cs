namespace FactoryMethod
{
    public class BrazilianCommunication : Communication
    {
        protected override IPerson MakePerson()
        {
            return new Brazilian();
        }
    }
}