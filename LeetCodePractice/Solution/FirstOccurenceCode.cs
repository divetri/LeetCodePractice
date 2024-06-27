using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Solution
{
    public class FirstOccurenceCode
    {
        public static void FirstOccurence()
        {
            //help, better way to unit test is needed
            string haystack1 = "sadbutsad";
            string haystack2 = "leetcode";
            string haystack3 = "a";
            string needle1 = "but";
            string needle2 = "leeto";
            string needle3 = "a";
            Console.WriteLine(FirstOccurence(haystack1, needle1));
            Console.WriteLine(FirstOccurence(haystack2, needle2));
            Console.WriteLine(FirstOccurence(haystack3, needle3));
        }
        private static int FirstOccurence(string haystack, string needle)
        {
            return haystack.IndexOf(needle);
            //but if you hate one line solution...
            //if (haystack.Length < needle.Length)
            //{
            //    return -1;
            //}
            //else
            //{
            //    for (int i = 0; i <= haystack.Length - needle.Length; i++)
            //    {
            //        if(haystack.Substring(i,needle.Length)!= needle)
            //        {
            //            continue;
            //        }
            //        else
            //        {
            //            return i;
            //        }
            //    }
            //    return -1;
            //}
        }
    }
}
