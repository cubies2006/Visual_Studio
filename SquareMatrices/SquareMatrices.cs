using System;

namespace SquareMatrices
{
	/// <summary>
	/// Summary description for SquareMatrices.
	/// </summary>
	class SquareMatrices
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void PrintMatrix(int n, int[,] matrix)
		{
			for (int row = 0; row < n; row++)
			{
				for (int col = 0; col < n; col++)
				{
					Console.Write("{0,4}", matrix[row, col]);
				}
				Console.WriteLine();
			}
		}

		static void Main(string[] args)
		{
			Console.Write("Enter a value for Square Matrices (1 to 15 only): ");
			int n = Convert.ToInt32(Console.ReadLine());
			if ((n < 1) || (n > 15))
				Console.WriteLine("INVALID INPUT!!!");
			else
			{
				int[,] matrix = new int[n, n];
				//First Matrix
				int num = 1;
				for (int row = 0; row < n; row++)
				{
					for (int col = 0; col < n; col++)
					{
						matrix[row, col] = n * col + num;
					}
					num++;
				}
				Console.WriteLine("\nFirst Matrix");
				PrintMatrix(n, matrix);

				//Second Matrix
				Console.WriteLine();
				num = 1;
				int c1 = 0, c2 = n - 1;
				while (num <= n * n)
				{
					//Right
					for (int i = c1; i <= c2; i++)
						matrix[c1, i] = num++;
					//Down
					for (int j = c1 + 1; j <= c2; j++)
						matrix[j, c2] = num++;
					//Left
					for (int i = c2 - 1; i >= c1; i--)
						matrix[c2, i] = num++;
					//Up
					for (int j = c2 - 1; j >= c1 + 1; j--)
						matrix[j, c1] = num++;
					c1++;
					c2--;
				}
				Console.WriteLine("Second Matrix");
				PrintMatrix(n, matrix);

				//Third Matrix
				Console.WriteLine("\nThird Matrix");
				for (int i = 0; i < n; i++)
				{
					for (int j = 1; j < n + 1; j++)
					{
						Console.Write("{0,4}", i + j);
					}
					Console.WriteLine();
				}
			}
            Console.WriteLine("\n(Press any key to end)");
			Console.Read();
		}
	}
}
