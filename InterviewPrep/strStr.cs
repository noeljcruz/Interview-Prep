using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
	internal class strStr
	{
		public static int StrStr(string haystack, string needle)
		{
			if (string.IsNullOrEmpty(needle)) return 0;

			int nPointer = 0;
			StringBuilder newNeedle = new StringBuilder();

			for (int i = 0; i < haystack.Length; i++)
			{
				while (nPointer < needle.Length)
				{
					if (haystack[i] == needle[nPointer])
					{
						newNeedle.Append(haystack[i]);
						nPointer++;
					}
					else if (newNeedle.ToString().LastIndexOf(newNeedle[0]) > 0)
					{

					}
				}
			}
			if (needle == newNeedle.ToString())
			{
				return haystack.IndexOf(needle[0]);
			}
			else return -1;
		}

		// SOLUTION

		public int StringStrangStrung(string haystack, string needle)
		{
			if (needle == string.Empty)
				return 0;

			int st = 0, j = 0, i = 0;
			while (i < haystack.Length)
			{
				if (haystack[i] == needle[j])
				{
					j++;
					i++;
					if (j >= needle.Length)
						return st;
				}
				else
				{
					st++;
					i = st;
					j = 0;
				}
			}

			return -1;
		}
	}

}