using System;
using System.Collections.Generic;
using System.Text;

namespace TeacherStudent
{
    class Student
    {
        public string sName;

        public string SName { get => sName; private set => sName = value; }

        public Student(string sName)
        {
            SName = sName;
        }
        public void Learn()
        {
            Console.WriteLine("Student {0} learned something new.", this.SName);
        }
        public void Question(Teacher TName)
        {
            Console.WriteLine("Student {0}: I have a question, {1}.", this.SName, TName.tName);
            TName.Answer(this);
        }
    }
}
