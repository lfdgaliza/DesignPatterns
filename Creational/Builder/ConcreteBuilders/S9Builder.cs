using Builder;

namespace Builders.ConcreteBuilders
{
    public class S9Builder : IMobilePhoneBuilder
    {
        private MobilePhone _mobilePhone;
        public S9Builder()
        {
            _mobilePhone = new MobilePhone();
        }
        public MobilePhone Phone => _mobilePhone;

        public IMobilePhoneBuilder BuildBattery()
        {
            _mobilePhone.Battery = "Non-removable Li-Ion 3000 mAh battery (11.55 Wh)";
            return this;
        }

        public IMobilePhoneBuilder BuildName()
        {
            _mobilePhone.Name = "Galaxy S9";
            return this;
        }

        public IMobilePhoneBuilder BuildOS()
        {
            _mobilePhone.Os = "Android";
            return this;
        }

        public IMobilePhoneBuilder BuildProcessor()
        {
            _mobilePhone.Processor = "Octa-core (4x2.7 GHz Mongoose M3 & 4x1.8 GHz Cortex-A55) - EMEA";
            return this;
        }
    }
}