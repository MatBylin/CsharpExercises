using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTeacher
{
    class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {
            //Create person
            var person = new Person();
            person.Hello();

            //Create student
            var student = new Student();
            student.SetAge(21);
            student.Hello();
            student.ShowAge();

            //Create teacher
            var teacher = new Teacher();
            teacher.SetAge(30);
            teacher.Hello();
            teacher.Explain();

            Console.Read();
        }
    }

    class Person
    {
        protected int age;

        public void SetAge(int n)
        {
            age = n;
        }

        public void Hello()
        {
            Console.WriteLine("Hello!");
        }
    }

    class Student : Person
    {
        public void GoToClasses()
        {
            Console.WriteLine("I'm going to class.");
        }

        public void ShowAge()
        {
            Console.WriteLine("My age is {0} years old.", age);
        }
    }

    class Teacher : Person
    {
        private string _subject;

        public void Explain()
        {
            Console.WriteLine("Explanation begins.");
        }
    }
    

}
