using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
	public class Fibonacci
	{
		public void FindFibonacci()
		{
			Console.WriteLine("Please enter number of which Fibonacci needs to find out");
			var str = Console.ReadLine();

			int num = Convert.ToInt32(str);
			
			CalculateFibonacci(num,1,0);
		}
		int CalculateFibonacci(int num, int val, int prev)
		{
			Console.WriteLine(val);
			if (num == 0)
				return prev;
			if (num == 1)
				return val;

			return CalculateFibonacci(num - 1, val + prev, val);

		}
	}


}
