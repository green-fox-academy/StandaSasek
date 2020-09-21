using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Sponsor : Person
    {
        public string Company { get; private set; }
        public int HiredStudents { get; private set; }
        public Sponsor(string _name, int _age, Gend _gender, string _company) : base(_name, _age, _gender)
        {
            Company = _company;
            HiredStudents = 0;
        }
        public Sponsor() : base()
        {
            Company = "Google";
            HiredStudents = 0;
        }
        public override void GetGoal()
        {
            Console.WriteLine();
            Console.WriteLine("My goal is: Hire brilliant junior software developers.");
        }
        public override void Introduce()
        {
            base.Introduce();
            Console.Write(" who represents {0} and hired {1} students so far.", Company, HiredStudents);
        }
        public void Hire()
        {
            HiredStudents += 1;
        }
    }
}
