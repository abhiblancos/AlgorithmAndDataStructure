using System;

namespace Sorting
{
	public class BubbleSort
	{

		public void BubbleSorting()
		{
			int[] inputArray =  new int[] {4, 2, 7, 4, 9, 3, 1};
			

			for (int i = 0; i< inputArray.Length -1; i++)
			{
				for(int j = 0; j< inputArray.Length -1; j++)
				{
					if(inputArray[j] >= inputArray[j+1])
					{
						int temp = inputArray[j];
						inputArray[j] = inputArray[j + 1];
						inputArray[j + 1] = temp;
					}

				}
			}

			foreach (var item in inputArray)
			{
				Console.WriteLine(item);
			}
		}
	}
}
