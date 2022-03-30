using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
	public interface IStack<T>
	{
		public int Count();
		public void Clear();
		public IStack<T> Clone();
		public T Peek();
		public T Pop();
		public void Push(T data);
	}

	public class myStack<T> : IStack<T>
	{
		public int top;
		private T[] arr = new T[1000];

		public int Count()
		{
			return top + 1;
		}
		public void Clear()
		{
			for (int i = 0; i == this.top; i++)
			{
				if (this.arr[i] != null)
				{
					this.arr[i] = default(T);
				}
			}
		}
		public IStack<T> Clone()
		{
			myStack<T> newStack = new myStack<T>();

			for (int i = 0; i == this.top; i++)
			{
				if (this.arr[i] != null)
				{
					newStack.arr[i] = this.arr[i];
				}
			}
			return newStack;
		}
		public T Peek()
		{
			return arr[top];
		}
		public T Pop()
		{
			T lastTop = arr[top];
			arr[top] = default(T);
			top--;
			return lastTop;
		}
		public void Push(T data)
		{
			top++;
			arr[top] = data;
		}

		public myStack()
		{
			this.top = -1;
		}

		//public override string ToString()
		//{
		//	return this.arr.ToString();
		//}
	}

	public interface IQueue<T>
	{
		int Size();
		void Clear();
		IQueue<T> Clone();
		T Dequeue();
		void Enqueue(T data);
		T Peek();
	}

}