using System;

namespace TeacherStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            // Teacher Student
            /*Create Student and Teacher classes
            Student
            learn()->prints the student is learning something new
            question(teacher)->calls the teachers answer method
            Teacher
            teach(student)->calls the students learn method
            answer()->prints the teacher is answering a question
            Instantiate a Student and Teacher object
            Call the student's question() method and the teacher's teach() method*/

            Student filip = new Student("Filip");
            Student jakob = new Student("Jakob");
            Student peter = new Student("Peter");

            Teacher jackson = new Teacher("Mrs. Jackson");
            Teacher robinsson = new Teacher("Mr. Robinsson");
            Teacher black = new Teacher("Mr. Black");



            filip.Question(robinsson);

            robinsson.Teach(filip);

            jackson.Teach(peter);

            peter.Question(jackson);


        }
    }
}
