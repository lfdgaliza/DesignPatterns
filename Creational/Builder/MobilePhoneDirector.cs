namespace Builder
{
    public class MobilePhoneDirector
    {
        private IMobilePhoneBuilder _mobilePhoneBuilder;

        public MobilePhoneDirector(IMobilePhoneBuilder mobilePhoneBuilder)
        {
            _mobilePhoneBuilder = mobilePhoneBuilder;
        }

        public MobilePhone Phone => _mobilePhoneBuilder.Phone;

        public void MakePhone()
        {
            _mobilePhoneBuilder
                .BuildName()
                .BuildOS()
                .BuildBattery()
                .BuildProcessor();
        }
    }
}