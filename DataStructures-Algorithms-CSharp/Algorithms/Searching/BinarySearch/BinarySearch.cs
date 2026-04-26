using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms_CSharp.Algorithms.Searching.BinarySearch
{
    public partial class Searching
    {
        public static bool BinarySearch(int[] arr,int target,int start,int end)
        {
            if (start > end) return false;

            int mid =  start +( end - start) / 2;

            if ( arr[mid] == target) return true;
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
