namespace Zadanie1
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pn_top = new System.Windows.Forms.Panel();
			this.gb_input = new System.Windows.Forms.GroupBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.lbl_natureStates = new System.Windows.Forms.Label();
			this.lblDecisions = new System.Windows.Forms.Label();
			this.lblCriteria = new System.Windows.Forms.Label();
			this.chooseCriterium = new System.Windows.Forms.ComboBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.pn_top.SuspendLayout();
			this.gb_input.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// pn_top
			// 
			this.pn_top.Controls.Add(this.gb_input);
			this.pn_top.Dock = System.Windows.Forms.DockStyle.Top;
			this.pn_top.Location = new System.Drawing.Point(0, 0);
			this.pn_top.Name = "pn_top";
			this.pn_top.Size = new System.Drawing.Size(736, 178);
			this.pn_top.TabIndex = 0;
			// 
			// gb_input
			// 
			this.gb_input.Controls.Add(this.flowLayoutPanel1);
			this.gb_input.Dock = System.Windows.Forms.DockStyle.Left;
			this.gb_input.Location = new System.Drawing.Point(0, 0);
			this.gb_input.Name = "gb_input";
			this.gb_input.Size = new System.Drawing.Size(324, 178);
			this.gb_input.TabIndex = 0;
			this.gb_input.TabStop = false;
			this.gb_input.Text = "Warunki wejściowe";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.lbl_natureStates);
			this.flowLayoutPanel1.Controls.Add(this.maskedTextBox1);
			this.flowLayoutPanel1.Controls.Add(this.lblDecisions);
			this.flowLayoutPanel1.Controls.Add(this.maskedTextBox2);
			this.flowLayoutPanel1.Controls.Add(this.lblCriteria);
			this.flowLayoutPanel1.Controls.Add(this.chooseCriterium);
			this.flowLayoutPanel1.Controls.Add(this.label1);
			this.flowLayoutPanel1.Controls.Add(this.numericUpDown1);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
			this.flowLayoutPanel1.Size = new System.Drawing.Size(318, 159);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// lbl_natureStates
			// 
			this.lbl_natureStates.Location = new System.Drawing.Point(13, 10);
			this.lbl_natureStates.Name = "lbl_natureStates";
			this.lbl_natureStates.Size = new System.Drawing.Size(100, 23);
			this.lbl_natureStates.TabIndex = 0;
			this.lbl_natureStates.Text = "Stany natury";
			// 
			// lblDecisions
			// 
			this.lblDecisions.Location = new System.Drawing.Point(13, 36);
			this.lblDecisions.Name = "lblDecisions";
			this.lblDecisions.Size = new System.Drawing.Size(100, 23);
			this.lblDecisions.TabIndex = 2;
			this.lblDecisions.Text = "Decyzje";
			// 
			// lblCriteria
			// 
			this.lblCriteria.Location = new System.Drawing.Point(13, 62);
			this.lblCriteria.Name = "lblCriteria";
			this.lblCriteria.Size = new System.Drawing.Size(100, 23);
			this.lblCriteria.TabIndex = 4;
			this.lblCriteria.Text = "Kryterium decyzyjne";
			// 
			// chooseCriterium
			// 
			this.flowLayoutPanel1.SetFlowBreak(this.chooseCriterium, true);
			this.chooseCriterium.FormattingEnabled = true;
			this.chooseCriterium.Items.AddRange(new object[] {
            "Kryterium Walda (minmax)",
            "Kryterium optymistyczne (maxmax)",
            "Kryterium Hurwicza ",
            "Kryterium Bayesa-Laplace\'a",
            "Kryterium Savage\'a"});
			this.chooseCriterium.Location = new System.Drawing.Point(119, 65);
			this.chooseCriterium.Name = "chooseCriterium";
			this.chooseCriterium.Size = new System.Drawing.Size(168, 21);
			this.chooseCriterium.TabIndex = 5;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dataGridView2);
			this.panel1.Controls.Add(this.dataGridView1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 178);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(736, 188);
			this.panel1.TabIndex = 1;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(736, 53);
			this.dataGridView1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 89);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 6;
			this.label1.Text = "Poziom ostrośności";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.Location = new System.Drawing.Point(119, 13);
			this.maskedTextBox1.Mask = "00000";
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
			this.maskedTextBox1.TabIndex = 7;
			this.maskedTextBox1.ValidatingType = typeof(int);
			// 
			// maskedTextBox2
			// 
			this.maskedTextBox2.Location = new System.Drawing.Point(119, 39);
			this.maskedTextBox2.Mask = "00000";
			this.maskedTextBox2.Name = "maskedTextBox2";
			this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
			this.maskedTextBox2.TabIndex = 8;
			this.maskedTextBox2.ValidatingType = typeof(int);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.numericUpDown1.Location = new System.Drawing.Point(119, 92);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown1.TabIndex = 9;
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView2.Location = new System.Drawing.Point(0, 53);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(736, 135);
			this.dataGridView2.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(736, 366);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pn_top);
			this.Name = "Form1";
			this.Text = "Form1";
			this.pn_top.ResumeLayout(false);
			this.gb_input.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pn_top;
		private System.Windows.Forms.GroupBox gb_input;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label lbl_natureStates;
		private System.Windows.Forms.Label lblDecisions;
		private System.Windows.Forms.Label lblCriteria;
		private System.Windows.Forms.ComboBox chooseCriterium;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
		private System.Windows.Forms.MaskedTextBox maskedTextBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.DataGridView dataGridView2;
	}
}

