using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Inheritance
{
    class Student : Person
    {
        public string PreviousOrganization { get; private set; }
        public int SkippedDays { get; private set; }
        public Student(string _name, int _age, Gend _gender, string _prevOrg) : base(_name, _age, _gender)
        {
            PreviousOrganization = _prevOrg;
            SkippedDays = 0;
        }
        public Student() : base()
        {
            PreviousOrganization = "The School of life";
            SkippedDays = 0;
        }
        public override void GetGoal()
        {
            Console.WriteLine(); 
            Console.WriteLine("My goal is: Be a junior software developer.");
        }
        public override void Introduce()
        {
            base.Introduce();
            Console.Write(" from {0} who skipped {1} days from the course already.", PreviousOrganization, SkippedDays);
        }
        public void SkipDays(int numberOfDays)
        {
            SkippedDays += numberOfDays; 
        }
    }
}
