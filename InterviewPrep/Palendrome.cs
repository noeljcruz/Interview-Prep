using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
	internal class Palendrome
	{
		// Space Complexity: O(1) + O(1) + O(1) = 3(O(1)) ... O(1)
		// Time Complexity: 1/2(O(n)) ... O(n)

		public static void CheckIfPalendrome(string word)
		{
			word = word.ToLower();
			int left = 0;
			int right = word.Length - 1;
			bool isPalendrome = false;

			while (left < right)
			{
				if (word[left] == word[right])
				{
					isPalendrome = true;
					left++;
					right--;
				}
				else
				{
					isPalendrome = false;
					break;
				}
			}
			Console.WriteLine(isPalendrome);
		}
	}
}