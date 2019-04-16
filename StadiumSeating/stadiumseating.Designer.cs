namespace stadiumseating
{
    partial class StadiumSeating
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
            this.BtnCalc = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.GbSold = new System.Windows.Forms.GroupBox();
            this.lblCC = new System.Windows.Forms.Label();
            this.lblCB = new System.Windows.Forms.Label();
            this.lblCA = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbC3 = new System.Windows.Forms.TextBox();
            this.tbC2 = new System.Windows.Forms.TextBox();
            this.tbC1 = new System.Windows.Forms.TextBox();
            this.gboxRev = new System.Windows.Forms.GroupBox();
            this.lblClassA = new System.Windows.Forms.Label();
            this.lblClassB = new System.Windows.Forms.Label();
            this.lblClassC = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GbSold.SuspendLayout();
            this.gboxRev.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCalc
            // 
            this.BtnCalc.Location = new System.Drawing.Point(34, 251);
            this.BtnCalc.Name = "BtnCalc";
            this.BtnCalc.Size = new System.Drawing.Size(105, 45);
            this.BtnCalc.TabIndex = 0;
            this.BtnCalc.Text = "Calculate Revenue";
            this.BtnCalc.UseVisualStyleBackColor = true;
            this.BtnCalc.Click += new System.EventHandler(this.BtnCalc_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Location = new System.Drawing.Point(208, 251);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(106, 45);
            this.BtnClear.TabIndex = 1;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click_1);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(370, 251);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(106, 45);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click_1);
            // 
            // GbSold
            // 
            this.GbSold.Controls.Add(this.lblCC);
            this.GbSold.Controls.Add(this.lblCB);
            this.GbSold.Controls.Add(this.lblCA);
            this.GbSold.Controls.Add(this.label1);
            this.GbSold.Controls.Add(this.tbC3);
            this.GbSold.Controls.Add(this.tbC2);
            this.GbSold.Controls.Add(this.tbC1);
            this.GbSold.Location = new System.Drawing.Point(12, 51);
            this.GbSold.Name = "GbSold";
            this.GbSold.Size = new System.Drawing.Size(241, 182);
            this.GbSold.TabIndex = 3;
            this.GbSold.TabStop = false;
            this.GbSold.Text = "Tickets Sold";
            // 
            // lblCC
            // 
            this.lblCC.AutoSize = true;
            this.lblCC.Location = new System.Drawing.Point(55, 136);
            this.lblCC.Name = "lblCC";
            this.lblCC.Size = new System.Drawing.Size(45, 13);
            this.lblCC.TabIndex = 6;
            this.lblCC.Text = "Class C:";
            // 
            // lblCB
            // 
            this.lblCB.AutoSize = true;
            this.lblCB.Location = new System.Drawing.Point(55, 110);
            this.lblCB.Name = "lblCB";
            this.lblCB.Size = new System.Drawing.Size(45, 13);
            this.lblCB.TabIndex = 5;
            this.lblCB.Text = "Class B:";
            // 
            // lblCA
            // 
            this.lblCA.AutoSize = true;
            this.lblCA.Location = new System.Drawing.Point(55, 81);
            this.lblCA.Name = "lblCA";
            this.lblCA.Size = new System.Drawing.Size(45, 13);
            this.lblCA.TabIndex = 4;
            this.lblCA.Text = "Class A:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter the number of tickets sold for each class of seats.";
            // 
            // tbC3
            // 
            this.tbC3.Location = new System.Drawing.Point(113, 133);
            this.tbC3.Name = "tbC3";
            this.tbC3.Size = new System.Drawing.Size(100, 20);
            this.tbC3.TabIndex = 2;
            // 
            // tbC2
            // 
            this.tbC2.Location = new System.Drawing.Point(113, 107);
            this.tbC2.Name = "tbC2";
            this.tbC2.Size = new System.Drawing.Size(100, 20);
            this.tbC2.TabIndex = 1;
            // 
            // tbC1
            // 
            this.tbC1.Location = new System.Drawing.Point(113, 81);
            this.tbC1.Name = "tbC1";
            this.tbC1.Size = new System.Drawing.Size(100, 20);
            this.tbC1.TabIndex = 0;
            // 
            // gboxRev
            // 
            this.gboxRev.Controls.Add(this.lblClassA);
            this.gboxRev.Controls.Add(this.lblClassB);
            this.gboxRev.Controls.Add(this.lblClassC);
            this.gboxRev.Controls.Add(this.lblTotal);
            this.gboxRev.Controls.Add(this.label5);
            this.gboxRev.Controls.Add(this.label4);
            this.gboxRev.Controls.Add(this.label3);
            this.gboxRev.Controls.Add(this.label2);
            this.gboxRev.Location = new System.Drawing.Point(259, 51);
            this.gboxRev.Name = "gboxRev";
            this.gboxRev.Size = new System.Drawing.Size(235, 182);
            this.gboxRev.TabIndex = 4;
            this.gboxRev.TabStop = false;
            this.gboxRev.Text = "Revenue Generated";
            // 
            // lblClassA
            // 
            this.lblClassA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClassA.Location = new System.Drawing.Point(117, 23);
            this.lblClassA.Name = "lblClassA";
            this.lblClassA.Size = new System.Drawing.Size(100, 23);
            this.lblClassA.TabIndex = 7;
            this.lblClassA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClassB
            // 
            this.lblClassB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClassB.Location = new System.Drawing.Point(117, 56);
            this.lblClassB.Name = "lblClassB";
            this.lblClassB.Size = new System.Drawing.Size(100, 23);
            this.lblClassB.TabIndex = 6;
            this.lblClassB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClassC
            // 
            this.lblClassC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClassC.Location = new System.Drawing.Point(117, 88);
            this.lblClassC.Name = "lblClassC";
            this.lblClassC.Size = new System.Drawing.Size(100, 23);
            this.lblClassC.TabIndex = 5;
            this.lblClassC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(117, 131);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 23);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Class C:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Class B:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Class A:";
            // 
            // StadiumSeating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 339);
            this.Controls.Add(this.gboxRev);
            this.Controls.Add(this.GbSold);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnCalc);
            this.Name = "StadiumSeating";
            this.Text = "Stadium Seating";
            this.GbSold.ResumeLayout(false);
            this.GbSold.PerformLayout();
            this.gboxRev.ResumeLayout(false);
            this.gboxRev.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCalc;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.GroupBox GbSold;
        private System.Windows.Forms.GroupBox gboxRev;
        private System.Windows.Forms.TextBox tbC3;
        private System.Windows.Forms.TextBox tbC2;
        private System.Windows.Forms.TextBox tbC1;
        private System.Windows.Forms.Label lblCC;
        private System.Windows.Forms.Label lblCB;
        private System.Windows.Forms.Label lblCA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClassA;
        private System.Windows.Forms.Label lblClassB;
        private System.Windows.Forms.Label lblClassC;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

