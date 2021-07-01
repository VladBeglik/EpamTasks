using System;

namespace Task1
{
	public class Program
	{
		static void Main(string[] args)
		{
			string str = Console.ReadLine();

			var result = CountOfUniqueChar(str);
			Console.WriteLine($"привет Вадя {result}"); ;
		}

		/// <summary>
		/// Сounts the number of unique characters in a str.
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		public static int CountOfUniqueChar(string str)
		{

			if (str.Length <= 0)
			{
				throw new Exception("The input data has zero or negative length");
			}

			if (str is null)
			{
				throw new ArgumentNullException(nameof(str));
			}

			int max = 0;
			int count = 0;
			for (int i = 0; i < str.Length - 1; i++)
			{
				if(str[i] != str[i + 1])
				{
					count++;
				}
				else
				{
					count = 0;
				}
			}

			if (count > max)
			{
				max = count;
			}

			return max + 1;
		}
	}
}
