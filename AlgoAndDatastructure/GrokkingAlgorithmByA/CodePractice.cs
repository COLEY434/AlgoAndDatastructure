using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoAndDatastructure.GrokkingAlgorithmByA
{
    internal class CodePractice
    {

        public static int? BinarySearch(int[] list, int item)
        {
            if (list == null || list.Length == 0)
                return null;

            int low = 0;
            int high = list.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                int guess = list[mid];

                if (guess == item)
                {
                    return mid;
                }

                if (guess < item)
                {
                    low = mid + 1;
                }

                if (guess > item)
                {
                    high = mid - 1;
                }
            }
            return null;
        }

        public static List<int> SelectionSort(List<int> list)
        {
            List<int> rtnList = new List<int>();

            if (list == null || list.Count == 0)
            {
                return rtnList;
            }

            int len = list.Count;

            for (int i = 0; i < len; i++)
            {
                int smallestIndex = GetSmallestItemIndex(list);
                rtnList.Add(list[smallestIndex]);
                list.RemoveAt(smallestIndex);
            }

            return rtnList;
        }

        private static int GetSmallestItemIndex(List<int> list)
        {
            int smallest = list[0];
            int smallestIndex = 0;

            for (int j = 1; j < list.Count; j++)
            {
                if (list[j] < smallest)
                {
                    smallestIndex = j;
                    smallest = list[j];
                }
            }

            return smallestIndex;
        }

        public static int[] QuickSort(int[] nums)
        {
            QuickSortHelper(nums, 0, nums.Length - 1);
            return nums;
        }
        private static void QuickSortHelper(int[] nums, int startIdx, int endIdx)
        {
            if (startIdx >= endIdx)
            {
                return;
            }

            int pivot = startIdx;
            int left = startIdx + 1;
            int right = endIdx;

            while (left <= right)
            {
                if (nums[left] > nums[pivot] && nums[right] < nums[pivot])
                {
                    Swap(left, right, nums);
                }

                if (nums[left] <= nums[pivot])
                {
                    left++;
                }

                if (nums[right] > nums[pivot])
                {
                    right--;
                }
            }

            Swap(pivot, right, nums);

            bool isLeftSubarraySmaller = right - 1 - startIdx < endIdx - (right + 1);

            if (isLeftSubarraySmaller)
            {
                QuickSortHelper(nums, startIdx, right - 1);
                QuickSortHelper(nums, right + 1, endIdx);
            }
            else
            {
                QuickSortHelper(nums, right + 1, endIdx);
                QuickSortHelper(nums, startIdx, right - 1);
            }

        }

        private static void Swap(int i, int j, int[] nums)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }

        public static int[] InsertElementAtSpecificPosition(int[] nums, int position, int digit)
        {
            if (position < 0 || position > nums.Length + 1)
            {
                throw new ArgumentOutOfRangeException("position");
            }
            
            for(int i = 0; i < 8; i++)
            {
                nums[i] = i;
            }
            
            for(int k = nums.Length - 1; k > position - 1; k--)
            {
                nums[k] = nums[k - 1];
            }

            nums[position - 1] = digit;

            return nums;
        }

        
    }
}
