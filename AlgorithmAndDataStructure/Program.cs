using System;
using BigO;
using DataStructureArray;
using DataStructureLinkedList;
using Recursion;
using Sorting;
using StackAndQueue;

namespace AlgorithmAndDataStructure
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Selection.SelectionMethod();
		}
		

	}

	public static class Selection
	{

		public static void SelectionMethod()
		{
			Console.WriteLine("Please select");
			Console.WriteLine("Data Structure: 1 : Big O(n) \n 2=Array \n3=Linked List \n 4 = Stack \n 7 = Factorial recursion \n 8 = Fibonacci");
			Console.Write("Please enter your selection: ");
			string str = Console.ReadLine();
			switch (str)
			{
				case "1":
					BigOn.Call100();
					break;
				case "2":
					DSArray.ChooseArray();
					break;
				case "3":
					LinkedList linkedList = new LinkedList(5);
					linkedList.LinkListOperation();
					break;
				case "4":
					Stack stack = new Stack();
					stack.StackOperation();
					break;
				case "7":
					Factorial fact = new Factorial();
					fact.FindFactorial();
					break;
				case "8":
					Fibonacci fibonacci = new Fibonacci();
					fibonacci.FindFibonacci();
					break;
				case "9":
					ReverseString rev = new ReverseString();
					rev.RevString();
					break;
				case "10":
					BubbleSort bubble = new();
					bubble.BubbleSorting();
					break;
			}
		}

	}

	
}
