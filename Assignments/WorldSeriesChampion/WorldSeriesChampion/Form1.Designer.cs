namespace WorldSeriesChampion
{
    partial class WorldSeries
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblTeam = new System.Windows.Forms.Label();
            this.lblWin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 203);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 41);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load World Series Wins";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(179, 203);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 41);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(313, 29);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(74, 45);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Calculate Wins";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Location = new System.Drawing.Point(313, 81);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(68, 13);
            this.lblTeam.TabIndex = 3;
            this.lblTeam.Text = "Team Name:";
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.Location = new System.Drawing.Point(310, 162);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(86, 13);
            this.lblWin.TabIndex = 4;
            this.lblWin.Text = "Number of Wins:";
            // 
            // WorldSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLoad);
            this.Name = "WorldSeries";
            this.Text = "World Series Champion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.Label lblWin;
    }
}

