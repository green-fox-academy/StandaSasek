using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Inheritance
{
    class Cohort
    {
        public string Name { get; private set; }
        public List<Student> Students { get; private set; }
        public List<Mentor> Mentors { get; private set; }
        public Cohort(string _name)
        {
            Name = _name;
            Students = new List<Student>();
            Mentors = new List<Mentor>();
        }
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }public void AddMentor(Mentor mentor)
        {
            Mentors.Add(mentor);
        }
        public void Info()
        {
            Console.WriteLine("The {0} cohort has {1} students and {2} mentors.", Name, Students.Count, Mentors.Count);
        }
    }
}
