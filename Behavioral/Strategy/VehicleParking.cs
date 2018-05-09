using System;

namespace Strategy
{
    public abstract class VehicleParking
    {
        public VehicleParking(string plate, DateTime arrival)
        {
            CarPlate = plate;
            _arrival = arrival;
        }
        
        public string CarPlate { get; set; }
        protected DateTime _arrival { get; set; }
        protected DateTime _departure { get; set; }

        public abstract decimal CalculatePrice();

        public void LeaveParking()
        {
            _departure = DateTime.Now;
        }
    }
}