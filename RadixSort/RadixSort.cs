using System;
using System.Collections;

namespace RadixSort
{	
	class RadixSort
	{
		enum DigitType {ones = 1, tens = 10}

		static void DisplayArray(int[] n)
		{
			for(int x = 0; x <= n.GetUpperBound(0); x++)
				Console.Write(n[x] + " ");
		}

		static void RSort(Queue[] que, int[] n, DigitType digit)
		{
			int snum;
			for(int x = 0; x <= n.GetUpperBound(0); x++)
			{
				if (digit == DigitType.ones)
					snum = n[x] % 10;
				else
					snum = n[x] / 10;
				que[snum].Enqueue(n[x]);
			}
		}

		static void BuildArray(Queue[] que, int[] n)
		{
			int y = 0;
			for (int x = 0; x <= 9; x++)
				while(que[x].Count > 0)
				{
					n[y] = Int32.Parse(que[x].Dequeue().ToString());
					y++;
				}
		}

		static void Main()
		{
			Queue[] numQueue = new Queue[10];
			int[] nums = new int[10];
			Console.WriteLine("Enter 10 unsorted integers for Radix Sort:\n(ranging from 0 to 99 only)");
			for (int i = 0; i < 10; i++)
				nums[i] = Int32.Parse(Console.ReadLine());
			//Display original list
			for (int i = 0; i < 10; i++)
				numQueue[i] = new Queue();
			//First pass sort
			RSort(numQueue, nums, DigitType.ones);
			//numQueue, nums, 1
			BuildArray(numQueue, nums);
			Console.WriteLine();
			Console.WriteLine("First pass results: ");
			DisplayArray(nums);
			Console.WriteLine();
			//Second pass sort
			RSort(numQueue, nums, DigitType.tens);
			//numQueue, nums, 10
			BuildArray(numQueue, nums);
			Console.WriteLine();
			Console.WriteLine("Second pass results: ");
			// Display final results
			DisplayArray(nums);
            Console.WriteLine("\n\n(Press any key to end)");
			Console.Read();
		}
	}
}