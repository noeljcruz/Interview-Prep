// C# program to print Hello World!
using System;

// namespace declaration
namespace InterviewPrep
{
	// Class declaration
	class Geeks
	{
		// Main Method
		static void Main(string[] args)
		{
			// string input = "race car";
			// Palendrome(input.Replace(" ", ""));

			// int[] testArr = new int[] { 1, 2, 2, 3 };
			// UniqueArrayValues.ArrHasDuplicates(testArr);

			int[] inputArr = { 3, 3 };

			Console.WriteLine(String.Join(",", TwoSumSolution.TwoSum(inputArr, 6)));
			Console.ReadKey();
		}

		// Space Complexity: O(1) + O(1) + O(1) = 3(O(1)) ... O(1)
		// Time Complexity: 1/2(O(n)) ... O(n)

		public static void Palendrome(string word)
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