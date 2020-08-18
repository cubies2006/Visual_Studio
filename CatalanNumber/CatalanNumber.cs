using System;

namespace CatalanNumber
{
	class CatalanNumber
	{
		static ulong FindPartialFactorial (ulong startNumber, ulong num)
		{
			ulong factorial = (ulong)startNumber;
			for (ulong i = startNumber + 1; i < num + 1; i++)
				factorial *= i;
			return factorial;
		}

		static void Main(string[] args)
		{
			Console.Write("Enter a value for Catalan Number (0 to 14 only): ");
			ulong num = ulong.Parse(Console.ReadLine());
			if (num >= 0 && num <= 14)
			{
				Console.WriteLine("\nThe sequence of Catalan Number from index 0 to {0} is:", num);
				for (ulong ctr = 0; ctr <= num; ctr++)
				{
					ulong nth_element = FindPartialFactorial((ctr + 1), (2 * ctr)) / FindPartialFactorial(1, ctr + 1);
					Console.Write("{0}", nth_element);
					if (ctr <= (num - 1))
						Console.Write(",  ");
				}
			}
			else
				Console.WriteLine("\nINVALID INPUT!!!");
            Console.WriteLine("\n\n(Press any key to end)");
			Console.Read();
		}
	}
}