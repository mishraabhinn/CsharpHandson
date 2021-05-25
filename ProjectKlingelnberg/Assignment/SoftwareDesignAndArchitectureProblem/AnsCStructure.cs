using System;
namespace Machines
{
	public class AnsCStruncture
	{
		public string MachineName { get; }

		public int LatesSeries { get; }


		public AnsCStruncture(string machinename, int latestSeries)
		{
			this.MachineName = machinename;

			this.LatesSeries = latestSeries;

		}
	}
}
