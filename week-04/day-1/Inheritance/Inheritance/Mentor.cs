using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public enum Seniority
    {
        junior,
        intermediate,
        senior
    }
    class Mentor : Person
    {
        public Seniority Level { get; private set; }

        public Mentor(string _name, int _age, Gend _gender, Seniority _level) : base(_name, _age, _gender)
        {
            Level = _level;
        }
        public Mentor() : base()
        {
            Level = Seniority.intermediate;
        }
        public override void GetGoal()
        {
            Console.WriteLine();
            Console.WriteLine("My goal is: Educate brilliant junior software developers.");
        }
        public override void Introduce()
        {
            base.Introduce();
            Console.Write(" {0} mentor.", Level);
        }
    }
}
