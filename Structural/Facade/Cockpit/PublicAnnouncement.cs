using System;

namespace Facade.Cockpit
{
    public class PublicAnnouncement
    {
        public void GetAnnouncementForTakeOff()
            => Console.WriteLine("Cabin crew, please take your seats for take-off.");
    }
}