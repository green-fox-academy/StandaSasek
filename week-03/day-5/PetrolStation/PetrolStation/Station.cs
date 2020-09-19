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
        string stationName;
        public string StationName { get => stationName; private set => stationName = value; }

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
            GasAmountStation += 1000;

        }
        public void Refill(string CarName)
        {
            Console.WriteLine("Please stop your engine and wait. We will refuel your car soon.");
            // this.GasAmountStation -= 100 - CarStatus(CarName); // does not work... lost in names/classes/methods/this/Big letters/small letters again :-(
        }
        public static void CleanSpilledGas()
        {
            Console.WriteLine("Please wait while we clean spilled gasoline.");
            Console.ReadLine();
            Console.WriteLine("Gas station is clean again.");
        }
        public void StationStatus()
        {
            Console.WriteLine("Fuel level in tank of gas station {0} is {1} litres.", this.StationName, this.GasAmountStation);
        }
    }
}
