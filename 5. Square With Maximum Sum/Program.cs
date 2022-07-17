using System;
using System.Linq;

namespace _03.BiggestSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int biggestSquareRows = 2;
            int biggestSquareCols = 2;

            int[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] inputMatrix = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < inputMatrix.Length; col++)
                {
                    matrix[row, col] = inputMatrix[col];
                }
            }

            int maxSum = int.MinValue;
            int rowIndex = 0;
            int colIndex = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (row + biggestSquareRows - 1 < rows && col + biggestSquareCols - 1 < cols)
                    {
                        int sum = 0;
                        for (int currentRow = row; currentRow < row + biggestSquareRows; currentRow++)
                        {
                            for (int currontCol = col; currontCol < col + biggestSquareCols; currontCol++)
                            {
                                sum += matrix[currentRow, currontCol];
                            }
                        }


                        if (sum > maxSum)
                        {
                            maxSum = sum;
                            colIndex = col;
                            rowIndex = row;
                        }
                    }


                }
            }


            for (int row = rowIndex; row < rowIndex + biggestSquareRows; row++)
            {
                for (int col = colIndex; col < colIndex + biggestSquareCols; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine(maxSum);
        }
    }
}