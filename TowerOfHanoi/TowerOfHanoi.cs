using System;

namespace TowerOfHanoi
{
	/// <summary>
	/// Summary description for TowerOfHanoi.
	/// </summary>
	class TowerOfHanoi
	{
		public static void move(int n, int from, int to, int via)
		{
			if (n == 1)
				Console.WriteLine("Move disk from pole " + from + " to pole " + to);
			else
			{
				move(n - 1, from, via, to);
				move(1, from, to, via);
				move(n - 1, via, to, from);
			}
		}

		static void Main(string[] args)
		{
			move(4, 1, 2, 3);
			Console.Read();
		}
	}
}