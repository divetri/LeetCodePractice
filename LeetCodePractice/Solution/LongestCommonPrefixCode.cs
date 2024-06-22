using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Solution
{
    public class LongestCommonPrefixCode
    {
        public static void LongestCommonPrefix()
        {
            //help, better way to unit test is needed
            string[] strs1 = { "flower", "flow", "flight" };
            string[] strs2 = { "dog", "racecar", "car" };
            string[] strs3 = { "ab", "a" };
            string longest1 = LongestCommonPrefix(strs1);
            string longest2 = LongestCommonPrefix(strs2);
            string longest3 = LongestCommonPrefix(strs3);
            Console.WriteLine(longest1);
            Console.WriteLine(longest2);
            Console.WriteLine(longest3);
        }
        private static string LongestCommonPrefix(string[] strs)
        {
            string longest = "";
            for (int i = 0; i < strs[0].Length; i++)
            {
                string c = strs[0].Substring(0, i + 1);
                foreach (var s in strs)
                {
                    if (s.Length < i + 1 || s.Substring(0, i + 1) != c)
                    {
                        return longest;
                    }
                }
                longest = c;
            }
            return longest;
        }
    }
}
