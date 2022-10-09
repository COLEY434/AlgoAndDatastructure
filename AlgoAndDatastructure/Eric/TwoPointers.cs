using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoAndDatastructure.Eric
{
    internal class TwoPointers
    {
             
        //public static int RemoveDuplicates(int[] nums)
        //{
        //    int len = nums.Length;

        //    if(len < 2)
        //    {
        //        return len;
        //    }

        //    int leftPointer = 0;
        //    int rightPointer = 1;

        //    while(rightPointer < len)
        //    {
        //        if(nums[leftPointer] == nums[rightPointer])
        //        {

        //        }
        //    }
        //}

        //https://leetcode.com/problems/move-zeroes/
        public static void MoveZeros(int[] nums)
        {
            int len = nums.Length;

            if (len < 2)
            {
                return;
            }

            int leftPointer = 0;
            int rightPointer = 1;


            while (rightPointer < len)
            {
                if(nums[leftPointer] != 0)
                {
                    leftPointer++;
                    rightPointer++;
                }
                else if(nums[rightPointer] == 0)
                {
                    rightPointer++;
                }
                else
                {
                    int temp = nums[rightPointer];
                    nums[rightPointer] = nums[leftPointer];
                    nums[(leftPointer++)] = temp;
                }
            }
        }
    }

}
