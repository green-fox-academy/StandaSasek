using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Inheritance
{
    class Student : Person, ICloneable
    {
        public string PreviousOrganization { get; private set; }
        public int SkippedDays { get; private set; }
        public Student(string inpName, int inpAge, Gend inpGender, string inpPrevOrg) : base(inpName, inpAge, inpGender)
        {
            PreviousOrganization = inpPrevOrg;
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

        public object Clone()
        {
            return new Student(Name, Age, Gender, PreviousOrganization);
        }
    }
}
