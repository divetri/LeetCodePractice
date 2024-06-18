using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Solution
{
    public class OddPowCode
    {
        public static void OddPow(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine((i / 2) * (i / 2) + " ");
                }
                else
                {
                    Console.WriteLine(i + " ");
                }
            }
        }
    }
}
