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
			else if (target < nums[0])
			{
				return 0;
			}
			else if (target > nums[nums.Length - 1])
			{
				return nums.Length;
			}
			else
			{
				return BinarySearch(nums, target);
			}
		}

		private static int BinarySearch(int[] arr, int key)
		{
			int min = 0;
			int max = arr.Length - 1;
			int targetIndex = 1;

			while (max - min > 1)
			{
				if (key == arr[min] + 1)
				{
					return min + 1;
				}

				if (key == arr[max] - 1)
				{
					return max;
				}

				int mid = min + (max - min) / 2;

				if (key < arr[mid])
				{
					max = mid;
					targetIndex = max;
				}
				else
				{
					min = mid;
					targetIndex = min + 1;
				}
			}
			return targetIndex;
		}
	}
}