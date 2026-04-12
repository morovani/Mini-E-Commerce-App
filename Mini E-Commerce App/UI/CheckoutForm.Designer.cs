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
            cmbStatus = new ComboBox();
            btnPayment = new Button();
            lblDiscountSummary = new Label();
            grpPaymentSummary = new GroupBox();
            lblFinalTotal = new Label();
            label1 = new Label();
            txtCardInfo = new TextBox();
            lblNet = new Label();
            lblTaxSummary = new Label();
            btnReturnToCart = new Button();
            grpPaymentSummary.SuspendLayout();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(12, 34);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(54, 21);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Status: ";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Pending", "Paid", "Failed" });
            cmbStatus.Location = new Point(63, 30);
            cmbStatus.Margin = new Padding(3, 4, 3, 4);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(121, 29);
            cmbStatus.TabIndex = 1;
            cmbStatus.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
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
            btnPayment.Click += btnPayment_Click;
            // 
            // lblDiscountSummary
            // 
            lblDiscountSummary.AutoSize = true;
            lblDiscountSummary.BorderStyle = BorderStyle.Fixed3D;
            lblDiscountSummary.Location = new Point(16, 32);
            lblDiscountSummary.Name = "lblDiscountSummary";
            lblDiscountSummary.Size = new Size(99, 23);
            lblDiscountSummary.TabIndex = 0;
            lblDiscountSummary.Text = "Discount: $$$";
            // 
            // grpPaymentSummary
            // 
            grpPaymentSummary.Controls.Add(lblFinalTotal);
            grpPaymentSummary.Controls.Add(label1);
            grpPaymentSummary.Controls.Add(txtCardInfo);
            grpPaymentSummary.Controls.Add(lblNet);
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
            grpPaymentSummary.Enter += grpPaymentSummary_Enter;
            // 
            // lblFinalTotal
            // 
            lblFinalTotal.AutoSize = true;
            lblFinalTotal.BorderStyle = BorderStyle.Fixed3D;
            lblFinalTotal.Location = new Point(16, 173);
            lblFinalTotal.Name = "lblFinalTotal";
            lblFinalTotal.Size = new Size(105, 23);
            lblFinalTotal.TabIndex = 5;
            lblFinalTotal.Text = "Final Total: $$$";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(6, 217);
            label1.Name = "label1";
            label1.Size = new Size(88, 23);
            label1.TabIndex = 4;
            label1.Text = "Card Details";
            // 
            // txtCardInfo
            // 
            txtCardInfo.Location = new Point(6, 239);
            txtCardInfo.Margin = new Padding(3, 4, 3, 4);
            txtCardInfo.MaxLength = 16;
            txtCardInfo.Name = "txtCardInfo";
            txtCardInfo.Size = new Size(233, 25);
            txtCardInfo.TabIndex = 3;
            txtCardInfo.TextChanged += txtCardInfo_TextChanged;
            // 
            // lblNet
            // 
            lblNet.AutoSize = true;
            lblNet.BorderStyle = BorderStyle.Fixed3D;
            lblNet.Location = new Point(16, 126);
            lblNet.Name = "lblNet";
            lblNet.Size = new Size(102, 23);
            lblNet.TabIndex = 2;
            lblNet.Text = "Net Total: $$$";
            // 
            // lblTaxSummary
            // 
            lblTaxSummary.AutoSize = true;
            lblTaxSummary.BorderStyle = BorderStyle.Fixed3D;
            lblTaxSummary.Location = new Point(16, 79);
            lblTaxSummary.Name = "lblTaxSummary";
            lblTaxSummary.Size = new Size(106, 23);
            lblTaxSummary.TabIndex = 1;
            lblTaxSummary.Text = "Tax (15%): $$$";
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
            btnReturnToCart.Click += btnReturnToCart_Click;
            // 
            // CheckoutForm
            // 
            AcceptButton = btnPayment;
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnReturnToCart;
            ClientSize = new Size(676, 628);
            Controls.Add(btnReturnToCart);
            Controls.Add(grpPaymentSummary);
            Controls.Add(btnPayment);
            Controls.Add(cmbStatus);
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
        private ComboBox cmbStatus;
        private Button btnPayment;
        private Label lblDiscountSummary;
        private GroupBox grpPaymentSummary;
        private Label lblFinalTotal;
        private Label lblTaxSummary;
        private Label lblNet;
        private TextBox txtCardInfo;
        private Button btnReturnToCart;
        private Label label1;
    }
}