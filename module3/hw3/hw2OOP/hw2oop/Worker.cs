using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2oop
{
    class Worker
    {
        private string _name;
        private int _salary;

        public Worker(string name, int salary)
        {
            _name = name;
            _salary = salary;
        }
        public void Print()
        {
            Console.WriteLine("lala" + _name);
        }
        public string GetName()
        {
            return _name;
        }
        public int GetSalary()
        {
            return _salary;
        }
    }
}
