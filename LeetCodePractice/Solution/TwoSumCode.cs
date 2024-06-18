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
            for (int i = 0; i < (nums.Length / 2) + 1; i++)
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

        public static void TwoSum(int[] nums, int target)
        {
            string output = "";
            for (int i = 0; i < (nums.Length / 2) + 1; i++)
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
