using System;

namespace Strategy.CalcAlrogithm
{
    public class CarParking : VehicleParking
    {
        public CarParking(string plate, DateTime arrival) : base(plate, arrival)
        {
        }

        public override decimal CalculatePrice()
        {
            // Custom calculation algorithm
            return 1.1M;
        }
    }
}