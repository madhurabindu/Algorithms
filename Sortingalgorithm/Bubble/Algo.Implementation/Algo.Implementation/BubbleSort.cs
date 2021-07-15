using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo.Implementation
{
    public class BubbleSort
    {
        public int[] SortAscending(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 1; j < input.Length; j++)
                {
                    if (input[j] < input[j-1]){
                        Swap(ref input, j, j-1);
                    }
                }
            }
            return input;
        }

        public int[] SortDescending(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 1; j < input.Length; j++)
                {
                    if (input[j] > input[j - 1])
                    {
                        Swap(ref input, j, j - 1);
                    }
                }
            }
            return input;
        }

        private void Swap(ref int[] input, int i, int j)
        {
            int temp = input[i];
            input[i] = input[j];
            input[j] = temp;
        }
    }
}
