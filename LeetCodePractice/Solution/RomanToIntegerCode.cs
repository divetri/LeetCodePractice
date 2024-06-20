using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Solution
{
    public class RomanToIntegerCode
    {
        public static void RomanToInteger()
        {
            string input;
            Console.Write("Input roman number to convert: ");
            input = Console.ReadLine();
            int result = RomanToInteger(input.ToUpper());
            Console.WriteLine(result);
        }

        private static int value(char c)
        {
            int num = c == 'I' ? 1
                : c == 'V' ? 5
                : c == 'X' ? 10
                : c == 'L' ? 50
                : c == 'C' ? 100
                : c == 'D' ? 500
                : c == 'M' ? 1000
                : 0;
            return num;
        }
        private static int RomanToInteger(string s)
        {
            int result = 0;
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if(i != s.Length - 1)
                {
                    if (value(s[i]) >= value(s[i + 1]))
                    {
                        if (value(s[i]) == value(s[i + 1]))
                        {
                            count++;
                            if (count > 3)
                            {
                                Console.WriteLine("Invalid.");
                                return 0;
                            }
                        }
                        else
                        {
                            count = 0;
                        }
                        result += value(s[i]);
                    }
                    else
                    {
                        count = 0;
                        result += value(s[i + 1]) - value(s[i]);
                        i++;
                    }
                }
                else
                {
                    if (s.Length > 1)
                    {
                        if(value(s[i]) == value(s[i - 1]))
                        {
                            count++;
                            if (count > 3)
                            {
                                Console.WriteLine("Invalid.");
                                return 0;
                            }
                        }
                    }
                    result += value(s[i]);
                }
            }
            return result;
        }
    }
}
