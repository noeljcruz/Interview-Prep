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
			//string input = "race car";
			//Palendrome.CheckIfPalendrome(input.Replace(" ", ""));

			//int[] testArr = new int[] { 1, 2, 2, 3 };
			//UniqueArrayValues.ArrHasDuplicates(testArr);

			//int[] inputArr = { 3, 3 };
			//Console.WriteLine(String.Join(",", TwoSumSolution.TwoSum(inputArr, 6)));

			int[] nums = { 1, 3, 5, 6 };
			int target = 5;
			Console.WriteLine(SearchInsertPosition.SearchInsert(nums, target));

			Console.ReadKey();
		}
	}
}