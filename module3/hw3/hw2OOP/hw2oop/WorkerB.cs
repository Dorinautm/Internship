using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2oop
{
    class WorkerB : User
    {
        private int _salary;

        public WorkerB(string name, int age, int salary) : base(name, age)
        {
            _salary = salary;
        }
        public void SetSalary(int salary)
        {
            _salary = salary;
        }
        public int GetSalary()
        {
            return _salary;
        }
    }
}
