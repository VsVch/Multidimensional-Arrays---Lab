using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] cubeMatrix = new int[n][];
            int sumGig = 0;

            for (int rowCol = 0; rowCol < n; rowCol++)
            {
                    cubeMatrix[rowCol] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray(); 
            }

            for (int i = 0; i < n; i++)
            {
                    sumGig += cubeMatrix[i][i];
            }

            Console.WriteLine(sumGig);
        }
    }
}
