namespace DataStructures_Algorithms_CSharp.DataStructures.Stack.Array
{
    internal class StackArray
    {


        private int TopIndex;
        private int[] Entries;

        public int Count { get; private set; }
        public int Capacity { get; private set; }

        public StackArray(int capacity)
        {

            Entries = new int[capacity];
            Capacity = capacity;
            Count = 0;
            TopIndex = -1;
        }

        public void Push(int item)
        {
            ResizeOrNot(Count);

            Entries[Count] = item;

            AddOrDeleteEntry(true);

        }

        public int? Pop()
        {
            if (TopIndex == -1) return null;

            int deletedValue = Entries[TopIndex];

            Entries[TopIndex] = 0;

            AddOrDeleteEntry(false);

            return deletedValue;
        }

        public void Print()
        {
            Console.Write("Items: ");
            for (int i = TopIndex; i >= 0; i--)
            {
                Console.Write($"{Entries[i]} ");
            }
            Console.WriteLine();
        }

        public int? Peek()
        {
            if (TopIndex == -1) return null;
            return Entries[TopIndex];
        }

        public bool IsEmpty() => Count == 0;


        // when the array is full make a new array with a douple of its capacity
        private void ResizeOrNot(int count)
        {
            if (count >= Capacity)
            {
                Capacity = Capacity * 2;
                int[] newEntries = new int[Capacity];

                Entries.CopyTo(newEntries, 0);

                Entries = null!;
                Entries = newEntries;
            }
        }


        private void AddOrDeleteEntry(bool add = true)
        {
            if (add)
            {
                TopIndex++;
                Count++;
                return;
            }

            TopIndex--;
            Count--;
        }


        public override string ToString()
        {
            Print();
            return $"Count: {Count}\n" +
                   $"Capacity: {Capacity}\n" +
                   $"Peek: {Peek()}\n" +
                   $"IsEmpty: {IsEmpty()}";
        }
    }
}
