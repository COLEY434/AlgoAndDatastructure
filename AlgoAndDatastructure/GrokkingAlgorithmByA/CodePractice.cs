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
            if(list == null || list.Length == 0)
                return null;

            int low = 0;
            int high = list.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                int guess = list[mid];

                if(guess == item)
                {
                    return mid;
                }

                if(guess < item)
                {
                    low = mid + 1;
                }

                if(guess > item)
                {
                    high = mid - 1;
                }
            }
            return null;
        }
    }
}
