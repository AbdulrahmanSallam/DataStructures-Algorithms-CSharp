using DataStructures_Algorithms_CSharp.DataStructures.LinkedList.Singly;

namespace DataStructures_Algorithms_CSharp.DataStructures.LinkedList.Doubly
{
    internal class DoublyLinkedList
    {

        public DoublyLinkedListNode? Head { get; private set; }
        public DoublyLinkedListNode? Tail { get; private set; }

        public int Count { get; private set; } = 0;

        public void InsertFirst(int data)
        {

            if (Head is null)
            {
               InsertFirstNode(data);
                return;
            }

            var newNode = new DoublyLinkedListNode(data);
            Head.Prev = newNode;

            newNode.Next = Head;

            Head = newNode;

            Count++;
        }

        public void InsertLast(int data)
        {

            if (Head is null)
            {
                InsertFirstNode(data);
                return;
            }
            var newNode = new DoublyLinkedListNode(data);

            Tail!.Next = newNode;
            newNode.Prev = Tail;
            Tail = newNode;


            Count++;
        }

        private void InsertFirstNode(int data)
        {
            var newNode = new DoublyLinkedListNode(data);
            Head = Tail = newNode;
            Count++;
        }

        public void InsertBefore(int data , int newData)
        {

            if (Head is null) return;

            var current = FindNode(data);

            if (current is null) return;


            if (current == Head ) InsertFirst(newData);
            else
            {
                InsertBetweenNodes(newData, current.Prev, current);
            }

        }

        public void InsertAfter(int data, int newData)
        {

            if (Head is null) return;

            var current = FindNode(data);

            if (current is null) return;


            if (current == Tail) InsertLast(newData);
            else
            {
                InsertBetweenNodes(newData, current, current.Next);
            }

        }

        private void InsertBetweenNodes(int data, DoublyLinkedListNode first, DoublyLinkedListNode second)
        {
            var newNode = new DoublyLinkedListNode(data);

            newNode.Prev = first;
            newNode.Next = second;

            first.Next = newNode;
            second.Prev = newNode;

            Count++;
        }


        public void Delete(int data)
        {
            var current = FindNode(data);

            if (current == null) return;

            if (current == Head) DeleteFirst();
            else if (current == Tail) DeleteLast();
            else DeleteMiddleNode(current);

        }

        public void DeleteFirst()
        {
            if (Head == null) return;

            if (Head.Next == null)
            {
            Head = Tail= null;
            }
            else
            {
                Head = Head.Next;
                Head.Prev = null;
            }
            Count--;
        }

        public void DeleteLast()
        {
            if (Tail == null) return;

            if (Tail.Prev == null)
            {
                Head = Tail = null;

            }
            else
            {
                Tail = Tail.Prev;
                Tail.Next = null;
            }

            Count--;
        }

        private void DeleteMiddleNode(DoublyLinkedListNode node)
        {
            var prev = node.Prev;
            var next = node.Next;

            prev.Next = next;
            next.Prev = prev;

            Count--;
        }

        private DoublyLinkedListNode? FindNode(int data)
        {
            if (Head is null) return null;

            DoublyLinkedListIterator? current = new DoublyLinkedListIterator(Head);

            while (current.CurrentNode is not null)
            {
                if (current.Data() == data)
                {
                    return current.CurrentNode;
                }
                current.Next();
            }
            return null;
        }

    }
}
