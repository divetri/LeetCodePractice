using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Solution
{
    public class ValidParenthesesCode
    {
        public static void ValidParentheses()
        {
            string input;
            Console.Write("Input: ");
            input = Console.ReadLine();
            if (IsValid(input)) Console.WriteLine("True");
            else Console.WriteLine("False");
        }
        private static bool IsValid(string s)
        {
            bool isValid = false;
            if (string.IsNullOrEmpty(s))
            {
                isValid = true;
            }
            else if (s.Length <= 1 || s.Length % 2 != 0)
            {
                isValid = false;
            }
            else
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (i != s.Length - 1)
                    {
                        if ((s[i] == '{' && s[i + 1] == '}') 
                            || (s[i] == '[' && s[i + 1] == ']') 
                            || (s[i] == '(' && s[i + 1] == ')'))
                        {
                            s = s.Remove(i, 2);
                            if (IsValid(s)) return true; else return false;
                        }
                    }
                }
            }
            return isValid;
        }
    }
}
