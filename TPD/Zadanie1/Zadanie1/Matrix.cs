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

		public double[] this[int i]
		{
			get
			{
				double[] tmp = new double[this.Columns];
				for (int j = 0; j < tmp.Length; j++)
				{
					tmp[j] = this[i, j];
				}
				return tmp;
			}
		}
		public double Max(int column)
		{
			double max = this[0, column];
			for (int i = 1; i < _internal.GetLength(0); i++)
			{
				if (this[i, column] > max)
				{
					max = this[i, column];
				}
			}
			return max;
		}

		public int Rows
		{
			get { return _internal.GetLength(0); }
			set
			{
				int old = _internal.GetLength(0);
				double[,] copy = new double[value, Columns];
				if (value > Rows)
				{
					for (int i = 0; i < old; i++)
					{
						for (int j = 0; j < Columns; j++)
						{
							copy[i, j] = _internal[i, j];
						}
					}
					for (int i = old; i < Rows; i++)
					{
						for (int j = 0; j < Columns; j++)
						{
							copy[i, j] = _internal[i, j];
						}
					}
					_internal = copy;
				}
				else if (value < Rows)
				{
					for (int i = 0; i < old; i++)
					{
						for (int j = 0; j < Columns; j++)
						{
							copy[i, j] = _internal[i, j];
						}
					}
					_internal = copy;
				}
			}
		}
		public int Columns
		{
			get { return _internal.GetLength(1); }
			set
			{
				int old = _internal.GetLength(1);
				double[,] copy = new double[Rows, value];
				if (value > Columns)
				{

					for (int i = 0; i < Rows; i++)
					{
						for (int j = 0; j < old; j++)
						{
							copy[i, j] = _internal[i, j];
						}
						for (int j = old; j < value; j++)
						{
							copy[i, j] = 0;
						}
					}
					_internal = copy;
				}
				else if (value < Columns)
				{
					for (int i = 0; i < Rows; i++)
					{
						for (int j = 0; j < value; j++)
						{
							copy[i, j] = _internal[i, j];
						}
					}
					_internal = copy;
				}
			}
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
