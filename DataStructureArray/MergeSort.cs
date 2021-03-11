using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureArray
{
	public partial class DSArray
	{
		public static void MergeSort()
		{
			Console.WriteLine("Please Enter Value and Press Enter :");

			int[] numberArray = new int[5];
			int i = 0;
			string str = string.Empty;
			while (i<5)
			{
				str = Console.ReadLine();

				if(int.TryParse(str,out int k))
				{
					numberArray[i] = k;
					i++;
				}
				else
					break;
			}

			int[] result = new int[1000];
			if (numberArray.Length >= 1)
			result = Sort(numberArray);

			Console.WriteLine(result);
		}

		public static int[] Sort(int[] numberArray)
		{
			int[] left;
			int[] right;
			int[] result = new int[numberArray.Length];

			if (numberArray.Length <= 1)
				return numberArray;

			int midPoint = numberArray.Length / 2;
			left = new int[midPoint];

			if(numberArray.Length % 2 ==0)
			{
				right = new int[midPoint];
			}else
				right = new int[midPoint+1];

			for(int i = 0; i<midPoint;i++)
			{
				left[i] = numberArray[i];
			}
			int x = 0;
			for (int i = midPoint; i < numberArray.Length; i++)
			{
				right[x] = numberArray[i];
				x++;
			}

			left = Sort(left);
			//Recursively sort the right array
			right = Sort(right);
			//Merge our two sorted arrays
			result = merge(left, right);
			return result;
		}

		public static int[] merge(int[] left, int[] right)
		{
			int[] result = new int[left.Length + right.Length];


			int indexLeft = 0, indexRight = 0, indexResult = 0;

			while(indexLeft < left.Length || indexRight < right.Length )
			{
				if (indexLeft < left.Length && indexRight < right.Length)
				{
					if(left[indexLeft] <= right[indexRight])
					{
						result[indexResult] = left[indexLeft];
						indexLeft++;
						indexResult++;
					}
					else
					{
						result[indexResult] = right[indexRight];
						indexRight++;
						indexResult++;
					}
				}
				else if(indexLeft < left.Length)
				{
					result[indexResult] = left[indexLeft];
					indexLeft++;
					indexResult++;
				}
				else
				{
					result[indexResult] = right[indexRight];
					indexRight++;
					indexResult++;
				}
			}

			return result;
			
		}
	}
}
