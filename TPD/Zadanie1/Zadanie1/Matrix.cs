using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
	public class Matrix
	{
		double[,] _internal;

		public Matrix(int rows, int columns)
		{
			_internal = new double[rows, columns];
		}

		public double this[int i, int j]
		{
			get { return _internal[i, j]; }
			set { _internal[i, j] = value; }
		}

		public double Max(int column)
		{
			double max = this[0, column];
			for(int i=1; i < _internal.GetLength(0); i++)
			{
				if (this[i, column]>max)
				{
					max = this[i, column];
				}
			}
			return max;
		}

		public int Rows
		{
			get { return _internal.GetLength(0); }
		}
		public int Columns
		{
			get { return _internal.GetLength(1); }
		}


		public double Min(int column)
		{
			double min = this[0, column];
			for (int i = 1; i < _internal.GetLength(0); i++)
			{
				if (this[i, column] < min)
				{
					min = this[i, column];
				}
			}
			return min;
		}
	}
}
