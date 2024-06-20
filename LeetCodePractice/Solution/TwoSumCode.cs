using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Solution
{
    public class TwoSumCode
    {
        public static int[] TwoSumLeetCode(int[] nums, int target)
        {
            int[] output = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        output[0] = i;
                        output[1] = j;
                        return output;
                    }
                }
            }
            return output;
        }
        public static void TwoSum()
        {
            List<int> nums = new List<int>();
            int[] numbers;
            int n;
            Console.Write("Input number to iterate\n(Press number to add numbers, Press 'Y' to end): ");
            string input = Console.ReadLine();
            while (Int32.TryParse(input, out n))
            {
                nums.Add(n);
                foreach (int i in nums)
                {
                    Console.Write("{0} ", i.ToString());
                }
                Console.WriteLine();
                input = Console.ReadLine();
            }
            numbers = nums.ToArray();
            Console.Write("Input number of target: ");
            if (!Int32.TryParse(Console.ReadLine(), out int target))
            Console.WriteLine("Invalid input.");
            else TwoSum(numbers, target);
        }
        private static void TwoSum(int[] nums, int target)
        {
            int[] output = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        output[0] = i;
                        output[1] = j;
                        break;
                    }
                }
            }
            foreach (int i in output)
            {
                Console.Write("{0} ", i.ToString());
            }
            Console.WriteLine();
        }
    }
}
