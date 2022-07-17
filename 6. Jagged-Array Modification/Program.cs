using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] jaggedAray = new int[n][];
            for (int i = 0; i < n; i++)
            {
                jaggedAray[i] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            }
            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] inputArray = input.Split();
                string commmand = inputArray[0];
                int row = int.Parse(inputArray[1]);
                int col = int.Parse(inputArray[2]);
                int value = int.Parse(inputArray[3]);
                if (row < 0|| col < 0 ||row >= jaggedAray.Length || col >= jaggedAray[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else if (commmand == "Add")
                {
                    jaggedAray[row][col] += value;
                }
                else if (commmand == "Subtract")
                {
                    jaggedAray[row][col] -= value;
                }

                input = Console.ReadLine();
            }

            for (int row = 0; row < jaggedAray.Length; row++)
            {
                Console.WriteLine($"{String.Join(" ", jaggedAray[row])}");
            }


        }
    }
}
