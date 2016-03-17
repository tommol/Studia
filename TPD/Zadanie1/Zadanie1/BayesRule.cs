using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
	public class BayesRule : IDecisionRule
	{
		public double[] Probability
		{
			get;
			set;
		}

		public BayesRule(double[] probability)
		{
			Probability = probability;
		}

		public int[] Decide(Matrix matrix)
		{
			List<int> decisions = new List<int>();
			double[] rows = new double[matrix.Rows];
			
			for (int i = 0; i < matrix.Rows; i++)
			{
				for (int j = 0; j < matrix.Columns; j++)
				{
					rows[i] += Probability[j] * matrix[i, j];
				}
			}
			decisions.Add(0);
			double max = rows[0];
			for (int i = 1; i < rows.Length; i++)
			{
				if (rows[i] >= max)
				{
					if (rows[i] > max)
					{
						decisions.Clear();
						max = rows[i];
					}
					decisions.Add(i);
				}

			}
			return decisions.ToArray();
		}
		public string Name
		{ get { return "Kryterium Bayesa Laplace'a"; } }
	}
}
