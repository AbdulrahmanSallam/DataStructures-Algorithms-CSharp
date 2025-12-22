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

        public static void MergeSort(int[] arr)
        {
            if (arr == null || arr.Length == 0 || arr.Length == 1) return;

            MergeSort(arr, 0, arr.Length - 1);
        }

        private static void MergeSort(int[] arr, int startIndex, int endIndex)
        {
            if (startIndex >= endIndex) return;

            int midIndex = (startIndex + endIndex) / 2;

            MergeSort(arr, startIndex, midIndex);
            MergeSort(arr, midIndex + 1, endIndex);

            Merge(arr, startIndex, midIndex, endIndex);
        }

        private static void Merge(int[] arr, int startIndex, int midIndex, int endIndex)
        {
            int leftArrLength = midIndex - startIndex + 1;
            int rightArrLength = endIndex - midIndex;

            int[] leftArr = new int[leftArrLength];
            int[] rightArr = new int[rightArrLength];


            for (int i = 0; i < leftArr.Length; i++)
            {
                leftArr[i] = arr[startIndex + i];
            }

            for (int i = 0; i < rightArr.Length; i++)
            {
                rightArr[i] = arr[midIndex + 1 + i];
            }


            int leftArrIndex = 0;
            int rightArrIndex = 0;

            int originalArrIndex = startIndex;


            while (leftArrIndex < leftArr.Length && rightArrIndex < rightArr.Length)
            {
                if (leftArr[leftArrIndex] < rightArr[rightArrIndex])
                {
                    arr[originalArrIndex] = leftArr[leftArrIndex];
                    leftArrIndex++;
                }
                else
                {
                    arr[originalArrIndex] = rightArr[rightArrIndex];
                    rightArrIndex++;
                }
                originalArrIndex++;
            }


            while (leftArrIndex < leftArr.Length)
            {
                arr[originalArrIndex] = leftArr[leftArrIndex];
                originalArrIndex++;
                leftArrIndex++;
            }

            while (rightArrIndex < rightArr.Length)
            {
                arr[originalArrIndex] = rightArr[rightArrIndex];
                originalArrIndex++;
                rightArrIndex++;
            }


        }


    }
}
