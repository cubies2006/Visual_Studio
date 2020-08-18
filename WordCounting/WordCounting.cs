using System;
using System.Text.RegularExpressions;

namespace WordCounting
{
	class WordCounting
	{		
		static void Main(string[] args)
		{
			Regex reg = new Regex(@"[A-Za-z0-9]+");
			Console.WriteLine("Enter a word, phrase, sentence, or paragraph: ");
			string statement = Console.ReadLine();
			MatchCollection matchSet;
			matchSet = reg.Matches(statement);			
			Console.WriteLine("\nTotal number of words = " + matchSet.Count);
			if (matchSet.Count > 0)
				foreach (Match aMatch in matchSet)
					Console.WriteLine(aMatch);
            Console.WriteLine("\n(Press any key to end)");
			Console.Read();
		}
	}
}