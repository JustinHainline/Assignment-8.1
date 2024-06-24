using System.Runtime.CompilerServices;

namespace Assignment_8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 10, 7, 8, 9, 1, 5 };
            int N = array.Length;
            
            // Function Call
            QuickSort(array, 0, N - 1);
            Console.WriteLine("Sorted array:");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(array[i] + " ");
            }
        }
        static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
            
            // This function takes last element as pivot, 
            // places the pivot element at its correct position
            // in sorted array, and places all smaller to left
            // of pivot and all greater elements to right of pivot
        }
        static int Partition(int[] array, int low, int high)
        {   //Choosing the pivot
            int pivot = array[high];
            int i = (low - 1);  // index of smaller element and indicates the right position of pivot found so far

            for (int j = low; j <= high - 1; j++)
            {
                if (array[j] < pivot)  // if current element is smaller than the pivot
                {
                    i++;  // increment index of smaller element
                    Swap(array, i, j);
                }
            }
            Swap(array, i + 1, high);
            return (i + 1);
        }
        static void QuickSort(int[] array, int low , int high)  // array[] to be sorted, low starting index, high ending index
        {
            if (low < high)
            {
                int pi = Partition(array, low, high); // pi is partitioning index, array[p] is now at right place
                QuickSort(array, low, pi - 1);  // separately sort elements before and after partition index
                QuickSort(array, pi + 1, high);
            }
        }

    }
}
