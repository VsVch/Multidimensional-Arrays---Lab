using System;

namespace _05.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            long[][] triangle = new long[n][];
            triangle[0] = new long[1] { 1 };
            for (long row = 1; row < n; row++)
            {
                
                triangle[row] = new long[triangle[row - 1].Length + 1];
                for (long col = 0; col < triangle[row].Length; col++)
                {
                    if (triangle[row - 1].Length > col)
                    {
                        triangle[row][col] += triangle[row - 1][col];
                    }
                    if (col > 0)
                    {
                        triangle[row][col] += triangle[row - 1][col - 1];
                    }
                }
            }

            for (long row = 0; row < triangle.Length; row++)
            {
                Console.WriteLine($"{String.Join(" ", triangle[row])}");
            }
        }

        
    }
}