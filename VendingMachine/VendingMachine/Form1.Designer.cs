namespace VendingMachine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbCola = new System.Windows.Forms.PictureBox();
            this.pbRoot = new System.Windows.Forms.PictureBox();
            this.pbLime = new System.Windows.Forms.PictureBox();
            this.pbGrape = new System.Windows.Forms.PictureBox();
            this.pbCream = new System.Windows.Forms.PictureBox();
            this.lblColaPrice = new System.Windows.Forms.Label();
            this.lblRPrice = new System.Windows.Forms.Label();
            this.lblLPrice = new System.Windows.Forms.Label();
            this.lblGPrice = new System.Windows.Forms.Label();
            this.lblCPrice = new System.Windows.Forms.Label();
            this.lblCola = new System.Windows.Forms.Label();
            this.lblRB = new System.Windows.Forms.Label();
            this.lblLL = new System.Windows.Forms.Label();
            this.lblG = new System.Windows.Forms.Label();
            this.lblCS = new System.Windows.Forms.Label();
            this.lblT = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCream)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCola
            // 
            this.pbCola.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCola.BackgroundImage")));
            this.pbCola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbCola.Location = new System.Drawing.Point(13, 13);
            this.pbCola.Name = "pbCola";
            this.pbCola.Size = new System.Drawing.Size(100, 96);
            this.pbCola.TabIndex = 0;
            this.pbCola.TabStop = false;
            this.pbCola.Click += new System.EventHandler(this.pbCola_Click);
            // 
            // pbRoot
            // 
            this.pbRoot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbRoot.BackgroundImage")));
            this.pbRoot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbRoot.Location = new System.Drawing.Point(132, 13);
            this.pbRoot.Name = "pbRoot";
            this.pbRoot.Size = new System.Drawing.Size(100, 96);
            this.pbRoot.TabIndex = 1;
            this.pbRoot.TabStop = false;
            this.pbRoot.Click += new System.EventHandler(this.pbRoot_Click);
            // 
            // pbLime
            // 
            this.pbLime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLime.BackgroundImage")));
            this.pbLime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbLime.Location = new System.Drawing.Point(12, 173);
            this.pbLime.Name = "pbLime";
            this.pbLime.Size = new System.Drawing.Size(100, 96);
            this.pbLime.TabIndex = 2;
            this.pbLime.TabStop = false;
            this.pbLime.Click += new System.EventHandler(this.pbLime_Click);
            // 
            // pbGrape
            // 
            this.pbGrape.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbGrape.BackgroundImage")));
            this.pbGrape.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbGrape.Location = new System.Drawing.Point(132, 173);
            this.pbGrape.Name = "pbGrape";
            this.pbGrape.Size = new System.Drawing.Size(100, 96);
            this.pbGrape.TabIndex = 3;
            this.pbGrape.TabStop = false;
            this.pbGrape.Click += new System.EventHandler(this.pbGrape_Click);
            // 
            // pbCream
            // 
            this.pbCream.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCream.BackgroundImage")));
            this.pbCream.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbCream.Location = new System.Drawing.Point(75, 329);
            this.pbCream.Name = "pbCream";
            this.pbCream.Size = new System.Drawing.Size(100, 96);
            this.pbCream.TabIndex = 4;
            this.pbCream.TabStop = false;
            this.pbCream.Click += new System.EventHandler(this.pbCream_Click);
            // 
            // lblColaPrice
            // 
            this.lblColaPrice.AutoSize = true;
            this.lblColaPrice.Location = new System.Drawing.Point(51, 116);
            this.lblColaPrice.Name = "lblColaPrice";
            this.lblColaPrice.Size = new System.Drawing.Size(55, 13);
            this.lblColaPrice.TabIndex = 5;
            this.lblColaPrice.Text = "Cola Price";
            // 
            // lblRPrice
            // 
            this.lblRPrice.AutoSize = true;
            this.lblRPrice.Location = new System.Drawing.Point(162, 116);
            this.lblRPrice.Name = "lblRPrice";
            this.lblRPrice.Size = new System.Drawing.Size(49, 13);
            this.lblRPrice.TabIndex = 6;
            this.lblRPrice.Text = "RB Price";
            // 
            // lblLPrice
            // 
            this.lblLPrice.AutoSize = true;
            this.lblLPrice.Location = new System.Drawing.Point(51, 272);
            this.lblLPrice.Name = "lblLPrice";
            this.lblLPrice.Size = new System.Drawing.Size(46, 13);
            this.lblLPrice.TabIndex = 7;
            this.lblLPrice.Text = "LL Price";
            // 
            // lblGPrice
            // 
            this.lblGPrice.AutoSize = true;
            this.lblGPrice.Location = new System.Drawing.Point(162, 272);
            this.lblGPrice.Name = "lblGPrice";
            this.lblGPrice.Size = new System.Drawing.Size(63, 13);
            this.lblGPrice.TabIndex = 8;
            this.lblGPrice.Text = "Grape Price";
            // 
            // lblCPrice
            // 
            this.lblCPrice.AutoSize = true;
            this.lblCPrice.Location = new System.Drawing.Point(104, 428);
            this.lblCPrice.Name = "lblCPrice";
            this.lblCPrice.Size = new System.Drawing.Size(48, 13);
            this.lblCPrice.TabIndex = 9;
            this.lblCPrice.Text = "CS Price";
            // 
            // lblCola
            // 
            this.lblCola.AutoSize = true;
            this.lblCola.Location = new System.Drawing.Point(51, 142);
            this.lblCola.Name = "lblCola";
            this.lblCola.Size = new System.Drawing.Size(28, 13);
            this.lblCola.TabIndex = 10;
            this.lblCola.Text = "Cola";
            // 
            // lblRB
            // 
            this.lblRB.AutoSize = true;
            this.lblRB.Location = new System.Drawing.Point(162, 142);
            this.lblRB.Name = "lblRB";
            this.lblRB.Size = new System.Drawing.Size(55, 13);
            this.lblRB.TabIndex = 11;
            this.lblRB.Text = "Root Beer";
            // 
            // lblLL
            // 
            this.lblLL.AutoSize = true;
            this.lblLL.Location = new System.Drawing.Point(51, 300);
            this.lblLL.Name = "lblLL";
            this.lblLL.Size = new System.Drawing.Size(64, 13);
            this.lblLL.TabIndex = 12;
            this.lblLL.Text = "Lemon Lime";
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Location = new System.Drawing.Point(162, 300);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(36, 13);
            this.lblG.TabIndex = 13;
            this.lblG.Text = "Grape";
            // 
            // lblCS
            // 
            this.lblCS.AutoSize = true;
            this.lblCS.Location = new System.Drawing.Point(104, 456);
            this.lblCS.Name = "lblCS";
            this.lblCS.Size = new System.Drawing.Size(65, 13);
            this.lblCS.TabIndex = 14;
            this.lblCS.Text = "Cream Soda";
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Location = new System.Drawing.Point(72, 498);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(34, 13);
            this.lblT.TabIndex = 15;
            this.lblT.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(113, 497);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 523);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblT);
            this.Controls.Add(this.lblCS);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.lblLL);
            this.Controls.Add(this.lblRB);
            this.Controls.Add(this.lblCola);
            this.Controls.Add(this.lblCPrice);
            this.Controls.Add(this.lblGPrice);
            this.Controls.Add(this.lblLPrice);
            this.Controls.Add(this.lblRPrice);
            this.Controls.Add(this.lblColaPrice);
            this.Controls.Add(this.pbCream);
            this.Controls.Add(this.pbGrape);
            this.Controls.Add(this.pbLime);
            this.Controls.Add(this.pbRoot);
            this.Controls.Add(this.pbCola);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pbCola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGrape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCream)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCola;
        private System.Windows.Forms.PictureBox pbRoot;
        private System.Windows.Forms.PictureBox pbLime;
        private System.Windows.Forms.PictureBox pbGrape;
        private System.Windows.Forms.PictureBox pbCream;
        private System.Windows.Forms.Label lblColaPrice;
        private System.Windows.Forms.Label lblRPrice;
        private System.Windows.Forms.Label lblLPrice;
        private System.Windows.Forms.Label lblGPrice;
        private System.Windows.Forms.Label lblCPrice;
        private System.Windows.Forms.Label lblCola;
        private System.Windows.Forms.Label lblRB;
        private System.Windows.Forms.Label lblLL;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblCS;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Label lblTotal;
    }
}

