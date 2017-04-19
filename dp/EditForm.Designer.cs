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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grpInputData.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(16, 64);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(442, 85);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "PhP-SRePS";
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.White;
            this.lblClose.ForeColor = System.Drawing.Color.Black;
            this.lblClose.Location = new System.Drawing.Point(1256, 897);
            this.lblClose.Margin = new System.Windows.Forms.Padding(4);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(288, 58);
            this.lblClose.TabIndex = 15;
            this.lblClose.Text = "Close";
            this.lblClose.UseVisualStyleBackColor = false;
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
            this.grpInputData.Location = new System.Drawing.Point(419, 206);
            this.grpInputData.Margin = new System.Windows.Forms.Padding(4);
            this.grpInputData.Name = "grpInputData";
            this.grpInputData.Padding = new System.Windows.Forms.Padding(4);
            this.grpInputData.Size = new System.Drawing.Size(733, 554);
            this.grpInputData.TabIndex = 16;
            this.grpInputData.TabStop = false;
            this.grpInputData.Text = "Edit Data";
            this.grpInputData.Enter += new System.EventHandler(this.grpInputData_Enter);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.ForeColor = System.Drawing.Color.Aqua;
            this.lblStock.Location = new System.Drawing.Point(81, 371);
            this.lblStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(94, 32);
            this.lblStock.TabIndex = 7;
            this.lblStock.Text = "Stock:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.ForeColor = System.Drawing.Color.Aqua;
            this.lblPrice.Location = new System.Drawing.Point(81, 239);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(88, 32);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price:";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.ForeColor = System.Drawing.Color.Aqua;
            this.lblProduct.Location = new System.Drawing.Point(81, 117);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(121, 32);
            this.lblProduct.TabIndex = 5;
            this.lblProduct.Text = "Product:";
            this.lblProduct.Click += new System.EventHandler(this.lblProduct_Click);
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(251, 113);
            this.txtProduct.Margin = new System.Windows.Forms.Padding(4);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(369, 38);
            this.txtProduct.TabIndex = 2;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(251, 367);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(369, 38);
            this.txtStock.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(251, 236);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(369, 38);
            this.txtPrice.TabIndex = 3;
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.White;
            this.btnUpload.ForeColor = System.Drawing.Color.Black;
            this.btnUpload.Location = new System.Drawing.Point(437, 489);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(288, 58);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.Text = "Update";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(554, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select item to edit:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(560, 123);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(291, 39);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1560, 970);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpInputData);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditForm";
            this.Text = "Edit Record";
            this.Load += new System.EventHandler(this.EditForm_Load_1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}