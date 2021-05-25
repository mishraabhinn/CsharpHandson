using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machines
{
	class NewStructure
	{
		public string MachineName { get; }
		public string Assetname { get; }
		public int Series { get; }


		public NewStructure(string machinename, string assetname, int series)
		{
			this.MachineName = machinename;
			this.Assetname = assetname;
			this.Series = series;

		}
	}

}
