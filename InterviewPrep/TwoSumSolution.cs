using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
	internal class TwoSumSolution
	{
		public static int[] TwoSum(int[] nums, int target)
		{
			int[] sortedNums = (int[])nums.Clone();
			Array.Sort(sortedNums);

			int left = 0;
			int right = sortedNums.Length - 1;

			while (left < right)
			{
				if (sortedNums[left] + sortedNums[right] == target)
				{
					return new int[] { Array.IndexOf(nums, sortedNums[left]), Array.LastIndexOf(nums, sortedNums[right]) };
				}
				else if (sortedNums[left] + sortedNums[right] > target)
				{
					right--;
				}
				else if (sortedNums[left] + sortedNums[right] < target)
				{
					left++;
				}
			}
			return new int[] { 0, 0 };
		}
	}
}