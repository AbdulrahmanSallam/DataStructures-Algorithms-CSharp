namespace DataStructures_Algorithms_CSharp.DataStructures.LinkedList.Singly
{
    static class SinglyLinkedListExtensionMethods
    {

        public  static  void Print (this SinglyLinkedList linkedList,SinglyLinkedListNode head)
        {
            Console.Write("list : ");
            for(SinglyLinkedListIterator i = new (head); i.CurrentNode is not null; i.Next())
            {
                Console.Write("{0} ", i.Data());
            }
            Console.WriteLine();
        }
    }
}
