using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2oop
{
    class User
    {
        protected string name;
        protected int age;

        public User(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return this.name;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
        public int GetAge()
        {
            return this.age;
        }

    }
}
