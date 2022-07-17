using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            int[,] matrix = new int[rows, cols];
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] inputMatrix = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < inputMatrix.Length; j++)
                {
                    matrix[i, j] = inputMatrix[j];
                }

            }
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                int sumCols = 0;
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    sumCols += matrix[j,i];
                }

                Console.WriteLine(sumCols);
            }
        }
    }
}
