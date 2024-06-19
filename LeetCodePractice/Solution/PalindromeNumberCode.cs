using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Solution
{
    public class PalindromeNumberCode
    {
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
