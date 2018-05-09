using Facade.Cockpit;

namespace Facade
{
    public class PilotFacade
    {
        private Cabin _cabin;
        private Engine _engine;
        private Wings _wings;
        private PublicAnnouncement _pa;

        public PilotFacade()
        {
            _cabin = new Cabin();
            _engine = new Engine();
            _wings = new Wings();
            _pa = new PublicAnnouncement();
        }

        public void TakeOffThisAeroplane()
        {
            _pa.GetAnnouncementForTakeOff();
            _wings.SetFlaps(15);
            _wings.SetSlats(20);
            _wings.DoSomething();
            _cabin.TurnLights(false);
            _engine.SetSpeed(99.9);
        }
    }
}