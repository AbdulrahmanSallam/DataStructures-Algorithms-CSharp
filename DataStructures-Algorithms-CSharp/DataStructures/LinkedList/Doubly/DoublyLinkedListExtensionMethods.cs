using DataStructures_Algorithms_CSharp.DataStructures.LinkedList.Singly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms_CSharp.DataStructures.LinkedList.Doubly
{
    static class DoublyLinkedListExtensionMethods
    {

        public static void Print(this DoublyLinkedList linkedList, DoublyLinkedListNode head)
        {
            Console.WriteLine($"head : {linkedList.Head?.Data}");
            Console.WriteLine($"tail : {linkedList.Tail?.Data}");

            Console.Write("list : ");
            for (DoublyLinkedListIterator i = new(head); i.CurrentNode is not null; i.Next())
            {
                Console.Write("{0} ", i.Data());
            }
            Console.WriteLine($"\nCount : {linkedList.Count}");

            Console.WriteLine("-----------------------------");
        }
    }
}
