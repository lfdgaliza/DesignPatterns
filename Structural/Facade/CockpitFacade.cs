using Facade.Business;

namespace Facade
{
    public class CockpitFacade
    {
        private Cabin _cabin;
        private Engine _engine;
        private Wings _wings;
        private PublicAnnouncement _pa;

        public CockpitFacade()
        {
            _cabin = new Cabin();
            _engine = new Engine();
            _wings = new Wings();
            _pa = new PublicAnnouncement();
        }

        public string PrepareForTakeOff()
        {
            _wings.DoSomething();
            return _pa.GetAnnouncementForTakeOff();
        }

        public void TakeOff()
        {
            _wings.SetFlaps(15);
            _wings.SetSlats(20);
            _wings.DoSomething();
            _cabin.TurnLights(false);
            _engine.SetSpeed(99.9);
        }
    }
}