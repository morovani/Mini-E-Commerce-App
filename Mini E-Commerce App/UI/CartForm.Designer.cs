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
            lblName = new Label();
            lblPrice = new Label();
            lblSubTotal = new Label();
            numericUpDown1 = new NumericUpDown();
            btnReturnToShop = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCartItems).BeginInit();
            grpCartDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dgvCartItems
            // 
            dgvCartItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCartItems.Location = new Point(12, 12);
            dgvCartItems.Name = "dgvCartItems";
            dgvCartItems.Size = new Size(468, 276);
            dgvCartItems.TabIndex = 0;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(50, 318);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(85, 15);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Total Price: $$$";
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.Enabled = false;
            btnRemoveItem.Location = new Point(12, 362);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(121, 51);
            btnRemoveItem.TabIndex = 2;
            btnRemoveItem.Text = "Remove Item";
            btnRemoveItem.UseVisualStyleBackColor = true;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(185, 362);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(121, 51);
            btnCheckout.TabIndex = 3;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = true;
            // 
            // btnUpdateItem
            // 
            btnUpdateItem.Location = new Point(170, 336);
            btnUpdateItem.Name = "btnUpdateItem";
            btnUpdateItem.Size = new Size(73, 46);
            btnUpdateItem.TabIndex = 4;
            btnUpdateItem.Text = "Update Item";
            btnUpdateItem.UseVisualStyleBackColor = true;
            // 
            // grpCartDetails
            // 
            grpCartDetails.Controls.Add(numericUpDown1);
            grpCartDetails.Controls.Add(btnUpdateItem);
            grpCartDetails.Controls.Add(lblSubTotal);
            grpCartDetails.Controls.Add(lblPrice);
            grpCartDetails.Controls.Add(lblName);
            grpCartDetails.Location = new Point(522, 12);
            grpCartDetails.Name = "grpCartDetails";
            grpCartDetails.Size = new Size(266, 402);
            grpCartDetails.TabIndex = 5;
            grpCartDetails.TabStop = false;
            grpCartDetails.Text = "Cart Item Details";
            grpCartDetails.Visible = false;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(23, 50);
            lblName.Name = "lblName";
            lblName.Size = new Size(84, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Product Name";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(20, 103);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(81, 15);
            lblPrice.TabIndex = 1;
            lblPrice.Text = " Product Price";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Location = new Point(22, 153);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(55, 15);
            lblSubTotal.TabIndex = 2;
            lblSubTotal.Text = "Sub Total";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(23, 350);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 3;
            // 
            // btnReturnToShop
            // 
            btnReturnToShop.Location = new Point(359, 362);
            btnReturnToShop.Name = "btnReturnToShop";
            btnReturnToShop.Size = new Size(121, 51);
            btnReturnToShop.TabIndex = 4;
            btnReturnToShop.Text = "Return to Shop";
            btnReturnToShop.UseVisualStyleBackColor = true;
            // 
            // CartForm
            // 
            AcceptButton = btnCheckout;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnReturnToShop;
            ClientSize = new Size(800, 426);
            Controls.Add(btnReturnToShop);
            Controls.Add(grpCartDetails);
            Controls.Add(btnCheckout);
            Controls.Add(btnRemoveItem);
            Controls.Add(lblTotal);
            Controls.Add(dgvCartItems);
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