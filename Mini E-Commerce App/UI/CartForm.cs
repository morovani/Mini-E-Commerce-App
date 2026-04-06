using Mini_E_Commerce_App.Models;
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
        private Cart cart;
        public CartForm(Cart cart)
        {
            InitializeComponent();
            this.cart = cart;
        }

        private void CartForm_Load(object sender, EventArgs e)
        {

        }
        private void LoadCart()
        {
            dgvCartItems.DataSource = null;
            dgvCartItems.DataSource = cart.Items;

            lblTotal.Text = cart.GetTotal().ToString("C");
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            CartItem item = (CartItem)dgvCartItems.CurrentRow.DataBoundItem;
            int newQty = (int)numericUpDown1.Value;

            cart.UpdateQuantity(item.Product, newQty);

            LoadCart();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            CartItem item = (CartItem)dgvCartItems.CurrentRow.DataBoundItem;

            cart.RemoveProduct(item.Product);

            LoadCart();

        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            
        }
    }
}
