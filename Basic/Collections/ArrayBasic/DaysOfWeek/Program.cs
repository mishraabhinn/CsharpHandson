using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
	static void Main(string[] args)
	{
		string[] daysOfWeek = {
			"Monday",
			"Tuesday",
			"Wensday",
			"Thursday",
			"Friday",
			"Saturday",
			"Sunday"
		};

		Console.WriteLine("Before:");
		foreach (string day in daysOfWeek)
			Console.WriteLine(day);

		daysOfWeek[2] = "Wednesday";

		Console.WriteLine("\r\nAfter:");
		foreach (string day in daysOfWeek)
			Console.WriteLine(day);
	}
}
