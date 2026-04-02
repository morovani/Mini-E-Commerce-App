namespace Mini_E_Commerce_App
{
    partial class MainShoppingForm
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
            dgvProducts = new DataGridView();
            cboCategory = new ComboBox();
            txtSearch = new TextBox();
            btnAddCart = new Button();
            btnViewCart = new Button();
            btnSearch = new Button();
            lblWelcome = new Label();
            grpProductDetails = new GroupBox();
            lblStock = new Label();
            nudQuantity = new NumericUpDown();
            lblDescription = new Label();
            lblType = new Label();
            lblPrice = new Label();
            lblName = new Label();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            grpProductDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(14, 217);
            dgvProducts.Margin = new Padding(3, 4, 3, 4);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(530, 471);
            dgvProducts.TabIndex = 5;
            dgvProducts.SelectionChanged += dgvProducts_SelectionChanged;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(405, 169);
            cboCategory.Margin = new Padding(3, 4, 3, 4);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(138, 28);
            cboCategory.TabIndex = 4;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(14, 91);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(282, 27);
            txtSearch.TabIndex = 0;
            // 
            // btnAddCart
            // 
            btnAddCart.Enabled = false;
            btnAddCart.Location = new Point(14, 156);
            btnAddCart.Margin = new Padding(3, 4, 3, 4);
            btnAddCart.Name = "btnAddCart";
            btnAddCart.Size = new Size(170, 53);
            btnAddCart.TabIndex = 2;
            btnAddCart.Text = "Add to Cart";
            btnAddCart.UseVisualStyleBackColor = true;
            btnAddCart.Click += btnAddCart_Click;
            // 
            // btnViewCart
            // 
            btnViewCart.Location = new Point(209, 156);
            btnViewCart.Margin = new Padding(3, 4, 3, 4);
            btnViewCart.Name = "btnViewCart";
            btnViewCart.Size = new Size(170, 53);
            btnViewCart.TabIndex = 3;
            btnViewCart.Text = "View Cart";
            btnViewCart.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(319, 91);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 31);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Gill Sans MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(405, 12);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(193, 29);
            lblWelcome.TabIndex = 7;
            lblWelcome.Text = "Welcome Username!!";
            // 
            // grpProductDetails
            // 
            grpProductDetails.Controls.Add(lblStock);
            grpProductDetails.Controls.Add(nudQuantity);
            grpProductDetails.Controls.Add(lblDescription);
            grpProductDetails.Controls.Add(lblType);
            grpProductDetails.Controls.Add(lblPrice);
            grpProductDetails.Controls.Add(lblName);
            grpProductDetails.Location = new Point(597, 91);
            grpProductDetails.Margin = new Padding(3, 4, 3, 4);
            grpProductDetails.Name = "grpProductDetails";
            grpProductDetails.Padding = new Padding(3, 4, 3, 4);
            grpProductDetails.Size = new Size(400, 597);
            grpProductDetails.TabIndex = 6;
            grpProductDetails.TabStop = false;
            grpProductDetails.Text = "Product Details";
            grpProductDetails.Visible = false;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(29, 395);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(52, 20);
            lblStock.TabIndex = 5;
            lblStock.Text = "Stock: ";
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(103, 508);
            nudQuantity.Margin = new Padding(3, 4, 3, 4);
            nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(137, 27);
            nudQuantity.TabIndex = 4;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(22, 323);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(140, 20);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Product Description";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(22, 236);
            lblType.Name = "lblType";
            lblType.Size = new Size(95, 20);
            lblType.TabIndex = 2;
            lblType.Text = "Product Type";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(22, 160);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(96, 20);
            lblPrice.TabIndex = 1;
            lblPrice.Text = "Product Price";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(22, 67);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 20);
            lblName.TabIndex = 0;
            lblName.Text = "ProductName";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(911, 16);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(86, 31);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // MainShoppingForm
            // 
            AcceptButton = btnSearch;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnLogout;
            ClientSize = new Size(1010, 704);
            Controls.Add(btnLogout);
            Controls.Add(grpProductDetails);
            Controls.Add(lblWelcome);
            Controls.Add(btnSearch);
            Controls.Add(btnViewCart);
            Controls.Add(btnAddCart);
            Controls.Add(txtSearch);
            Controls.Add(cboCategory);
            Controls.Add(dgvProducts);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainShoppingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shop - Browse";
            Load += MainShoppingForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            grpProductDetails.ResumeLayout(false);
            grpProductDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProducts;
        private ComboBox cboCategory;
        private TextBox txtSearch;
        private Button btnAddCart;
        private Button btnViewCart;
        private Button btnSearch;
        private Label lblWelcome;
        private GroupBox grpProductDetails;
        private NumericUpDown nudQuantity;
        private Label lblDescription;
        private Label lblType;
        private Label lblPrice;
        private Label lblName;
        private Button btnLogout;
        private Label lblStock;
    }
}