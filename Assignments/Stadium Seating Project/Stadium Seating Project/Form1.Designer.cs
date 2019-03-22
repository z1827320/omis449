namespace Stadium_Seating_Project
{
    partial class stadiumSeating
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tsCALabel = new System.Windows.Forms.Label();
            this.tsCBLabel = new System.Windows.Forms.Label();
            this.tsCCLabel = new System.Windows.Forms.Label();
            this.classAInput = new System.Windows.Forms.TextBox();
            this.classBInput = new System.Windows.Forms.TextBox();
            this.classCInput = new System.Windows.Forms.TextBox();
            this.ticketsSoldLabel = new System.Windows.Forms.Label();
            this.ticketsSoldDesc = new System.Windows.Forms.Label();
            this.revenueGenLabal = new System.Windows.Forms.Label();
            this.rgCALabel = new System.Windows.Forms.Label();
            this.rgCBLabel = new System.Windows.Forms.Label();
            this.rgCCLabel = new System.Windows.Forms.Label();
            this.rgCAOutput = new System.Windows.Forms.TextBox();
            this.rgCBOutput = new System.Windows.Forms.TextBox();
            this.rgCCOutput = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.TextBox();
            this.calcRevButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ticketsSoldDesc);
            this.groupBox1.Controls.Add(this.ticketsSoldLabel);
            this.groupBox1.Controls.Add(this.classCInput);
            this.groupBox1.Controls.Add(this.classBInput);
            this.groupBox1.Controls.Add(this.classAInput);
            this.groupBox1.Controls.Add(this.tsCCLabel);
            this.groupBox1.Controls.Add(this.tsCBLabel);
            this.groupBox1.Controls.Add(this.tsCALabel);
            this.groupBox1.Location = new System.Drawing.Point(26, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.totalOutput);
            this.groupBox2.Controls.Add(this.totalLabel);
            this.groupBox2.Controls.Add(this.rgCCOutput);
            this.groupBox2.Controls.Add(this.rgCBOutput);
            this.groupBox2.Controls.Add(this.rgCAOutput);
            this.groupBox2.Controls.Add(this.rgCCLabel);
            this.groupBox2.Controls.Add(this.rgCBLabel);
            this.groupBox2.Controls.Add(this.rgCALabel);
            this.groupBox2.Controls.Add(this.revenueGenLabal);
            this.groupBox2.Location = new System.Drawing.Point(310, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 208);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // tsCALabel
            // 
            this.tsCALabel.AutoSize = true;
            this.tsCALabel.Location = new System.Drawing.Point(29, 69);
            this.tsCALabel.Name = "tsCALabel";
            this.tsCALabel.Size = new System.Drawing.Size(42, 13);
            this.tsCALabel.TabIndex = 0;
            this.tsCALabel.Text = "Class A";
            // 
            // tsCBLabel
            // 
            this.tsCBLabel.AutoSize = true;
            this.tsCBLabel.Location = new System.Drawing.Point(29, 96);
            this.tsCBLabel.Name = "tsCBLabel";
            this.tsCBLabel.Size = new System.Drawing.Size(42, 13);
            this.tsCBLabel.TabIndex = 1;
            this.tsCBLabel.Text = "Class B";
            // 
            // tsCCLabel
            // 
            this.tsCCLabel.AutoSize = true;
            this.tsCCLabel.Location = new System.Drawing.Point(29, 125);
            this.tsCCLabel.Name = "tsCCLabel";
            this.tsCCLabel.Size = new System.Drawing.Size(42, 13);
            this.tsCCLabel.TabIndex = 2;
            this.tsCCLabel.Text = "Class C";
            // 
            // classAInput
            // 
            this.classAInput.Location = new System.Drawing.Point(77, 67);
            this.classAInput.Name = "classAInput";
            this.classAInput.Size = new System.Drawing.Size(100, 20);
            this.classAInput.TabIndex = 3;
            // 
            // classBInput
            // 
            this.classBInput.Location = new System.Drawing.Point(77, 93);
            this.classBInput.Name = "classBInput";
            this.classBInput.Size = new System.Drawing.Size(100, 20);
            this.classBInput.TabIndex = 4;
            // 
            // classCInput
            // 
            this.classCInput.Location = new System.Drawing.Point(77, 122);
            this.classCInput.Name = "classCInput";
            this.classCInput.Size = new System.Drawing.Size(100, 20);
            this.classCInput.TabIndex = 5;
            // 
            // ticketsSoldLabel
            // 
            this.ticketsSoldLabel.AutoSize = true;
            this.ticketsSoldLabel.Location = new System.Drawing.Point(29, 0);
            this.ticketsSoldLabel.Name = "ticketsSoldLabel";
            this.ticketsSoldLabel.Size = new System.Drawing.Size(66, 13);
            this.ticketsSoldLabel.TabIndex = 6;
            this.ticketsSoldLabel.Text = "Tickets Sold";
            // 
            // ticketsSoldDesc
            // 
            this.ticketsSoldDesc.AutoSize = true;
            this.ticketsSoldDesc.Location = new System.Drawing.Point(32, 20);
            this.ticketsSoldDesc.Name = "ticketsSoldDesc";
            this.ticketsSoldDesc.Size = new System.Drawing.Size(171, 26);
            this.ticketsSoldDesc.TabIndex = 7;
            this.ticketsSoldDesc.Text = "Enter the number of tickets sold for\r\neach class of seats.";
            // 
            // revenueGenLabal
            // 
            this.revenueGenLabal.AutoSize = true;
            this.revenueGenLabal.Location = new System.Drawing.Point(25, 0);
            this.revenueGenLabal.Name = "revenueGenLabal";
            this.revenueGenLabal.Size = new System.Drawing.Size(104, 13);
            this.revenueGenLabal.TabIndex = 0;
            this.revenueGenLabal.Text = "Revenue Generated";
            // 
            // rgCALabel
            // 
            this.rgCALabel.AutoSize = true;
            this.rgCALabel.Location = new System.Drawing.Point(31, 67);
            this.rgCALabel.Name = "rgCALabel";
            this.rgCALabel.Size = new System.Drawing.Size(42, 13);
            this.rgCALabel.TabIndex = 1;
            this.rgCALabel.Text = "Class A";
            // 
            // rgCBLabel
            // 
            this.rgCBLabel.AutoSize = true;
            this.rgCBLabel.Location = new System.Drawing.Point(31, 95);
            this.rgCBLabel.Name = "rgCBLabel";
            this.rgCBLabel.Size = new System.Drawing.Size(42, 13);
            this.rgCBLabel.TabIndex = 2;
            this.rgCBLabel.Text = "Class B";
            // 
            // rgCCLabel
            // 
            this.rgCCLabel.AutoSize = true;
            this.rgCCLabel.Location = new System.Drawing.Point(31, 122);
            this.rgCCLabel.Name = "rgCCLabel";
            this.rgCCLabel.Size = new System.Drawing.Size(42, 13);
            this.rgCCLabel.TabIndex = 3;
            this.rgCCLabel.Text = "Class C";
            // 
            // rgCAOutput
            // 
            this.rgCAOutput.Enabled = false;
            this.rgCAOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgCAOutput.Location = new System.Drawing.Point(79, 64);
            this.rgCAOutput.Name = "rgCAOutput";
            this.rgCAOutput.Size = new System.Drawing.Size(100, 20);
            this.rgCAOutput.TabIndex = 4;
            // 
            // rgCBOutput
            // 
            this.rgCBOutput.Enabled = false;
            this.rgCBOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgCBOutput.Location = new System.Drawing.Point(79, 90);
            this.rgCBOutput.Name = "rgCBOutput";
            this.rgCBOutput.Size = new System.Drawing.Size(100, 20);
            this.rgCBOutput.TabIndex = 5;
            // 
            // rgCCOutput
            // 
            this.rgCCOutput.Enabled = false;
            this.rgCCOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgCCOutput.Location = new System.Drawing.Point(80, 117);
            this.rgCCOutput.Name = "rgCCOutput";
            this.rgCCOutput.Size = new System.Drawing.Size(100, 20);
            this.rgCCOutput.TabIndex = 6;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(415, 249);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 40);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(34, 149);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(34, 13);
            this.totalLabel.TabIndex = 7;
            this.totalLabel.Text = "Total:";
            // 
            // totalOutput
            // 
            this.totalOutput.Enabled = false;
            this.totalOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutput.Location = new System.Drawing.Point(80, 146);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(100, 20);
            this.totalOutput.TabIndex = 8;
            // 
            // calcRevButton
            // 
            this.calcRevButton.Location = new System.Drawing.Point(121, 249);
            this.calcRevButton.Name = "calcRevButton";
            this.calcRevButton.Size = new System.Drawing.Size(75, 40);
            this.calcRevButton.TabIndex = 3;
            this.calcRevButton.Text = "Calculate Revenue";
            this.calcRevButton.UseVisualStyleBackColor = true;
            this.calcRevButton.Click += new System.EventHandler(this.calcRevButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(268, 249);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 40);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // stadiumSeating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 322);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calcRevButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "stadiumSeating";
            this.Text = "Stadium Seating";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox classCInput;
        private System.Windows.Forms.TextBox classBInput;
        private System.Windows.Forms.TextBox classAInput;
        private System.Windows.Forms.Label tsCCLabel;
        private System.Windows.Forms.Label tsCBLabel;
        private System.Windows.Forms.Label tsCALabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label ticketsSoldDesc;
        private System.Windows.Forms.Label ticketsSoldLabel;
        private System.Windows.Forms.Label rgCCLabel;
        private System.Windows.Forms.Label rgCBLabel;
        private System.Windows.Forms.Label rgCALabel;
        private System.Windows.Forms.Label revenueGenLabal;
        private System.Windows.Forms.TextBox rgCCOutput;
        private System.Windows.Forms.TextBox rgCBOutput;
        private System.Windows.Forms.TextBox rgCAOutput;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox totalOutput;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button calcRevButton;
        private System.Windows.Forms.Button clearButton;
    }
}

