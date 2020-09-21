using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Text;
using Microsoft.VisualBasic;

namespace Inheritance
{
        public enum Gend 
        {
        male,
        female
        }
    class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public Gend Gender { get; private set; }

        public Person(string _name, int _age, Gend _gender)
        {
            Name = _name;
            Age = _age;
            Gender = _gender;
        }
        public Person()
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = Gend.female;
        }
        public virtual void Introduce()
        {
            if (this.GetType() == typeof(Person)) 
            {
            Console.Write("Hi, I'm {0}, a {1} year old {2}.", Name, Age, Gender);
            }
            else
            {
                Console.Write("Hi, I'm {0}, a {1} year old {2}", Name, Age, Gender);
            }
        }
        public virtual void GetGoal()
        {
            Console.WriteLine();
            Console.WriteLine("My goal is: Live for the moment!");
        }

    }
}
