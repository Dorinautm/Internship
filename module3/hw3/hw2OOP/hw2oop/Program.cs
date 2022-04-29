using System;

namespace hw2oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker1 = new Worker("John", 1000);
            Console.WriteLine(worker1.GetName());
            Console.WriteLine(worker1.GetSalary());

            WorkerB worker1B = new WorkerB("Ivan", 25, 1000);
            WorkerB worker2B = new WorkerB("Vasya", 26, 2000);
            Console.WriteLine(worker1B.GetSalary() + worker2B.GetSalary());

            Student student = new Student("Ivan", 25, "Xscholarship", "Arts" );
            student.DisplayUserDetails();
        }
    }
}
