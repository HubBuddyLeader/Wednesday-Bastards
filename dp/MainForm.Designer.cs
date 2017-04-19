namespace dp
{
    partial class fm_Database
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fm_Database));
            this.lblTitle = new System.Windows.Forms.Label();
            this.pbShitImage = new System.Windows.Forms.PictureBox();
            this.lbProduct = new System.Windows.Forms.ListBox();
            this.lbPrice = new System.Windows.Forms.ListBox();
            this.lbStock = new System.Windows.Forms.ListBox();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lblPrices = new System.Windows.Forms.Label();
            this.lblStocks = new System.Windows.Forms.Label();
            this.msNav = new System.Windows.Forms.MenuStrip();
            this.navigateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblExit = new System.Windows.Forms.Button();
            this.lblEdit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbShitImage)).BeginInit();
            this.msNav.SuspendLayout();
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
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "PhP-SRePS";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // pbShitImage
            // 
            this.pbShitImage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbShitImage.ErrorImage")));
            this.pbShitImage.Image = ((System.Drawing.Image)(resources.GetObject("pbShitImage.Image")));
            this.pbShitImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbShitImage.InitialImage")));
            this.pbShitImage.Location = new System.Drawing.Point(24, 195);
            this.pbShitImage.Name = "pbShitImage";
            this.pbShitImage.Size = new System.Drawing.Size(449, 470);
            this.pbShitImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbShitImage.TabIndex = 6;
            this.pbShitImage.TabStop = false;
            this.pbShitImage.Click += new System.EventHandler(this.pbShitImage_Click);
            // 
            // lbProduct
            // 
            this.lbProduct.BackColor = System.Drawing.Color.DimGray;
            this.lbProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbProduct.ForeColor = System.Drawing.Color.LawnGreen;
            this.lbProduct.FormattingEnabled = true;
            this.lbProduct.ItemHeight = 25;
            this.lbProduct.Items.AddRange(new object[] {
            "Product 1",
            "Product 2",
            "Product 3",
            "Product 4"});
            this.lbProduct.Location = new System.Drawing.Point(535, 286);
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.Size = new System.Drawing.Size(169, 375);
            this.lbProduct.TabIndex = 7;
            this.lbProduct.SelectedIndexChanged += new System.EventHandler(this.lbProduct_SelectedIndexChanged);
            // 
            // lbPrice
            // 
            this.lbPrice.BackColor = System.Drawing.Color.DimGray;
            this.lbPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbPrice.ForeColor = System.Drawing.Color.LawnGreen;
            this.lbPrice.FormattingEnabled = true;
            this.lbPrice.ItemHeight = 25;
            this.lbPrice.Items.AddRange(new object[] {
            "Price 1",
            "Price 2",
            "Price 3",
            "Price 4"});
            this.lbPrice.Location = new System.Drawing.Point(739, 286);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(169, 375);
            this.lbPrice.TabIndex = 8;
            // 
            // lbStock
            // 
            this.lbStock.BackColor = System.Drawing.Color.DimGray;
            this.lbStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbStock.ForeColor = System.Drawing.Color.LawnGreen;
            this.lbStock.FormattingEnabled = true;
            this.lbStock.ItemHeight = 25;
            this.lbStock.Items.AddRange(new object[] {
            "Stock 1",
            "Stock 2",
            "Stock 3",
            "Stock 4"});
            this.lbStock.Location = new System.Drawing.Point(942, 286);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(169, 375);
            this.lbStock.TabIndex = 9;
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.ForeColor = System.Drawing.Color.Cyan;
            this.lblProducts.Location = new System.Drawing.Point(530, 248);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(103, 25);
            this.lblProducts.TabIndex = 10;
            this.lblProducts.Text = "Products:";
            // 
            // lblPrices
            // 
            this.lblPrices.AutoSize = true;
            this.lblPrices.ForeColor = System.Drawing.Color.Cyan;
            this.lblPrices.Location = new System.Drawing.Point(734, 248);
            this.lblPrices.Name = "lblPrices";
            this.lblPrices.Size = new System.Drawing.Size(78, 25);
            this.lblPrices.TabIndex = 11;
            this.lblPrices.Text = "Prices:";
            // 
            // lblStocks
            // 
            this.lblStocks.AutoSize = true;
            this.lblStocks.ForeColor = System.Drawing.Color.Cyan;
            this.lblStocks.Location = new System.Drawing.Point(937, 248);
            this.lblStocks.Name = "lblStocks";
            this.lblStocks.Size = new System.Drawing.Size(72, 25);
            this.lblStocks.TabIndex = 12;
            this.lblStocks.Text = "Stock:";
            // 
            // msNav
            // 
            this.msNav.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.msNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navigateToolStripMenuItem});
            this.msNav.Location = new System.Drawing.Point(0, 0);
            this.msNav.Name = "msNav";
            this.msNav.Size = new System.Drawing.Size(1170, 40);
            this.msNav.TabIndex = 13;
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
            this.addRecordToolStripMenuItem.Text = "Add Record";
            this.addRecordToolStripMenuItem.Click += new System.EventHandler(this.addRecordToolStripMenuItem_Click);
            // 
            // editRecordToolStripMenuItem
            // 
            this.editRecordToolStripMenuItem.Name = "editRecordToolStripMenuItem";
            this.editRecordToolStripMenuItem.Size = new System.Drawing.Size(269, 38);
            this.editRecordToolStripMenuItem.Text = "Edit Record";
            this.editRecordToolStripMenuItem.Click += new System.EventHandler(this.editRecordToolStripMenuItem_Click);
            // 
            // lblExit
            // 
            this.lblExit.BackColor = System.Drawing.Color.White;
            this.lblExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.lblExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.lblExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblExit.ForeColor = System.Drawing.Color.Black;
            this.lblExit.Location = new System.Drawing.Point(942, 723);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(216, 47);
            this.lblExit.TabIndex = 14;
            this.lblExit.Text = "Exit";
            this.lblExit.UseVisualStyleBackColor = false;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.BackColor = System.Drawing.Color.White;
            this.lblEdit.Location = new System.Drawing.Point(726, 734);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(192, 25);
            this.lblEdit.TabIndex = 18;
            this.lblEdit.Text = "Please EXIT Twice";
            // 
            // fm_Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1170, 782);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblStocks);
            this.Controls.Add(this.lblPrices);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.lbStock);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbProduct);
            this.Controls.Add(this.pbShitImage);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.msNav);
            this.MainMenuStrip = this.msNav;
            this.Name = "fm_Database";
            this.Text = "PhP-SRePS";
            this.Load += new System.EventHandler(this.fm_Database_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbShitImage)).EndInit();
            this.msNav.ResumeLayout(false);
            this.msNav.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pbShitImage;
        private System.Windows.Forms.ListBox lbProduct;
        private System.Windows.Forms.ListBox lbPrice;
        private System.Windows.Forms.ListBox lbStock;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblPrices;
        private System.Windows.Forms.Label lblStocks;
        private System.Windows.Forms.MenuStrip msNav;
        private System.Windows.Forms.ToolStripMenuItem navigateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRecordToolStripMenuItem;
        private System.Windows.Forms.Button lblExit;
        private System.Windows.Forms.Label lblEdit;
    }
}

