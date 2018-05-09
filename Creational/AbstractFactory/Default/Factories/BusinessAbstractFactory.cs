using Default.Business;

namespace Default.Factories
{
    public abstract class BusinessAbstractFactory
    {
        public abstract MyBusinessBase CreateMyBusiness();
    }
}