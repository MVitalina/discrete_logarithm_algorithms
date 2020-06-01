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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(616, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelA.Location = new System.Drawing.Point(12, 74);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(18, 20);
            this.labelA.TabIndex = 1;
            this.labelA.Text = "a";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelB.Location = new System.Drawing.Point(12, 103);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(18, 20);
            this.labelB.TabIndex = 2;
            this.labelB.Text = "b";
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelP.Location = new System.Drawing.Point(12, 133);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(18, 20);
            this.labelP.TabIndex = 3;
            this.labelP.Text = "p";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(36, 76);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(274, 20);
            this.textBoxA.TabIndex = 4;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(36, 105);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(274, 20);
            this.textBoxB.TabIndex = 5;
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(36, 135);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(274, 20);
            this.textBoxP.TabIndex = 6;
            // 
            // buttonSimpleFormula
            // 
            this.buttonSimpleFormula.Location = new System.Drawing.Point(13, 174);
            this.buttonSimpleFormula.Name = "buttonSimpleFormula";
            this.buttonSimpleFormula.Size = new System.Drawing.Size(297, 31);
            this.buttonSimpleFormula.TabIndex = 7;
            this.buttonSimpleFormula.Text = "Simple Formula";
            this.buttonSimpleFormula.UseVisualStyleBackColor = true;
            this.buttonSimpleFormula.Click += new System.EventHandler(this.buttonSimpleFormula_Click);
            // 
            // buttonMatching
            // 
            this.buttonMatching.Location = new System.Drawing.Point(13, 248);
            this.buttonMatching.Name = "buttonMatching";
            this.buttonMatching.Size = new System.Drawing.Size(297, 31);
            this.buttonMatching.TabIndex = 9;
            this.buttonMatching.Text = "Matching Algorithm";
            this.buttonMatching.UseVisualStyleBackColor = true;
            this.buttonMatching.Click += new System.EventHandler(this.buttonMatching_Click);
            // 
            // buttonPohligHellman
            // 
            this.buttonPohligHellman.Location = new System.Drawing.Point(12, 285);
            this.buttonPohligHellman.Name = "buttonPohligHellman";
            this.buttonPohligHellman.Size = new System.Drawing.Size(297, 31);
            this.buttonPohligHellman.TabIndex = 10;
            this.buttonPohligHellman.Text = "Pohlig-Hellman Algorithm";
            this.buttonPohligHellman.UseVisualStyleBackColor = true;
            this.buttonPohligHellman.Click += new System.EventHandler(this.buttonPohligHellman_Click);
            // 
            // buttonRhoPollard
            // 
            this.buttonRhoPollard.Location = new System.Drawing.Point(12, 322);
            this.buttonRhoPollard.Name = "buttonRhoPollard";
            this.buttonRhoPollard.Size = new System.Drawing.Size(297, 31);
            this.buttonRhoPollard.TabIndex = 11;
            this.buttonRhoPollard.Text = "Pollard Rho Algorithm";
            this.buttonRhoPollard.UseVisualStyleBackColor = true;
            this.buttonRhoPollard.Click += new System.EventHandler(this.buttonRhoPollard_Click);
            // 
            // buttonBruteForce
            // 
            this.buttonBruteForce.Location = new System.Drawing.Point(12, 211);
            this.buttonBruteForce.Name = "buttonBruteForce";
            this.buttonBruteForce.Size = new System.Drawing.Size(297, 31);
            this.buttonBruteForce.TabIndex = 8;
            this.buttonBruteForce.Text = "Brute Force Method";
            this.buttonBruteForce.UseVisualStyleBackColor = true;
            this.buttonBruteForce.Click += new System.EventHandler(this.buttonBruteForce_Click);
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(354, 76);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(274, 20);
            this.textBoxX.TabIndex = 13;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX.Location = new System.Drawing.Point(330, 74);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(16, 20);
            this.labelX.TabIndex = 12;
            this.labelX.Text = "x";
            // 
            // labelSF
            // 
            this.labelSF.AutoSize = true;
            this.labelSF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSF.Location = new System.Drawing.Point(330, 178);
            this.labelSF.Name = "labelSF";
            this.labelSF.Size = new System.Drawing.Size(51, 20);
            this.labelSF.TabIndex = 14;
            this.labelSF.Text = "Time: ";
            // 
            // labelBF
            // 
            this.labelBF.AutoSize = true;
            this.labelBF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBF.Location = new System.Drawing.Point(330, 215);
            this.labelBF.Name = "labelBF";
            this.labelBF.Size = new System.Drawing.Size(51, 20);
            this.labelBF.TabIndex = 15;
            this.labelBF.Text = "Time: ";
            // 
            // labelMA
            // 
            this.labelMA.AutoSize = true;
            this.labelMA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMA.Location = new System.Drawing.Point(330, 252);
            this.labelMA.Name = "labelMA";
            this.labelMA.Size = new System.Drawing.Size(51, 20);
            this.labelMA.TabIndex = 16;
            this.labelMA.Text = "Time: ";
            // 
            // labelPHA
            // 
            this.labelPHA.AutoSize = true;
            this.labelPHA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPHA.Location = new System.Drawing.Point(330, 289);
            this.labelPHA.Name = "labelPHA";
            this.labelPHA.Size = new System.Drawing.Size(51, 20);
            this.labelPHA.TabIndex = 17;
            this.labelPHA.Text = "Time: ";
            // 
            // labelRho
            // 
            this.labelRho.AutoSize = true;
            this.labelRho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRho.Location = new System.Drawing.Point(330, 326);
            this.labelRho.Name = "labelRho";
            this.labelRho.Size = new System.Drawing.Size(51, 20);
            this.labelRho.TabIndex = 18;
            this.labelRho.Text = "Time: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 365);
            this.Controls.Add(this.labelRho);
            this.Controls.Add(this.labelPHA);
            this.Controls.Add(this.labelMA);
            this.Controls.Add(this.labelBF);
            this.Controls.Add(this.labelSF);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.buttonBruteForce);
            this.Controls.Add(this.buttonRhoPollard);
            this.Controls.Add(this.buttonPohligHellman);
            this.Controls.Add(this.buttonMatching);
            this.Controls.Add(this.buttonSimpleFormula);
            this.Controls.Add(this.textBoxP);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelP);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "Discrete Logarithm Algorithms";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

