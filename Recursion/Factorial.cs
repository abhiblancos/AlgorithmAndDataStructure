using System;

namespace Recursion
{
	public class Factorial
	{
		public void FindFactorial()
		{
			Console.WriteLine("Please enter number of which factorial needs to find out");
			var str = Console.ReadLine();

			int num = Convert.ToInt32(str);
			int result = CalculateFact(num);

			Console.WriteLine("Factorial is  "
				+ result.ToString());

		}

		int CalculateFact(int num)
		{
			if (num > 1)
				return num * CalculateFact(num - 1);
			else
				return num;
			 
		}

	}
}
