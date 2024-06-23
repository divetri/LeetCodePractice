using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Solution
{
    public class IntegerToRomanCode
    {
        public static void IntegerToRoman()
        {
            Console.Write("Input number to convert: ");
            if(Int32.TryParse(Console.ReadLine(), out int input)){
                Console.WriteLine(IntegerToRoman(input));
            }
        }
        private static string IntegerToRoman(int num)
        {
            string output = "";
            for (int i = 0; i < num / 1000; i++)
            {
                output += "M";
            }
            num = num % 1000;
            int div = 100;
            while (div > 0)
            {
                if (num / div == 9)
                {
                    if (div == 100) output += "CM";
                    else if (div == 10) output += "XC";
                    else if (div == 1) output += "IX";
                }
                else if (num / div == 4)
                {
                    if (div == 100) output += "CD";
                    else if (div == 10) output += "XL";
                    else if (div == 1) output += "IV";
                }
                else
                {
                    if (num / div >= 5)
                    {
                        if (div == 100) output += "D";
                        else if (div == 10) output += "L";
                        else if (div == 1) output += "V";
                        num = num % (5 * div);
                    }
                    for (int i = 0; i < num / div; i++)
                    {
                        if (div == 100) output += "C";
                        else if (div == 10) output += "X";
                        else if (div == 1) output += "I";
                    }
                }
                num = num % div;
                div = div / 10;
            }
            //string output = "";
            //for (int i = 0; i < num / 1000; i++)
            //{
            //    output += "M";

            //}
            //num = num % 1000;
            //if (num / 100 == 9)
            //{
            //    output += "CM";
            //    num = num % 100;
            //}
            //else if (num / 100 == 4)
            //{
            //    output += "CD";
            //    num = num % 100;
            //}
            //else if (num / 100 >= 5)
            //{
            //    output += "D";
            //    num = num % 500;
            //    for (int i = 0; i < num / 100; i++)
            //    {
            //        output += "C";
            //    }
            //    num = num % 100;
            //}
            //else if (num / 100 < 5)
            //{
            //    for (int i = 0; i < num / 100; i++)
            //    {
            //        output += "C";
            //    }
            //    num = num % 100;
            //}
            //if (num / 10 == 9)
            //{
            //    output += "XC";
            //    num = num % 10;
            //}
            //else if (num / 10 == 4)
            //{
            //    output += "XL";
            //    num = num % 10;
            //}
            //else if (num / 10 >= 5)
            //{
            //    output += "L";
            //    num = num % 50;
            //    for (int i = 0; i < num / 10; i++)
            //    {
            //        output += "X";
            //    }
            //    num = num % 10;
            //}
            //else if (num / 10 < 5)
            //{
            //    for (int i = 0; i < num / 10; i++)
            //    {
            //        output += "X";
            //    }
            //    num = num % 10;
            //}
            //if (num == 9)
            //{
            //    output += "IX";
            //}
            //else if (num == 4)
            //{
            //    output += "IV";
            //}
            //else if (num >= 5)
            //{
            //    output += "V";
            //    num = num % 5;
            //    for (int i = 0; i < num; i++)
            //    {
            //        output += "I";
            //    }
            //}
            //else if (num < 5)
            //{
            //    for (int i = 0; i < num; i++)
            //    {
            //        output += "I";
            //    }
            //}
            return output;
        }
    }
}
