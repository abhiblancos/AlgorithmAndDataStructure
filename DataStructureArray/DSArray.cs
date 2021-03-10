using System;


namespace DataStructureArray
{
	public partial class DSArray
	{

		public static void ChooseArray()
		{
			Console.Clear();
			Console.WriteLine("Please select");
			Console.WriteLine("Data Structure: 1 : Reverse String \n 2=medium \n 3=large");
			Console.Write("Please enter your selection: ");
			string str = Console.ReadLine();
			switch (str)
			{
				case "1":
					ReverseString();
					break;
				case "3":
					ChooseArray();
					break;
			}
		}

	}
}
