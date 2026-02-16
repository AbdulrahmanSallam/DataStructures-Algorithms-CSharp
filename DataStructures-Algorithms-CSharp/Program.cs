using DataStructures_Algorithms_CSharp.Algorithms.Sorting;
using DataStructures_Algorithms_CSharp.DataStructures.LinkedList.Doubly;
using DataStructures_Algorithms_CSharp.DataStructures.LinkedList.Singly;
using DataStructures_Algorithms_CSharp.DataStructures.Stack.Array;

namespace DataStructures_Algorithms_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {



            #region Datastructures

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


            #region SinglyLinkedList


            //Console.WriteLine("=== Testing Singly Linked List Implementation ===\n");

            //// Test 1: Create empty list
            //Console.WriteLine("Test 1: Creating empty list");
            //SinglyLinkedList list = new SinglyLinkedList();


            //Console.WriteLine("Empty list");
            //list.Print();

            //Console.WriteLine($"Head: {list.Head?.Data ?? null}, Tail: {list.Tail?.Data ?? null}\n");

            //// Test 2: Insert First
            //Console.WriteLine("Test 2: Insert First Operations");
            //list.InsertFirst(30);
            //Console.WriteLine("After InsertFirst(30)");
            //list.Print();

            //list.InsertFirst(20);
            //Console.WriteLine("After InsertFirst(20)");
            //list.Print();

            //list.InsertFirst(10);
            //Console.WriteLine("After InsertFirst(10)");            
            //Console.WriteLine($"Head: {list.Head?.Data}, Tail: {list.Tail?.Data}\n");
            //list.Print();

            //// Test 3: Insert Last
            //Console.WriteLine("Test 3: Insert Last Operations");
            //list.InsertLast(40);
            //Console.WriteLine("After InsertLast(40)");
            //list.Print();

            //list.InsertLast(50);
            //Console.WriteLine("After InsertLast(50)");            
            //list.Print();

            //Console.WriteLine($"Head: {list.Head?.Data}, Tail: {list.Tail?.Data}\n");

            //// Test 4: Insert After
            //Console.WriteLine("Test 4: Insert After Operations");
            //list.InsertAfter(20, 25);
            //Console.WriteLine("After InsertAfter(20, 25)");
            //list.Print();

            //list.InsertAfter(50, 55);
            //Console.WriteLine("After InsertAfter(50, 55) - after tail");
            //list.Print();

            //list.InsertAfter(99, 1000);
            //Console.WriteLine("After InsertAfter(99, 1000) - non-existent (should not change)");
            //list.Print();

            //Console.WriteLine($"Head: {list.Head?.Data}, Tail: {list.Tail?.Data}\n");
            //// Test 5: Insert Before
            //Console.WriteLine("Test 5: Insert Before Operations");
            //list.InsertBefore(20, 15);
            //Console.WriteLine("After InsertBefore(20, 15)");
            //list.Print();

            //list.InsertBefore(10, 5);
            //Console.WriteLine("After InsertBefore(20, 15)");
            //list.Print();


            //list.InsertBefore(999, 1000);
            //Console.WriteLine("After InsertBefore(999, 1000) - non-existent (should not change)");
            //list.Print();

            //Console.WriteLine($"Head: {list.Head?.Data}, Tail: {list.Tail?.Data}\n");
            //// Test 6: Delete Operations
            //Console.WriteLine("Test 6: Delete Operations");

            //// Delete head
            //list.DeleteNode(5);
            //Console.WriteLine("After DeleteNode(5) - delete head");
            //list.Print();

            //Console.WriteLine($"Head: {list.Head?.Data}, Tail: {list.Tail?.Data}");

            //// Delete tail
            //list.DeleteNode(55);
            //Console.WriteLine("After DeleteNode(55) - delete tail");
            //list.Print();           
            //Console.WriteLine($"Head: {list.Head?.Data}, Tail: {list.Tail?.Data}");

            //// Delete middle
            //list.DeleteNode(25);
            //Console.WriteLine("After DeleteNode(25) - delete middle");
            //list.Print();

            //// Delete non-existent
            //list.DeleteNode(999);

            //Console.WriteLine("After DeleteNode(999) - non-existent");
            //list.Print();
            //Console.WriteLine($"Head: {list.Head?.Data}, Tail: {list.Tail?.Data}\n");

            //// Test 7: Single element list
            //Console.WriteLine("Test 7: Single Element List Operations");
            //SinglyLinkedList singleList = new SinglyLinkedList();
            //singleList.InsertFirst(42);
            //Console.WriteLine("Single element list");
            //singleList.Print();


            //// Insert after on single element
            //singleList.InsertAfter(42, 43);
            //Console.WriteLine("AfterInsertAfter(42, 43)");
            //singleList.Print();
            //// Insert before on single element
            //singleList.InsertBefore(42, 41);
            //Console.WriteLine("After InsertBefore(42, 41)");
            //singleList.Print();

