using Builder;

namespace Builder.ConcreteBuilders
{
    public class Redmi3ProBuilder : IMobilePhoneBuilder
    {
        private MobilePhone _mobilePhone;

        public Redmi3ProBuilder()
        {
            _mobilePhone = new MobilePhone();
        }

        public MobilePhone Phone => _mobilePhone;

        public IMobilePhoneBuilder BuildBattery()
        {
            _mobilePhone.Battery = "Non-removable Li-Ion 4100 mAh battery";
            return this;
        }

        public IMobilePhoneBuilder BuildName()
        {
            _mobilePhone.Name = "Redmi 3 Pro";
            return this;
        }

        public IMobilePhoneBuilder BuildOS()
        {
            _mobilePhone.Os = "Miui (Android)";
            return this;
        }

        public IMobilePhoneBuilder BuildProcessor()
        {
            _mobilePhone.Processor = "Qualcomm MSM8939v2 Snapdragon 616";
            return this;
        }
    }
}