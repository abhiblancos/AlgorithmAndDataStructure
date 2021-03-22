using System;

namespace StackAndQueue
{
	public class Stack
	{
		private Node top { get; set; }

		private Node bottom { get; set; }

		private int length { get; set; }


		public Stack()
		{
			this.top = null;
			this.bottom =null;
			length = 0;
		}

		public void Pop()
		{
			if (this.top == null)
				return;

			Node holdingPointer = this.top;

			this.top = this.top.next;
			this.length--;

		}

		public void Push(int value)
		{
			Node newNode = new(value);
			if (this.length <= 0)
			{
				this.top = newNode;
				this.bottom = newNode;
			}
			else
			{
				Node holdingPointer = this.top;
				this.top = newNode;
				this.top.next = holdingPointer;
			}
			this.length++;
		}

		public int Peek()
		{
			if (this.length > 0)
				return this.top.value;
			return -100000; //returning -100000 if length is 0
		}


		public void PrintStack()
		{
			if (top == null)
			{
				return;
			}
			Node currentNode = top;
			Console.Write(currentNode.value);
			currentNode = currentNode.next;
			while (currentNode != null)
			{
				Console.Write("-->" + currentNode.value);
				currentNode = currentNode.next;
			}
			Console.ReadKey();
		}

		public void StackOperation()
		{
			Console.Clear();
			Console.WriteLine("Please select");
			Console.WriteLine("Stack :\n 1: Push \n 2= Pop \n 3= Peek \n 4 = Print");
			Console.Write("Please enter your selection: ");
			string str = Console.ReadLine();
			switch (str)
			{
				case "1":
					Console.Write("Please enter your value to Push: ");
					string valueAppend = Console.ReadLine();
					Push(Convert.ToInt32(valueAppend));
					StackOperation();
					break;
				case "2":
					Console.Write("Pop operation: ");					
					Pop();
					StackOperation();
					break;
				case "3":
					Console.Write("Peek operation: ");
					Peek();
					StackOperation();					
					break;
				case "4":
					Console.Write("PrintStack operation: ");
					PrintStack();
					StackOperation();
					break;				
			}
		}

	}

	public class Node
	{
		public int value { get; set; }

		public Node next { get; set; }

		public Node(int value)
		{
			this.value = value;
			this.next = null;
		}
	}
}
