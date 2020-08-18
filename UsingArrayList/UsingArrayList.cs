using System;
using System.Collections;

namespace UsingArrayList
{
	class UsingArrayList
	{
		static void Main()
		{
			ArrayList names = new ArrayList();
			names.Add("Michael Erick");
			names.Add("Jacqueline");
			names.Add("Roy Eduard");
			names.Add("Joni Mae");
			names.Add("Omega");
			Console.WriteLine("The original list of names are: ");
			foreach (object name in names)
				Console.WriteLine(name);
			Console.WriteLine();
			String[] newNames = new string[]{"Jian Carlo", "August"};
			ArrayList moreNames = new ArrayList();
			moreNames.Add("Crizzle");
			moreNames.Add("Juvy");
			moreNames.Add("Vanessa");
			moreNames.Add("Clayton");
			moreNames.Add("Alisa");
			names.InsertRange(0, newNames);
			names.AddRange(moreNames);
			Console.WriteLine("The new list of names are: ");
			foreach (object name in names)
				Console.WriteLine(name);
			Console.Read();
		}
	}
}
