namespace Workshop_Selector_Project
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
            this.lstWS = new System.Windows.Forms.ListBox();
            this.lstLoc = new System.Windows.Forms.ListBox();
            this.calcCost = new System.Windows.Forms.Button();
            this.regLabel = new System.Windows.Forms.Label();
            this.lodgingLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.regText = new System.Windows.Forms.TextBox();
            this.lodText = new System.Windows.Forms.TextBox();
            this.totText = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.wsLabel = new System.Windows.Forms.Label();
            this.locLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstWS
            // 
            this.lstWS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstWS.FormattingEnabled = true;
            this.lstWS.ItemHeight = 20;
            this.lstWS.Items.AddRange(new object[] {
            "Handling Stress",
            "Time Management",
            "Supervision Skills",
            "Negotiation",
            "How to Interview"});
            this.lstWS.Location = new System.Drawing.Point(12, 36);
            this.lstWS.Name = "lstWS";
            this.lstWS.Size = new System.Drawing.Size(204, 144);
            this.lstWS.TabIndex = 0;
            // 
            // lstLoc
            // 
            this.lstLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLoc.FormattingEnabled = true;
            this.lstLoc.ItemHeight = 20;
            this.lstLoc.Items.AddRange(new object[] {
            "Austin",
            "Chicago",
            "Dallas",
            "Orlando",
            "Phoenix",
            "Raleigh"});
            this.lstLoc.Location = new System.Drawing.Point(235, 36);
            this.lstLoc.Name = "lstLoc";
            this.lstLoc.Size = new System.Drawing.Size(204, 144);
            this.lstLoc.TabIndex = 1;
            // 
            // calcCost
            // 
            this.calcCost.Location = new System.Drawing.Point(63, 224);
            this.calcCost.Name = "calcCost";
            this.calcCost.Size = new System.Drawing.Size(103, 53);
            this.calcCost.TabIndex = 3;
            this.calcCost.Text = "Calculate Cost";
            this.calcCost.UseVisualStyleBackColor = true;
            this.calcCost.Click += new System.EventHandler(this.calcCost_Click);
            // 
            // regLabel
            // 
            this.regLabel.AutoSize = true;
            this.regLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regLabel.Location = new System.Drawing.Point(455, 36);
            this.regLabel.Name = "regLabel";
            this.regLabel.Size = new System.Drawing.Size(99, 20);
            this.regLabel.TabIndex = 4;
            this.regLabel.Text = "Registration:";
            // 
            // lodgingLabel
            // 
            this.lodgingLabel.AutoSize = true;
            this.lodgingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lodgingLabel.Location = new System.Drawing.Point(484, 69);
            this.lodgingLabel.Name = "lodgingLabel";
            this.lodgingLabel.Size = new System.Drawing.Size(70, 20);
            this.lodgingLabel.TabIndex = 5;
            this.lodgingLabel.Text = "Lodging:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(506, 109);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(48, 20);
            this.totalLabel.TabIndex = 6;
            this.totalLabel.Text = "Total:";
            // 
            // regText
            // 
            this.regText.Enabled = false;
            this.regText.Location = new System.Drawing.Point(560, 36);
            this.regText.Name = "regText";
            this.regText.Size = new System.Drawing.Size(100, 20);
            this.regText.TabIndex = 7;
            // 
            // lodText
            // 
            this.lodText.Enabled = false;
            this.lodText.Location = new System.Drawing.Point(560, 69);
            this.lodText.Name = "lodText";
            this.lodText.Size = new System.Drawing.Size(100, 20);
            this.lodText.TabIndex = 8;
            // 
            // totText
            // 
            this.totText.Enabled = false;
            this.totText.Location = new System.Drawing.Point(560, 109);
            this.totText.Name = "totText";
            this.totText.Size = new System.Drawing.Size(100, 20);
            this.totText.TabIndex = 9;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(289, 224);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(103, 53);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(510, 224);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(103, 53);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // wsLabel
            // 
            this.wsLabel.AutoSize = true;
            this.wsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wsLabel.Location = new System.Drawing.Point(68, 13);
            this.wsLabel.Name = "wsLabel";
            this.wsLabel.Size = new System.Drawing.Size(89, 20);
            this.wsLabel.TabIndex = 12;
            this.wsLabel.Text = "Workshops";
            // 
            // locLabel
            // 
            this.locLabel.AutoSize = true;
            this.locLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locLabel.Location = new System.Drawing.Point(300, 13);
            this.locLabel.Name = "locLabel";
            this.locLabel.Size = new System.Drawing.Size(78, 20);
            this.locLabel.TabIndex = 13;
            this.locLabel.Text = "Locations";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 298);
            this.Controls.Add(this.locLabel);
            this.Controls.Add(this.wsLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.totText);
            this.Controls.Add(this.lodText);
            this.Controls.Add(this.regText);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.lodgingLabel);
            this.Controls.Add(this.regLabel);
            this.Controls.Add(this.calcCost);
            this.Controls.Add(this.lstLoc);
            this.Controls.Add(this.lstWS);
            this.Name = "Form1";
            this.Text = "Workshop Selector";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstWS;
        private System.Windows.Forms.ListBox lstLoc;
        private System.Windows.Forms.Button calcCost;
        private System.Windows.Forms.Label regLabel;
        private System.Windows.Forms.Label lodgingLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox regText;
        private System.Windows.Forms.TextBox lodText;
        private System.Windows.Forms.TextBox totText;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label wsLabel;
        private System.Windows.Forms.Label locLabel;
    }
}

