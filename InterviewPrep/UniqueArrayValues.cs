using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
	internal class UniqueArrayValues
	{

		// --- QUESTION ---

		//Given an integer array nums, return true if any value appears at least twice in the array, and return false if every element is distinct.

		//Example 1:
		//Input: nums = [1,2,3,1]
		//		Output: true

		//Example 2:
		//Input: nums = [1,2,3,4]
		//		Output: false

		//Example 3:
		//Input: nums = [1,1,1,3,3,4,3,2,4,2]
		//		Output: true

		// --- SOLUTION ---

		// 1/ inclement a hash table
		// 2/ iterate over the array
		// 3/ for each iteration we check if the value at the index already exist as a key in the hashtable; if so, increment value; else, add
		// 4/ loop over the array 

		// [2, 3, 2, 4]

		public static void ArrHasDuplicates(int[] arr)
		{
			Hashtable ht = new Hashtable();

			foreach (int i in arr)
			{
				if (ht.ContainsKey(i))
				{
					int value = (int)ht[i];
					value++;
					ht[i] = value;
				}
				else
				{
					ht.Add(i, 1);
				}
			}

			// ht looks like this:
			// {
			// 2 : 2, 
			// 3 : 1,
			// 4 : 1
			// }

			bool thereAreDuplicates = false;

			foreach (DictionaryEntry entry in ht)
			{
				if ((int)entry.Value > 1)
				{
					thereAreDuplicates = true;
					break;
				}
			}
			Console.WriteLine(thereAreDuplicates);
		}
	}
}