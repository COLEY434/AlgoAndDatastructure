using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoAndDatastructure.Neetcode
{
    internal class ArraysAndHashing
    {
        public static bool ContainsDuplicate(int[] nums)
        {

            int numslength = nums.Length;

            if (nums == null || numslength == 0)
            {
                return false;
            }

            HashSet<int> numsCount = new HashSet<int>();

            foreach (int i in nums)
            {
                if (numsCount.Contains(i))
                {
                    return true;
                }
                numsCount.Add(i);
            }

            return false;
        }

        public static bool IsAnagram(string s, string t)
        {
            if(s.Length != t.Length)
            {
                return false;
            }

            var dic = new Dictionary<char, int>();
            var mapS = new Dictionary<char, int>();
            for(int i = 0; i < t.Length; i++)
            {
                var key = t[i];

                if (dic.ContainsKey(key))
                {
                    dic[key] += 1;
                }
                else
                {
                    dic.Add(key, 1);
                }
                
            }

            for (int i = 0; i < s.Length; i++)
            {
                var key = s[i];

                if (mapS.ContainsKey(key))
                {
                    mapS[key] += 1;
                }
                else
                {
                    mapS.Add(key, 1);
                }
            }
            bool isAnagram = true;

            foreach (char c in dic.Keys)
            {
                if (mapS.ContainsKey(c))
                {
                    if(dic[c] != mapS[c])
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

            return isAnagram;
        }
   
        public static int[] TwoSumBruteForce(int[] nums, int target)
        {
            int[] result = new int[2];

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for(int k = i + 1; k < nums.Length; k++)
                {
                    if(nums[k] + nums[i] == target)
                    {
                        result[0] = i;
                        result[1] = k;
                    }
                }
            }

            return result;
        }

        public static int[] TwoSumHashMapPattern(int[] nums, int target)
        {
            var map = new Dictionary<int, int>();

            for(int i = 0; i < nums.Length; i++)
            {
                int x = target - nums[i];

                if (map.ContainsKey(x))
                {
                    return new int[] { i, map[x] };
                }
                map.Add(nums[i], i);
            }

            return new int[2];
        }

        //https://leetcode.com/problems/group-anagrams
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IList<IList<string>> list = new List<IList<string>>();

            if(strs == null || strs.Length == 0)
            {
                return list;
            }

            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

            foreach(string str in strs)
            {
                char[] count = new char[26];

                for(int i = 0; i < str.Length; i++)
                {
                    var n = str[i] - 'a';
                    count[n]++;
                }
             
                string rep = new string(count);

                if (map.ContainsKey(rep))
                {
                    map[rep].Add(str);
                }
                else
                {
                    map.Add(rep, new List<string> { str });
                }
            }

            foreach(var item in map.Values)
            {
                list.Add(item);
            }

            return list;
        }

        //https://leetcode.com/problems/top-k-frequent-elements
        public static int[] TopKFrequent(int[] nums, int k)
        {
            if(nums == null || nums.Length == 0 || k < 1)
            {
                return new int[0];
            }

            Dictionary<int, int> numCount = new Dictionary<int, int>();

            foreach(int num in nums)
            {
                if (numCount.ContainsKey(num))
                {
                    numCount[num] += 1;
                }
                else
                {
                    numCount.Add(num, 1);
                }
            }

            var sortedMap = numCount.OrderByDescending(x => x.Value);

            int[] result = new int[k];
            int count = 0;

            foreach(var item in sortedMap)
            {
                if(count == k)
                {
                    break;
                }

                result[count] = item.Key;
                count++;
            }

            return result;
        }

    }
}
