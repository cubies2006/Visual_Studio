using System;
using System.IO;
using System.Text.RegularExpressions;

namespace EmailCounting
{
	class EmailCounting
	{
		static void Main(string[] args)
		{
			StreamReader SR;
			string S;

			//match against this pattern
			string pattern = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
			Regex re = new Regex(pattern);

			//Open the file and read through it...

			SR = File.OpenText("D:\\POST-COLYMPIC_ERA\\Important_Stuff\\Computer-Related\\Programming_Projects\\Visual_Studio\\EmailCounting\\email.txt");			
			Console.WriteLine("Match(es) found: ");
			S = SR.ReadLine();
			while (S != null)
			{
				//get all matches
				MatchCollection matches = re.Matches(S);
				//we have a match?				
				if (matches.Count > 0)
				{
					//print out matches
					for (int i = 0; i < matches.Count; i++)
					{
						Console.WriteLine(matches[i]);
					}
				}
				//next line
				S = SR.ReadLine();
			}
			SR.Close();
			Console.Read();
		}
	}
}