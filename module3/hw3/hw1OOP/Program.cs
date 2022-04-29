using System;

namespace hw1OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = new int[3, 3] {
                { 1,   3,  5},
                { 2, 3, 5},
                {100, 56 , -54} };
            int[,] matrix2 = new int[3, 4] {
                { 1,   3,  5,   6},
                { 2,   3,  5,  78},
                {100, 56 , -54, 6} };

            Matrix matrix = new Matrix();
            matrix.GetSum_firstDiagonal(matrix1);
            matrix.GetSum_secondDiagonal(matrix1);
            matrix.GetSum_firstDiagonal(matrix2);
            matrix.IsSquare();

            Console.WriteLine("--------------------------------ex1");

            Worker worker1 = new Worker
            {
                name = "John",
                age = 25,
                salary = 1000
            };

            Worker worker2 = new Worker
            {
                name = "Sam",
                age = 26,
                salary = 2000
            };

            Console.WriteLine("Sum of workers age is " + (worker1.age + worker2.age));
            Console.WriteLine("Sum of workers salary is " + (worker1.salary + worker2.salary));

            Console.WriteLine("--------------------------------ex2");

            WorkerB worker1B = new WorkerB();
            worker1B.SetName("John");
            worker1B.SetSalary(1000);
            worker1B.SetAge(25);
            
            WorkerB worker2B = new WorkerB();
            worker2B.SetName("Sam");
            worker2B.SetSalary(2000);
            worker2B.SetAge(26);

            Console.WriteLine("Sum of workers salary is " + (worker1B.GetSalary() + worker2B.GetSalary()));
            Console.WriteLine("Sum of workers age is " + (worker1B.GetAge() + worker2B.GetAge()));
            
            Console.WriteLine("--------------------------------ex3");

            WorkerB worker3B = new WorkerB();
            worker3B.SetAge(-1);
            Console.WriteLine(worker3B.GetAge());

            WorkerB worker4B = new WorkerB();
            worker4B.SetAge(1000);
            Console.WriteLine(worker4B.GetAge());


        }
    }
}
