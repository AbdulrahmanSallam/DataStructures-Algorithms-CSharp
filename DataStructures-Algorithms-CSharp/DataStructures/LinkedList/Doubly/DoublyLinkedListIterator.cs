using DataStructures_Algorithms_CSharp.DataStructures.LinkedList.Singly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms_CSharp.DataStructures.LinkedList.Doubly
{
    internal class DoublyLinkedListIterator
    {
        public DoublyLinkedListNode? CurrentNode { get; private set; }

        public DoublyLinkedListIterator(DoublyLinkedListNode node)
        {
            CurrentNode = node;
        }

        public int? Data()
        {
            return CurrentNode?.Data;
        }

        public void Next()
        {
            CurrentNode = CurrentNode?.Next;
        }


        public void Prev()
        {
            CurrentNode = CurrentNode?.Prev;
        }


    }
}
