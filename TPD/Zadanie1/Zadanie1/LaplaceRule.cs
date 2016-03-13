using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
	public class LaplaceRule : IDecisionRule
	{
		double[] p;
		public LaplaceRule(double[] probability)
		{
			p = probability;
		}

		public int Decide(Matrix matrix)
		{
			double[] rows = new double[matrix.Rows];
			int decision = 0;		
			for(int i=0; i < matrix.Rows; i++)
			{
				for(int j =0; j< matrix.Columns; j++)
				{
					rows[i] += p[j] * matrix[i, j];
				}
			}
			double max = rows[0];
			for(int i =0; i< rows.Length; i++)
			{
				if(rows[i] > max)
				{
					max = rows[i];
					decision = i;
				}

			}
			return decision;
		}
	}
}
