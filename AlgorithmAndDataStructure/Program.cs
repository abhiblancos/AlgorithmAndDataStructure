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
			Console.WriteLine("Data Structure: \n 1 : Big O(n) \n 2 : Array \n 3 : Linked List \n 4 : Stack \n 7 : Factorial recursion \n 8 : Fibonacci \n 9 : ReverseString (Recursion) \n 10 : Bubble Sort \n 11 : Selection Sort \n 12 : Insertion Sort");
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
				case "11":
					SelectionSort selection = new();
					selection.SortSelection();
					break;
				case "12":
					InsertionSort insertion = new();
					insertion.Insertion();
					break;
			}
		}

	}

	
}
