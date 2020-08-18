using System;

namespace FourDigitNumber
{
	/// <summary>
	/// Summary description for FourDigitNumber.
	/// </summary>
	class FourDigitNumber
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Console.Write("Please enter a 4-Digit number: ");
			int num = int.Parse(Console.ReadLine());
			if ((num < 1000) || (num > 9999))
				Console.WriteLine("INVALID INPUT!!!");
			else
			{
				int a = num % 10; 
				int b = (num / 10) % 10; 
				int c = (num / 100) % 10; 
				int d = (num / 1000) % 10;
				int sum = a + b + c + d;
				String reverse = a + "" + b + "" + c + "" + d;
				String last2first = a + "" + d + "" + c + "" + b;
				String secondthirdswap = d + "" + b + "" + c + "" + a;
				Console.WriteLine("The sum of the 4-Digit number is " + sum);
				Console.WriteLine("The reverse of the 4-Digit number is " + reverse);
				Console.WriteLine("The last digit on the first position of the 4-Digit number is " + last2first);
				Console.WriteLine("The swapping on the 2nd and 3rd digit of the 4-Digit number is " + secondthirdswap);
			}
            Console.WriteLine("\n(Press any key to end)");
			Console.Read();
		}
	}
}
