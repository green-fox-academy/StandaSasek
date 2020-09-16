using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Animal
    {
        string animalName;
        int hunger;
        int thirst;
        public string AnimalName { get => animalName; set => animalName = value; }
        public int Hunger
        {
            get => hunger;
            set 
                {
                if (value > 100)
                {
                    hunger = 100;
                }
                else if (value < 0)
                {
                    hunger = 0;
                }
                else
                {
                    hunger = value;
                };
            }
        }
        public int Thirst
        {
            get => thirst;
            set
            {
                if (value > 100)
                {
                    thirst = 100;
                }
                else if (value < 0)
                {
                    thirst = 0;
                }
                else
                {
                    thirst = value;
                }
                ;
            }
        }

        public Animal(string animalName)
        {
            AnimalName = animalName;
            hunger = 50;
            thirst = 50;
        }
        public Animal()
        {
            AnimalName = "IAnimal";
            hunger = 50;
            thirst = 50;
        }
        public void Eat()
        {
            Hunger--;
        }
        public void Drink()
        {
            Thirst--;
        }
        public void Play()
        {
            Hunger++;
            Thirst++;
        }
    }
}
