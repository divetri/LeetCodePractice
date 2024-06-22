using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Solution
{
    public class RemoveElementCode
    {
        public static void RemoveElement()
        {
            //help, better way to unit test is needed
            int[] testCase1 = { 3, 2 };
            int[] testCase2 = { 0, 1, 2, 2, 3, 0, 4, 2 };
            int[] testCase3 = { 0, 4, 4, 0, 4, 4, 4, 0, 2 };
            int val1 = 3;
            int val2 = 2;
            int val3 = 4;
            int result1 = RemoveElement(testCase1, val1);
            int result2 = RemoveElement(testCase2, val2);
            int result3 = RemoveElement(testCase3, val3);   
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
        }
        private static int RemoveElement(int[] nums, int val)
        {
            int result = nums.ToList().Count(i => i != val);
            int numofvals = 0;
            for (int i = 0; i < result; i++)
            {
                if(nums[i] == val)
                {
                    numofvals++;
                    for(int j = 0; j < nums.Length-numofvals; j++)
                    {
                        if (nums[nums.Length - j - 1] != val)
                        {
                            nums[i] = nums[nums.Length - j - 1];
                            nums[nums.Length - j - 1] = val;
                            break;
                        }
                    }
                }
            }
            //foreach(int i in nums)
            //{
            //    Console.Write(i+" ");
            //}
            //Console.WriteLine();
            return result;
        }
    }
}
