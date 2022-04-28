using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1OOP
{
    class Matrix
    {       
        private int first_diagonal = 0;
        private int second_diagonal = 0;

        public void GetSum_firstDiagonal(int [,] matrixOfIntegers)
        {
            if (matrixOfIntegers.GetLength(0) == matrixOfIntegers.GetLength(1))
            {
                for (int i = 0; i < matrixOfIntegers.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixOfIntegers.GetLength(1); j++)
                    {
                        if (i == j)
                        {
                            first_diagonal += matrixOfIntegers[i, j];
                        }
                    }
                }
                Console.WriteLine("First diagonal " + first_diagonal);
            }
            else
            {
                Console.WriteLine("Matrix doesn't have diagonals");
            }
        }
        public void GetSum_secondDiagonal(int[,] matrixOfIntegers)
        {
            if (matrixOfIntegers.GetLength(0) == matrixOfIntegers.GetLength(1))
            {
                for (int i = 0; i < matrixOfIntegers.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixOfIntegers.GetLength(1); j++)
                    {
                        if ((i + j) == (matrixOfIntegers.GetLength(1) - 1))
                        {
                            second_diagonal += matrixOfIntegers[i, j];
                        }
                    }
                }
                Console.WriteLine("First diagonal " + second_diagonal);
            }
            else
            {
                Console.WriteLine("Matrix doesn't have diagonals");
            }
        }
    }
}
