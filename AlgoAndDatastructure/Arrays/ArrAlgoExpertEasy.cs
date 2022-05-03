using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoAndDatastructure.Arrays
{
    internal class ArrAlgoExpertEasy
    {
        //Space complexity = O(n)
        //Time complexity = O(n)
        public static int[] TwoNumberSum(int[] nums, int targetSum)
        {
            if(nums == null || nums.Length == 0)
            {
                return new int[] { };
            }

            var numsHashset = new HashSet<int>();

            for(int i = 0; i < nums.Length; i++)
            {
                int currVal = nums[i];
                int y = targetSum - currVal;

                if (numsHashset.Contains(y))
                {
                    return new[] { y, currVal };
                }

                numsHashset.Add(currVal);
            }

            return new int[] { };
        }

        //Space complexity = O(1)
        //Time complexity = O(nlogn)
        public static int[] TwoNumberSum2(int[] nums, int targetSum)
        {
            if (nums == null || nums.Length == 0)
            {
                return new int[] { };
            }

            Array.Sort(nums);

            int leftPointer = 0;
            int rightPointer = nums.Length - 1;

            while(leftPointer < rightPointer)
            {
                int sum = nums[leftPointer] + nums[rightPointer];

                if(sum == targetSum)
                {
                    return new int[] { nums[leftPointer], nums[rightPointer] };
                }

                if(sum < targetSum)
                {
                    leftPointer++;
                }
                else
                {
                    rightPointer--;
                }
            }

            return new int[] { };
        }
    }
}
