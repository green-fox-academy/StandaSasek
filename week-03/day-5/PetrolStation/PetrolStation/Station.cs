using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Timers;

namespace PetrolStation
{
    class Station
    {
        public string StationName { get; private set; }

        private int gasAmountStation;
        public int GasAmountStation
        {
            get => gasAmountStation;
            private set
            {
                if (value > 1000)
                {
                    gasAmountStation = 1000;
                }
                else if (value < 10)
                {
                    RefillEmptyStation();
                }
                else
                {
                    gasAmountStation = value;
                }
            }
        }
        public Station(string name)
        {
            StationName = name;
            GasAmountStation = 1000;
        }
        public void RefillEmptyStation()
        {
            Console.WriteLine("Please wait while we refill gasoline to the gas station tank.");
            var toFill = 1000 - GasAmountStation;
            GasAmountStation += toFill;
            Console.ReadKey();
            StationStatus();

            GasAmountStation += 1000;
            Console.ReadKey();
            Console.WriteLine("Gas station is ready to serve again.");
        }
        public void RefillAutomatic(Car car)
        {
            Console.WriteLine("Please stop your engine and wait. We will refuel your car soon.");
            var missingGas = 100 - car.GasAmountCar;
            var toFill = GasAmountStation - missingGas >= 0 ? missingGas : GasAmountStation;
            GasAmountStation -= toFill;
            car.GasAmountCar += toFill;
            Console.ReadKey();
            car.CarStatus();
        }
        public void RefillSelfservice(Car car, int amount)
        {
            Console.WriteLine("Please stop your engine and refuel your car. Beware of your maximum gasoline volume.");
            GasAmountStation -= amount;
            car.GasAmountCar += amount;
            Console.ReadKey();
            car.CarStatus();
        }
        internal static void Refill(string carName)
        {
            throw new NotImplementedException();
        }

        public static void CleanSpilledGas()
        {
            Console.WriteLine("Please wait while we clean spilled gasoline.");
            Console.ReadKey();
            Console.WriteLine("Gas station is clean again.");
        }
        public void StationStatus()
        {
            Console.WriteLine("Fuel level in tank of gas station {0} is {1} litres.", this.StationName, this.GasAmountStation);
        }
    }
}
