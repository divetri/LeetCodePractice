using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Solution
{
    public class PalindromeNumberCode
    {
        public static void PalindromeNumber()
        {
            int n;
            Console.Write("Input number to check: ");
            bool result = new bool();
            if (Int32.TryParse(Console.ReadLine(), out n))
                result = Solution.PalindromeNumberCode.PalindromeNumber(n);
            if (result) Console.WriteLine("Palindrome");
            else Console.WriteLine("Not palindrome");
        }
        public static bool PalindromeNumber(int n)
        {
            int temp = n;
            int sum = 0;
            while (n > 0)
            {
                sum = (sum * 10) + (n % 10);
                n /= 10;
            }
            if (temp == sum) return true;
            else return false;
        }
    }
}
