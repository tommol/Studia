using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
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
			new LaplaceRule(1),
			new BayesRule(new double[]{0.5,0.5}),
			new SavageRule()
		};

		private InputData inputData = new InputData()
		{
			ProfitMatrix = new Matrix(1, 1),
			Probability = new double[1] { 1 },
			RiskFactor = 0.5d
		};
		private IDecisionRule selectedRule;
		const string text = "Przy {0} najlepszą decyzją jest decyzja {1}.\\n";

		public Form1()
		{
			InitializeComponent();
		}

		private void chooseCriterium_SelectedIndexChanged(object sender, EventArgs e)
		{
			selectedRule = rules[chooseCriterium.SelectedIndex];
			HurwiczRuleChange();
			if (selectedRule is BayesRule)
			{
				if (selectedRule is LaplaceRule)
				{
					selectedRule = new LaplaceRule(viewGrid.Rows[0].Cells.Count);
				}
				else {
					probabilityGrid.Columns.Clear();
					(selectedRule as BayesRule).Probability = inputData.Probability;
					probabilityGrid.Visible = true;
					for (int i = 0; i < inputData.Probability.Length; i++)
					{
						probabilityGrid.Columns.Add("colP" + i.ToString(), "P" + i.ToString());
						probabilityGrid.Rows[0].Cells[i].Value = inputData.Probability[i].ToString();
					}
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
			for (int i = 0; i < inputData.ProfitMatrix.Columns; i++)
			{
				viewGrid.Columns.Add("S" + (i + 1).ToString(), "S" + (i + 1).ToString());
			}
			for (int i = 0; i < inputData.ProfitMatrix.Rows; i++)
			{
				viewGrid.Rows.Insert(i);
				for (int j = 0; j < inputData.ProfitMatrix.Columns; j++)
				{
					viewGrid.Rows[i].Cells[j].Value = inputData.ProfitMatrix[i, j];
				}
			}
		}
		private void updateResult()
		{
			for (int i = 0; i < viewGrid.Rows.Count - 1; i++)
			{
				viewGrid.Rows[i].DefaultCellStyle.BackColor = Color.White;
				for (int j = 0; j < viewGrid.Rows[i].Cells.Count; j++)
				{
					inputData.ProfitMatrix[i, j] = double.Parse(viewGrid.Rows[i].Cells[j].Value.ToString());
				}
			}
			if (selectedRule != null)
			{
				int[] decisions = inputData.ProfitMatrix.MakeDecision(selectedRule);
				for (int i = 0; i < decisions.Length; i++)
				{
					viewGrid.Rows[decisions[i]].DefaultCellStyle.BackColor = Color.LawnGreen;
				}
			}
		}



		private void natureStatesCount_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{
			MessageBox.Show("Liczba stanów natury musi być większa od 0");
		}

		private void natureStatesCount_TextChanged(object sender, EventArgs e)
		{
			if (natureStatesCount.Text != string.Empty)
			{
				int parsed = int.Parse(natureStatesCount.Text);
				if (parsed == 0)
				{
					MessageBox.Show("Liczba stanów natury musi być większa od 0");
					return;
				}
				else
				{
					inputData.ProfitMatrix.Columns = parsed;
				}
				updateMatrix();
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
					inputData.ProfitMatrix.Rows = parsed;
				}
				updateMatrix();
			}
		}

		private void decisionsCount_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{
			MessageBox.Show("Liczba decyzji musi być większa od 0");
		}

		private void calculateBtn_Click(object sender, EventArgs e)
		{
			updateResult();
		}

		private void saveBtn_Click(object sender, EventArgs e)
		{
			if (saveFile.ShowDialog() == DialogResult.OK)
			{
				using (FileStream stream = new FileStream(saveFile.FileName, FileMode.OpenOrCreate, FileAccess.ReadWrite))
				{
					DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(InputData));

					serializer.WriteObject(stream, inputData);
				}
			}
		}

		private void loadBtn_Click(object sender, EventArgs e)
		{
			if (openFile.ShowDialog() == DialogResult.OK)
			{
				using (FileStream stream = new FileStream(openFile.FileName, FileMode.Open, FileAccess.Read))
				{
					DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(InputData));

					inputData = (InputData)serializer.ReadObject(stream);
				}
			}
			updateMatrix();
			decisionsCount.Text = inputData.ProfitMatrix.Rows.ToString();
			natureStatesCount.Text = inputData.ProfitMatrix.Columns.ToString();
			securityLevel.Text = inputData.RiskFactor.ToString();
		}

		private void securityLevel_TextChanged(object sender, EventArgs e)
		{
			double parsed;
			if(double.TryParse(securityLevel.Text, out parsed)){
				if(parsed >0 || parsed < 1)
				{
					if (selectedRule is HurwiczRule)
					{
						(selectedRule as HurwiczRule).Lambda = parsed;
					}
					inputData.RiskFactor = parsed;
				}
			}
		}
	}
}
