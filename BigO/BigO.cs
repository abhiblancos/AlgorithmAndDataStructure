using System;

namespace BigO
{
	public static class BigOn
	{
		static string[] text = { "nemo" };

		static string[] text100 = new string[100000];

		public static void callSingle()
		{
			FindNemo(text);
		}

		public static void call100()
		{			
			for(int i =0; i< 100000; i++)
			{
				text100[i] = "nemo";
			}
			FindNemo(text100);
		}


		public static void FindNemo(string[] text)
		{
			var t0 = DateTime.UtcNow;

			for(var i=0;i< text.Length;i++)
			{
				if(text[i] == "nemo")
				{
					Console.Write("nemo found");
				}
			}

			var t1 = DateTime.UtcNow;

			Console.Write("time took" +  (t1 - t0).ToString());
		}
	}
}
