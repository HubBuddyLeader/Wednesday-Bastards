namespace dp
{
    partial class EditForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Button();
            this.grpInputData = new System.Windows.Forms.GroupBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.grpInputData.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(12, 52);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(353, 67);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "PhP-SRePS";
            // 
            // lblClose
            // 
            this.lblClose.ForeColor = System.Drawing.Color.Black;
            this.lblClose.Location = new System.Drawing.Point(942, 723);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(216, 47);
            this.lblClose.TabIndex = 15;
            this.lblClose.Text = "Close";
            this.lblClose.UseVisualStyleBackColor = true;
            this.lblClose.Click += new System.EventHandler(this.lblBack_Click);
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
            this.grpInputData.Location = new System.Drawing.Point(314, 166);
            this.grpInputData.Name = "grpInputData";
            this.grpInputData.Size = new System.Drawing.Size(550, 447);
            this.grpInputData.TabIndex = 16;
            this.grpInputData.TabStop = false;
            this.grpInputData.Text = "Edit Data";
            this.grpInputData.Enter += new System.EventHandler(this.grpInputData_Enter);
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
            this.btnUpload.Text = "Update";
            this.btnUpload.UseVisualStyleBackColor = true;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1170, 782);
            this.Controls.Add(this.grpInputData);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.grpInputData.ResumeLayout(false);
            this.grpInputData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button lblClose;
        private System.Windows.Forms.GroupBox grpInputData;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnUpload;
    }
}