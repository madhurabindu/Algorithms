using System;

namespace Algo.Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            QuickSort sort = new QuickSort();
            int[] input = new int[] { 60, 30, 20, 90, 50, 40, 80, 10, 70 };
            Console.WriteLine("\nInput");
            Array.ForEach(input, Console.WriteLine);

            Console.WriteLine("\nAscending");
            sort.SortAscending(input);
            Array.ForEach(input, Console.WriteLine);

            Console.WriteLine("\nDescending");
            sort.SortDescending(input);
            Array.ForEach(input, Console.WriteLine);
        }
    }
}
