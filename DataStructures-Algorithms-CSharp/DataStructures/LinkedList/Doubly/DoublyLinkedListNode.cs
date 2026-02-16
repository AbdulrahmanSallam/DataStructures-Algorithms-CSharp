namespace DataStructures_Algorithms_CSharp.DataStructures.LinkedList.Doubly
{
    internal class DoublyLinkedListNode
    {
        public int Data { get; set; }

        public DoublyLinkedListNode? Next { get; set; }

        public DoublyLinkedListNode? Prev { get; set; }

        public DoublyLinkedListNode(int data)
        {
            Data = data;
        }

    }
}
