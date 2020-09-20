using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace PetrolStation
{
    class Car
    {

        private int gasAmountCar;
        string carName;
        public string CarName { get => carName; private set => carName = value; }
        public int GasAmountCar
        {
            get => gasAmountCar;
             set
            {
                if (value > 100)
                {
                    gasAmountCar = 100;
                    GasSpilled();
                }
                else if (value < 0)
                {
                    gasAmountCar = 0;
                }
                else
                {
                    gasAmountCar = value;
                }
            }
        }
        public Car(string name)
        {
            CarName = name;
            gasAmountCar = 100;
        }
        public void EmptyCarTank()
        {
            Console.WriteLine("The car's fuel tank will soon be empty, refuel.");
            Station.Refill(carName);
        }
        public void GasSpilled()
        {
            Console.WriteLine("Gasoline spilled under car, please call gas station staff.");
            Station.CleanSpilledGas();
        }
        public int CarStatus()
        {
            Console.WriteLine("Fuel level in {0} is {1} litres.", this.CarName, this.GasAmountCar); 
            return this.GasAmountCar;
        }
        public void CarTrip(Int32 km)
        {
            Console.WriteLine("Awesome, it was a beautiful {0} km long trip. Nice views and stunning architecture.", km);
            this.GasAmountCar -= km;
            CarStatus();
        }
    }
}
