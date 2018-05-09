using System;
using Strategy.CalcAlrogithm;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleParking car = new CarParking("CAR1234", DateTime.Now);
            VehicleParking truck = new TruckParking("TRK1234", DateTime.Now);
            VehicleParking carAfterOneDay = new CarAfterOneDayParking("AFT1234", DateTime.Now);
            VehicleParking special = new SpecialCalculationAskedByClientParking("SPE1234", DateTime.Now);

            Console.WriteLine($"{car.CarPlate}: {car.CalculatePrice()}");
            Console.WriteLine($"{truck.CarPlate}: {truck.CalculatePrice()}");
            Console.WriteLine($"{carAfterOneDay.CarPlate}: {carAfterOneDay.CalculatePrice()}");
            Console.WriteLine($"{special.CarPlate}: {special.CalculatePrice()}");
        }
    }
}
