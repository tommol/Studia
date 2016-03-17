using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
	[DataContract]
	public class Matrix
	{
		[DataMember]
		double[][] _internal;

		public Matrix(int rows, int columns)
		{
			_internal = new double[rows][];
			for(int i =0; i < rows; i++)
			{
				_internal[i] = new double[columns];
			}
		}

		
		public double this[int i, int j]
		{
			get { return _internal[i][j]; }
			set { _internal[i][j] = value; }
		}

		public double[] this[int i]
		{
			get
			{				
				return _internal[i];
			}
		}
		public double Max(int row)
		{
			double max = this[row,0];
			for (int i = 1; i < _internal[row].Length; i++)
			{
				if (this[row,i] > max)
				{
					max = this[row,i];
				}
			}
			return max;
		}

		public int Rows
		{
			get { return _internal.Length; }
			set
			{
				int old = _internal.Length;
				double[][] copy = new double[value][];
				if (value > Rows)
				{
					for (int i = 0; i < old; i++)
					{
						copy[i] = new double[Columns];
						for (int j = 0; j < Columns; j++)
						{
							copy[i][j] = _internal[i][j];
						}
					}
					for (int i = old; i < value; i++)
					{
						copy[i] = new double[Columns];
						for (int j = 0; j < Columns; j++)
						{
							copy[i][j] = 0;
						}
					}
					_internal = copy;
				}
				else if (value < Rows)
				{
					for (int i = 0; i < old; i++)
					{
						copy[i] = new double[Columns];
						for (int j = 0; j < Columns; j++)
						{
							copy[i][j] = _internal[i][j];
						}
					}
					_internal = copy;
				}
			}
		}
		public int Columns
		{
			get { return _internal[0].Length; }
			set
			{
				int old = _internal[0].Length;
				double[][] copy = new double[Rows][];
				if (value > Columns)
				{

					for (int i = 0; i < Rows; i++)
					{
						copy[i] = new double[value];
						for (int j = 0; j < old; j++)
						{
							copy[i][j] = _internal[i][j];
						}
						for (int j = old; j < value; j++)
						{
							copy[i][j] = 0;
						}
					}
					_internal = copy;
				}
				else if (value < Columns)
				{
					for (int i = 0; i < Rows; i++)
					{
						copy[i] = new double[value];
						for (int j = 0; j < value; j++)
						{
							copy[i][j] = _internal[i][j];
						}
					}
					_internal = copy;
				}
			}
		}
		
		public double Min(int row)
		{
			double min = this[row,0];
			for (int i = 1; i < _internal[row].Length; i++)
			{
				if (this[row,i] < min)
				{
					min = this[row,i];
				}
			}
			return min;
		}
	}
}
