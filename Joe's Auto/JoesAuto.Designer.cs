namespace WindowsFormsApp1
{
    partial class joesautomotive
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
            this.cbLube = new System.Windows.Forms.CheckBox();
            this.cbOil = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbTflush = new System.Windows.Forms.CheckBox();
            this.cbRflush = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbTire = new System.Windows.Forms.CheckBox();
            this.cbMuffler = new System.Windows.Forms.CheckBox();
            this.cbInspec = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbLabor1 = new System.Windows.Forms.TextBox();
            this.tbPart1 = new System.Windows.Forms.TextBox();
            this.lblLabor1 = new System.Windows.Forms.Label();
            this.lblPart1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblParts2 = new System.Windows.Forms.Label();
            this.lblSandL = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tbSandL = new System.Windows.Forms.TextBox();
            this.tbParts2 = new System.Windows.Forms.TextBox();
            this.tbTax = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbLube);
            this.groupBox1.Controls.Add(this.cbOil);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oil and Lube";
            // 
            // cbLube
            // 
            this.cbLube.AutoSize = true;
            this.cbLube.Location = new System.Drawing.Point(7, 44);
            this.cbLube.Name = "cbLube";
            this.cbLube.Size = new System.Drawing.Size(112, 17);
            this.cbLube.TabIndex = 1;
            this.cbLube.Text = "Lube Job ($18.00)";
            this.cbLube.UseVisualStyleBackColor = true;
            // 
            // cbOil
            // 
            this.cbOil.AutoSize = true;
            this.cbOil.Location = new System.Drawing.Point(7, 20);
            this.cbOil.Name = "cbOil";
            this.cbOil.Size = new System.Drawing.Size(120, 17);
            this.cbOil.TabIndex = 0;
            this.cbOil.Text = "Oil Change ($15.00)";
            this.cbOil.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbTflush);
            this.groupBox2.Controls.Add(this.cbRflush);
            this.groupBox2.Location = new System.Drawing.Point(174, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(166, 69);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flushes";
            // 
            // cbTflush
            // 
            this.cbTflush.AutoSize = true;
            this.cbTflush.Location = new System.Drawing.Point(7, 44);
            this.cbTflush.Name = "cbTflush";
            this.cbTflush.Size = new System.Drawing.Size(157, 17);
            this.cbTflush.TabIndex = 1;
            this.cbTflush.Text = "Transmission Flush ($80.00)";
            this.cbTflush.UseVisualStyleBackColor = true;
            // 
            // cbRflush
            // 
            this.cbRflush.AutoSize = true;
            this.cbRflush.Location = new System.Drawing.Point(7, 20);
            this.cbRflush.Name = "cbRflush";
            this.cbRflush.Size = new System.Drawing.Size(136, 17);
            this.cbRflush.TabIndex = 0;
            this.cbRflush.Text = "Radiator Flush ($30.00)";
            this.cbRflush.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbTire);
            this.groupBox3.Controls.Add(this.cbMuffler);
            this.groupBox3.Controls.Add(this.cbInspec);
            this.groupBox3.Location = new System.Drawing.Point(13, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(156, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Misc";
            // 
            // cbTire
            // 
            this.cbTire.AutoSize = true;
            this.cbTire.Location = new System.Drawing.Point(6, 67);
            this.cbTire.Name = "cbTire";
            this.cbTire.Size = new System.Drawing.Size(129, 17);
            this.cbTire.TabIndex = 2;
            this.cbTire.Text = "Tire Rotation ($20.00)";
            this.cbTire.UseVisualStyleBackColor = true;
            // 
            // cbMuffler
            // 
            this.cbMuffler.AutoSize = true;
            this.cbMuffler.Location = new System.Drawing.Point(6, 43);
            this.cbMuffler.Name = "cbMuffler";
            this.cbMuffler.Size = new System.Drawing.Size(149, 17);
            this.cbMuffler.TabIndex = 1;
            this.cbMuffler.Text = "Replace Muffler ($100.00)";
            this.cbMuffler.UseVisualStyleBackColor = true;
            // 
            // cbInspec
            // 
            this.cbInspec.AutoSize = true;
            this.cbInspec.Location = new System.Drawing.Point(7, 20);
            this.cbInspec.Name = "cbInspec";
            this.cbInspec.Size = new System.Drawing.Size(117, 17);
            this.cbInspec.TabIndex = 0;
            this.cbInspec.Text = "Inspection ($15.00)";
            this.cbInspec.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbLabor1);
            this.groupBox4.Controls.Add(this.tbPart1);
            this.groupBox4.Controls.Add(this.lblLabor1);
            this.groupBox4.Controls.Add(this.lblPart1);
            this.groupBox4.Location = new System.Drawing.Point(176, 89);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(164, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parts and Labor";
            // 
            // tbLabor1
            // 
            this.tbLabor1.Location = new System.Drawing.Point(71, 47);
            this.tbLabor1.Name = "tbLabor1";
            this.tbLabor1.Size = new System.Drawing.Size(70, 20);
            this.tbLabor1.TabIndex = 3;
            // 
            // tbPart1
            // 
            this.tbPart1.Location = new System.Drawing.Point(71, 20);
            this.tbPart1.Name = "tbPart1";
            this.tbPart1.Size = new System.Drawing.Size(70, 20);
            this.tbPart1.TabIndex = 2;
            // 
            // lblLabor1
            // 
            this.lblLabor1.AutoSize = true;
            this.lblLabor1.Location = new System.Drawing.Point(13, 50);
            this.lblLabor1.Name = "lblLabor1";
            this.lblLabor1.Size = new System.Drawing.Size(52, 13);
            this.lblLabor1.TabIndex = 1;
            this.lblLabor1.Text = "Labor ($):";
            // 
            // lblPart1
            // 
            this.lblPart1.AutoSize = true;
            this.lblPart1.Location = new System.Drawing.Point(31, 21);
            this.lblPart1.Name = "lblPart1";
            this.lblPart1.Size = new System.Drawing.Size(34, 13);
            this.lblPart1.TabIndex = 0;
            this.lblPart1.Text = "Parts:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbTotal);
            this.groupBox5.Controls.Add(this.tbTax);
            this.groupBox5.Controls.Add(this.tbParts2);
            this.groupBox5.Controls.Add(this.tbSandL);
            this.groupBox5.Controls.Add(this.lblTotal);
            this.groupBox5.Controls.Add(this.lblTax);
            this.groupBox5.Controls.Add(this.lblParts2);
            this.groupBox5.Controls.Add(this.lblSandL);
            this.groupBox5.Location = new System.Drawing.Point(13, 196);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(325, 156);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Summary";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(7, 91);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(75, 13);
            this.lblTax.TabIndex = 2;
            this.lblTax.Text = "Tax (on parts):";
            // 
            // lblParts2
            // 
            this.lblParts2.AutoSize = true;
            this.lblParts2.Location = new System.Drawing.Point(7, 53);
            this.lblParts2.Name = "lblParts2";
            this.lblParts2.Size = new System.Drawing.Size(34, 13);
            this.lblParts2.TabIndex = 1;
            this.lblParts2.Text = "Parts:";
            // 
            // lblSandL
            // 
            this.lblSandL.AutoSize = true;
            this.lblSandL.Location = new System.Drawing.Point(7, 20);
            this.lblSandL.Name = "lblSandL";
            this.lblSandL.Size = new System.Drawing.Size(97, 13);
            this.lblSandL.TabIndex = 0;
            this.lblSandL.Text = "Service and Labor:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(7, 129);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(60, 13);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total Fees:";
            // 
            // tbSandL
            // 
            this.tbSandL.Location = new System.Drawing.Point(110, 17);
            this.tbSandL.Name = "tbSandL";
            this.tbSandL.Size = new System.Drawing.Size(100, 20);
            this.tbSandL.TabIndex = 4;
            // 
            // tbParts2
            // 
            this.tbParts2.Location = new System.Drawing.Point(111, 50);
            this.tbParts2.Name = "tbParts2";
            this.tbParts2.Size = new System.Drawing.Size(100, 20);
            this.tbParts2.TabIndex = 5;
            // 
            // tbTax
            // 
            this.tbTax.Location = new System.Drawing.Point(111, 88);
            this.tbTax.Name = "tbTax";
            this.tbTax.Size = new System.Drawing.Size(100, 20);
            this.tbTax.TabIndex = 6;
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(111, 126);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(100, 20);
            this.tbTotal.TabIndex = 7;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(13, 373);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(137, 373);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(263, 373);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // joesautomotive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 408);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "joesautomotive";
            this.Text = "Joe\'s Automotive";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbLube;
        private System.Windows.Forms.CheckBox cbOil;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbTflush;
        private System.Windows.Forms.CheckBox cbRflush;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbTire;
        private System.Windows.Forms.CheckBox cbMuffler;
        private System.Windows.Forms.CheckBox cbInspec;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbLabor1;
        private System.Windows.Forms.TextBox tbPart1;
        private System.Windows.Forms.Label lblLabor1;
        private System.Windows.Forms.Label lblPart1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblParts2;
        private System.Windows.Forms.Label lblSandL;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox tbTax;
        private System.Windows.Forms.TextBox tbParts2;
        private System.Windows.Forms.TextBox tbSandL;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

