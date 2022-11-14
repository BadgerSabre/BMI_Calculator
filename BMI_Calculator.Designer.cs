namespace BMI_Calculator
{
    partial class BMI_Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.calculateBtn = new System.Windows.Forms.Button();
            this.toggleMetric = new System.Windows.Forms.RadioButton();
            this.BMIResult = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.errorMessageDisplay = new System.Windows.Forms.Label();
            this.weightUnits = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.littleHeightUnits = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.textBoxHeightInchesOrCm = new System.Windows.Forms.NumericUpDown();
            this.heightLabel = new System.Windows.Forms.Label();
            this.textBoxWeightLbOrKg = new System.Windows.Forms.NumericUpDown();
            this.textBoxHeightFeetorMeters = new System.Windows.Forms.NumericUpDown();
            this.textBoxAge = new System.Windows.Forms.NumericUpDown();
            this.bigHeightUnits = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxHeightInchesOrCm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxWeightLbOrKg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxHeightFeetorMeters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxAge)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateBtn
            // 
            this.calculateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.calculateBtn.Location = new System.Drawing.Point(110, 45);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(362, 33);
            this.calculateBtn.TabIndex = 0;
            this.calculateBtn.Text = "Calculate BMI";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // toggleMetric
            // 
            this.toggleMetric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.toggleMetric.AutoSize = true;
            this.toggleMetric.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toggleMetric.Location = new System.Drawing.Point(110, 5);
            this.toggleMetric.Name = "toggleMetric";
            this.toggleMetric.Size = new System.Drawing.Size(362, 32);
            this.toggleMetric.TabIndex = 5;
            this.toggleMetric.TabStop = true;
            this.toggleMetric.Text = "Toggle Metric";
            this.toggleMetric.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toggleMetric.UseVisualStyleBackColor = true;
            // 
            // BMIResult
            // 
            this.BMIResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BMIResult.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BMIResult.Location = new System.Drawing.Point(110, 91);
            this.BMIResult.MaxLength = 3;
            this.BMIResult.Name = "BMIResult";
            this.BMIResult.ReadOnly = true;
            this.BMIResult.Size = new System.Drawing.Size(362, 23);
            this.BMIResult.TabIndex = 9;
            // 
            // resultLabel
            // 
            this.resultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(3, 95);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(101, 15);
            this.resultLabel.TabIndex = 10;
            this.resultLabel.Text = "Your BMI:";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // errorMessageDisplay
            // 
            this.errorMessageDisplay.AutoSize = true;
            this.errorMessageDisplay.Location = new System.Drawing.Point(222, 296);
            this.errorMessageDisplay.Name = "errorMessageDisplay";
            this.errorMessageDisplay.Size = new System.Drawing.Size(0, 15);
            this.errorMessageDisplay.TabIndex = 14;
            // 
            // weightUnits
            // 
            this.weightUnits.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.weightUnits.AutoSize = true;
            this.weightUnits.Location = new System.Drawing.Point(245, 64);
            this.weightUnits.Name = "weightUnits";
            this.weightUnits.Size = new System.Drawing.Size(17, 15);
            this.weightUnits.TabIndex = 13;
            this.weightUnits.Text = "lb";
            // 
            // weightLabel
            // 
            this.weightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(3, 64);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(82, 15);
            this.weightLabel.TabIndex = 7;
            this.weightLabel.Text = "Your Weight:";
            this.weightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // littleHeightUnits
            // 
            this.littleHeightUnits.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.littleHeightUnits.AutoSize = true;
            this.littleHeightUnits.Location = new System.Drawing.Point(424, 16);
            this.littleHeightUnits.Name = "littleHeightUnits";
            this.littleHeightUnits.Size = new System.Drawing.Size(17, 15);
            this.littleHeightUnits.TabIndex = 12;
            this.littleHeightUnits.Text = "in";
            // 
            // ageLabel
            // 
            this.ageLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(3, 115);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(82, 15);
            this.ageLabel.TabIndex = 8;
            this.ageLabel.Text = "Your Age:";
            this.ageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxHeightInchesOrCm
            // 
            this.textBoxHeightInchesOrCm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHeightInchesOrCm.Location = new System.Drawing.Point(270, 12);
            this.textBoxHeightInchesOrCm.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.textBoxHeightInchesOrCm.Name = "textBoxHeightInchesOrCm";
            this.textBoxHeightInchesOrCm.Size = new System.Drawing.Size(148, 23);
            this.textBoxHeightInchesOrCm.TabIndex = 16;
            // 
            // heightLabel
            // 
            this.heightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(3, 16);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(82, 15);
            this.heightLabel.TabIndex = 6;
            this.heightLabel.Text = "Your Height:";
            this.heightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxWeightLbOrKg
            // 
            this.textBoxWeightLbOrKg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWeightLbOrKg.Location = new System.Drawing.Point(91, 60);
            this.textBoxWeightLbOrKg.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.textBoxWeightLbOrKg.Name = "textBoxWeightLbOrKg";
            this.textBoxWeightLbOrKg.Size = new System.Drawing.Size(148, 23);
            this.textBoxWeightLbOrKg.TabIndex = 17;
            // 
            // textBoxHeightFeetorMeters
            // 
            this.textBoxHeightFeetorMeters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxHeightFeetorMeters.Location = new System.Drawing.Point(91, 12);
            this.textBoxHeightFeetorMeters.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.textBoxHeightFeetorMeters.Name = "textBoxHeightFeetorMeters";
            this.textBoxHeightFeetorMeters.Size = new System.Drawing.Size(148, 23);
            this.textBoxHeightFeetorMeters.TabIndex = 15;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAge.Location = new System.Drawing.Point(91, 111);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(148, 23);
            this.textBoxAge.TabIndex = 18;
            // 
            // bigHeightUnits
            // 
            this.bigHeightUnits.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bigHeightUnits.AutoSize = true;
            this.bigHeightUnits.Location = new System.Drawing.Point(245, 16);
            this.bigHeightUnits.Name = "bigHeightUnits";
            this.bigHeightUnits.Size = new System.Drawing.Size(15, 15);
            this.bigHeightUnits.TabIndex = 11;
            this.bigHeightUnits.Text = "ft";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.38806F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.80597F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.80597F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.Controls.Add(this.bigHeightUnits, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxAge, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxHeightFeetorMeters, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxWeightLbOrKg, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.heightLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxHeightInchesOrCm, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.ageLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.littleHeightUnits, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.weightLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.weightUnits, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(28, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.33831F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.32836F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(475, 148);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.27273F));
            this.tableLayoutPanel2.Controls.Add(this.calculateBtn, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.resultLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.BMIResult, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.toggleMetric, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(28, 187);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.53815F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.12852F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(475, 124);
            this.tableLayoutPanel2.TabIndex = 20;
            // 
            // BMI_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 331);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.errorMessageDisplay);
            this.Name = "BMI_Calculator";
            this.Text = "Desktop BMI Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.textBoxHeightInchesOrCm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxWeightLbOrKg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxHeightFeetorMeters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxAge)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.RadioButton toggleMetric;
        private System.Windows.Forms.TextBox BMIResult;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label errorMessageDisplay;
        private System.Windows.Forms.Label weightUnits;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label littleHeightUnits;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.NumericUpDown textBoxHeightInchesOrCm;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.NumericUpDown textBoxWeightLbOrKg;
        private System.Windows.Forms.NumericUpDown textBoxHeightFeetorMeters;
        private System.Windows.Forms.NumericUpDown textBoxAge;
        private System.Windows.Forms.Label bigHeightUnits;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}
