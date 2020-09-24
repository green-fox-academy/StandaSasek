using System;
using System.Collections.Generic;
using System.Text;

namespace ZOO
{
    public enum Gend
    {
        male,
        female
    }
    public enum Feed
    {
        meat,
        vegies,
        everything
    }
    public abstract class Animal
    {
        protected string name;
        protected int age;
        protected Gend gender;
        protected string wayBorn;
        protected int legs;
        protected Feed food;
        protected string greet;

        protected Animal(string inpName, int inpAge, Gend inpGender, Feed inpFood)
        {
            name = inpName;
            age = inpAge;
            gender = inpGender;
            food = inpFood;
            greet = $", I am a {age} years old {gender}, I eat {food} and";
        }
        public abstract string Greet();
        public string WantChild()
        {
            return $" I want a child from {wayBorn}.";
        }
        public string GetName()
        {
            return name;
        }
        public abstract string MoreInfo();

    }
}
