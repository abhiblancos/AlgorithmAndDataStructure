using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureArray
{
	public partial class DSArray
	{		 
		public static void ReverseString()
		{
			Console.WriteLine("Please Enter Value :");						
			string str = Console.ReadLine();
			string newString = string.Empty;
			
			for (int i = str.Length-1; i >= 0; i--)
			{
				newString += str[i];
			}

			Console.WriteLine(newString);
			Console.ReadKey();
		}

	}
}
