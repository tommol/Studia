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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.outputLog = new System.Windows.Forms.TextBox();
			this.gb_input = new System.Windows.Forms.GroupBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.lbl_natureStates = new System.Windows.Forms.Label();
			this.natureStatesCount = new System.Windows.Forms.MaskedTextBox();
			this.lblDecisions = new System.Windows.Forms.Label();
			this.decisionsCount = new System.Windows.Forms.MaskedTextBox();
			this.lblCriteria = new System.Windows.Forms.Label();
			this.chooseCriterium = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.securityLevel = new System.Windows.Forms.TextBox();
			this.calculateBtn = new System.Windows.Forms.Button();
			this.saveBtn = new System.Windows.Forms.Button();
			this.loadBtn = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.viewGrid = new System.Windows.Forms.DataGridView();
			this.probabilityGrid = new System.Windows.Forms.DataGridView();
			this.saveFile = new System.Windows.Forms.SaveFileDialog();
			this.openFile = new System.Windows.Forms.OpenFileDialog();
			this.pn_top.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.gb_input.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.viewGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.probabilityGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// pn_top
			// 
			this.pn_top.Controls.Add(this.groupBox1);
			this.pn_top.Controls.Add(this.gb_input);
			this.pn_top.Dock = System.Windows.Forms.DockStyle.Top;
			this.pn_top.Location = new System.Drawing.Point(0, 0);
			this.pn_top.Name = "pn_top";
			this.pn_top.Size = new System.Drawing.Size(736, 178);
			this.pn_top.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.outputLog);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupBox1.Location = new System.Drawing.Point(324, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(335, 178);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Wyjście";
			// 
			// outputLog
			// 
			this.outputLog.Dock = System.Windows.Forms.DockStyle.Fill;
			this.outputLog.Location = new System.Drawing.Point(3, 16);
			this.outputLog.Multiline = true;
			this.outputLog.Name = "outputLog";
			this.outputLog.Size = new System.Drawing.Size(329, 159);
			this.outputLog.TabIndex = 0;
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
			this.flowLayoutPanel1.Controls.Add(this.natureStatesCount);
			this.flowLayoutPanel1.Controls.Add(this.lblDecisions);
			this.flowLayoutPanel1.Controls.Add(this.decisionsCount);
			this.flowLayoutPanel1.Controls.Add(this.lblCriteria);
			this.flowLayoutPanel1.Controls.Add(this.chooseCriterium);
			this.flowLayoutPanel1.Controls.Add(this.label1);
			this.flowLayoutPanel1.Controls.Add(this.securityLevel);
			this.flowLayoutPanel1.Controls.Add(this.calculateBtn);
			this.flowLayoutPanel1.Controls.Add(this.saveBtn);
			this.flowLayoutPanel1.Controls.Add(this.loadBtn);
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
			// natureStatesCount
			// 
			this.natureStatesCount.Location = new System.Drawing.Point(119, 13);
			this.natureStatesCount.Mask = "00000";
			this.natureStatesCount.Name = "natureStatesCount";
			this.natureStatesCount.Size = new System.Drawing.Size(100, 20);
			this.natureStatesCount.TabIndex = 7;
			this.natureStatesCount.ValidatingType = typeof(int);
			this.natureStatesCount.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.natureStatesCount_MaskInputRejected);
			this.natureStatesCount.TextChanged += new System.EventHandler(this.natureStatesCount_TextChanged);
			// 
			// lblDecisions
			// 
			this.lblDecisions.Location = new System.Drawing.Point(13, 36);
			this.lblDecisions.Name = "lblDecisions";
			this.lblDecisions.Size = new System.Drawing.Size(100, 23);
			this.lblDecisions.TabIndex = 2;
			this.lblDecisions.Text = "Decyzje";
			// 
			// decisionsCount
			// 
			this.decisionsCount.Location = new System.Drawing.Point(119, 39);
			this.decisionsCount.Mask = "00000";
			this.decisionsCount.Name = "decisionsCount";
			this.decisionsCount.Size = new System.Drawing.Size(100, 20);
			this.decisionsCount.TabIndex = 8;
			this.decisionsCount.ValidatingType = typeof(int);
			this.decisionsCount.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.decisionsCount_MaskInputRejected);
			this.decisionsCount.TextChanged += new System.EventHandler(this.decisionsCount_TextChanged);
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
            "Kryterium Laplace\'a",
            "Kryterium Bayes\'a",
            "Kryterium Savage\'a"});
			this.chooseCriterium.Location = new System.Drawing.Point(119, 65);
			this.chooseCriterium.Name = "chooseCriterium";
			this.chooseCriterium.Size = new System.Drawing.Size(168, 21);
			this.chooseCriterium.TabIndex = 5;
			this.chooseCriterium.SelectedIndexChanged += new System.EventHandler(this.chooseCriterium_SelectedIndexChanged);
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
			// securityLevel
			// 
			this.securityLevel.Enabled = false;
			this.flowLayoutPanel1.SetFlowBreak(this.securityLevel, true);
			this.securityLevel.Location = new System.Drawing.Point(119, 92);
			this.securityLevel.Name = "securityLevel";
			this.securityLevel.Size = new System.Drawing.Size(100, 20);
			this.securityLevel.TabIndex = 9;
			// 
			// calculateBtn
			// 
			this.calculateBtn.Location = new System.Drawing.Point(13, 118);
			this.calculateBtn.Name = "calculateBtn";
			this.calculateBtn.Size = new System.Drawing.Size(75, 23);
			this.calculateBtn.TabIndex = 10;
			this.calculateBtn.Text = "Oblicz";
			this.calculateBtn.UseVisualStyleBackColor = true;
			this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
			// 
			// saveBtn
			// 
			this.saveBtn.Location = new System.Drawing.Point(94, 118);
			this.saveBtn.Name = "saveBtn";
			this.saveBtn.Size = new System.Drawing.Size(75, 23);
			this.saveBtn.TabIndex = 11;
			this.saveBtn.Text = "Zapisz";
			this.saveBtn.UseVisualStyleBackColor = true;
			this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
			// 
			// loadBtn
			// 
			this.loadBtn.Location = new System.Drawing.Point(175, 118);
			this.loadBtn.Name = "loadBtn";
			this.loadBtn.Size = new System.Drawing.Size(75, 23);
			this.loadBtn.TabIndex = 12;
			this.loadBtn.Text = "Wczytaj";
			this.loadBtn.UseVisualStyleBackColor = true;
			this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.viewGrid);
			this.panel1.Controls.Add(this.probabilityGrid);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 178);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(736, 188);
			this.panel1.TabIndex = 1;
			// 
			// viewGrid
			// 
			this.viewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.viewGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.viewGrid.Location = new System.Drawing.Point(0, 53);
			this.viewGrid.Name = "viewGrid";
			this.viewGrid.Size = new System.Drawing.Size(736, 135);
			this.viewGrid.TabIndex = 1;
			// 
			// probabilityGrid
			// 
			this.probabilityGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.probabilityGrid.Dock = System.Windows.Forms.DockStyle.Top;
			this.probabilityGrid.Location = new System.Drawing.Point(0, 0);
			this.probabilityGrid.Name = "probabilityGrid";
			this.probabilityGrid.Size = new System.Drawing.Size(736, 53);
			this.probabilityGrid.TabIndex = 0;
			this.probabilityGrid.Visible = false;
			// 
			// saveFile
			// 
			this.saveFile.DefaultExt = "json";
			// 
			// openFile
			// 
			this.openFile.FileName = "openFileDialog1";
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
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.gb_input.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.viewGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.probabilityGrid)).EndInit();
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
		private System.Windows.Forms.DataGridView probabilityGrid;
		private System.Windows.Forms.MaskedTextBox natureStatesCount;
		private System.Windows.Forms.MaskedTextBox decisionsCount;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView viewGrid;
		private System.Windows.Forms.TextBox securityLevel;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox outputLog;
		private System.Windows.Forms.Button calculateBtn;
		private System.Windows.Forms.Button saveBtn;
		private System.Windows.Forms.Button loadBtn;
		private System.Windows.Forms.SaveFileDialog saveFile;
		private System.Windows.Forms.OpenFileDialog openFile;
	}
}

