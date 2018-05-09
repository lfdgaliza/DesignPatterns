using System;

namespace Strategy.CalcAlrogithm
{
    public class SpecialCalculationAskedByClientParking : VehicleParking
    {
        public SpecialCalculationAskedByClientParking(string plate, DateTime arrival) : base(plate, arrival)
        {
        }

        public override decimal CalculatePrice()
        {
            // Custom calculation algorithm
            return 2.5M;
        }
    }
}