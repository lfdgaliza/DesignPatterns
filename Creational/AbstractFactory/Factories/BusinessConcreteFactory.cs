using Default.Business;

namespace Default.Factories
{
    public class BusinessConcreteFactory : BusinessAbstractFactory
    {
        public override MyBusinessBase CreateMyBusiness()
        {
            return new MyBusiness();
        }
    }
}