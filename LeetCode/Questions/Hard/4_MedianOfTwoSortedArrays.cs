using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Questions.Hard
{
    public class MedianOfTwoSortedArrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] list = [.. nums1, .. nums2];
            IEnumerable<int> sortedList = list.OrderBy(n => n);
            int count = sortedList.Count();
            if (count % 2 == 0)
            {
                var sum = sortedList.ElementAt(count / 2 - 1) + sortedList.ElementAt(count / 2);
                return (double)sum / 2;
            }
            else
            {
                return sortedList.ElementAt(count / 2);
            }
        }
    }
}
