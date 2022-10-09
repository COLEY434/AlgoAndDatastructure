using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoAndDatastructure.GrokkingAlgorithmByA
{
    internal class SlidingWindow
    {
        public static int MaximumSubArrayOfSizeK(int[] nums, int k)
        {
            if(nums.Length == 0 || nums.Length < k || nums == null)
            {
                return 0;
            }

            //[2, 1, 5, 1, 3, 2]

            int maxSum = 0;        
            int len = nums.Length;
            
            for(int i = 0; i < len - k; i++)
            {
                int currentSum = 0;

                for (int j = i; j < k + i; j++)
                {
                    currentSum = currentSum + nums[j];
                }

                maxSum = Math.Max(maxSum, currentSum);
            }

            return maxSum;
        }

        public static int MaximumSubArrayOfSizeKSlidingWindow(int[] nums, int k)
        {
            if (nums.Length == 0 || nums.Length < k || nums == null)
            {
                return 0;
            }

            //[2, 1, 5, 1, 3, 2]

            int maxSum = 0;
            int len = nums.Length;
            int windowStart = 0, windowSum = 0;
           
            for(int windowEnd = 0; windowEnd < len; windowEnd++)
            {
                windowSum = windowSum + nums[windowEnd];

                if(windowEnd >= k - 1)
                {
                    maxSum = Math.Max(maxSum, windowSum);
                    windowSum -= nums[windowStart];
                    windowStart++;
                }
            }

            return maxSum;
            
        }
    }
}
