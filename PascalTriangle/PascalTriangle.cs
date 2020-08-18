using System;

namespace PascalTriangle
{
	/// <summary>
	/// Summary description for PascalTriangle.
	/// </summary>
	class PascalTriangle
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void CreateTriangle (int n)
		{
			if ((n > 0) && (n <= 30))
			{
				for (int i = 0; i < n; i++)
				{
					int c = 1;
					Console.Write("".PadLeft(2 * (n - 1 - i)));
					for (int k = 0; k <= i; k++)
					{
						Console.Write("{0} ",c.ToString().PadLeft(3));
						c = c * (i - k) / (k + 1);
					}
					Console.WriteLine();
				}
			}
			else
				Console.WriteLine("INVALID INPUT!!!");
		}

		static void Main(string[] args)
		{
			Console.Write("Enter a value for Pascal Triangle (1 to 30 only): ");
			int val = int.Parse(Console.ReadLine());
			Console.WriteLine();
			CreateTriangle(val);
            Console.WriteLine("\n(Press any key to end)");
			Console.Read();
		}
	}
}