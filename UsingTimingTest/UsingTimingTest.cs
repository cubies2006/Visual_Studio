using System;
using System.Diagnostics;

namespace UsingTimingTest
{
	class UsingTimingTest
	{
		TimeSpan startingTime;
		TimeSpan duration;

		public UsingTimingTest()
		{
			startingTime = new TimeSpan(0);
			duration = new TimeSpan(0);
		}

		public void stopTime()
		{
			duration = Process.GetCurrentProcess().Threads[0].UserProcessorTime.Subtract(startingTime);
		}

		public void startTime()
		{
			GC.Collect();
			GC.WaitForPendingFinalizers();
			startingTime = Process.GetCurrentProcess().Threads[0].UserProcessorTime;
		}

		public TimeSpan result()
		{
			return duration;
		}

		static void Main()
		{
			int[] nums = new int[100000];
			BuildArray(nums);
			UsingTimingTest tObj = new UsingTimingTest();
			tObj.startTime();
			DisplayNums(nums);
			tObj.stopTime();
			Console.WriteLine("Time (.NET) " + tObj.result().TotalSeconds);			
			Console.ReadLine();
		}

		static void BuildArray(int[] arr)
		{
			for (int i = 0; i <= 99999; i++)
				arr[i] = i;
		}

		static void DisplayNums(int[] arr)
		{
			for (int i = 0; i <= arr.GetUpperBound(0); i++)
				Console.WriteLine(arr[i] + " ");
		}
	}
}
