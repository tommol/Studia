using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
	public class OptimisticRule : HurwiczRule
	{
		public OptimisticRule() : base(0)
		{
			
		}
		public virtual new string Name
		{ get { return "Kryterium optymistyczne"; } }
	}
}
