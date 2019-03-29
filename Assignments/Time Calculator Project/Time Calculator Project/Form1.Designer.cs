namespace Time_Calculator_Project
{
    partial class timeCalc
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
            this.secInputText = new System.Windows.Forms.TextBox();
            this.secInputLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.minOutputText = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // secInputText
            // 
            this.secInputText.Location = new System.Drawing.Point(214, 45);
            this.secInputText.Name = "secInputText";
            this.secInputText.Size = new System.Drawing.Size(100, 20);
            this.secInputText.TabIndex = 0;
            // 
            // secInputLabel
            // 
            this.secInputLabel.AutoSize = true;
            this.secInputLabel.Location = new System.Drawing.Point(38, 48);
            this.secInputLabel.Name = "secInputLabel";
            this.secInputLabel.Size = new System.Drawing.Size(170, 13);
            this.secInputLabel.TabIndex = 1;
            this.secInputLabel.Text = "Enter the amount of seconds here:";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(110, 83);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(98, 13);
            this.minLabel.TabIndex = 2;
            this.minLabel.Text = "Number of minutes;";
            // 
            // minOutputText
            // 
            this.minOutputText.Enabled = false;
            this.minOutputText.Location = new System.Drawing.Point(214, 80);
            this.minOutputText.Name = "minOutputText";
            this.minOutputText.Size = new System.Drawing.Size(100, 20);
            this.minOutputText.TabIndex = 3;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(41, 163);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(99, 43);
            this.calcButton.TabIndex = 4;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(214, 163);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(99, 43);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // timeCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 244);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.minOutputText);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.secInputLabel);
            this.Controls.Add(this.secInputText);
            this.Name = "timeCalc";
            this.Text = "Time Calculator";
            this.Load += new System.EventHandler(this.timeCalc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox secInputText;
        private System.Windows.Forms.Label secInputLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.TextBox minOutputText;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button exitButton;
    }
}

