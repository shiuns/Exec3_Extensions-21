using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _作業03_Exec3_Extensions_Q1_21謝孟勳
{
	internal class Program
	{
		static void Main(string[] args)
		{
			bool result = 77.IsEven();
			Console.WriteLine(result);

			bool result1 = 88.IsEven();
			Console.WriteLine(result1);

			bool result2 = 54.IsOdd();
			Console.WriteLine(result2);

			bool result3 = 31.IsOdd();
			Console.WriteLine(result3);
		}
	}

	public static class IsMath
	{
		public static bool IsEven(this int sourse)
		{
			return sourse % 2 == 0;
		}

		public static bool IsOdd(this int number)
		{
			return number % 2 == 1;
		}
	}
}
