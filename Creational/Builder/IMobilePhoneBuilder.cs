namespace Builder
{
    public interface IMobilePhoneBuilder
    {
        IMobilePhoneBuilder BuildName();
        IMobilePhoneBuilder BuildOS();
        IMobilePhoneBuilder BuildProcessor();
        IMobilePhoneBuilder BuildBattery();

        MobilePhone Phone { get; }
    }
}