namespace CalsfromFatandCarbs
{
    partial class CarbandFatCalc
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
            this.lblFat = new System.Windows.Forms.Label();
            this.lblCarb = new System.Windows.Forms.Label();
            this.lblCalFat = new System.Windows.Forms.Label();
            this.lblCalCarb = new System.Windows.Forms.Label();
            this.tbFat = new System.Windows.Forms.TextBox();
            this.tbCalCarb = new System.Windows.Forms.TextBox();
            this.tbCalFat = new System.Windows.Forms.TextBox();
            this.tbCarb = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFat
            // 
            this.lblFat.AutoSize = true;
            this.lblFat.Location = new System.Drawing.Point(12, 25);
            this.lblFat.Name = "lblFat";
            this.lblFat.Size = new System.Drawing.Size(103, 13);
            this.lblFat.TabIndex = 0;
            this.lblFat.Text = "Enter number of Fat:";
            // 
            // lblCarb
            // 
            this.lblCarb.AutoSize = true;
            this.lblCarb.Location = new System.Drawing.Point(12, 52);
            this.lblCarb.Name = "lblCarb";
            this.lblCarb.Size = new System.Drawing.Size(115, 13);
            this.lblCarb.TabIndex = 1;
            this.lblCarb.Text = "Enter number of Carbs:";
            // 
            // lblCalFat
            // 
            this.lblCalFat.AutoSize = true;
            this.lblCalFat.Location = new System.Drawing.Point(12, 86);
            this.lblCalFat.Name = "lblCalFat";
            this.lblCalFat.Size = new System.Drawing.Size(88, 13);
            this.lblCalFat.TabIndex = 2;
            this.lblCalFat.Text = "Calories from Fat:";
            // 
            // lblCalCarb
            // 
            this.lblCalCarb.AutoSize = true;
            this.lblCalCarb.Location = new System.Drawing.Point(13, 112);
            this.lblCalCarb.Name = "lblCalCarb";
            this.lblCalCarb.Size = new System.Drawing.Size(100, 13);
            this.lblCalCarb.TabIndex = 3;
            this.lblCalCarb.Text = "Calories from Carbs:";
            // 
            // tbFat
            // 
            this.tbFat.Location = new System.Drawing.Point(133, 22);
            this.tbFat.Name = "tbFat";
            this.tbFat.Size = new System.Drawing.Size(100, 20);
            this.tbFat.TabIndex = 4;
            // 
            // tbCalCarb
            // 
            this.tbCalCarb.Location = new System.Drawing.Point(133, 109);
            this.tbCalCarb.Name = "tbCalCarb";
            this.tbCalCarb.ReadOnly = true;
            this.tbCalCarb.Size = new System.Drawing.Size(100, 20);
            this.tbCalCarb.TabIndex = 5;
            // 
            // tbCalFat
            // 
            this.tbCalFat.Location = new System.Drawing.Point(133, 83);
            this.tbCalFat.Name = "tbCalFat";
            this.tbCalFat.ReadOnly = true;
            this.tbCalFat.Size = new System.Drawing.Size(100, 20);
            this.tbCalFat.TabIndex = 6;
            // 
            // tbCarb
            // 
            this.tbCarb.Location = new System.Drawing.Point(133, 49);
            this.tbCarb.Name = "tbCarb";
            this.tbCarb.Size = new System.Drawing.Size(100, 20);
            this.tbCarb.TabIndex = 7;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(16, 163);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(84, 64);
            this.btnCalc.TabIndex = 8;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(149, 163);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 64);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // CarbandFatCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 250);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.tbCarb);
            this.Controls.Add(this.tbCalFat);
            this.Controls.Add(this.tbCalCarb);
            this.Controls.Add(this.tbFat);
            this.Controls.Add(this.lblCalCarb);
            this.Controls.Add(this.lblCalFat);
            this.Controls.Add(this.lblCarb);
            this.Controls.Add(this.lblFat);
            this.Name = "CarbandFatCalc";
            this.Text = "Carb and Fat Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFat;
        private System.Windows.Forms.Label lblCarb;
        private System.Windows.Forms.Label lblCalFat;
        private System.Windows.Forms.Label lblCalCarb;
        private System.Windows.Forms.TextBox tbFat;
        private System.Windows.Forms.TextBox tbCalCarb;
        private System.Windows.Forms.TextBox tbCalFat;
        private System.Windows.Forms.TextBox tbCarb;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnExit;
    }
}

