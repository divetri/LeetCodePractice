using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Solution
{
    public class OddPowCode
    {
        public static void OddPow()
        {
            int n;
            Console.Write("Input number to iterate: ");
            if (Int32.TryParse(Console.ReadLine(), out n))
                Solution.OddPowCode.OddPow(n);
            else Console.WriteLine("Invalid input.");
        }
        private static void OddPow(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write((i / 2) * (i / 2) + " ");
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
