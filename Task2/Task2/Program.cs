using System;

namespace Task2
{
	public class Program
	{
		static void Main(string[] args)
		{
			int a = Convert.ToInt32(Console.ReadLine());
			int b = Convert.ToInt32(Console.ReadLine());

			var result = ConvertToNumeralSystem(a, b);
			Console.WriteLine(result);
		}


		/// <summary>
		/// Convert number to some numeral system.
		/// </summary>
		/// <param name="number"></param>
		/// <param name="numeralSystem"></param>
		/// <returns></returns>
		public static string ConvertToNumeralSystem(int number, int numeralSystem)
		{
			if (number < 0)
			{
				throw new Exception(" ");
			}
			string result = string.Empty;
			while (number != 0)
			{
				result += number % numeralSystem;
				number /= numeralSystem;
			}
			char[] arr = result.ToCharArray();
			Array.Reverse(arr);
			return new string(arr);
		}
	}
}
