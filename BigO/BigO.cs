using System;
using System.Diagnostics;

namespace BigO
{
	public static class BigOn
	{
		static readonly string[] text = { "nemo" };

		static readonly string[] text100 = new string[100000];

		public static void CallSingle()
		{
			FindNemo(text);
		}

		public static void Call100()
		{
			
			for (int i =0; i< 100000; i++)
			{
				text100[i] = "nemo";
			}
			FindNemo(text100);
		}


		public static void FindNemo(string[] text)
		{
			Stopwatch stopWatch = new Stopwatch();

			stopWatch.Start();
			for (var i=0;i< text.Length;i++)
			{
				if(text[i] == "nemo")
				{
					Console.Write("nemo found");
				}
			}
			stopWatch.Stop();
			TimeSpan ts = stopWatch.Elapsed;
			string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
		   ts.Hours, ts.Minutes, ts.Seconds,
		   ts.Milliseconds / 10);
			Console.WriteLine("RunTime " + elapsedTime);
		}
	}

}
