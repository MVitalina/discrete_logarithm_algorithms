namespace discrete_logarithm_algorithms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelP = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.buttonSimpleFormula = new System.Windows.Forms.Button();
            this.buttonMatching = new System.Windows.Forms.Button();
            this.buttonPohligHellman = new System.Windows.Forms.Button();
            this.buttonRhoPollard = new System.Windows.Forms.Button();
            this.buttonBruteForce = new System.Windows.Forms.Button();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.labelSF = new System.Windows.Forms.Label();
            this.labelBF = new System.Windows.Forms.Label();
            this.labelMA = new System.Windows.Forms.Label();
            this.labelPHA = new System.Windows.Forms.Label();
            this.labelRho = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabCalculator = new System.Windows.Forms.TabPage();
            this.tabAnalyzer = new System.Windows.Forms.TabPage();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.numericUpDownP = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownB = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownA = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericNumRuns = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonAnalyze = new System.Windows.Forms.Button();
            this.gridMain = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabCalculator.SuspendLayout();
            this.tabAnalyzer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumRuns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(616, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA.Location = new System.Drawing.Point(0, 62);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(18, 20);
            this.labelA.TabIndex = 1;
            this.labelA.Text = "a";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelB.Location = new System.Drawing.Point(0, 91);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(18, 20);
            this.labelB.TabIndex = 2;
            this.labelB.Text = "b";
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelP.Location = new System.Drawing.Point(0, 121);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(18, 20);
            this.labelP.TabIndex = 3;
            this.labelP.Text = "p";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(24, 64);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(274, 22);
            this.textBoxA.TabIndex = 4;
            this.textBoxA.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(24, 93);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(274, 22);
            this.textBoxB.TabIndex = 5;
            this.textBoxB.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(24, 123);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(274, 22);
            this.textBoxP.TabIndex = 6;
            this.textBoxP.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // buttonSimpleFormula
            // 
            this.buttonSimpleFormula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSimpleFormula.Location = new System.Drawing.Point(1, 162);
            this.buttonSimpleFormula.Name = "buttonSimpleFormula";
            this.buttonSimpleFormula.Size = new System.Drawing.Size(297, 31);
            this.buttonSimpleFormula.TabIndex = 7;
            this.buttonSimpleFormula.Text = "Simple Formula";
            this.buttonSimpleFormula.UseVisualStyleBackColor = true;
            this.buttonSimpleFormula.Click += new System.EventHandler(this.buttonSimpleFormula_Click);
            // 
            // buttonMatching
            // 
            this.buttonMatching.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMatching.Location = new System.Drawing.Point(1, 236);
            this.buttonMatching.Name = "buttonMatching";
            this.buttonMatching.Size = new System.Drawing.Size(297, 31);
            this.buttonMatching.TabIndex = 9;
            this.buttonMatching.Text = "Matching Algorithm";
            this.buttonMatching.UseVisualStyleBackColor = true;
            this.buttonMatching.Click += new System.EventHandler(this.buttonMatching_Click);
            // 
            // buttonPohligHellman
            // 
            this.buttonPohligHellman.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPohligHellman.Location = new System.Drawing.Point(0, 273);
            this.buttonPohligHellman.Name = "buttonPohligHellman";
            this.buttonPohligHellman.Size = new System.Drawing.Size(297, 31);
            this.buttonPohligHellman.TabIndex = 10;
            this.buttonPohligHellman.Text = "Pohlig-Hellman Algorithm";
            this.buttonPohligHellman.UseVisualStyleBackColor = true;
            this.buttonPohligHellman.Click += new System.EventHandler(this.buttonPohligHellman_Click);
            // 
            // buttonRhoPollard
            // 
            this.buttonRhoPollard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRhoPollard.Location = new System.Drawing.Point(0, 310);
            this.buttonRhoPollard.Name = "buttonRhoPollard";
            this.buttonRhoPollard.Size = new System.Drawing.Size(297, 31);
            this.buttonRhoPollard.TabIndex = 11;
            this.buttonRhoPollard.Text = "Pollard Rho Algorithm";
            this.buttonRhoPollard.UseVisualStyleBackColor = true;
            this.buttonRhoPollard.Click += new System.EventHandler(this.buttonRhoPollard_Click);
            // 
            // buttonBruteForce
            // 
            this.buttonBruteForce.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBruteForce.Location = new System.Drawing.Point(0, 199);
            this.buttonBruteForce.Name = "buttonBruteForce";
            this.buttonBruteForce.Size = new System.Drawing.Size(297, 31);
            this.buttonBruteForce.TabIndex = 8;
            this.buttonBruteForce.Text = "Brute Force Method";
            this.buttonBruteForce.UseVisualStyleBackColor = true;
            this.buttonBruteForce.Click += new System.EventHandler(this.buttonBruteForce_Click);
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(342, 64);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(274, 22);
            this.textBoxX.TabIndex = 13;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX.Location = new System.Drawing.Point(318, 62);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(16, 20);
            this.labelX.TabIndex = 12;
            this.labelX.Text = "x";
            // 
            // labelSF
            // 
            this.labelSF.AutoSize = true;
            this.labelSF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSF.Location = new System.Drawing.Point(318, 166);
            this.labelSF.Name = "labelSF";
            this.labelSF.Size = new System.Drawing.Size(51, 20);
            this.labelSF.TabIndex = 14;
            this.labelSF.Text = "Time: ";
            // 
            // labelBF
            // 
            this.labelBF.AutoSize = true;
            this.labelBF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBF.Location = new System.Drawing.Point(318, 203);
            this.labelBF.Name = "labelBF";
            this.labelBF.Size = new System.Drawing.Size(51, 20);
            this.labelBF.TabIndex = 15;
            this.labelBF.Text = "Time: ";
            // 
            // labelMA
            // 
            this.labelMA.AutoSize = true;
            this.labelMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMA.Location = new System.Drawing.Point(318, 240);
            this.labelMA.Name = "labelMA";
            this.labelMA.Size = new System.Drawing.Size(51, 20);
            this.labelMA.TabIndex = 16;
            this.labelMA.Text = "Time: ";
            // 
            // labelPHA
            // 
            this.labelPHA.AutoSize = true;
            this.labelPHA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPHA.Location = new System.Drawing.Point(318, 277);
            this.labelPHA.Name = "labelPHA";
            this.labelPHA.Size = new System.Drawing.Size(51, 20);
            this.labelPHA.TabIndex = 17;
            this.labelPHA.Text = "Time: ";
            // 
            // labelRho
            // 
            this.labelRho.AutoSize = true;
            this.labelRho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRho.Location = new System.Drawing.Point(318, 314);
            this.labelRho.Name = "labelRho";
            this.labelRho.Size = new System.Drawing.Size(51, 20);
            this.labelRho.TabIndex = 18;
            this.labelRho.Text = "Time: ";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabCalculator);
            this.tabControl.Controls.Add(this.tabAnalyzer);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(643, 408);
            this.tabControl.TabIndex = 19;
            // 
            // tabCalculator
            // 
            this.tabCalculator.Controls.Add(this.pictureBox1);
            this.tabCalculator.Controls.Add(this.labelRho);
            this.tabCalculator.Controls.Add(this.labelA);
            this.tabCalculator.Controls.Add(this.labelPHA);
            this.tabCalculator.Controls.Add(this.labelB);
            this.tabCalculator.Controls.Add(this.labelMA);
            this.tabCalculator.Controls.Add(this.labelP);
            this.tabCalculator.Controls.Add(this.labelBF);
            this.tabCalculator.Controls.Add(this.textBoxA);
            this.tabCalculator.Controls.Add(this.labelSF);
            this.tabCalculator.Controls.Add(this.textBoxB);
            this.tabCalculator.Controls.Add(this.textBoxX);
            this.tabCalculator.Controls.Add(this.textBoxP);
            this.tabCalculator.Controls.Add(this.labelX);
            this.tabCalculator.Controls.Add(this.buttonSimpleFormula);
            this.tabCalculator.Controls.Add(this.buttonBruteForce);
            this.tabCalculator.Controls.Add(this.buttonMatching);
            this.tabCalculator.Controls.Add(this.buttonRhoPollard);
            this.tabCalculator.Controls.Add(this.buttonPohligHellman);
            this.tabCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabCalculator.Location = new System.Drawing.Point(4, 25);
            this.tabCalculator.Name = "tabCalculator";
            this.tabCalculator.Padding = new System.Windows.Forms.Padding(3);
            this.tabCalculator.Size = new System.Drawing.Size(635, 379);
            this.tabCalculator.TabIndex = 0;
            this.tabCalculator.Text = "Calculator";
            this.tabCalculator.UseVisualStyleBackColor = true;
            // 
            // tabAnalyzer
            // 
            this.tabAnalyzer.Controls.Add(this.checkedListBox);
            this.tabAnalyzer.Controls.Add(this.numericUpDownP);
            this.tabAnalyzer.Controls.Add(this.numericUpDownB);
            this.tabAnalyzer.Controls.Add(this.numericUpDownA);
            this.tabAnalyzer.Controls.Add(this.label3);
            this.tabAnalyzer.Controls.Add(this.label4);
            this.tabAnalyzer.Controls.Add(this.label5);
            this.tabAnalyzer.Controls.Add(this.label2);
            this.tabAnalyzer.Controls.Add(this.numericNumRuns);
            this.tabAnalyzer.Controls.Add(this.label1);
            this.tabAnalyzer.Controls.Add(this.progressBar);
            this.tabAnalyzer.Controls.Add(this.buttonAnalyze);
            this.tabAnalyzer.Controls.Add(this.gridMain);
            this.tabAnalyzer.Location = new System.Drawing.Point(4, 25);
            this.tabAnalyzer.Name = "tabAnalyzer";
            this.tabAnalyzer.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnalyzer.Size = new System.Drawing.Size(635, 379);
            this.tabAnalyzer.TabIndex = 1;
            this.tabAnalyzer.Text = "Analyzer";
            this.tabAnalyzer.UseVisualStyleBackColor = true;
            // 
            // checkedListBox
            // 
            this.checkedListBox.CheckOnClick = true;
            this.checkedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Items.AddRange(new object[] {
            "Brute Force",
            "Simple Formula",
            "Matching",
            "Pohlig Hellman",
            "Pollard Rho"});
            this.checkedListBox.Location = new System.Drawing.Point(84, 12);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.ScrollAlwaysVisible = true;
            this.checkedListBox.Size = new System.Drawing.Size(124, 19);
            this.checkedListBox.TabIndex = 17;
            this.checkedListBox.TabStop = false;
            this.checkedListBox.MouseEnter += new System.EventHandler(this.checkedListBox_MouseEnter);
            this.checkedListBox.MouseLeave += new System.EventHandler(this.checkedListBox_MouseLeave);
            // 
            // numericUpDownP
            // 
            this.numericUpDownP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numericUpDownP.Location = new System.Drawing.Point(300, 297);
            this.numericUpDownP.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownP.Name = "numericUpDownP";
            this.numericUpDownP.Size = new System.Drawing.Size(52, 23);
            this.numericUpDownP.TabIndex = 11;
            this.numericUpDownP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownB
            // 
            this.numericUpDownB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numericUpDownB.Location = new System.Drawing.Point(220, 297);
            this.numericUpDownB.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownB.Name = "numericUpDownB";
            this.numericUpDownB.Size = new System.Drawing.Size(52, 23);
            this.numericUpDownB.TabIndex = 10;
            this.numericUpDownB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownA
            // 
            this.numericUpDownA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numericUpDownA.Location = new System.Drawing.Point(140, 297);
            this.numericUpDownA.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownA.Name = "numericUpDownA";
            this.numericUpDownA.Size = new System.Drawing.Size(52, 23);
            this.numericUpDownA.TabIndex = 9;
            this.numericUpDownA.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(118, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "a";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(198, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "b";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(278, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "p";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(6, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Count of bytes:";
            // 
            // numericNumRuns
            // 
            this.numericNumRuns.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numericNumRuns.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericNumRuns.Location = new System.Drawing.Point(140, 268);
            this.numericNumRuns.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericNumRuns.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericNumRuns.Name = "numericNumRuns";
            this.numericNumRuns.Size = new System.Drawing.Size(52, 23);
            this.numericNumRuns.TabIndex = 4;
            this.numericNumRuns.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(5, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number of runs:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(3, 3);
            this.progressBar.MarqueeAnimationSpeed = 50;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(626, 3);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar.TabIndex = 2;
            this.progressBar.Visible = false;
            // 
            // buttonAnalyze
            // 
            this.buttonAnalyze.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonAnalyze.Location = new System.Drawing.Point(3, 8);
            this.buttonAnalyze.Name = "buttonAnalyze";
            this.buttonAnalyze.Size = new System.Drawing.Size(75, 24);
            this.buttonAnalyze.TabIndex = 1;
            this.buttonAnalyze.Text = "Analyze";
            this.buttonAnalyze.UseVisualStyleBackColor = true;
            this.buttonAnalyze.Click += new System.EventHandler(this.buttonAnalyze_Click);
            // 
            // gridMain
            // 
            this.gridMain.AllowUserToAddRows = false;
            this.gridMain.AllowUserToDeleteRows = false;
            this.gridMain.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMain.Location = new System.Drawing.Point(3, 38);
            this.gridMain.Name = "gridMain";
            this.gridMain.ReadOnly = true;
            this.gridMain.RowHeadersVisible = false;
            this.gridMain.Size = new System.Drawing.Size(622, 224);
            this.gridMain.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 432);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Discrete Logarithm Algorithms";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabCalculator.ResumeLayout(false);
            this.tabCalculator.PerformLayout();
            this.tabAnalyzer.ResumeLayout(false);
            this.tabAnalyzer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumRuns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.Button buttonSimpleFormula;
        private System.Windows.Forms.Button buttonMatching;
        private System.Windows.Forms.Button buttonPohligHellman;
        private System.Windows.Forms.Button buttonRhoPollard;
        private System.Windows.Forms.Button buttonBruteForce;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelSF;
        private System.Windows.Forms.Label labelBF;
        private System.Windows.Forms.Label labelMA;
        private System.Windows.Forms.Label labelPHA;
        private System.Windows.Forms.Label labelRho;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabCalculator;
        private System.Windows.Forms.TabPage tabAnalyzer;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.NumericUpDown numericUpDownP;
        private System.Windows.Forms.NumericUpDown numericUpDownB;
        private System.Windows.Forms.NumericUpDown numericUpDownA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericNumRuns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button buttonAnalyze;
        private System.Windows.Forms.DataGridView gridMain;
    }
}

