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
			myStack<int> stack = new myStack<int>();

			stack.Push(1);
			stack.Push(2);
			stack.Push(3);

			Console.WriteLine(stack.Count());

			var secondStack = stack.Clone();
			
			foreach(var item in secondStack)
			{
				Console.WriteLine(secondStack[item]);
			}

			Console.WriteLine(secondStack);

			Console.ReadKey();
		}
	}
}