using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice
{
    class Program
    {
        public static void Main()
        {
            Console.Clear();
            Console.WriteLine("-------LIST OF PROBLEMS SOLVED-------");
            Console.WriteLine("0. Odd Pow (Unknown)");
            Console.WriteLine("1. Two Sum (Easy)");
            Console.WriteLine("2. Palindrome Number (Easy)");
            Console.WriteLine("3. Roman to Integer (Easy)");
            Console.WriteLine("4. Valid Parentheses (Easy)");
            Console.WriteLine("5. Longest Common Prefix (Easy)");
            Console.WriteLine("6. Remove Element (Easy)");
            Console.WriteLine("7. Integer to Roman (Medium)");
            Console.Write("Input problem number: ");
            if (Int32.TryParse(Console.ReadLine(), out int quiz))
            {
                switch (quiz)
                {
                    case 0:
                        Solution.OddPowCode.OddPow();
                        waitForContinue();
                        break;
                    case 1:
                        Solution.TwoSumCode.TwoSum();
                        waitForContinue();
                        break;
                    case 2:
                        Solution.PalindromeNumberCode.PalindromeNumber();
                        waitForContinue();
                        break;
                    case 3:
                        Solution.RomanToIntegerCode.RomanToInteger();
                        waitForContinue();
                        break;
                    case 4:
                        Solution.ValidParenthesesCode.ValidParentheses();
                        waitForContinue();
                        break;
                    case 5:
                        Solution.LongestCommonPrefixCode.LongestCommonPrefix();
                        waitForContinue();
                        break;
                    case 6:
                        Solution.RemoveElementCode.RemoveElement();
                        waitForContinue();
                        break;
                    case 7:
                        Solution.IntegerToRomanCode.IntegerToRoman();
                        waitForContinue();
                        break;

                    default:
                        Console.WriteLine("Invalid input.");
                        waitForContinue();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
                waitForContinue();
            }
        }
        public static void waitForContinue()
        {
            Console.Write("Continue? (press Y button)");
            string key = Console.ReadKey().Key.ToString();
            if (key.ToUpper() == "Y")
            {
                Main();
            }
        }
    }
}
