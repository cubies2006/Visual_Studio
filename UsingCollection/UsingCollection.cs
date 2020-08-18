using System;
using System.Collections;

namespace UsingCollection
{
	public class Collection : CollectionBase
	{
		public void Add(object item)
		{
			InnerList.Add(item);
		}

		public void Remove(object item)
		{
			InnerList.Remove(item);
		}

		public new void Clear()
		{
			InnerList.Clear();
		}

		public new int Count()
		{
			return InnerList.Count;
		}

		public void Insert(int index, object item)
		{
			InnerList.Insert(index, item);
		}

		public void Contains(object item)
		{
			InnerList.Contains(item);
		}

		public new void RemoveAt(int index)
		{
			InnerList.RemoveAt(index);
		}
	}

	class UsingCollection
	{
		static void Main()
		{
			Collection names = new Collection();
			names.Add("David");
			names.Add("Bernica");
			names.Add("Raymond");
			names.Add("Clayton");
			foreach (Object name in names)
				Console.WriteLine(name);
			Console.WriteLine("Number of names: " + names.Count());
			names.Insert(1, "Ronald");			
			Console.WriteLine("\nNumber of names (after Inserting Ronald at index 1): " + names.Count());
			foreach (Object name in names)
				Console.WriteLine(name);
			names.Remove("Raymond");
			names.RemoveAt(0);
			Console.WriteLine("\nNumber of names (after Removing Raymond & David): " + names.Count());
			foreach (Object name in names)
				Console.WriteLine(name);
			names.Clear();
			Console.WriteLine("\nNumber of names (after Clearing all names): " + names.Count());			
			Console.Read();
		}
	}
}