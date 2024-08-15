using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{       //https://leetcode.com/problems/merge-sorted-array
    public class MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int[] nums1 = [1, 2, 3, 0, 0, 0];
            int[] nums2 = [2, 5, 6];

            
            int startIndex = nums2.Length;

            
            Array.Resize(ref nums1, nums2.Length + nums1.Length);

            
            for (int i = 0; i < nums2.Length; i++)
            {
                nums1[startIndex + i] = nums2[i];
            }

            

        }
    }
}
