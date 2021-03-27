using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
	public class ReverseString
	{
		public void RevString()
		{
			Console.WriteLine("Please enter number of which Fibonacci needs to find out");
			var str = Console.ReadLine();

			Console.WriteLine(StringRev(str));
		}

		public string StringRev(string str)
		{
			if (str.Length == 0)
			{
				return "";
			}
			return StringRev(str.Substring(1)) + str[0];
		}
	}
}
