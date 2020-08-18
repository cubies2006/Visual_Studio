using System;
using System.IO;

namespace NumberSearching
{	
	class NumberSearching
	{		
		static void Main()
		{			
			try
			{
				int[] numbers = new int[100];
				StreamReader numFile = File.OpenText("D:\\POST-COLYMPIC_ERA\\Important_Stuff\\Computer-Related\\Programming_Projects\\Visual_Studio\\NumberSearching\\numbers.txt");
				for (int i = 0; i < numbers.Length - 1; i++)
					numbers[i] = Convert.ToInt32(numFile.ReadLine(), 10);
				int searchNumber;
				Console.Write("Enter a number to search for: ");
				searchNumber = Convert.ToInt32(Console.ReadLine(), 10);
				int foundAt;
				foundAt = SeqSearch(numbers, searchNumber);
				if (foundAt >= 0)
					Console.WriteLine(searchNumber + " is in the array at position " + foundAt + ".");
				else
					Console.WriteLine(searchNumber + " is not in the array.");
				numFile.Close();
			}
			catch (IOException ioe)
			{
				Console.WriteLine("File does not exist.");
			}
			Console.Read();
		                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         }

		static int SeqSearch(int[] arr, int sValue)
		{
			for (int index = 0; index < arr.Length - 1; index++)
				if (arr[index] == sValue)
					return index;
			return -1;
		}
	}
}