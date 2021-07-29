using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsApp
{
    public static class LoopTypes
    {
        internal static int HighestForEachLoop(List<int> nums)
        {
            int highest = Int32.MinValue;
            foreach (var n in nums)
            {
                if (n > highest)
                {
                    highest = n;
                }
            }
            return highest;
        }
        internal static int HighestForLoop(List<int> nums)
        {
            int highest = 0;

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] > highest)
                {
                    highest = nums[i];
                }
            }
            return highest;
        }
        internal static int HighestWhileLoop(List<int> nums)
        {
            int highest = 0;
            int i = 0;

            while (i < nums.Count)
            {
                if (nums[i] > highest)
                {
                    highest = nums[i];
                }
                i++;
            }
            return highest;
        }
        internal static int HighestDoWhileLoop(List<int> nums)
        {
            int highest = 0;
            int count = 0;

            do
            {
                if (nums[count] > highest)
                {
                    highest = nums[count];
                }
                count++;
            }
            while (count < nums.Count);
            return highest;
        }
    }
}
