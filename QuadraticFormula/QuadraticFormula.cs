using System;

namespace QuadraticFormula
{
	/// <summary>
	/// Summary description for QuadraticFormula.
	/// </summary>
	class QuadraticFormula
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			Console.Write("Enter the first value: ");
			double first = double.Parse(Console.ReadLine());
			Console.Write("Enter the second value: ");
			double second = double.Parse(Console.ReadLine());
			Console.Write("Enter the third value: ");
			double third = double.Parse(Console.ReadLine());
			Console.WriteLine("\nUsing Quadratic Formula: x = (-b +/- Sqrt(b^2 - 4ac) / 2a");
			SolveQuadratic(first, second, third);
            Console.WriteLine("\n(Press any key to end)");
			Console.Read();
		}

		public static void SolveQuadratic(double a, double b, double c)
		{
			//Quadratic Formula: x = (-b +/- Sqrt(b^2 - 4ac) / 2a
			
			double insideSquareRoot = (b * b) - 4 * a * c;
			double x1, x2;

			if (insideSquareRoot < 0)
			{
				//There is no solution
				x1 = double.NaN;
				x2 = double.NaN;				
				Console.WriteLine("There are no roots.");
			}
			else
			{
				//Compute the value of each x
				//If there is only one solution, both x's will be the same
				double sqrt = Math.Sqrt(insideSquareRoot);
				x1 = (-b + sqrt) / (2 * a);
				x2 = (-b - sqrt) / (2 * a);
				Console.WriteLine("The roots are " + x1 + " and " + x2);
			}
		}
	}
}
