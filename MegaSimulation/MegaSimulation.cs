using System;

namespace MegaSimulation
{
	/// <summary>
	/// Summary description for MegaSimulation.
	/// </summary>
	class MegaSimulation
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		
		static void Calculate(int first, int second, int third)
		{
			int loop = 10;
			do
			{
				first += (loop * 2);
				second = third - first;
				third = loop + second;
				Console.WriteLine(first + third);
				loop--;
			}
			while (loop >= 1);
		}


		static void Main(string[] args)
		{
			//Mega Simulation #1 - Basic Operation with Array
			Console.WriteLine("Mega Simulation #1");
			int n = 10, x = 1, y = 3, z = 5;
			int[] array = new int[n];
			for (int ctr = 0; ctr < n; ctr++)
			{
				array[ctr] = x + y * z;
				x = y + z;
				y = array[ctr] - x;
				z = array[ctr] / y;
				Console.WriteLine(array[ctr] - z);
            }
            Console.WriteLine("\n(Press any key to continue)");
            Console.ReadLine();

			//Mega Simulation #2 - Using Method
			Console.WriteLine("Mega Simulation #2");
			int a = 2, b = 4, c = 6;
            Calculate(a, b, c);
            Console.WriteLine("\n(Press any key to continue)");
            Console.ReadLine();

			//Mega Simulation #3 - Basic Operation
			Console.WriteLine("Mega Simulation #3");
			int r = 7, s = 8, t = 9, u = 10;
			for (int counter = 1; counter <= u; counter++)
			{
				r = t + counter - u;
				s = r + u - counter;
				t = u - counter;
				if (t % counter == 0)
					Console.WriteLine(s * t - r);
				else
					Console.WriteLine(counter + (u * s));
            }
            Console.WriteLine("\n(Press any key to continue)");
            Console.ReadLine();

			//Mega Simulation #4 - String Manipulation			
			Console.WriteLine("Mega Simulation #4");
			string word1 = "Ronald Dee";
			string word2 = "August Caguioa";
			for (int ctr = 0; ctr < word1.Length; ctr++)
			{
				if (word1[ctr].CompareTo(word2[ctr]) == -1)
					Console.WriteLine(string.Concat(word1[ctr], "aw" + word2[ctr]));
				else
					Console.WriteLine(string.Concat(word2[ctr], "en" + word1[ctr]));
            }
            Console.WriteLine("\n(Press any key to end)");
			Console.Read();
		}
	}
}
