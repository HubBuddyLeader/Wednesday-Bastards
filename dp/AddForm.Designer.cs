﻿namespace dp
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grpInputData.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInputData
            // 
            this.grpInputData.Controls.Add(this.btnInsert);
            this.grpInputData.Controls.Add(this.lblStock);
            this.grpInputData.Controls.Add(this.lblPrice);
            this.grpInputData.Controls.Add(this.lblProduct);
            this.grpInputData.Controls.Add(this.txtProduct);
            this.grpInputData.Controls.Add(this.txtStock);
            this.grpInputData.Controls.Add(this.txtPrice);
            this.grpInputData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpInputData.Location = new System.Drawing.Point(419, 206);
            this.grpInputData.Margin = new System.Windows.Forms.Padding(5);
            this.grpInputData.Name = "grpInputData";
            this.grpInputData.Padding = new System.Windows.Forms.Padding(5);
            this.grpInputData.Size = new System.Drawing.Size(733, 554);
            this.grpInputData.TabIndex = 6;
            this.grpInputData.TabStop = false;
            this.grpInputData.Text = "Input Data";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.White;
            this.btnInsert.ForeColor = System.Drawing.Color.Black;
            this.btnInsert.Location = new System.Drawing.Point(437, 489);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(288, 58);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Upload";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
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
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(251, 113);
            this.txtProduct.Margin = new System.Windows.Forms.Padding(5);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(369, 38);
            this.txtProduct.TabIndex = 2;
            this.txtProduct.TextChanged += new System.EventHandler(this.txtProduct_TextChanged);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(251, 367);
            this.txtStock.Margin = new System.Windows.Forms.Padding(5);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(369, 38);
            this.txtStock.TabIndex = 4;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(251, 236);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(5);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(369, 38);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Red;
            this.lblTitle.Location = new System.Drawing.Point(16, 64);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(442, 85);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "PhP-SRePS";
            // 
            // lblClose
            // 
            this.lblClose.BackColor = System.Drawing.Color.White;
            this.lblClose.ForeColor = System.Drawing.Color.Black;
            this.lblClose.Location = new System.Drawing.Point(1513, 1069);
            this.lblClose.Margin = new System.Windows.Forms.Padding(4);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(288, 58);
            this.lblClose.TabIndex = 16;
            this.lblClose.Text = "Close";
            this.lblClose.UseVisualStyleBackColor = false;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(500, 825);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(85, 32);
            this.errorLabel.TabIndex = 9;
            this.errorLabel.Text = "Error:";
            this.errorLabel.Visible = false;
            this.errorLabel.Click += new System.EventHandler(this.errorLabel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(0, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1256, 897);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 58);
            this.button1.TabIndex = 17;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1560, 1059);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpInputData);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddForm";
            this.Text = "Add Record";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.grpInputData.ResumeLayout(false);
            this.grpInputData.PerformLayout();
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
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button lblClose;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button1;
    }
}