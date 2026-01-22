namespace DataStructures_Algorithms_CSharp.DataStructures.LinkedList.Singly
{
    internal class SinglyLinkedListIterator
    {

        public SinglyLinkedListNode? CurrentNode { get; private set; }


        public SinglyLinkedListIterator(SinglyLinkedListNode? currentNode)
        {
            CurrentNode = currentNode;

        }

        public int? Data()
        {
            if (CurrentNode is null)
                return null;

            return CurrentNode.Data;
        }


        public void Next()
        {
            CurrentNode = CurrentNode?.Next;
        }


    }
}
