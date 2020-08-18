using System;

namespace Fibonacci100
{
	/// <summary>
	/// Summary description for Fibonacci100.
	/// </summary>
	class Fibonacci100
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Console.WriteLine("The Fibonacci Sequence From the 1st to the 100th Digit are: "); 
			ulong x = 1, y = 0, z = 1, ctr;
			for (ctr = 0; ctr < 100; ctr++)
			{
                if (ctr % 10 == 0)
                    Console.Write("\n");
                else
                {
                    Console.Write(z);
                    x = y;
                    y = z;
                    z = x + y;
                    if (ctr < 99)
                    {
                        Console.Write(", ");
                    }
                }
			}
            Console.WriteLine("\n\n(Press any key to continue)");
			Console.Read();
		}
	}
}
