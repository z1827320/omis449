namespace NameSearchProject
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
            this.btnBoy = new System.Windows.Forms.Button();
            this.btnGirl = new System.Windows.Forms.Button();
            this.lblBoth = new System.Windows.Forms.Label();
            this.lblBoy = new System.Windows.Forms.Label();
            this.lblGirl = new System.Windows.Forms.Label();
            this.tbBoy = new System.Windows.Forms.TextBox();
            this.tbGirl = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.tbGirlOut = new System.Windows.Forms.TextBox();
            this.tbBoyOut = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBoy
            // 
            this.btnBoy.Location = new System.Drawing.Point(25, 57);
            this.btnBoy.Name = "btnBoy";
            this.btnBoy.Size = new System.Drawing.Size(99, 36);
            this.btnBoy.TabIndex = 0;
            this.btnBoy.Text = "Load Boys Name";
            this.btnBoy.UseVisualStyleBackColor = true;
            this.btnBoy.Click += new System.EventHandler(this.btnBoy_Click);
            // 
            // btnGirl
            // 
            this.btnGirl.Location = new System.Drawing.Point(25, 99);
            this.btnGirl.Name = "btnGirl";
            this.btnGirl.Size = new System.Drawing.Size(99, 36);
            this.btnGirl.TabIndex = 1;
            this.btnGirl.Text = "Load Girls Name";
            this.btnGirl.UseVisualStyleBackColor = true;
            this.btnGirl.Click += new System.EventHandler(this.btnGirl_Click);
            // 
            // lblBoth
            // 
            this.lblBoth.AutoSize = true;
            this.lblBoth.Location = new System.Drawing.Point(180, 24);
            this.lblBoth.Name = "lblBoth";
            this.lblBoth.Size = new System.Drawing.Size(219, 13);
            this.lblBoth.TabIndex = 2;
            this.lblBoth.Text = "Enter either a boys name, girls name  or both.";
            // 
            // lblBoy
            // 
            this.lblBoy.AutoSize = true;
            this.lblBoy.Location = new System.Drawing.Point(244, 67);
            this.lblBoy.Name = "lblBoy";
            this.lblBoy.Size = new System.Drawing.Size(25, 13);
            this.lblBoy.TabIndex = 3;
            this.lblBoy.Text = "Boy";
            // 
            // lblGirl
            // 
            this.lblGirl.AutoSize = true;
            this.lblGirl.Location = new System.Drawing.Point(244, 109);
            this.lblGirl.Name = "lblGirl";
            this.lblGirl.Size = new System.Drawing.Size(22, 13);
            this.lblGirl.TabIndex = 4;
            this.lblGirl.Text = "Girl";
            // 
            // tbBoy
            // 
            this.tbBoy.Location = new System.Drawing.Point(299, 67);
            this.tbBoy.Name = "tbBoy";
            this.tbBoy.Size = new System.Drawing.Size(100, 20);
            this.tbBoy.TabIndex = 5;
            // 
            // tbGirl
            // 
            this.tbGirl.Location = new System.Drawing.Point(299, 109);
            this.tbGirl.Name = "tbGirl";
            this.tbGirl.Size = new System.Drawing.Size(100, 20);
            this.tbGirl.TabIndex = 6;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(310, 147);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 7;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // tbGirlOut
            // 
            this.tbGirlOut.Enabled = false;
            this.tbGirlOut.Location = new System.Drawing.Point(25, 222);
            this.tbGirlOut.Name = "tbGirlOut";
            this.tbGirlOut.Size = new System.Drawing.Size(374, 20);
            this.tbGirlOut.TabIndex = 8;
            // 
            // tbBoyOut
            // 
            this.tbBoyOut.Enabled = false;
            this.tbBoyOut.Location = new System.Drawing.Point(25, 185);
            this.tbBoyOut.Name = "tbBoyOut";
            this.tbBoyOut.Size = new System.Drawing.Size(374, 20);
            this.tbBoyOut.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 254);
            this.Controls.Add(this.tbBoyOut);
            this.Controls.Add(this.tbGirlOut);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.tbGirl);
            this.Controls.Add(this.tbBoy);
            this.Controls.Add(this.lblGirl);
            this.Controls.Add(this.lblBoy);
            this.Controls.Add(this.lblBoth);
            this.Controls.Add(this.btnGirl);
            this.Controls.Add(this.btnBoy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBoy;
        private System.Windows.Forms.Button btnGirl;
        private System.Windows.Forms.Label lblBoth;
        private System.Windows.Forms.Label lblBoy;
        private System.Windows.Forms.Label lblGirl;
        private System.Windows.Forms.TextBox tbBoy;
        private System.Windows.Forms.TextBox tbGirl;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox tbGirlOut;
        private System.Windows.Forms.TextBox tbBoyOut;
    }
}

