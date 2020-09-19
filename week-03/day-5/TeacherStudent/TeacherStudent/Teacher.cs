using System;
using System.Collections.Generic;
using System.Text;

namespace TeacherStudent
{
    class Teacher
    {
        public string tName;

        public string TName { get => tName; private set => tName = value; }

        public Teacher(string tName)
        {
            TName = tName;
        }
        public void Teach(Student SName)
        {
            Console.WriteLine("Teacher {0}: Learn this, {1}.", this.tName, SName.sName);
            SName.Learn();
        }
        public void Answer(Student SName)
        {
            Console.WriteLine("Teacher {0}: Here is an answer to your question, {1}.", this.tName, SName.sName);
        }
    }
}
