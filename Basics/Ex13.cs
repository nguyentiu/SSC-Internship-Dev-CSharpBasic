using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Exercises.Basics
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }
        public void Study()
        {
            Console.WriteLine(Name + " is studying.");
        }

        public void TakeExam()
        {
            Console.WriteLine(Name + " is taking an exam.");
        }
    }
    internal class Ex13
    {
        public static void Run()
        {
            Student student = new Student
            {
                Name = "Alice",
                Age = 20,
                Grade = "A"
            };

            student.Study();
            student.TakeExam();
        }

    }
}
