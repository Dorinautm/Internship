using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace C_Sharp_Lesson_3_Homework
{
    public class Homework
    {
        public void GetCentralElementFromMatrix(int[,] matrixOfIntegers)
        {
            /*print to console the central element from matrixOfIntegers, if not exist print: "This matrix doesn't have a central element"
             * |   input           | result             |
             * |-------------------|--------------------|
             * | {                 |                    |
             * |  { 1,   3,  5},   |    The central     |
             * |  {-1, 100, 11},   |  element is 100    |
             * |  { 2,  15, 44}    |                    |
             * |  }                |                    |
             * |----------------------------------------|
             * |{                  |                    |
             * | { 1,  6, 21,  8 },| This matrix doesn't|
             * | { 5, -4,  5,  7 },| have a central     |
             * | {77,  5,  0, 74 } |  element           |
             * | }                 |                    |
             * ------------------------------------------
             *    
             */
            //your code here
   
            // Check the matrix is square
            if (matrixOfIntegers.GetLength(0) == matrixOfIntegers.GetLength(1))
            {
                // Check the matrix has a center element
                if (matrixOfIntegers.GetLength(0) % 2 != 0)
                {
                    int central_row = matrixOfIntegers.GetLength(0) / 2;
                    Console.WriteLine(matrixOfIntegers[central_row, central_row]);
                }
                else
                {
                    Console.WriteLine("Matrix doesn't have a central element");
                }
            }
            else
            {
                Console.WriteLine("Matrix is not square");
            }
        }
     

        public void GetSummOfDiagonalsElements(int[,] matrixOfIntegers)
        {
            /*print to console the central element from matrixOfIntegers, if not exist print: "This matrix doesn't have a central element"
             * |   input           | result              |
             * |-------------------|---------------------|
             * | {                 |                     |
             * |  { 1,   3,  5},   | First diagonal: 145 |
             * |  {-1, 100, 11},   | Second diagonal: 107|
             * |  { 2,  15, 44}    |                     |
             * |  }                |                     |
             * |-----------------------------------------|
             * |{                  |                     |
             * | { 1,  6, 21,  8 },| This matrix doesn't |
             * | { 5, -4,  5,  7 },| have a diagonals    |
             * | {77,  5,  0, 74 } |                     |
             * | }                 |                     |
             * ------------------------------------------
             *    
             */
   
            int first_diagonal = 0;
            int second_diagonal = 0;

            if (matrixOfIntegers.GetLength(0) == matrixOfIntegers.GetLength(1))
            {
                for (int i = 0; i < matrixOfIntegers.GetLength(0); i++)
                {
                    for(int j = 0; j < matrixOfIntegers.GetLength(1); j++)
                    {
                        if (i == j)
                        {
                            first_diagonal += matrixOfIntegers[i, j];
                        }
                        if ((i+j) == (matrixOfIntegers.GetLength(1) - 1))
                        {
                            second_diagonal += matrixOfIntegers[i, j];
                        }
                    }
                }
                Console.WriteLine("First diagonal " + first_diagonal);
                Console.WriteLine("Second diagonal " + second_diagonal);
            }
            else
            {
                Console.WriteLine("Matrix doesn't have diagonals");
            }
        }
        public void StarPrinter(int triangleHight)
        {
            /* Write a programm that will print a triagle of stars  with hight = triangleHight
             *  Example: triangleHight = 3;
             *  Result:   *
             *           * *
             *          * * * 
             */
            int count = triangleHight - 1;
            for (int j = 1; j <= triangleHight; j++)
            {
                for (int i = 1; i <= count; i++) {
                    Console.Write(" ");
                }    
                count--;
                for (int i = 1; i <= j; i++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
            public void SortList(IList<int> listOfNumbers)
        {
            //Print to console elements of  listOfNumbers in ascending order
            //your code here
            //int temp;
            for (int i = 0; i < listOfNumbers.Count; i++)
                for (int j = i + 1; j < listOfNumbers.Count; j++)
                    if (listOfNumbers[i] > listOfNumbers[j])
                    {
                        int temp = listOfNumbers[i];
                        listOfNumbers[i] = listOfNumbers[j];
                        listOfNumbers[j] = temp;
                    }
            for (int j = 0; j < listOfNumbers.Count; j++)
            {
                Console.WriteLine(listOfNumbers[j]);
            }
        }
        public static void Main(String[] args)
        {
            Homework homework = new Homework();
            IList<int> list = new List<int>() { -5, 8, -7, 0, 44, 121, -8};
            int[,] matrix = new int[3, 3] {
                { 1,   3,  5},
                { 2, 3, 5},
                {100, 56 , -54} };
            int[,] matrix2 = new int[3, 4] {
                { 1,   3,  5,   6},
                { 2,   3,  5,  78},
                {100, 56 , -54, 6} };

            homework.GetCentralElementFromMatrix(matrix);
            homework.GetCentralElementFromMatrix(matrix2);
            homework.GetSummOfDiagonalsElements(matrix);
            homework.GetSummOfDiagonalsElements(matrix2);
            homework.StarPrinter(5);
            homework.SortList(list);

            Console.WriteLine("--------------------------------------------");

            /*int[] nr_list = new int[] { 1, 2, 3 };
            List<int> list2 = new();
            IList<int> list3 = new List<int>() { -5, 8, -7, 0, 44, 121, -8 };

            ArrayList arr_list = new ArrayList();
            arr_list.Add("billie");
            arr_list.Add(12);
            string first_element1 = (string)arr_list[0];
            arr_list.Insert(2, 2.3);

            SortedList<int, string> sorted_list = new SortedList<int, string>();
            sorted_list.Add(2, "Two");
            sorted_list.Add(4, null);

            IDictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Two");
            dict.Add(2, "Three");
            dict.Remove(1);
            dict.Add(3, "Four");
            dict[3] = "444";
            for (int i = 0; i < dict.Count; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}",
                                                        dict.ElementAt(i).Key,
                                                        dict.ElementAt(i).Value);
            }

            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "one");
            hashtable.Add(2, "two");
            foreach (DictionaryEntry de in hashtable)
            {
                Console.WriteLine(de.Value);
            }

            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            if (stack.Count > 0)
            {
                Console.WriteLine(stack.Peek());
            }
            foreach (int i in stack)
                Console.WriteLine(i);

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("A");
            queue.Enqueue("B");
            queue.Dequeue();
            foreach (var i in queue)
                Console.WriteLine(i);*/


            /*list2.Add(9);
            list2.Add(1);
            list2.Add(5);
            list2.Insert(3,2);
            //list2.Remove(9);
            Console.WriteLine(list2.IndexOf(5));
            list2.Sort();
            //list2.Reverse();
            int x = list2.Count();
            Console.WriteLine(x);
            Console.WriteLine(list2.GetHashCode());*/

            /*Console.WriteLine(nr_list[0]);
            nr_list[2] = -2;
            Console.WriteLine(nr_list.Length);
            Console.WriteLine(nr_list.GetHashCode());
            Console.WriteLine(nr_list.Sum());
            Array.Sort(nr_list);*/
            //Array.Reverse(nr_list);

            /*foreach (var i in arr_list)
            {
                Console.WriteLine(i);
            }*/


        }

    }
}