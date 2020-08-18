using System;
using System.Collections;

namespace CStack
{	
	class CStack
	{		
		private int p_index;
		private ArrayList list;

		public CStack()
		{
			list = new ArrayList();
			p_index = -1;
		}

		public int count
		{
			get
			{
				return list.Count;
			}
		}

		public void push(object item)
		{
			list.Add(item);
			p_index++;
		}

		public object pop()
		{
			object obj = list[p_index];
			list.RemoveAt(p_index);
			p_index--;
			return obj;
		}

		public void clear()
		{
			list.Clear();
			p_index = -1;
		}

		public object peek()
		{
			return list[p_index];
		}
		
		static void Main(String[] args)
		{
			CStack alist = new CStack();
			string ch;
			Console.Write("Enter a word to determine if it is a PALINDROME: ");
			String word = Console.ReadLine();
			bool isPalindrome = true;
			for (int x = 0; x < word.Length; x++)
				alist.push(word.Substring(x, 1));
			int pos = 0;
			while (alist.count > 0)
			{
				ch = alist.pop().ToString();
				if (ch != word.Substring(pos, 1))
				{
					isPalindrome = false;
					break;
				}
				pos++;
			}
			if (isPalindrome)
				Console.WriteLine(word + " is a PALINDROME.");
			else
				Console.WriteLine(word + " is NOT a PALINDROME.");
            Console.WriteLine("\n(Press any key to end)");
			Console.Read();
		}
	}
}