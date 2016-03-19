using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
	public class SavageRule : IDecisionRule
	{
		public string Name
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public int[] Decide(Matrix matrix)
		{
			return matrix.RelativeLost().MakeDecision(new MinMax());
		}
	}

	internal class MinMax : IDecisionRule
	{
		public string Name
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		public int[] Decide(Matrix matrix)
		{
			List<int> decisions = new List<int>();
			double[] rows = new double[matrix.Rows];
			decisions.Add(0);
			for (int i = 0; i < matrix.Rows; i++)
			{
				rows[i] =  matrix.Max(i);
			}
			double min = rows[0];
			for (int i = 1; i < matrix.Rows; i++)
			{
				if (rows[i] <= min)
				{
					if (rows[i] < min)
					{
						decisions.Clear();
						min = rows[i];
					}
					decisions.Add(i);
				}
			}
			return decisions.ToArray();
		}
	}
	
}
