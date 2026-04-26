using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms_CSharp.Algorithms.Searching
{
    public partial class Searching
    {

        public static int BinarySearch(int[] arr, int target)
        {
            return  BinarySearch(arr, target, 0, arr.Length - 1);
        }


        public static int BinarySearch(int[] arr,int target,int start,int end)
        {
            if (start > end) return -1;

            int mid =  start +( end - start) / 2;

            if ( arr[mid] == target) return mid;
            else if (arr[mid] > target)
            {
                return BinarySearch(arr, target, start, mid-1);
            }
            else
            {
                return BinarySearch(arr, target, mid+1, end);
            }
        }
       

    }
}
