using System;

namespace Horspool
{
	public static class Program
	{
		static void Main(string[] args)
		{
			//Apply for 5 tests
			for (int i = 0; i < 6; i++)
			{
				Test();
				Console.ReadKey();

			}
		}

		public static void Test()
		{
			Console.WriteLine("Shkruani fjalën për t'u përshkuar - haystack:");
			string haystack = Console.ReadLine();

			Console.WriteLine();

			Console.WriteLine("Shkruani fjalën kërkuese - needle:");
			string needle = Console.ReadLine();

			int match = Horspool.Find(haystack, needle);

			Console.Clear();

			if (match == -1)
			{
				Console.WriteLine("Asnjë përshtatje nuk u gjend!");
				return;
			}

			Console.WriteLine("Përshtatja në karakterin {0}", match);

			Console.WriteLine();
			Console.WriteLine(haystack);
			for (int i = 0; i < match; i++)
				Console.Write(" ");

			for (int i = 0; i < needle.Length; i++)
				Console.Write("-");

		}
	}
}