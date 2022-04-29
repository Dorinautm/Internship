using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1OOP
{
    class Matrix
    {       
        private int _first_diagonal;
        private int _second_diagonal;
        private bool _isSquare;

        public bool IsSquare(int[,] matrixOfIntegers)
        {
            if (matrixOfIntegers.GetLength(0) == matrixOfIntegers.GetLength(1))
            {
                return true;
            }
            return false;
        }
        public void GetSum_firstDiagonal(int [,] matrixOfIntegers)
        {
            if (IsSquare(matrixOfIntegers))
            {
                for (int i = 0; i < matrixOfIntegers.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixOfIntegers.GetLength(1); j++)
                    {
                        if (i == j)
                        {
                            _first_diagonal += matrixOfIntegers[i, j];
                        }
                    }
                }
                Console.WriteLine("First diagonal " + _first_diagonal);
            }
        }

        public void GetSum_secondDiagonal(int[,] matrixOfIntegers)
        {
            if (IsSquare(matrixOfIntegers))
            {
                for (int i = 0; i < matrixOfIntegers.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixOfIntegers.GetLength(1); j++)
                    {
                        if ((i + j) == (matrixOfIntegers.GetLength(1) - 1))
                        {
                            _second_diagonal += matrixOfIntegers[i, j];
                        }
                    }
                }
                Console.WriteLine("Second diagonal " + _second_diagonal);
            }
        }
        public void IsSquare()
        {
            if (_isSquare == false)
            {
                Console.WriteLine("Matrix doesn't have diagonals");
            }
        }
    }
}
