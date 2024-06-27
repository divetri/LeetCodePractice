using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Solution
{
    public class DivideTwoIntegerCode
    {
        public static void DivideTwoInteger()
        {
            Console.WriteLine(DivideTwoInteger(-2147483648, -1));
        }
        private static int DivideTwoInteger(int dividend, int divisor)
        {
            long dividend2 = long.Parse(dividend.ToString());
            long divisor2 = long.Parse(divisor.ToString());
            long result = dividend2 / divisor2;

            if (result > Int32.MaxValue) result = (Int32.MaxValue);
            if (result < Int32.MinValue) result = (Int32.MinValue);
            return Int32.Parse(result.ToString());
        }
    }
}
