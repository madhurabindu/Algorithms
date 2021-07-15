using System;

namespace Algo.Implementation
{
    public class QuickSort
    {
        public int[] SortAscending(int[] input)
        {
            int low = 0;
            int high = input.Length - 1;
            InternalQuickSort(input, low, high, true);
            return input;
        }

        public int[] SortDescending(int[] input)
        {
            int low = 0;
            int high = input.Length - 1;
            InternalQuickSort(input, low, high, false);
            return input;
        }

        private int PartitionOnHighPivotAsc(int[] input, int low, int high)
        {
            int pivot = input[high];
            int pivotIndex = high;
            int index = -1;
            for (int i = 0; i < input.Length-1; i++)
            {
                // check if input[i] is less than pivot value, if yes, them move them to left
                if(input[i] < pivot)
                {
                    index++;
                    Swap(ref input, index, i);
                }
            }
            // found the right position for pivot
            index++;
            Swap(ref input, index, pivotIndex);

            return index;
        }
        private int PartitionOnHighPivotDesc(int[] input, int low, int high)
        {
            int pivot = input[high];
            int pivotIndex = high;
            int index = -1;
            for (int i = 0; i < input.Length - 1; i++)
            {
                // check if input[i] is less than pivot value, if yes, them move them to left
                if (input[i] > pivot)
                {
                    index++;
                    Swap(ref input, index, i);
                }
            }
            // found the right position for pivot
            index++;
            Swap(ref input, index, pivotIndex);

            return index;
        }
        private void InternalQuickSort(int[] input, int low, int high, bool ascending)
        {
            int index = ascending? PartitionOnHighPivotAsc(input, low, high) : PartitionOnHighPivotDesc(input, low, high);
            if (index > 0)
            {
                InternalQuickSort(input, low, index - 1, ascending);
            }

            if (index < high)
            {
                InternalQuickSort(input, index + 1, high, ascending);
            }
        }


        private void Swap(ref int[] input, int i, int j)
        {
            int temp = input[i];
            input[i] = input[j];
            input[j] = temp;
        }
    }
}
