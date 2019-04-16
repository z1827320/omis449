namespace NameSearchPorjectV._2
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
            this.btnBoyL = new System.Windows.Forms.Button();
            this.btnGirlL = new System.Windows.Forms.Button();
            this.lblBoth = new System.Windows.Forms.Label();
            this.lblBoy = new System.Windows.Forms.Label();
            this.lblGirl = new System.Windows.Forms.Label();
            this.tbBoyIn = new System.Windows.Forms.TextBox();
            this.tbGirlIn = new System.Windows.Forms.TextBox();
            this.tbBoyOutput = new System.Windows.Forms.TextBox();
            this.tbGirlOutput = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBoyL
            // 
            this.btnBoyL.Location = new System.Drawing.Point(12, 50);
            this.btnBoyL.Name = "btnBoyL";
            this.btnBoyL.Size = new System.Drawing.Size(105, 46);
            this.btnBoyL.TabIndex = 0;
            this.btnBoyL.Text = "Load Boys Names";
            this.btnBoyL.UseVisualStyleBackColor = true;
            this.btnBoyL.Click += new System.EventHandler(this.btnBoyL_Click);
            // 
            // btnGirlL
            // 
            this.btnGirlL.Location = new System.Drawing.Point(12, 116);
            this.btnGirlL.Name = "btnGirlL";
            this.btnGirlL.Size = new System.Drawing.Size(105, 46);
            this.btnGirlL.TabIndex = 1;
            this.btnGirlL.Text = "Load Girls Names";
            this.btnGirlL.UseVisualStyleBackColor = true;
            this.btnGirlL.Click += new System.EventHandler(this.btnGirlL_Click);
            // 
            // lblBoth
            // 
            this.lblBoth.AutoSize = true;
            this.lblBoth.Location = new System.Drawing.Point(79, 18);
            this.lblBoth.Name = "lblBoth";
            this.lblBoth.Size = new System.Drawing.Size(222, 13);
            this.lblBoth.TabIndex = 2;
            this.lblBoth.Text = "Enter either a Boys name, Girls name, or both.";
            // 
            // lblBoy
            // 
            this.lblBoy.AutoSize = true;
            this.lblBoy.Location = new System.Drawing.Point(136, 64);
            this.lblBoy.Name = "lblBoy";
            this.lblBoy.Size = new System.Drawing.Size(59, 13);
            this.lblBoy.TabIndex = 3;
            this.lblBoy.Text = "Boys name";
            // 
            // lblGirl
            // 
            this.lblGirl.AutoSize = true;
            this.lblGirl.Location = new System.Drawing.Point(139, 131);
            this.lblGirl.Name = "lblGirl";
            this.lblGirl.Size = new System.Drawing.Size(56, 13);
            this.lblGirl.TabIndex = 4;
            this.lblGirl.Text = "Girls name";
            // 
            // tbBoyIn
            // 
            this.tbBoyIn.Location = new System.Drawing.Point(225, 61);
            this.tbBoyIn.Name = "tbBoyIn";
            this.tbBoyIn.Size = new System.Drawing.Size(100, 20);
            this.tbBoyIn.TabIndex = 5;
            // 
            // tbGirlIn
            // 
            this.tbGirlIn.Location = new System.Drawing.Point(224, 130);
            this.tbGirlIn.Name = "tbGirlIn";
            this.tbGirlIn.Size = new System.Drawing.Size(100, 20);
            this.tbGirlIn.TabIndex = 6;
            // 
            // tbBoyOutput
            // 
            this.tbBoyOutput.Enabled = false;
            this.tbBoyOutput.Location = new System.Drawing.Point(12, 180);
            this.tbBoyOutput.Name = "tbBoyOutput";
            this.tbBoyOutput.Size = new System.Drawing.Size(312, 20);
            this.tbBoyOutput.TabIndex = 7;
            // 
            // tbGirlOutput
            // 
            this.tbGirlOutput.Enabled = false;
            this.tbGirlOutput.Location = new System.Drawing.Point(12, 218);
            this.tbGirlOutput.Name = "tbGirlOutput";
            this.tbGirlOutput.Size = new System.Drawing.Size(312, 20);
            this.tbGirlOutput.TabIndex = 8;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(130, 267);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 9;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 323);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.tbGirlOutput);
            this.Controls.Add(this.tbBoyOutput);
            this.Controls.Add(this.tbGirlIn);
            this.Controls.Add(this.tbBoyIn);
            this.Controls.Add(this.lblGirl);
            this.Controls.Add(this.lblBoy);
            this.Controls.Add(this.lblBoth);
            this.Controls.Add(this.btnGirlL);
            this.Controls.Add(this.btnBoyL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBoyL;
        private System.Windows.Forms.Button btnGirlL;
        private System.Windows.Forms.Label lblBoth;
        private System.Windows.Forms.Label lblBoy;
        private System.Windows.Forms.Label lblGirl;
        private System.Windows.Forms.TextBox tbBoyIn;
        private System.Windows.Forms.TextBox tbGirlIn;
        private System.Windows.Forms.TextBox tbBoyOutput;
        private System.Windows.Forms.TextBox tbGirlOutput;
        private System.Windows.Forms.Button btnCheck;
    }
}

