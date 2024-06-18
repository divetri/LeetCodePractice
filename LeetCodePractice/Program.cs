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
            Console.WriteLine("-------------");
            Console.WriteLine("1. Two Sum");
            Console.Write("Input problem number: ");
            if (Int32.TryParse(Console.ReadLine(), out int quiz))
            {
                switch (quiz)
                {
                    case 1:
                        int[] nums = {3,2,4,5,8};
                        int target = 9;
                        Solution.TwoSumCode.TwoSum(nums, target);
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
