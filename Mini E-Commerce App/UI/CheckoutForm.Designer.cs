namespace Mini_E_Commerce_App.Services
{
    partial class CheckoutForm
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
            lblStatus = new Label();
            comboBox1 = new ComboBox();
            btnPayment = new Button();
            lblDiscountSummary = new Label();
            grpPaymentSummary = new GroupBox();
            lblTaxSummary = new Label();
            lblSummary = new Label();
            txtCardInfo = new TextBox();
            btnReturnToCart = new Button();
            label1 = new Label();
            grpPaymentSummary.SuspendLayout();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 34);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(44, 18);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Status: ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(63, 30);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 26);
            comboBox1.TabIndex = 1;
            // 
            // btnPayment
            // 
            btnPayment.Location = new Point(12, 367);
            btnPayment.Margin = new Padding(3, 4, 3, 4);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(92, 59);
            btnPayment.TabIndex = 3;
            btnPayment.Text = "Confirm Payment";
            btnPayment.UseVisualStyleBackColor = true;
            // 
            // lblDiscountSummary
            // 
            lblDiscountSummary.AutoSize = true;
            lblDiscountSummary.BorderStyle = BorderStyle.Fixed3D;
            lblDiscountSummary.Location = new Point(16, 47);
            lblDiscountSummary.Name = "lblDiscountSummary";
            lblDiscountSummary.Size = new Size(82, 20);
            lblDiscountSummary.TabIndex = 0;
            lblDiscountSummary.Text = "Discount: $$$";
            // 
            // grpPaymentSummary
            // 
            grpPaymentSummary.Controls.Add(label1);
            grpPaymentSummary.Controls.Add(txtCardInfo);
            grpPaymentSummary.Controls.Add(lblSummary);
            grpPaymentSummary.Controls.Add(lblTaxSummary);
            grpPaymentSummary.Controls.Add(lblDiscountSummary);
            grpPaymentSummary.Location = new Point(12, 68);
            grpPaymentSummary.Margin = new Padding(3, 4, 3, 4);
            grpPaymentSummary.Name = "grpPaymentSummary";
            grpPaymentSummary.Padding = new Padding(3, 4, 3, 4);
            grpPaymentSummary.Size = new Size(245, 277);
            grpPaymentSummary.TabIndex = 2;
            grpPaymentSummary.TabStop = false;
            grpPaymentSummary.Text = "Payment Summary";
            // 
            // lblTaxSummary
            // 
            lblTaxSummary.AutoSize = true;
            lblTaxSummary.BorderStyle = BorderStyle.Fixed3D;
            lblTaxSummary.Location = new Point(16, 107);
            lblTaxSummary.Name = "lblTaxSummary";
            lblTaxSummary.Size = new Size(86, 20);
            lblTaxSummary.TabIndex = 1;
            lblTaxSummary.Text = "Tax (15%): $$$";
            // 
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.BorderStyle = BorderStyle.Fixed3D;
            lblSummary.Location = new Point(16, 173);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(85, 20);
            lblSummary.TabIndex = 2;
            lblSummary.Text = "Net Total: $$$";
            // 
            // txtCardInfo
            // 
            txtCardInfo.Location = new Point(6, 239);
            txtCardInfo.Margin = new Padding(3, 4, 3, 4);
            txtCardInfo.Name = "txtCardInfo";
            txtCardInfo.Size = new Size(233, 21);
            txtCardInfo.TabIndex = 3;
            // 
            // btnReturnToCart
            // 
            btnReturnToCart.Location = new Point(159, 367);
            btnReturnToCart.Margin = new Padding(3, 4, 3, 4);
            btnReturnToCart.Name = "btnReturnToCart";
            btnReturnToCart.Size = new Size(92, 59);
            btnReturnToCart.TabIndex = 4;
            btnReturnToCart.Text = "Back To Cart";
            btnReturnToCart.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(6, 217);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 4;
            label1.Text = "Card Details";
            // 
            // CheckoutForm
            // 
            AcceptButton = btnPayment;
            AutoScaleDimensions = new SizeF(7F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnReturnToCart;
            ClientSize = new Size(269, 439);
            Controls.Add(btnReturnToCart);
            Controls.Add(grpPaymentSummary);
            Controls.Add(btnPayment);
            Controls.Add(comboBox1);
            Controls.Add(lblStatus);
            Font = new Font("Gill Sans MT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CheckoutForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Checkout";
            Load += CheckoutForm_Load;
            grpPaymentSummary.ResumeLayout(false);
            grpPaymentSummary.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStatus;
        private ComboBox comboBox1;
        private Button btnPayment;
        private Label lblDiscountSummary;
        private GroupBox grpPaymentSummary;
        private Label label2;
        private Label lblTaxSummary;
        private Label lblSummary;
        private TextBox txtCardInfo;
        private Button btnReturnToCart;
        private Label label1;
    }
}