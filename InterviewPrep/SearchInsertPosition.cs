using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
	internal class SearchInsertPosition
	{
		// Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.

		// You must write an algorithm with O(log n) runtime complexity.

		// EXAMPLES:

		// Input: nums = [1, 3, 5, 6], target = 5
		// Output: 2

		// Input: nums = [1, 3, 5, 6], target = 2
		// Output: 1

		// Input: nums = [1, 3, 5, 6], target = 7
		// Output: 4

		// CONSTRAINTS:

		// 1 <= nums.length <= 104
		// -104 <= nums[i] <= 104
		// nums contains distinct values sorted in ascending order.
		// -104 <= target <= 104

		public static int SearchInsert(int[] nums, int target)
		{
			if (nums.Contains(target))
			{
				return Array.IndexOf(nums, target);
			}
			return -1;
		}

		// BINARY SEARCH EXAMPLE
		public static object BinarySearchDisplay(int[] arr, int key)
		{
			int minNum = 0;
			int maxNum = arr.Length - 1;

			while (minNum <= maxNum)
			{
				int mid = (minNum + maxNum) / 2;
				if (key == arr[mid])
				{
					return ++mid;
				}
				else if (key < arr[mid])
				{
					maxNum = mid - 1;
				}
				else
				{
					minNum = mid + 1;
				}
			}
			return "None";
		}
	}
}