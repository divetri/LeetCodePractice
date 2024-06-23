using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Solution
{
    public class SearchInsertPositionCode
    {
        public static void SearchInsertPosition()
        {
            //help, better way to unit test is needed
            int[] nums = { 1, 3, 5, 6 };
            int target1 = 5;
            int target2 = 2;
            int target3 = 7;
            int result1 = SearchInsertPosition(nums, target1);
            int result2 = SearchInsertPosition(nums, target2);
            int result3 = SearchInsertPosition(nums, target3);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
        }
        private static int SearchInsertPosition(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if(target > nums[i])
                {
                    continue;
                }
                else
                {
                    return i;
                }
            }
            return nums.Length;
        }
    }
}
