namespace DataStructures_Algorithms_CSharp.DataStructures.LinkedList.Singly
{
    internal class SinglyLinkedList
    {

        public SinglyLinkedListNode? Head { get; private set; }
        public SinglyLinkedListNode? Tail { get; private set; }


        public SinglyLinkedList()
        {
            Head = Tail = null;
        }


        public void InsertFirst(int newData)
        {
            SinglyLinkedListNode newNode = new(newData);

            if (Head is null)
            {
                Head = Tail = newNode;
                return;
            }

            newNode!.Next = Head;
            Head = newNode;

        }

        public void InsertLast(int newData)
        {
            SinglyLinkedListNode newNode = new(newData);

            if (Head is null)
            {
                Head = Tail = newNode;
                return;
            }

            Tail!.Next = newNode;
            Tail = newNode;

        }

        public void InsertAfter(int data, int newData)
        {
            if (Head is null) return;


            if (Tail!.Data == data)
            {
                InsertLast(newData);
                return;
            }

            SinglyLinkedListNode? node = FindNode(data);
            if (node is null) return;


            SinglyLinkedListNode newNode = new(newData);

            newNode.Next = node.Next;
            node.Next = newNode;
        }

        public void InsertBefore(int data, int newData)
        {
            if (Head is null) return;

            if (Head.Data == data)
            {
                InsertFirst(newData);
                return;
            }

            SinglyLinkedListNode? beforeNode = FindNodeBefore(data);
            if (beforeNode is null) return;

            SinglyLinkedListNode newNode = new(newData);
            newNode.Next = beforeNode.Next;
            beforeNode.Next = newNode;

        }

        public void DeleteNode(int data)
        {
            if (Head is null) return;

            if (Head == Tail)
            {
                Head = Tail = null;
                return;
            }

            if (Head.Data == data)
            {
                DeleteHead();
                return;
            }

            if (Tail!.Data == data)
            {
                DeleteTail();
                return;
            }

            DeleteNodeElseHeadOrTail(data);

        }

        public void Print()
        {
            Console.WriteLine();
            for (SinglyLinkedListIterator i = new(Head); i.CurrentNode is not null; i.Next())
            {
                Console.Write($"{i.Data()} ");
            }
            Console.WriteLine();
        }

        private void DeleteHead()
        {
            Head = Head?.Next;
        }

        private void DeleteTail()
        {
            if (Tail is null) return;

            SinglyLinkedListNode beforeTail = FindNodeBefore(Tail.Data)!;

            Tail = beforeTail;
            Tail.Next = null;
        }

        private void DeleteNodeElseHeadOrTail(int data)
        {

            SinglyLinkedListNode beforeTail = FindNodeBefore(data)!;

            if (beforeTail is null) return;

            beforeTail.Next = beforeTail.Next?.Next;

        }

        private SinglyLinkedListNode? FindNode(int data)
        {
            if (Head is null) return null;

            for (SinglyLinkedListIterator i = new(Head); i.CurrentNode is not null; i.Next())
            {
                if (i.Data() == data)
                {
                    return i.CurrentNode;
                }
            }

            return null;
        }

        private SinglyLinkedListNode? FindNodeBefore(int data)
        {

            if (Head is null) return null;

            for (SinglyLinkedListIterator i = new(Head); i.CurrentNode!.Next is not null; i.Next())
            {
                if (i.CurrentNode.Next.Data == data)
                {
                    return i.CurrentNode;
                }
            }

            return null;
        }

    }
}
