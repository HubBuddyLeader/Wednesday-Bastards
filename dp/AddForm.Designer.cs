namespace dp
{
    partial class AddForm
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
            this.grpInputData = new System.Windows.Forms.GroupBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.msNav = new System.Windows.Forms.MenuStrip();
            this.navigateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBack = new System.Windows.Forms.Button();
            this.grpInputData.SuspendLayout();
            this.msNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInputData
            // 
            this.grpInputData.Controls.Add(this.lblStock);
            this.grpInputData.Controls.Add(this.lblPrice);
            this.grpInputData.Controls.Add(this.lblProduct);
            this.grpInputData.Controls.Add(this.txtProduct);
            this.grpInputData.Controls.Add(this.txtStock);
            this.grpInputData.Controls.Add(this.txtPrice);
            this.grpInputData.Controls.Add(this.btnUpload);
            this.grpInputData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpInputData.Location = new System.Drawing.Point(329, 167);
            this.grpInputData.Name = "grpInputData";
            this.grpInputData.Size = new System.Drawing.Size(550, 447);
            this.grpInputData.TabIndex = 6;
            this.grpInputData.TabStop = false;
            this.grpInputData.Text = "Input Data";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.ForeColor = System.Drawing.Color.Aqua;
            this.lblStock.Location = new System.Drawing.Point(61, 299);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(72, 25);
            this.lblStock.TabIndex = 7;
            this.lblStock.Text = "Stock:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.ForeColor = System.Drawing.Color.Aqua;
            this.lblPrice.Location = new System.Drawing.Point(61, 193);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(67, 25);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price:";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.ForeColor = System.Drawing.Color.Aqua;
            this.lblProduct.Location = new System.Drawing.Point(61, 94);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(92, 25);
            this.lblProduct.TabIndex = 5;
            this.lblProduct.Text = "Product:";
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(188, 91);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(278, 31);
            this.txtProduct.TabIndex = 2;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(188, 296);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(278, 31);
            this.txtStock.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(188, 190);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(278, 31);
            this.txtPrice.TabIndex = 3;
            // 
            // btnUpload
            // 
            this.btnUpload.ForeColor = System.Drawing.Color.Black;
            this.btnUpload.Location = new System.Drawing.Point(328, 394);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(216, 47);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(12, 55);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(353, 67);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "PhP-SRePS";
            // 
            // msNav
            // 
            this.msNav.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.msNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navigateToolStripMenuItem});
            this.msNav.Location = new System.Drawing.Point(0, 0);
            this.msNav.Name = "msNav";
            this.msNav.Size = new System.Drawing.Size(1170, 40);
            this.msNav.TabIndex = 14;
            this.msNav.Text = "Navigation Bar";
            // 
            // navigateToolStripMenuItem
            // 
            this.navigateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRecordToolStripMenuItem,
            this.editRecordToolStripMenuItem});
            this.navigateToolStripMenuItem.Name = "navigateToolStripMenuItem";
            this.navigateToolStripMenuItem.Size = new System.Drawing.Size(122, 36);
            this.navigateToolStripMenuItem.Text = "Navigate";
            // 
            // addRecordToolStripMenuItem
            // 
            this.addRecordToolStripMenuItem.Name = "addRecordToolStripMenuItem";
            this.addRecordToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.addRecordToolStripMenuItem.Text = "Main Form";
            // 
            // editRecordToolStripMenuItem
            // 
            this.editRecordToolStripMenuItem.Name = "editRecordToolStripMenuItem";
            this.editRecordToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.editRecordToolStripMenuItem.Text = "Edit Record";
            // 
            // lblBack
            // 
            this.lblBack.ForeColor = System.Drawing.Color.Black;
            this.lblBack.Location = new System.Drawing.Point(942, 723);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(216, 47);
            this.lblBack.TabIndex = 8;
            this.lblBack.Text = "Back";
            this.lblBack.UseVisualStyleBackColor = true;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1170, 782);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.msNav);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpInputData);
            this.Name = "AddForm";
            this.Text = "Form2";
            this.grpInputData.ResumeLayout(false);
            this.grpInputData.PerformLayout();
            this.msNav.ResumeLayout(false);
            this.msNav.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInputData;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.MenuStrip msNav;
        private System.Windows.Forms.ToolStripMenuItem navigateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRecordToolStripMenuItem;
        private System.Windows.Forms.Button lblBack;
    }
}