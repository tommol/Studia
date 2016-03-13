using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
	public class HurwiczRule : IDecisionRule
	{
		public double Lambda
		{
			get;
			set;
		}

		public HurwiczRule(double securityValue =0.5d)
		{
			Lambda = securityValue;
		}
		public int Decide(Matrix matrix)
		{
			double[] decisions = new double[matrix.Rows];
			int decision = 0;
			for (int i = 0; i < matrix.Rows; i++)
			{
				decisions[i] = Lambda * matrix.Min(i) + (1 - Lambda) * matrix.Max(i);
			}
			double max = decisions[0];
			for (int i = 1; i < matrix.Rows; i++)
			{
				if (decisions[i] > max)
				{
					decision = i;
					max = decisions[i];
				}
			}
			return decision;
		}
	}
}
