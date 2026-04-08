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
            dgvProducts.Location = new Point(12, 163);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(464, 353);
            dgvProducts.TabIndex = 5;
            dgvProducts.SelectionChanged += dgvProducts_SelectionChanged;
            // 
            // cboCategory
            // 
            cboCategory.FormattingEnabled = true;
            cboCategory.Location = new Point(354, 127);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(121, 23);
            cboCategory.TabIndex = 4;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 68);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(247, 23);
            txtSearch.TabIndex = 0;
            // 
            // btnAddCart
            // 
            btnAddCart.Enabled = false;
            btnAddCart.Location = new Point(12, 117);
            btnAddCart.Name = "btnAddCart";
            btnAddCart.Size = new Size(149, 40);
            btnAddCart.TabIndex = 2;
            btnAddCart.Text = "Add to Cart";
            btnAddCart.UseVisualStyleBackColor = true;
            btnAddCart.Click += btnAddCart_Click;
            // 
            // btnViewCart
            // 
            btnViewCart.Location = new Point(183, 117);
            btnViewCart.Name = "btnViewCart";
            btnViewCart.Size = new Size(149, 40);
            btnViewCart.TabIndex = 3;
            btnViewCart.Text = "View Cart";
            btnViewCart.UseVisualStyleBackColor = true;
            btnViewCart.Click += btnViewCart_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(279, 68);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Gill Sans MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(354, 9);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(153, 23);
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
            grpProductDetails.Location = new Point(522, 68);
            grpProductDetails.Name = "grpProductDetails";
            grpProductDetails.Size = new Size(350, 448);
            grpProductDetails.TabIndex = 6;
            grpProductDetails.TabStop = false;
            grpProductDetails.Text = "Product Details";
            grpProductDetails.Visible = false;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(25, 296);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(42, 15);
            lblStock.TabIndex = 5;
            lblStock.Text = "Stock: ";
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(90, 381);
            nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(120, 23);
            nudQuantity.TabIndex = 4;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(19, 242);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(112, 15);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Product Description";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(19, 177);
            lblType.Name = "lblType";
            lblType.Size = new Size(76, 15);
            lblType.TabIndex = 2;
            lblType.Text = "Product Type";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(19, 120);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(78, 15);
            lblPrice.TabIndex = 1;
            lblPrice.Text = "Product Price";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(19, 50);
            lblName.Name = "lblName";
            lblName.Size = new Size(81, 15);
            lblName.TabIndex = 0;
            lblName.Text = "ProductName";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(797, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 8;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // MainShoppingForm
            // 
            AcceptButton = btnSearch;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnLogout;
            ClientSize = new Size(884, 528);
            Controls.Add(btnLogout);
            Controls.Add(grpProductDetails);
            Controls.Add(lblWelcome);
            Controls.Add(btnSearch);
            Controls.Add(btnViewCart);
            Controls.Add(btnAddCart);
            Controls.Add(txtSearch);
            Controls.Add(cboCategory);
            Controls.Add(dgvProducts);
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