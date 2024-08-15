using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests
{
    [TestClass()]
    public class RemoveElementsTest
    {
        [TestMethod()]
        public void RemoveElementTest()
        {
            int[] nums = [...]; // Input array
            int val = ...; // Value to remove
            int[] expectedNums = [...]; // The expected answer with correct length.
                                        // It is sorted with no values equaling val.

            int k = removeElement(nums, val); // Calls your implementation

            assert k == expectedNums.length;
            sort(nums, 0, k); // Sort the first k elements of nums
            for (int i = 0; i < actualLength; i++)
            {
                assert nums[i] == expectedNums[i];
                Assert.Fail();
            }
        }
    }
}