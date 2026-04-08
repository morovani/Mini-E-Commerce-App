using Mini_E_Commerce_App.Models;
using Mini_E_Commerce_App.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Mini_E_Commerce_App
{
    public partial class CartForm : Form
    {
        Cart cart;
        Customer currentCustomer;
        public CartForm(Cart cart, Customer customer)
        {
            InitializeComponent();
            this.cart = cart;
            this.currentCustomer = customer;
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            dgvCartItems.DataSource = null;
            dgvCartItems.DataSource = cart.items;

            lblTotal.Text = cart.GetTotal().ToString("C");
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            if (dgvCartItems.CurrentRow == null)
            {
                MessageBox.Show("Please select an item to update.");
                return;
            }
            CartItem item = (CartItem)dgvCartItems.CurrentRow.DataBoundItem;
            item.Quantity = (int)numericUpDown1.Value;

            dgvCartItems.Refresh();
            lblSubTotal.Text = item.GetSubtotal().ToString("C");
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvCartItems.CurrentRow == null)
            {
                MessageBox.Show("Please select an item to remove.");
                return;
            }
            CartItem item = (CartItem)dgvCartItems.CurrentRow.DataBoundItem;
            cart.items.Remove(item);
            
            dgvCartItems.DataSource = null;
            dgvCartItems.DataSource = cart.items;

            lblTotal.Text = cart.GetTotal().ToString("C");
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            CheckoutForm form = new CheckoutForm(cart, currentCustomer);
            form.Show();
            this.Hide();
        }

        private void btnReturnToShop_Click(object sender, EventArgs e)
        {
            MainShoppingForm mainForm = new MainShoppingForm(currentCustomer, cart);
            mainForm.Show();
            this.Hide();
        }

        private void dgvCartItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCartItems_SelectionChanged(object sender, EventArgs e)
        {
            grpCartDetails.Show();
            if (dgvCartItems.CurrentRow != null)
            {
                CartItem item = (CartItem)dgvCartItems.CurrentRow.DataBoundItem;
                lblName.Text = item.Product.Name;
                lblPrice.Text = item.Product.Price.ToString("C");
                lblSubTotal.Text = item.GetSubtotal().ToString("C");
                numericUpDown1.Value = item.Quantity;
            }
        }
    }
}
