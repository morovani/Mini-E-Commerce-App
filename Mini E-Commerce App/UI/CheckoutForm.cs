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
        private Cart cart;
        private Customer currentCustomer;
        public CheckoutForm()
        {
            InitializeComponent();
        }

        public CheckoutForm(Cart cart, Customer customer)
        {
            InitializeComponent();
            this.cart = cart;
            this.currentCustomer = customer;
        }

        private void CheckoutForm_Load(object sender, EventArgs e)
        {
            LoadSummary();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            {
                Order order = CreateOrder(cart, currentCustomer);

                Payment payment = new Payment
                {
                    Amount = order.GetTotal(),
                    CardNumber = txtCardInfo.Text
                };

                if (payment.ProcessPayment())
                {
                    MessageBox.Show("Payment successful!");
                }
                else
                {
                    MessageBox.Show("Payment failed!");
                }
            }
        }
        private Order CreateOrder(Cart cart, Customer customer)
        {
            Order order = new Order();
            order.Customer = customer;

            foreach (var item in cart.Items)
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

            decimal total = order.Items.Sum(i => i.GetSubtotal());
            decimal finalTotal = order.GetTotal();
            decimal discount = total - finalTotal;

            lblDiscountSummary.Text = discount.ToString("C");
            lblFinalTotal.Text = finalTotal.ToString("C");
        }

        private void grpPaymentSummary_Enter(object sender, EventArgs e)
        {

        }
    }
}

