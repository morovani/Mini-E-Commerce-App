using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Mini_E_Commerce_App.Models;
using Mini_E_Commerce_App.Services;

namespace Mini_E_Commerce_App
{
    public partial class MainShoppingForm : Form
    {
        public MainShoppingForm(Customer customer, Cart cart)
        {
            InitializeComponent();
            currentCustomer = customer;
            this.cart = cart;
        }
        Cart cart = new Cart();
        Customer currentCustomer;
        Inventory inventory = new Inventory();

        private void MainShoppingForm_Load(object sender, EventArgs e)
        {
            inventory.Load();
            dgvProducts.DataSource = inventory.Products;
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            grpProductDetails.Show();
            if (dgvProducts.CurrentRow != null)
            {
                Product? product = (Product)dgvProducts.CurrentRow.DataBoundItem;

                lblName.Text = product.Name;
                lblPrice.Text = product.GetFinalPrice().ToString("C");
                lblStock.Text = $"Stock: {product.Stock}";

            }
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow != null)
            {
                Product? product = (Product)dgvProducts.CurrentRow.DataBoundItem;
                int quantity = (int)nudQuantity.Value;

                cart.AddProduct(product, quantity);

                MessageBox.Show("Product added to cart!");
            }

        }

        private void btnViewCart_Click(object sender, EventArgs e)
        {
            CartForm form = new CartForm(cart, currentCustomer);
            form.Show();
            this.Hide();
        }
    }
}
    
