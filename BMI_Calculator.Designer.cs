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
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.BMIResult = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.bigHeightUnits = new System.Windows.Forms.Label();
            this.littleHeightUnits = new System.Windows.Forms.Label();
            this.weightUnits = new System.Windows.Forms.Label();
            this.errorMessageDisplay = new System.Windows.Forms.Label();
            this.textBoxHeightFeetorMeters = new System.Windows.Forms.NumericUpDown();
            this.textBoxHeightInchesOrCm = new System.Windows.Forms.NumericUpDown();
            this.textBoxWeightLbOrKg = new System.Windows.Forms.NumericUpDown();
            this.textBoxAge = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxHeightFeetorMeters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxHeightInchesOrCm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxWeightLbOrKg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxAge)).BeginInit();
            this.SuspendLayout();
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(174, 195);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(138, 36);
            this.calculateBtn.TabIndex = 0;
            this.calculateBtn.Text = "Calculate BMI";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // toggleMetric
            // 
            this.toggleMetric.AutoSize = true;
            this.toggleMetric.Location = new System.Drawing.Point(198, 166);
            this.toggleMetric.Name = "toggleMetric";
            this.toggleMetric.Size = new System.Drawing.Size(93, 19);
            this.toggleMetric.TabIndex = 5;
            this.toggleMetric.TabStop = true;
            this.toggleMetric.Text = "Toggle Metic";
            this.toggleMetric.UseVisualStyleBackColor = true;
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(65, 32);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(73, 15);
            this.heightLabel.TabIndex = 6;
            this.heightLabel.Text = "Your Height:";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(63, 84);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(75, 15);
            this.weightLabel.TabIndex = 7;
            this.weightLabel.Text = "Your Weight:";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(78, 139);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(58, 15);
            this.ageLabel.TabIndex = 8;
            this.ageLabel.Text = "Your Age:";
            // 
            // BMIResult
            // 
            this.BMIResult.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BMIResult.Location = new System.Drawing.Point(191, 257);
            this.BMIResult.MaxLength = 3;
            this.BMIResult.Name = "BMIResult";
            this.BMIResult.ReadOnly = true;
            this.BMIResult.Size = new System.Drawing.Size(100, 23);
            this.BMIResult.TabIndex = 9;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(116, 265);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(58, 15);
            this.resultLabel.TabIndex = 10;
            this.resultLabel.Text = "Your BMI:";
            // 
            // bigHeightUnits
            // 
            this.bigHeightUnits.AutoSize = true;
            this.bigHeightUnits.Location = new System.Drawing.Point(245, 32);
            this.bigHeightUnits.Name = "bigHeightUnits";
            this.bigHeightUnits.Size = new System.Drawing.Size(15, 15);
            this.bigHeightUnits.TabIndex = 11;
            this.bigHeightUnits.Text = "ft";
            // 
            // littleHeightUnits
            // 
            this.littleHeightUnits.AutoSize = true;
            this.littleHeightUnits.Location = new System.Drawing.Point(358, 32);
            this.littleHeightUnits.Name = "littleHeightUnits";
            this.littleHeightUnits.Size = new System.Drawing.Size(17, 15);
            this.littleHeightUnits.TabIndex = 12;
            this.littleHeightUnits.Text = "in";
            // 
            // weightUnits
            // 
            this.weightUnits.AutoSize = true;
            this.weightUnits.Location = new System.Drawing.Point(358, 84);
            this.weightUnits.Name = "weightUnits";
            this.weightUnits.Size = new System.Drawing.Size(17, 15);
            this.weightUnits.TabIndex = 13;
            this.weightUnits.Text = "lb";
            // 
            // errorMessageDisplay
            // 
            this.errorMessageDisplay.AutoSize = true;
            this.errorMessageDisplay.Location = new System.Drawing.Point(222, 296);
            this.errorMessageDisplay.Name = "errorMessageDisplay";
            this.errorMessageDisplay.Size = new System.Drawing.Size(0, 15);
            this.errorMessageDisplay.TabIndex = 14;
            // 
            // textBoxHeightFeetorMeters
            // 
            this.textBoxHeightFeetorMeters.Location = new System.Drawing.Point(157, 25);
            this.textBoxHeightFeetorMeters.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.textBoxHeightFeetorMeters.Name = "textBoxHeightFeetorMeters";
            this.textBoxHeightFeetorMeters.Size = new System.Drawing.Size(82, 23);
            this.textBoxHeightFeetorMeters.TabIndex = 15;
            // 
            // textBoxHeightInchesOrCm
            // 
            this.textBoxHeightInchesOrCm.Location = new System.Drawing.Point(266, 25);
            this.textBoxHeightInchesOrCm.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.textBoxHeightInchesOrCm.Name = "textBoxHeightInchesOrCm";
            this.textBoxHeightInchesOrCm.Size = new System.Drawing.Size(86, 23);
            this.textBoxHeightInchesOrCm.TabIndex = 16;
            // 
            // textBoxWeightLbOrKg
            // 
            this.textBoxWeightLbOrKg.Location = new System.Drawing.Point(157, 82);
            this.textBoxWeightLbOrKg.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.textBoxWeightLbOrKg.Name = "textBoxWeightLbOrKg";
            this.textBoxWeightLbOrKg.Size = new System.Drawing.Size(195, 23);
            this.textBoxWeightLbOrKg.TabIndex = 17;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(157, 137);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(195, 23);
            this.textBoxAge.TabIndex = 18;
            // 
            // BMI_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 331);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxWeightLbOrKg);
            this.Controls.Add(this.textBoxHeightInchesOrCm);
            this.Controls.Add(this.textBoxHeightFeetorMeters);
            this.Controls.Add(this.errorMessageDisplay);
            this.Controls.Add(this.weightUnits);
            this.Controls.Add(this.littleHeightUnits);
            this.Controls.Add(this.bigHeightUnits);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.BMIResult);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.toggleMetric);
            this.Controls.Add(this.calculateBtn);
            this.Name = "BMI_Calculator";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.textBoxHeightFeetorMeters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxHeightInchesOrCm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxWeightLbOrKg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.RadioButton toggleMetric;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox BMIResult;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label bigHeightUnits;
        private System.Windows.Forms.Label littleHeightUnits;
        private System.Windows.Forms.Label weightUnits;
        private System.Windows.Forms.Label errorMessageDisplay;
        private System.Windows.Forms.NumericUpDown textBoxHeightFeetorMeters;
        private System.Windows.Forms.NumericUpDown textBoxHeightInchesOrCm;
        private System.Windows.Forms.NumericUpDown textBoxWeightLbOrKg;
        private System.Windows.Forms.NumericUpDown textBoxAge;
    }
}
