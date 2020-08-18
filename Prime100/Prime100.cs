using System;

namespace Prime100
{
	/// <summary>
	/// Summary description for Prime100.
	/// </summary>
	class Prime100
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Console.Write("The prime numbers from 1 to 100 are:\n");
			for (int i = 1; i <= 100; i++)
			{
				int count1 = 0;
				int count2 = 0;
				for (int k = 2; k < i - 1; k++)
				{
					int rem = i % k;
					if (rem == 0)
						count1++;
					else
						count2++;
				}
				if (count1 == 0)
					Console.Write("{0}\t",i);
			}
			Console.Read();
		}
	}
}
