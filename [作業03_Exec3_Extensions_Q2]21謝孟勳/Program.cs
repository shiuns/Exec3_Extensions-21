using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _作業03_Exec3_Extensions_Q2_21謝孟勳
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string value = "9584625871";

			string result = value.Left(5);
			Console.WriteLine(result);

			value = null;
			string result1 = value.Left(2);
			Console.WriteLine(result1);

			value = "3";
			string result2 = value.Left(1000);
			Console.WriteLine(result2);

			string result3 = value.Left(-1000);
			Console.WriteLine(result3);
		}
	}
	public static class IsMath
	{
		public static string Left(this string value, int lengh)
		{
			if (string.IsNullOrEmpty(value)) return string.Empty;
			if (lengh <= 0) return string.Empty;
			if (value.Length < lengh) return value;

			return value.Substring(0, lengh);
		}
	}
}
