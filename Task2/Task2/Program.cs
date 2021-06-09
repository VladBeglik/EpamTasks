using System;

namespace Task2
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = Convert.ToInt32(Console.ReadLine());
			int b = Convert.ToInt32(Console.ReadLine());
			string result = string.Empty;
			while(a != 0)
			{
				result += a % b;
				a /= b;
			}
			char[] arr = result.ToCharArray();
			Array.Reverse(arr);
			Console.WriteLine(new string(arr));


		}
	}
}
