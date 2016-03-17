using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
	[DataContract]
	public class InputData
	{
		[DataMember]
		public Matrix ProfitMatrix { get; set; }
		[DataMember]
		public double[] Probability { get; set; }
		[DataMember]
		public double RiskFactor { get; set; }
	
	}
}
