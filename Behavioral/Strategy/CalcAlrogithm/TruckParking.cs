using System;

namespace Strategy.CalcAlrogithm
{
    public class TruckParking : VehicleParking
    {
        public TruckParking(string plate, DateTime arrival) : base(plate, arrival)
        {
        }

        public override decimal CalculatePrice()
        {
            // Custom calculation algorithm
            return 9.3M;
        }
    }
}