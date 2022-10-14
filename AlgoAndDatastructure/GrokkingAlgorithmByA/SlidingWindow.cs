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

        public static int SmallestSubArrayWithAGivenSum(int[] arr, int positiveNumber)
        {
            if(arr.Length == 0 || arr == null || positiveNumber <= 0)
            {
                return 0;
            }

            int minimumLength = int.MaxValue;
            int arrLength = arr.Length;
            int windowStart = 0;
            int windowSum = 0;

            for (int windowEnd = 0; windowEnd < arrLength; windowEnd++)
            {
                windowSum += arr[windowEnd];

                while(windowSum >= positiveNumber)
                {
                    minimumLength = Math.Min(minimumLength, windowEnd - windowStart + 1);
                    windowSum -= arr[windowStart];
                    windowStart++;
                }
            }

            return minimumLength == int.MaxValue ? 0 : minimumLength;
        }

        public static int LongestSubStringWithKDistinctCharacters(string str, int k)
        {
            if(string.IsNullOrEmpty(str) || str.Length < k)
            {
                return 0;
            }

            int strLength = str.Length;
            int maxLength = int.MinValue;
            int windowStart = 0;

            Dictionary<char, int> dict = new Dictionary<char, int>();


            for(int windowEnd = 0; windowEnd < strLength; windowEnd++)
            {
               
                if (dict.ContainsKey(str[windowEnd]))
                {
                    char currentChar = str[windowEnd];
                    dict[currentChar] = dict[currentChar] + 1;
                }
                else
                {
                    dict.Add(str[windowEnd], 1);
                }

                while (dict.Count > k)
                {
                    char key = str[windowStart];
                    dict.TryGetValue(key, out int value);

                
                    if (value == 1)
                    {
                        dict.Remove(key);
                    }
                    else
                    {
                        dict[key] = dict[key] - 1;
                    }
                                     
                    windowStart++;
                    
                }

                maxLength = Math.Max(maxLength, windowEnd - windowStart + 1);

            }

            return maxLength;
        }
    }
}
