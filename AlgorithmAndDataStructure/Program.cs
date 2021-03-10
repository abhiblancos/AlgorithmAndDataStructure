using System;
using BigO;
using DataStructureArray;


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
			Console.WriteLine("Data Structure: 1 : Big O(n) \n 2=Array 3=large");
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
			}
		}

	}

	
}
