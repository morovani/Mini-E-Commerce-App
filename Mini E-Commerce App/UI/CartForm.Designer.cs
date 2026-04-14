namespace Mini_E_Commerce_App
{
    partial class CartForm
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
            dgvCartItems = new DataGridView();
            lblTotal = new Label();
            btnRemoveItem = new Button();
            btnCheckout = new Button();
            btnUpdateItem = new Button();
            grpCartDetails = new GroupBox();
            numericUpDown1 = new NumericUpDown();
            lblSubTotal = new Label();
            lblPrice = new Label();
            lblName = new Label();
            btnReturnToShop = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCartItems).BeginInit();
            grpCartDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dgvCartItems
            // 
            dgvCartItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCartItems.Location = new Point(15, 16);
            dgvCartItems.Margin = new Padding(3, 4, 3, 4);
            dgvCartItems.Name = "dgvCartItems";
            dgvCartItems.RowHeadersWidth = 51;
            dgvCartItems.Size = new Size(535, 368);
            dgvCartItems.TabIndex = 0;
            dgvCartItems.CellContentClick += dgvCartItems_CellContentClick;
            dgvCartItems.SelectionChanged += dgvCartItems_SelectionChanged;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(57, 424);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(109, 20);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Total Price: $$$";
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.Location = new Point(15, 483);
            btnRemoveItem.Margin = new Padding(3, 4, 3, 4);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(137, 68);
            btnRemoveItem.TabIndex = 2;
            btnRemoveItem.Text = "Remove Item";
            btnRemoveItem.UseVisualStyleBackColor = true;
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(211, 483);
            btnCheckout.Margin = new Padding(3, 4, 3, 4);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(137, 68);
            btnCheckout.TabIndex = 3;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // btnUpdateItem
            // 
            btnUpdateItem.Location = new Point(193, 448);
            btnUpdateItem.Margin = new Padding(3, 4, 3, 4);
            btnUpdateItem.Name = "btnUpdateItem";
            btnUpdateItem.Size = new Size(83, 61);
            btnUpdateItem.TabIndex = 4;
            btnUpdateItem.Text = "Update Item";
            btnUpdateItem.UseVisualStyleBackColor = true;
            btnUpdateItem.Click += btnUpdateItem_Click;
            // 
            // grpCartDetails
            // 
            grpCartDetails.Controls.Add(numericUpDown1);
            grpCartDetails.Controls.Add(btnUpdateItem);
            grpCartDetails.Controls.Add(lblSubTotal);
            grpCartDetails.Controls.Add(lblPrice);
            grpCartDetails.Controls.Add(lblName);
            grpCartDetails.Location = new Point(597, 16);
            grpCartDetails.Margin = new Padding(3, 4, 3, 4);
            grpCartDetails.Name = "grpCartDetails";
            grpCartDetails.Padding = new Padding(3, 4, 3, 4);
            grpCartDetails.Size = new Size(304, 536);
            grpCartDetails.TabIndex = 5;
            grpCartDetails.TabStop = false;
            grpCartDetails.Text = "Cart Item Details";
            grpCartDetails.Visible = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(25, 467);
            numericUpDown1.Margin = new Padding(3, 4, 3, 4);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(137, 27);
            numericUpDown1.TabIndex = 3;
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Location = new Point(25, 204);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(71, 20);
            lblSubTotal.TabIndex = 2;
            lblSubTotal.Text = "Sub Total";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(23, 137);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(100, 20);
            lblPrice.TabIndex = 1;
            lblPrice.Text = " Product Price";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(25, 67);
            lblName.Name = "lblName";
            lblName.Size = new Size(104, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Product Name";
            // 
            // btnReturnToShop
            // 
            btnReturnToShop.Location = new Point(409, 483);
            btnReturnToShop.Margin = new Padding(3, 4, 3, 4);
            btnReturnToShop.Name = "btnReturnToShop";
            btnReturnToShop.Size = new Size(137, 68);
            btnReturnToShop.TabIndex = 4;
            btnReturnToShop.Text = "Return to Shop";
            btnReturnToShop.UseVisualStyleBackColor = true;
            btnReturnToShop.Click += btnReturnToShop_Click;
            // 
            // CartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnReturnToShop;
            ClientSize = new Size(913, 568);
            Controls.Add(btnReturnToShop);
            Controls.Add(grpCartDetails);
            Controls.Add(btnCheckout);
            Controls.Add(btnRemoveItem);
            Controls.Add(lblTotal);
            Controls.Add(dgvCartItems);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cart";
            Load += CartForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCartItems).EndInit();
            grpCartDetails.ResumeLayout(false);
            grpCartDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCartItems;
        private Label lblTotal;
        private Button btnRemoveItem;
        private Button btnCheckout;
        private Button btnUpdateItem;
        private GroupBox grpCartDetails;
        private Label lblSubTotal;
        private Label lblPrice;
        private Label lblName;
        private NumericUpDown numericUpDown1;
        private Button btnReturnToShop;
    }
}