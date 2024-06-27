using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Solution
{
    public class LongestOfLastWordCode
    {
        public static void LongestOfLastWord()
        {
            //help, better way to unit test is needed
            string input1 = "Hello World";
            string input2 = "     fly me   to the   moon      ";
            string input3 = "luffy is still joyboy";
            string input4 = "a";
            int output1 = LongestOfLastWord(input1);
            int output2 = LongestOfLastWord(input2);
            int output3 = LongestOfLastWord(input3);
            int output4 = LongestOfLastWord(input4);
            Console.WriteLine(output1);
            Console.WriteLine(output2);
            Console.WriteLine(output3);
            Console.WriteLine(output4);
        }
        private static int LongestOfLastWord(string s)
        {
            
            return s.Trim().Split(' ').Last().Length;
            //but if you hate one line solution...
            //int longest = 0;
            //List<string> words = s.Split(' ').ToList<string>();
            //for (int i = words.Count-1; i > 0; i--)
            //{
            //    if (words[i].Length <= 0)
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        longest = words[i].Length;
            //        return longest;
            //    }
            //}
            //return longest;
            //string word = s.Trim().Split(' ').Last();
        }
    }
}
