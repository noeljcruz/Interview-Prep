using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
	internal class RomanToInt
	{
		public int RomanToInterger(string s)
		{
			s = s.ToUpper();
			int sum = 0;

			for (int i = 0; i < s.Length; i++)
			{

				int val1 = RomanValue(s[i]);
				int val2 = 0;

				if (i + 1 < s.Length)
				{
					val2 = RomanValue(s[i + 1]);
				}

				if (val1 >= val2)
				{
					sum += val1;
				}
				else
				{
					sum += val2 - val1;
					i++;
				}
			}
			return sum;
		}
		public int RomanValue(char c)
		{
			switch (c)
			{
				case 'I':
					return 1;
				case 'V':
					return 5;
				case 'X':
					return 10;
				case 'L':
					return 50;
				case 'C':
					return 100;
				case 'D':
					return 500;
				case 'M':
					return 1000;
				default:
					return 0;
			}
		}
	}
}