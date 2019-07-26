namespace TravelExperts_GroupProject4
{
    partial class SupplierForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.lstViewSupplier = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSupName = new System.Windows.Forms.Label();
            this.lblSupID = new System.Windows.Forms.Label();
            this.lblProdId = new System.Windows.Forms.Label();
            this.lblProdName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detail";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(15, 274);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(134, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(178, 274);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(134, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Location = new System.Drawing.Point(655, 274);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(134, 23);
            this.btnAddSupplier.TabIndex = 4;
            this.btnAddSupplier.Text = "Add Supplier";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // lstViewSupplier
            // 
            this.lstViewSupplier.Location = new System.Drawing.Point(12, 25);
            this.lstViewSupplier.Name = "lstViewSupplier";
            this.lstViewSupplier.Size = new System.Drawing.Size(773, 243);
            this.lstViewSupplier.TabIndex = 5;
            this.lstViewSupplier.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Inputted  Data";
            // 
            // lblSupName
            // 
            this.lblSupName.AutoSize = true;
            this.lblSupName.Location = new System.Drawing.Point(12, 367);
            this.lblSupName.Name = "lblSupName";
            this.lblSupName.Size = new System.Drawing.Size(13, 13);
            this.lblSupName.TabIndex = 7;
            this.lblSupName.Text = "1";
            this.lblSupName.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblSupID
            // 
            this.lblSupID.AutoSize = true;
            this.lblSupID.Location = new System.Drawing.Point(175, 367);
            this.lblSupID.Name = "lblSupID";
            this.lblSupID.Size = new System.Drawing.Size(13, 13);
            this.lblSupID.TabIndex = 8;
            this.lblSupID.Text = "2";
            // 
            // lblProdId
            // 
            this.lblProdId.AutoSize = true;
            this.lblProdId.Location = new System.Drawing.Point(488, 367);
            this.lblProdId.Name = "lblProdId";
            this.lblProdId.Size = new System.Drawing.Size(13, 13);
            this.lblProdId.TabIndex = 9;
            this.lblProdId.Text = "3";
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.Location = new System.Drawing.Point(652, 367);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(13, 13);
            this.lblProdName.TabIndex = 10;
            this.lblProdName.Text = "4";
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblProdName);
            this.Controls.Add(this.lblProdId);
            this.Controls.Add(this.lblSupID);
            this.Controls.Add(this.lblSupName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstViewSupplier);
            this.Controls.Add(this.btnAddSupplier);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label1);
            this.Name = "SupplierForm";
            this.Text = "SupplierForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.ListView lstViewSupplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSupName;
        private System.Windows.Forms.Label lblSupID;
        private System.Windows.Forms.Label lblProdId;
        private System.Windows.Forms.Label lblProdName;
    }
}