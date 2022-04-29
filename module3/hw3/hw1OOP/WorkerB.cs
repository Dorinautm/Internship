using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1OOP
{
    class WorkerB
    {
        private string _name;
        private int _age;
        private int _salary;

        public void SetName(string name)
        {
            _name = name;
        }
        public string GetName()
        {
            return _name;
        }
        public void SetAge(int age)
        {
            bool valide_age = CheckAge(age);
            if (valide_age)
            {
                _age = age;
            }
            else
            {
                Console.WriteLine("Not a valid age");
            }           
        }
        public int GetAge()
        {
            return _age;
        }
        public void SetSalary(int salary)
        {
            _salary = salary;
        }
        public int GetSalary()
        {
            return _salary;
        }

        private bool CheckAge(int age)
        {
            if (age >= 1 && age <= 100)
            {
                return true;
            }
            else return false;
        }
    }
}
