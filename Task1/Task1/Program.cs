using System;

namespace Task1
{
	class Program
	{
		static void Main(string[] args)
		{
			int max = 0;
			int count = 0;
			string a = Console.ReadLine();

			for(int i = 0; i < a.Length - 1; i++)
			{
				if(a[i] != a[i + 1])
				{
					count++;
				}
				else
				{
					count = 0;
				}
			}

			if(count > max)
			{
				max = count;
			}

			Console.WriteLine(max+1);
		}
	}
}
