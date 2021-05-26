using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machines
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Which Operation You Want To Perform");
			Console.WriteLine("Press a to Get the list of Asset names for given machine type.");
			Console.WriteLine("Press b to Get the list of all machine types on which given asset is used.");
			Console.WriteLine("Press C To Get the machine types which are using the latest series of all the assets that it uses.");



			char userinputoption = Console.ReadLine()[0];
			string userinput="empty";

			if (userinputoption == 'a')
			{
				Console.WriteLine("Enter The Machine Code:");
				userinput = Console.ReadLine();
			}



			else if (userinputoption == 'b')
			{
				Console.WriteLine("Enter The AssetName:");
				userinput = Console.ReadLine();
			}

			else
			{
				Console.WriteLine("Machine types which are using the latest series of all the assets:");
			}
			


			string filePath = @"/Users/abhinnmishra/Downloads/CsharpHandson/ProjectKlingelnberg/Assignment/Data.csv";
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
				
				List<Structure> result = new List<Structure>();
				result.Add(machines[0]);
				for (int i=1;i<machines.Count;i++)
				{	
					for(int j=0;j<result.Count;j++)
					{
						if(String.Compare(result[j].Assetname, machines[i].Assetname) == 0)
						{
							if(String.Compare(result[j].Series, machines[i].Series) < 0)
							{
								result.RemoveAt(j);
								result.Add(machines[i]);
								break;
							}
								
						}
					}
				}
				foreach(var itr in result)
				{
					Console.WriteLine(itr.MachineName);
				}
			}


			

		}
	}
}
