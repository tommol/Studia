using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie1
{
	public partial class Form1 : Form
	{
		private IDecisionRule[] rules =
		{
			new WaldRule(),
			new OptimisticRule(),
			new HurwiczRule(),
			new LaplaceRule(new double[]{0.5,0.5})
		};
		private Matrix matrix = new Matrix(1, 1);
		private IDecisionRule selectedRule;

		public Form1()
		{
			InitializeComponent();
		}

		private void chooseCriterium_SelectedIndexChanged(object sender, EventArgs e)
		{
			selectedRule = rules[chooseCriterium.SelectedIndex];
			HurwiczRuleChange();
			if(selectedRule is LaplaceRule)
			{
				probabilityGrid.Columns.Clear();
				(selectedRule as LaplaceRule).Probability = new double[matrix.Columns];
				double p = 1.0 / matrix.Columns;
				probabilityGrid.Visible = true;
				for(int i =0; i< (selectedRule as LaplaceRule).Probability.Length; i++)
				{
					probabilityGrid.Columns.Add("colP" + i.ToString(), "P" + i.ToString());
				}
			}
			updateResult();
		}

		private void HurwiczRuleChange()
		{
			if (selectedRule is HurwiczRule)
			{
				securityLevel.Text = (selectedRule as HurwiczRule).Lambda.ToString();
				if (selectedRule is WaldRule || selectedRule is OptimisticRule)
				{
					securityLevel.Enabled = false;
				}
				else
				{
					securityLevel.Enabled = true;
				}
			}
			else
			{
				securityLevel.Text = string.Empty;
				securityLevel.Enabled = false;
			}
		}

		private void updateMatrix()
		{
			viewGrid.Rows.Clear();
			viewGrid.Columns.Clear();
			for (int i = 0; i < matrix.Columns; i++) 
			{
				viewGrid.Columns.Add("S" + (i + 1).ToString(), "S" + (i + 1).ToString());
			}
			for (int i = 0; i < matrix.Rows; i++)
			{
				viewGrid.Rows.Insert(i);
				for(int j=0; j< matrix.Columns; j++)
				{
					viewGrid.Rows[i].Cells[j].Value = matrix[i, j];
				}			
			}
		}
		private void updateResult()
		{
			int decision = matrix.MakeDecision(selectedRule);
		}



		private void natureStatesCount_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{
			MessageBox.Show("Liczba stanów natury musi być większa od 0");
		}

		private void natureStatesCount_TextChanged(object sender, EventArgs e)
		{
			if(natureStatesCount.Text != string.Empty)
			{
				int parsed = int.Parse(natureStatesCount.Text);
				if( parsed == 0)
				{
					MessageBox.Show("Liczba stanów natury musi być większa od 0");
					return;
				}
				else
				{
					matrix.Columns = parsed;
				}
				updateMatrix();
				//updateResult();
			}
		}

		private void decisionsCount_TextChanged(object sender, EventArgs e)
		{
			if (decisionsCount.Text != string.Empty)
			{
				int parsed = int.Parse(decisionsCount.Text);
				if (parsed == 0)
				{
					MessageBox.Show("Liczba decyzji musi być większa od 0");
					return;
				}
				else
				{
					matrix.Rows = parsed;
				}
				updateMatrix();
				//updateResult();
			}
		}

		private void decisionsCount_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{
			MessageBox.Show("Liczba decyzji musi być większa od 0");
		}
		
	}
}
