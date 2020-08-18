using System;

namespace OperationOfTwoSets
{
	/// <summary>
	/// Summary description for OperationOfTwoSets.
	/// </summary>
	class OperationOfTwoSets
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			//Size of Set A
			Console.Write("Enter the size of Set A: ");
			int x = int.Parse(Console.ReadLine());			
			int[] setA = new int[x];
			//Elements of Set A
			Console.WriteLine("Enter the {0} elements of Set A: ", x);
			for (int ctrA = 0; ctrA < x; ctrA++)
				setA[ctrA] = int.Parse(Console.ReadLine());

			//Size of Set B
			Console.Write("\nEnter the size of Set B: ");
			int y = int.Parse(Console.ReadLine());	
			//Elements of Set B
			int[] setB = new int[y];
			Console.WriteLine("Enter the {0} elements of Set B: ", y);
			for (int ctrB = 0; ctrB < y; ctrB++)
				setB[ctrB] = int.Parse(Console.ReadLine());

			//Intersection of Sets A and B				
			int[,] Intersection = new int[x, y]; 
			Console.Write("\nThe Intersection of Sets A and B are: ");
			for (int ctr1 = 0; ctr1 < x; ctr1++)
			{
				for (int ctr2 = 0; ctr2 < y; ctr2++)
				{
					if (setA[ctr1] == setB[ctr2])
					{
						Intersection[ctr1, ctr2] = setA[ctr1];
						Console.Write("{0} ", Intersection[ctr1, ctr2]);
					}
				}				
			}

			//Cartesian Product of Sets A and B
			Console.WriteLine("\nThe Cartesian Product of Sets A and B are: ");
			for (int ctr1 = 0; ctr1 < x; ctr1++)
				for (int ctr2 = 0; ctr2 < y; ctr2++)
					Console.Write("({0},{1}) ", setA[ctr1], setB[ctr2]);
            Console.WriteLine("\n\n(Press any key to end)");
			Console.Read();
		}
	}
}
