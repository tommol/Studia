﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
	public static class DecisionEngine
	{
		public static int[] MakeDecision(this Matrix matrix, IDecisionRule rules)
		{
			return rules.Decide(matrix);
		}

		public static Matrix RelativeLost(this Matrix matrix)
		{
			for (int j = 0; j < matrix.Columns; j++)
			{
				double max = matrix.Column(j).Max();
				for (int i = 0; i < matrix.Rows; i++)
				{
					matrix[i, j] = max - matrix[i, j];
				}
			}
			return matrix;
		}
	}
}
