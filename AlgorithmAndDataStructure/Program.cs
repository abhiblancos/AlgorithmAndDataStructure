using System;
using BigO;

namespace AlgorithmAndDataStructure
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Please select");
			Console.WriteLine("Data Structure: 1 : Big O(n) \n 2=medium 3=large");
			Console.Write("Please enter your selection: ");
			string str = Console.ReadLine();
			switch (str)
			{
				case "1":
					BigOn.call100();
					break;

			}
		}
	}
}
