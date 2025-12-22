namespace DataStructures_Algorithms_CSharp.Algorithms.Sorting
{
    internal static class Sorting
    {

        public static void InsertionSort(int[] arr)
        {
            if (arr == null || arr.Length == 0 || arr.Length == 1) return;

            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];

                int currentPrevIndex = i - 1;

                while (currentPrevIndex >= 0)
                {
                    if (key < arr[currentPrevIndex])
                        arr[currentPrevIndex + 1] = arr[currentPrevIndex];
                    else break;
                    currentPrevIndex--;
                }
                arr[currentPrevIndex + 1] = key;

            }
        }

    }
}
