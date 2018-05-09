using System;

namespace Strategy.CalcAlrogithm
{
    public class CarAfterOneDayParking : VehicleParking
    {
        public CarAfterOneDayParking(string plate, DateTime arrival) : base(plate, arrival)
        {
        }

        public override decimal CalculatePrice()
        {
            // Custom calculation algorithm
            return 2.3M;
        }
    }
}