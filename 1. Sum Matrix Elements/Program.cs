using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int raws = input[0];
            int cols = input[1];
            int[,] matrix = new int[raws, cols];
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] inputMatrix = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < inputMatrix.Length; j++)
                {
                    matrix[i, j] = inputMatrix[j];
                }


            }
            for (int i = 0; i < raws; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sum += matrix[i, j];
                }
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
