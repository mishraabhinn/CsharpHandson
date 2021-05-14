﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
	static void Main(string[] args)
	{
		string filePath = @"/Users/abhinnmishra/Downloads/csharp-collections-beginning/PopbyLargestFinal.csv ";
		CsvReader reader = new CsvReader(filePath);

		Country[] countries = reader.ReadFirstNCountries(10);

		foreach (Country country in countries)
		{
			Console.WriteLine($"{PopulationFormatter.FormatPopulation(country.Population).PadLeft(15)}: {country.Name}");
		}
	}
}

