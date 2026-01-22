namespace DataStructures_Algorithms_CSharp.DataStructures.LinkedList.Singly
{
    internal class SinglyLinkedListNode
    {

        public int Data { get; set; }

        public SinglyLinkedListNode? Next { get; set; }

        public SinglyLinkedListNode(int _data)
        {
            Data = _data;
        }
    }
}
