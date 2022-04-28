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
        }
    }
}
