using System;

namespace LearningArrays
{
    class Program
    {
        static void Main(string[] args)
        {
           string [] Part1 = {"Item1", "Item2", "Item3", "Item4", "Item5"};

            for (int i = 0; i < 5; i++)
            Console.WriteLine(Part1[i]);

            // or
            // foreach (string j in Part1)
            //{
            //Console.WriteLine(string[j]
            //}

            int[] Part2 = new int [] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            Array.Reverse(Part2);

            foreach (int k in Part2)
            {
                Console.Write(k + " ");
            }
        }
    }
}
