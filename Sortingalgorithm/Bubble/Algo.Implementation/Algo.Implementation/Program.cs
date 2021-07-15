using System;

namespace Algo.Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            BubbleSort sort = new BubbleSort();
            int[] input = new int[] { 60, 30, 20, 10, 50, 40 };
            Console.WriteLine("Input");
            Array.ForEach(input, Console.WriteLine);

            Console.WriteLine("Ascending");
            sort.SortAscending(input);
            Array.ForEach(input, Console.WriteLine);

            Console.WriteLine("Descending");
            sort.SortDescending(input);
            Array.ForEach(input, Console.WriteLine);
        }
    }
}
