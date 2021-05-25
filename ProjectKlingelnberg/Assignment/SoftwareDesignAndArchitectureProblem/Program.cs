using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machines
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Which Operation You Want To Perform");
			Console.WriteLine("Press a to Get the list of Asset names for given machine type.");
			Console.WriteLine("Press b to Get the list of all machine types on which given asset is used.");
			Console.WriteLine("Press C To Get the machine types which are using the latest series of all the assets that it uses.");



			char userinputoption = Console.ReadLine()[0];
			string userinput;

			if (userinputoption == 'a')
			{
				Console.WriteLine("Enter The Machine Code");
			}



			else if (userinputoption == 'b')
			{
				Console.WriteLine("Enter The AssetName");
			}

			else
			{
				Console.WriteLine("Type latest for getting latest series");
			}
			userinput = Console.ReadLine();


			string filePath = @"/Users/abhinnmishra/Downloads/Assignment/Data.csv";
			CsvReader reader = new CsvReader(filePath, userinput);

			List<Structure> machines = reader.ReadAllMachines();

			HashSet<string> ans = new HashSet<string>();
			if (userinputoption == 'a')
			{
				foreach (Structure machine in machines)
				{
					if (machine.MachineName == userinput)
					{
						ans.Add(machine.Assetname);
					}
				}
				foreach (var i in ans)
					Console.WriteLine(i);

			}
			else if (userinputoption == 'b')
			{
				foreach (Structure machine in machines)
				{
					if (machine.Assetname == userinput)
					{
						ans.Add(machine.MachineName);
					}

				}
				foreach (var i in ans)
					Console.WriteLine(i);

			}
			else
			{
				List<NewStructure> solutionc = new List<NewStructure>();
				foreach (Structure machine in machines)
				{
					string[] parts = machine.Series.Split('S');

					int code = Convert.ToInt32(parts[1]);


					solutionc.Add(new NewStructure(machine.MachineName, machine.Assetname, code));


				}

				solutionc = solutionc.OrderBy(x => -x.Series).ToList();


				if (solutionc[0].Series != solutionc[1].Series)
				{
					Console.WriteLine(solutionc[0].MachineName);

				}


				else
				{
					List<string> finalAns = new List<string>();
					List<AnsCStruncture> fullfinallatest = new List<AnsCStruncture>();

					for (int i = 0; i < solutionc.Count - 1; i++)
					{
						if (solutionc[i].Series == solutionc[i + 1].Series)
						{
							if (i == 0)
							{
								finalAns.Add(solutionc[i].MachineName);
								finalAns.Add(solutionc[i + 1].MachineName);
							}
							else
							{
								finalAns.Add(solutionc[i + 1].MachineName);
							}
						}
						else
						{
							break;
						}
					}
					foreach (var i in finalAns)
					{
						int sum = 0;
						foreach (var j in solutionc)
						{
							if (i == j.MachineName)
							{
								sum += j.Series;
							}
						}
						fullfinallatest.Add(new AnsCStruncture(i, sum));

					}
					fullfinallatest = fullfinallatest.OrderBy(x => -x.LatesSeries).ToList();
					Console.WriteLine(fullfinallatest[0].MachineName);
				}

			}

		}
	}
}
