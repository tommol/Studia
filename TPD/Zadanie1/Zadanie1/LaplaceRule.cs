using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
	public class LaplaceRule : BayesRule
	{
		
		public  LaplaceRule(int n) : base(Enumerable.Repeat(1.0d/n,n).ToArray()) { }
	}
}
