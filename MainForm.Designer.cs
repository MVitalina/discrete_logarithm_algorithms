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
            this.buttonSF = new System.Windows.Forms.Button();
            this.buttonMA = new System.Windows.Forms.Button();
            this.buttonPHA = new System.Windows.Forms.Button();
            this.buttonRo = new System.Windows.Forms.Button();
            this.buttonSub = new System.Windows.Forms.Button();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.labelSF = new System.Windows.Forms.Label();
            this.labelSM = new System.Windows.Forms.Label();
            this.labelMA = new System.Windows.Forms.Label();
            this.labelPHA = new System.Windows.Forms.Label();
            this.labelRo = new System.Windows.Forms.Label();
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
            // buttonSF
            // 
            this.buttonSF.Location = new System.Drawing.Point(13, 174);
            this.buttonSF.Name = "buttonSF";
            this.buttonSF.Size = new System.Drawing.Size(297, 31);
            this.buttonSF.TabIndex = 7;
            this.buttonSF.Text = "Simple Formula";
            this.buttonSF.UseVisualStyleBackColor = true;
            this.buttonSF.Click += new System.EventHandler(this.buttonSF_Click);
            // 
            // buttonMA
            // 
            this.buttonMA.Location = new System.Drawing.Point(13, 248);
            this.buttonMA.Name = "buttonMA";
            this.buttonMA.Size = new System.Drawing.Size(297, 31);
            this.buttonMA.TabIndex = 8;
            this.buttonMA.Text = "Matching Algorithm";
            this.buttonMA.UseVisualStyleBackColor = true;
            this.buttonMA.Click += new System.EventHandler(this.buttonMA_Click);
            // 
            // buttonPHA
            // 
            this.buttonPHA.Location = new System.Drawing.Point(12, 285);
            this.buttonPHA.Name = "buttonPHA";
            this.buttonPHA.Size = new System.Drawing.Size(297, 31);
            this.buttonPHA.TabIndex = 9;
            this.buttonPHA.Text = "Pohlig-Hellman Algorithm";
            this.buttonPHA.UseVisualStyleBackColor = true;
            this.buttonPHA.Click += new System.EventHandler(this.buttonPHA_Click);
            // 
            // buttonRo
            // 
            this.buttonRo.Location = new System.Drawing.Point(12, 322);
            this.buttonRo.Name = "buttonRo";
            this.buttonRo.Size = new System.Drawing.Size(297, 31);
            this.buttonRo.TabIndex = 10;
            this.buttonRo.Text = "Pollard Rho Algorithm";
            this.buttonRo.UseVisualStyleBackColor = true;
            this.buttonRo.Click += new System.EventHandler(this.buttonRo_Click);
            // 
            // buttonSub
            // 
            this.buttonSub.Location = new System.Drawing.Point(12, 211);
            this.buttonSub.Name = "buttonSub";
            this.buttonSub.Size = new System.Drawing.Size(297, 31);
            this.buttonSub.TabIndex = 11;
            this.buttonSub.Text = "Substitution Method";
            this.buttonSub.UseVisualStyleBackColor = true;
            this.buttonSub.Click += new System.EventHandler(this.buttonSub_Click);
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
            // labelSM
            // 
            this.labelSM.AutoSize = true;
            this.labelSM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSM.Location = new System.Drawing.Point(330, 215);
            this.labelSM.Name = "labelSM";
            this.labelSM.Size = new System.Drawing.Size(51, 20);
            this.labelSM.TabIndex = 15;
            this.labelSM.Text = "Time: ";
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
            // labelRo
            // 
            this.labelRo.AutoSize = true;
            this.labelRo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRo.Location = new System.Drawing.Point(330, 326);
            this.labelRo.Name = "labelRo";
            this.labelRo.Size = new System.Drawing.Size(51, 20);
            this.labelRo.TabIndex = 18;
            this.labelRo.Text = "Time: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 365);
            this.Controls.Add(this.labelRo);
            this.Controls.Add(this.labelPHA);
            this.Controls.Add(this.labelMA);
            this.Controls.Add(this.labelSM);
            this.Controls.Add(this.labelSF);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.buttonSub);
            this.Controls.Add(this.buttonRo);
            this.Controls.Add(this.buttonPHA);
            this.Controls.Add(this.buttonMA);
            this.Controls.Add(this.buttonSF);
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
        private System.Windows.Forms.Button buttonSF;
        private System.Windows.Forms.Button buttonMA;
        private System.Windows.Forms.Button buttonPHA;
        private System.Windows.Forms.Button buttonRo;
        private System.Windows.Forms.Button buttonSub;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelSF;
        private System.Windows.Forms.Label labelSM;
        private System.Windows.Forms.Label labelMA;
        private System.Windows.Forms.Label labelPHA;
        private System.Windows.Forms.Label labelRo;
    }
}

