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
                if (nums.Contains(target - nums[i]))
                {
                    output[0] = i;
                    output[1] = Array.IndexOf(nums, (target - nums[i]));
                    continue;
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
            TwoSum(numbers, 9);
        }
        private static void TwoSum(int[] nums, int target)
        {
            string output = "";
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums.Contains(target - nums[i]))
                {
                    output += i + " " + Array.IndexOf(nums, (target - nums[i]));
                    break;
                }
            }
            Console.WriteLine(output);
        }
    }
}
