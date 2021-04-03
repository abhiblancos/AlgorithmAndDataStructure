using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
	 public class SelectionSort
	{

		public void SortSelection()
		{
			int[] unSortedArray = new int[] { 8, 5, 9, 6, 2, 4, 1, 3 };			
			for (int i = 0; i< unSortedArray.Length -1;i++)
			{
				int lowestValue = i;				

				for(int j = i; j< unSortedArray.Length;j++ )
				{
					if(unSortedArray[lowestValue] > unSortedArray[j])
					{
						lowestValue = j;
						
					}
				}				
					int temp = unSortedArray[i];
					unSortedArray[i] = unSortedArray[lowestValue];
					unSortedArray[lowestValue] = temp;
				
			}


			foreach (var item in unSortedArray)
			{
				Console.WriteLine(item);
			}
			Console.ReadLine();
		}
	}
}
