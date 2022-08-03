using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoAndDatastructure
{
    internal class Util
    {
        public static string SortString(string str)
        {
            char[] tempArr = str.ToCharArray();
            Array.Sort(tempArr);
            string temp = new string(tempArr);

            return temp;
        }
    }
}
