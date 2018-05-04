using Builder;

namespace Builders.ConcreteBuilders
{
    public class IphoneXBuilder : IMobilePhoneBuilder
    {
        private MobilePhone _mobilePhone;

        public IphoneXBuilder()
        {
            _mobilePhone = new MobilePhone();
        }

        public MobilePhone Phone => _mobilePhone;

        public IMobilePhoneBuilder BuildBattery()
        {
            _mobilePhone.Battery = "Non-removable Li-Ion 2716 mAh battery (10.35 Wh)";
            return this;
        }

        public IMobilePhoneBuilder BuildName()
        {
            _mobilePhone.Name = "iPhone X";
            return this;
        }

        public IMobilePhoneBuilder BuildOS()
        {
            _mobilePhone.Os = "iOS";
            return this;
        }

        public IMobilePhoneBuilder BuildProcessor()
        {
            _mobilePhone.Processor = "Hexa-core 2.39 GHz (2x Monsoon + 4x Mistral)";
            return this;
        }
    }
}