            //// Delete the single element
            //singleList.DeleteNode(41);
            //singleList.Print();
            //Console.WriteLine($"Head: {singleList.Head?.Data}, Tail: {singleList.Tail?.Data}\n");

            //// Test 8: Edge cases with duplicates
            //Console.WriteLine("Test 8: Duplicate Values");
            //SinglyLinkedList dupList = new SinglyLinkedList();
            //dupList.InsertLast(10);
            //dupList.InsertLast(20);
            //dupList.InsertLast(20);
            //dupList.InsertLast(30);
            //dupList.Print();

            //dupList.InsertAfter(20, 25);
            //dupList.Print();

            //dupList.InsertBefore(20, 15);
            //dupList.Print();

            //dupList.DeleteNode(20);
            //dupList.Print();
            //Console.WriteLine();

            //// Test 9: Complete sequence
            //Console.WriteLine("Test 9: Complete Sequence Test");
            //SinglyLinkedList finalList = new SinglyLinkedList();
            //Console.WriteLine("Step 1: InsertFirst 3, 2, 1");
            //finalList.InsertFirst(3);
            //finalList.InsertFirst(2);
            //finalList.InsertFirst(1);
            //finalList.Print();

            //Console.WriteLine("\nStep 2: InsertLast 4, 5");
            //finalList.InsertLast(4);
            //finalList.InsertLast(5);
            //finalList.Print();

            //Console.WriteLine("\nStep 3: InsertAfter 3, 35");
            //finalList.InsertAfter(3, 35);
            //finalList.Print();

            //Console.WriteLine("\nStep 4: InsertBefore 2, 15");
            //finalList.InsertBefore(2, 15);
            //finalList.Print();

            //Console.WriteLine("\nStep 5: Delete head (1), middle (35), tail (5)");
            //finalList.DeleteNode(1);
            //finalList.DeleteNode(35);
            //finalList.DeleteNode(5);
            //finalList.Print();
            //Console.WriteLine($"Final Head: {finalList.Head?.Data}, Final Tail: {finalList.Tail?.Data}");

            #endregion


            #region DoublyLinkeList
            //var list = new DoublyLinkedList();

            //list.InsertFirst(10);
            //list.InsertLast(20);
            //list.InsertLast(30);
       
            //list.Print(list.Head);

            #endregion


            #endregion

            #region Algorithms


            #region Sorting

            // Test arrays
            //int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] arr2 = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            //int[] arr3 = { 64, 34, 25, 12, 22, 11, 90, 88, 75, 50 };
            //int[] arr4 = { 5, 2, 8, 2, 9, 1, 5, 3, 5, 7 };
            //int[] arr5 = { -5, 10, -3, 8, -1, 0, 4, -9, 7, 2 };
            //int[] arr6 = { 7, 7, 7, 7, 7, 7, 7, 7, 7, 7 };
            //int[] arr7 = { };
            //int[] arr8 = { 42 };
            //int[] arr9 = { Int32.MinValue, Int32.MaxValue, 0, -1000000, 1000000, 999, -999 };


            #region Insertion Sort
            //Console.WriteLine("Insertion Sort");
            //Sorting.InsertionSort(arr1);
            //Sorting.InsertionSort(arr2);
            //Sorting.InsertionSort(arr3);
            //Sorting.InsertionSort(arr4);
            //Sorting.InsertionSort(arr5);
            //Sorting.InsertionSort(arr6);
            //Sorting.InsertionSort(arr7);
            //Sorting.InsertionSort(arr8);
            //Sorting.InsertionSort(arr9);
            #endregion


            #region Merge Sort
            //Console.WriteLine("Merge Sort");
            //Sorting.MergeSort(arr1);
            //Sorting.MergeSort(arr2);
            //Sorting.MergeSort(arr3);
            //Sorting.MergeSort(arr4);
            //Sorting.MergeSort(arr5);
            //Sorting.MergeSort(arr6);
            //Sorting.MergeSort(arr7);
            //Sorting.MergeSort(arr8);
            //Sorting.MergeSort(arr9);

            #endregion

            // print arrays

            //foreach (var item in arr1)
            //    Console.Write($"{item} ");
            //Console.WriteLine();
            //foreach (var item in arr2)
            //    Console.Write($"{item} ");
            //Console.WriteLine();
            //foreach (var item in arr3)
            //    Console.Write($"{item} ");
            //Console.WriteLine();
            //foreach (var item in arr4)
            //    Console.Write($"{item} ");
            //Console.WriteLine();
            //foreach (var item in arr5)
            //    Console.Write($"{item} ");
            //Console.WriteLine();
            //foreach (var item in arr6)
            //    Console.Write($"{item} ");
            //Console.WriteLine();
            //foreach (var item in arr7)
            //    Console.Write($"{item} ");
            //Console.WriteLine();
            //foreach (var item in arr8)
            //    Console.Write($"{item} ");
            //Console.WriteLine();
            //foreach (var item in arr9)
            //    Console.Write($"{item} ");
            //Console.WriteLine();

            #endregion


            #endregion

        }
    }
}