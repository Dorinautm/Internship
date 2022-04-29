using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2oop
{
    class Student : User
    {
        private string _scholarship;
        private string _course;
        public Student(string name, int age, string scholarship, string course) : base(name, age)
        {
            _scholarship = scholarship;
            _course = course;
        }

        public void DisplayUserDetails()
        {
            Console.WriteLine("scholarship: " + _scholarship);
            Console.WriteLine("course: " + _course);
        }
    }
}
