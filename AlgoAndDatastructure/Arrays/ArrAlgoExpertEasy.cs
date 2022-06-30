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

        public static int[] Quicksort(int[] arr)
        {
            QuicksortHelper(arr, 0, arr.Length - 1);
            return arr;
        }

        private static void QuicksortHelper(int[] arr, int startIdx, int endIdx)
        {
            if(startIdx >= endIdx)
            {
                return;
            }

            int pivot = startIdx;
            int leftIdx = startIdx + 1;
            int rightIdx = endIdx;

            while (rightIdx >= leftIdx)
            {
                if(arr[leftIdx] > arr[pivot] && arr[rightIdx] < arr[pivot])
                {
                    Swap(arr, leftIdx, rightIdx);
                }

                if(arr[leftIdx] <= arr[pivot])
                {
                    leftIdx += 1;
                }

                if(arr[rightIdx] >= arr[pivot])
                {
                    rightIdx -= 1;
                }
            }

            Swap(arr, pivot, rightIdx);

            bool isLeftSubArraySmaller = rightIdx - 1 - startIdx < endIdx - (rightIdx + 1);

            if (isLeftSubArraySmaller)
            {
                QuicksortHelper(arr, startIdx, rightIdx - 1);
                QuicksortHelper(arr, rightIdx + 1, endIdx);
            }
            else
            {
                QuicksortHelper(arr, rightIdx + 1, endIdx);
                QuicksortHelper(arr, startIdx, rightIdx - 1);
            }
        }

        public static void Swap(int[] arr, int i, int j)
        {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public static int GetFibNumber2(int num)
        {
            if(num == 1)
            {
                return 0;
            }

            if(num == 2)
            {
                return 1;
            }

            return GetFibNumber2(num - 1) + GetFibNumber2(num - 2);
        }

        public static int GetFibNumber(int num)
        {
           var cache = new Dictionary<int, int>();
            cache.Add(1, 0);
            cache.Add(2, 1);

            return GetFibNumber(num, cache);          
        }

        public static int GetFibNumber(int num, Dictionary<int, int> cache)
        {
            if (cache.ContainsKey(num))
            {
                return cache[num];
            }
            else
            {
                cache.Add(num, GetFibNumber(num - 1, cache) + GetFibNumber(num - 2, cache));
                return cache[num];
            }
        }

        public static int ProductSum(List<object> array)
        {
            int depth = 1;

            return ProductSumHelper(array, depth);
        }

        public static int ProductSumHelper(List<object> array, int depth)
        {
            int sum = 0;
            foreach (var obj in array)
            {
                if (obj is IList<object>)
                {
                   
                    sum += ProductSumHelper((List<object>)obj, depth + 1);
                }
                else
                {
                    sum += (int)obj;
                }
            }

            return sum * depth;
        }
    }
}
