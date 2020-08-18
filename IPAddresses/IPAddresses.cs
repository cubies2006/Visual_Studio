using System;
using System.Collections;
using System.IO;

namespace IPAddresses
{
	public class IPAddresses : DictionaryBase
	{
		public void Add(string name, string ip) 
		{
			base.InnerHashtable.Add(name, ip);
		}

		public string Item(string name) 
		{
			return base.InnerHashtable[name].ToString();
		}

		public void Remove(string name) 
		{
			base.InnerHashtable.Remove(name);
		}

		public IPAddresses(string txtFile) 
		{
			string line;
			string[] words;
			StreamReader inFile;
			inFile = File.OpenText(txtFile);
			while(inFile.Peek() != -1) 
			{
				line = inFile.ReadLine();
				words = line.Split(',');
                this.InnerHashtable.Add(words[0], words[1]);
			}
			inFile.Close();
		}

		static void Main() 
		{
			IPAddresses myIPs = new IPAddresses("D:\\POST-COLYMPIC_ERA\\Important_Stuff\\Computer-Related\\Programming_Projects\\Visual_Studio\\EmailCounting\\email.txt");
			Console.WriteLine("There are {0} IP addresses\n", myIPs.Count);
			Console.WriteLine("Jacqueline's IP address: " + myIPs.Item("Jacqueline"));
			Console.WriteLine("Joni Mae's IP address: " + myIPs.Item("Joni Mae"));
			Console.WriteLine("Michael's IP address: " + myIPs.Item("Michael Erick"));			
			Console.WriteLine("Meg's IP address: " + myIPs.Item("Meg"));
			Console.WriteLine("Roy Eduard's IP address: " + myIPs.Item("Roy Eduard"));
			Console.WriteLine("Jian Carlo's IP address: " + myIPs.Item("Jian Carlo"));
			Console.WriteLine("August's IP address: " + myIPs.Item("August"));
			Console.WriteLine("Crizzle's IP address: " + myIPs.Item("Crizzle"));
			Console.WriteLine("Juvy's IP address: " + myIPs.Item("Juvy"));
			Console.Read();
		}
	}
}