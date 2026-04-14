using Mini_E_Commerce_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Mini_E_Commerce_App.Services
{
    public partial class CheckoutForm : Form

    {
        Cart cart;
        Customer currentCustomer;
        public CheckoutForm(Cart cart, Customer customer)
        {
            InitializeComponent();
            this.cart = cart;
            this.currentCustomer = customer;
        }

        private void CheckoutForm_Load(object sender, EventArgs e)
        {
            StyleForm();

            StyleComboBox(cmbStatus);
            StyleTextBox(txtCardInfo);
            StyleGroupBox(grpPaymentSummary);

            StyleButton(btnPayment, Color.FromArgb(46, 204, 113));
            StyleButton(btnReturnToCart, Color.FromArgb(108, 117, 125));

            lblFinalTotal.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblFinalTotal.ForeColor = Color.FromArgb(39, 174, 96);

            lblStatus.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            LoadSummary();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            try
            {
                Order order = CreateOrder(cart, currentCustomer);

                Payment payment = new Payment
                {
                    Amount = order.GetTotal(),
                    CardNumber = txtCardInfo.Text
                };

                if (payment.ProcessPayment())
                {
                    File.AppendAllText("orders.txt", $"{currentCustomer.Name},{order.GetTotal()}\n");
                    MessageBox.Show("Payment successful!");
                    lblFinalTotal.Text = "";
                    txtCardInfo.Text = "";
                    lblDiscountSummary.Text = "";
                }
                else
                {
                    MessageBox.Show("Payment failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private Order CreateOrder(Cart cart, Customer customer)
        {
            Order order = new Order();
            order.Customer = customer;

            foreach (var item in cart.items)
            {
                order.Items.Add(new OrderItem
                {
                    Product = item.Product,
                    Quantity = item.Quantity
                });
            }

            return order;
        }

        private void txtCardInfo_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoadSummary()
        {
            Order order = CreateOrder(cart, currentCustomer);

            decimal finalTotal = order.GetTotal();
            decimal discount = cart.GetTotal() - finalTotal;

            lblDiscountSummary.Text = discount.ToString("C");
            lblFinalTotal.Text = finalTotal.ToString("C");
        }

        private void grpPaymentSummary_Enter(object sender, EventArgs e)
        {

        }

        private void btnReturnToCart_Click(object sender, EventArgs e)
        {
            CartForm form = new CartForm(cart, currentCustomer);
            form.Show();
            this.Hide();
        }
        private void StyleForm()
        {
            this.BackColor = Color.FromArgb(245, 247, 250);
            this.ForeColor = Color.FromArgb(44, 62, 80);
            this.Font = new Font("Segoe UI", 10, FontStyle.Regular);
        }
        private void StyleButton(Button btn, Color backColor)
        {
            btn.BackColor = backColor;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;
        }
        private void StyleTextBox(TextBox txt)
        {
            txt.BackColor = Color.White;
            txt.ForeColor = Color.FromArgb(44, 62, 80);
            txt.BorderStyle = BorderStyle.FixedSingle;
        }

        private void StyleComboBox(ComboBox cbo)
        {
            cbo.BackColor = Color.White;
            cbo.ForeColor = Color.FromArgb(44, 62, 80);
            cbo.FlatStyle = FlatStyle.Flat;
        }
        private void StyleGroupBox(GroupBox grp)
        {
            grp.BackColor = Color.White;
            grp.ForeColor = Color.FromArgb(44, 62, 80);
            grp.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

