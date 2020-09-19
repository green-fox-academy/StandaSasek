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

            Station benzina1 = new Station("Benzina Praha");
            Car chrysler = new Car("Chrysler");

            benzina1.StationStatus();
            chrysler.CarStatus();

            chrysler.CarTrip(56);

            chrysler.GasSpilled();

        }
    }
}
