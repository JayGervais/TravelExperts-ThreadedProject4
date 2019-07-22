namespace TravelExperts_GroupProject4
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.btnPackages = new System.Windows.Forms.Button();
            this.txtMaxBasePrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMinBasePrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaxDuration = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMinDuration = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPackageCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalNumSuppliers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEngagedSuppliers = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalNumProducts = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEngagedProducts = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPackages
            // 
            this.btnPackages.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnPackages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPackages.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPackages.Location = new System.Drawing.Point(12, 12);
            this.btnPackages.Name = "btnPackages";
            this.btnPackages.Size = new System.Drawing.Size(123, 45);
            this.btnPackages.TabIndex = 0;
            this.btnPackages.Text = "Packages";
            this.btnPackages.UseVisualStyleBackColor = false;
            this.btnPackages.Click += new System.EventHandler(this.BtnPackages_Click);
            // 
            // txtMaxBasePrice
            // 
            this.txtMaxBasePrice.Enabled = false;
            this.txtMaxBasePrice.Location = new System.Drawing.Point(388, 173);
            this.txtMaxBasePrice.Name = "txtMaxBasePrice";
            this.txtMaxBasePrice.Size = new System.Drawing.Size(69, 20);
            this.txtMaxBasePrice.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Highest Base Price";
            // 
            // txtMinBasePrice
            // 
            this.txtMinBasePrice.Enabled = false;
            this.txtMinBasePrice.Location = new System.Drawing.Point(155, 173);
            this.txtMinBasePrice.Name = "txtMinBasePrice";
            this.txtMinBasePrice.Size = new System.Drawing.Size(69, 20);
            this.txtMinBasePrice.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Lowest Base Price:";
            // 
            // txtMaxDuration
            // 
            this.txtMaxDuration.Enabled = false;
            this.txtMaxDuration.Location = new System.Drawing.Point(388, 147);
            this.txtMaxDuration.Name = "txtMaxDuration";
            this.txtMaxDuration.Size = new System.Drawing.Size(69, 20);
            this.txtMaxDuration.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Maximun duration (Days):";
            // 
            // txtMinDuration
            // 
            this.txtMinDuration.Enabled = false;
            this.txtMinDuration.Location = new System.Drawing.Point(155, 147);
            this.txtMinDuration.Name = "txtMinDuration";
            this.txtMinDuration.Size = new System.Drawing.Size(69, 20);
            this.txtMinDuration.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Minumum duration (Days):";
            // 
            // txtPackageCount
            // 
            this.txtPackageCount.Enabled = false;
            this.txtPackageCount.Location = new System.Drawing.Point(155, 121);
            this.txtPackageCount.Name = "txtPackageCount";
            this.txtPackageCount.Size = new System.Drawing.Size(69, 20);
            this.txtPackageCount.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Total number of Packages:";
            // 
            // txtTotalNumSuppliers
            // 
            this.txtTotalNumSuppliers.Enabled = false;
            this.txtTotalNumSuppliers.Location = new System.Drawing.Point(388, 199);
            this.txtTotalNumSuppliers.Name = "txtTotalNumSuppliers";
            this.txtTotalNumSuppliers.Size = new System.Drawing.Size(69, 20);
            this.txtTotalNumSuppliers.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Total number of Suppliers:";
            // 
            // txtEngagedSuppliers
            // 
            this.txtEngagedSuppliers.Enabled = false;
            this.txtEngagedSuppliers.Location = new System.Drawing.Point(155, 199);
            this.txtEngagedSuppliers.Name = "txtEngagedSuppliers";
            this.txtEngagedSuppliers.Size = new System.Drawing.Size(69, 20);
            this.txtEngagedSuppliers.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Engaged Suppliers:";
            // 
            // txtTotalNumProducts
            // 
            this.txtTotalNumProducts.Enabled = false;
            this.txtTotalNumProducts.Location = new System.Drawing.Point(388, 225);
            this.txtTotalNumProducts.Name = "txtTotalNumProducts";
            this.txtTotalNumProducts.Size = new System.Drawing.Size(69, 20);
            this.txtTotalNumProducts.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(246, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Total number of Products:";
            // 
            // txtEngagedProducts
            // 
            this.txtEngagedProducts.Enabled = false;
            this.txtEngagedProducts.Location = new System.Drawing.Point(155, 225);
            this.txtEngagedProducts.Name = "txtEngagedProducts";
            this.txtEngagedProducts.Size = new System.Drawing.Size(69, 20);
            this.txtEngagedProducts.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Products in current use:";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTotalNumProducts);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEngagedProducts);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTotalNumSuppliers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEngagedSuppliers);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMaxBasePrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMinBasePrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaxDuration);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMinDuration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPackageCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPackages);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomePage";
            this.Text = "Travel Experts";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPackages;
        private System.Windows.Forms.TextBox txtMaxBasePrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMinBasePrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaxDuration;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMinDuration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPackageCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalNumSuppliers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEngagedSuppliers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalNumProducts;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEngagedProducts;
        private System.Windows.Forms.Label label9;
    }
}

