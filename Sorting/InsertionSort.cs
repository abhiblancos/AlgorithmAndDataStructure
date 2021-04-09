using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
	public class InsertionSort
	{
		public void Insertion()
		{
			Stopwatch stopWatch = new Stopwatch();
			int[] array = new int[] { 8, 6, 4, 1, 9, 2, 7, 5, 3 };

			Console.WriteLine(string.Join(',', array));
			stopWatch.Start();
			for (int i = 1; i < array.Length; ++i)
			{
				int key = array[i];
				int j = i - 1;
				while (j>=0 && array[j]>key)
				{
					array[j + 1] = array[j];
					j = j - 1;
				}
				array[j + 1] = key;
			}
			foreach (var item in array)
			{
				Console.WriteLine(item);
			}
			stopWatch.Stop();

			TimeSpan ts = stopWatch.Elapsed;

			// Format and display the TimeSpan value.
			string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
				ts.Hours, ts.Minutes, ts.Seconds,
				ts.Milliseconds / 10);
			Console.WriteLine("RunTime " + elapsedTime);
			Console.ReadLine();
		}

	}
}
