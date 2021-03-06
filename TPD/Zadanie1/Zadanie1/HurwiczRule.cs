﻿using System;
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
		public int[] Decide(Matrix matrix)
		{
			List<int> decisions = new List<int>();
			double[] rows = new double[matrix.Rows];
			decisions.Add(0);
			for (int i = 0; i < matrix.Rows; i++)
			{
				rows[i] = Lambda * matrix.Min(i) + (1 - Lambda) * matrix.Max(i);
			}
			double max = rows[0];
			for (int i = 1; i < matrix.Rows; i++)
			{
				if (rows[i] >= max)
				{
					if(rows[i] > max)
					{
						decisions.Clear();
						max = rows[i];
					}					
					decisions.Add(i);					
				}
			}
			return decisions.ToArray();
		}

		public virtual string Name { get { return "Kryterium Hurwicza"; } }
	}
}
