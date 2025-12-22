using DataStructures_Algorithms_CSharp.Algorithms.Sorting;
using DataStructures_Algorithms_CSharp.DataStructures.Stack.Array;

namespace DataStructures_Algorithms_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region StackArrayBased
            //StackArray arr = new StackArray(4);

            //Console.WriteLine($"IsEmpty {arr.IsEmpty()}");

            //Console.WriteLine("push 1:5");

            //for (int i = 1; i <= 5; i++)
            //    arr.Push(i);

            //Console.WriteLine(arr.ToString());

            //Console.WriteLine("push 6");
            //arr.Push(6);

            //Console.WriteLine(arr.ToString());

            //for (int i = 1; i <= 7; i++)
            //    Console.WriteLine($"Pop {arr.Pop()}");

            //Console.WriteLine(arr.ToString());

            #endregion

            #region Datastructures

            #endregion


            #region Algorithms


            #region Sorting

            // Test arrays
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] arr2 = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] arr3 = { 64, 34, 25, 12, 22, 11, 90, 88, 75, 50 };
            int[] arr4 = { 5, 2, 8, 2, 9, 1, 5, 3, 5, 7 };
            int[] arr5 = { -5, 10, -3, 8, -1, 0, 4, -9, 7, 2 };
            int[] arr6 = { 7, 7, 7, 7, 7, 7, 7, 7, 7, 7 };
            int[] arr7 = { };
            int[] arr8 = { 42 };
            int[] arr9 = { Int32.MinValue, Int32.MaxValue, 0, -1000000, 1000000, 999, -999 };


            #region Insertion Sort
            Console.WriteLine("Insertion Sort");
            Sorting.InsertionSort(arr1);
            Sorting.InsertionSort(arr2);
            Sorting.InsertionSort(arr3);
            Sorting.InsertionSort(arr4);
            Sorting.InsertionSort(arr5);
            Sorting.InsertionSort(arr6);
            Sorting.InsertionSort(arr7);
            Sorting.InsertionSort(arr8);
            Sorting.InsertionSort(arr9);
            #endregion


            #region Merge Sort
            Console.WriteLine("Merge Sort");
            Sorting.MergeSort(arr1);
            Sorting.MergeSort(arr2);
            Sorting.MergeSort(arr3);
            Sorting.MergeSort(arr4);
            Sorting.MergeSort(arr5);
            Sorting.MergeSort(arr6);
            Sorting.MergeSort(arr7);
            Sorting.MergeSort(arr8);
            Sorting.MergeSort(arr9);

            #endregion

            // print arrays

            foreach (var item in arr1)
                Console.Write($"{item} ");
            Console.WriteLine();
            foreach (var item in arr2)
                Console.Write($"{item} ");
            Console.WriteLine();
            foreach (var item in arr3)
                Console.Write($"{item} ");
            Console.WriteLine();
            foreach (var item in arr4)
                Console.Write($"{item} ");
            Console.WriteLine();
            foreach (var item in arr5)
                Console.Write($"{item} ");
            Console.WriteLine();
            foreach (var item in arr6)
                Console.Write($"{item} ");
            Console.WriteLine();
            foreach (var item in arr7)
                Console.Write($"{item} ");
            Console.WriteLine();
            foreach (var item in arr8)
                Console.Write($"{item} ");
            Console.WriteLine();
            foreach (var item in arr9)
                Console.Write($"{item} ");
            Console.WriteLine();

            #endregion

            #endregion
        }
    }
}
