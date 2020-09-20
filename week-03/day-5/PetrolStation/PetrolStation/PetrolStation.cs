using System;

namespace PetrolStation
{
    class PetrolStation
    {
        static void Main(string[] args)
        {
            // Create Station and Car classes
            /* Station
            GasAmount
            Refill(car)->decreases the gasAmount by the capacity of the car and increases the cars gasAmount
            
            Car
            GasAmount
            Capacity
            create constructor for Car where:
            initialize gasAmount-> 0
            initialize capacity-> 100
            */

            /* TRY THESE:
            EmptyCarTank()
            CarStatus()
            CarTrip(Int32 km)
            
            RefillEmptyStation()
            RefillAutomatic(Car car)
            RefillSelfservice(Car car, int amount) // try to overfill ;-)
            StationStatus()
            */

            Station benzina = new Station("Benzina");
            Car chrysler = new Car("Chrysler");

            benzina.StationStatus();
            chrysler.CarStatus();

            /*chrysler.CarTrip(56);

            benzina.RefillAutomatic(chrysler);

            chrysler.CarTrip(25);

            benzina.RefillSelfservice(chrysler, 20);*/

            chrysler.CarTrip(150);

        }
    }
}
