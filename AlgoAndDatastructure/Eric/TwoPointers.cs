using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoAndDatastructure.Eric
{
    internal class TwoPointers
    {
        //https://leetcode.com/problems/move-zeroes/
        public static void MoveZeroes(int[] nums)
        {
            int length = nums.Length;

            if(length < 2)
            {
                return;
            }
            int left = 0;
            int right = 1;

            while(right < length)
            {
                if(nums[left] != 0)
                {
                    left++;
                    right++;
                }
                else if(nums[right] == 0)
                {
                    right++;
                }
                else
                {
                    int temp = nums[right];
                    nums[right] = nums[left];
                    nums[left] = temp;
                }
            }
        }
    }

}
