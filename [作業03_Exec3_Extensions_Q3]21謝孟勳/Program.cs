using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _作業03_Exec3_Extensions_Q3_21謝孟勳
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string value = "566";
			int number = value.ToInt(-1);
			Console.WriteLine(number);

			value = "AS6";
			number = value.ToInt(-1);
			Console.WriteLine(number);
		}
	}
	public static class StringConvert
	{
		public static int ToInt(this string value, int defaultValue)
		{
			bool isInt = int.TryParse(value, out int number);

			return isInt ? number : defaultValue;
		}
	}
}
