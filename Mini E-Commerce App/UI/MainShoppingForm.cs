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
        public MainShoppingForm()
        {
            InitializeComponent();
        }
        private Cart cart = new Cart();

        private void MainShoppingForm_Load(object sender, EventArgs e)
        {
            btnAddCart.Enabled = true;
            LoadSampleData();
            LoadProducts();
        }

        //This is temporary sample code to test is my product.cs is going to work with products
        private Inventory inventory = new Inventory();

        private void LoadSampleData()
        {
            inventory.AddProduct(new PhysicalProduct
            {
                Id = 1,
                Name = "Laptop",
                _price = 1200,
                Description = "Gaming Laptop",
                StockQuantity = 5,
                HasDiscount = true,
                DiscountPercentage = 10
            });

            inventory.AddProduct(new DigitalProduct
            {
                Id = 2,
                Name = "E-Book",
                _price = 25,
                Description = "C# Guide",
                FileSizeMB = 3.2,
                HasDiscount = false
            });
        }

        private void LoadProducts()
        {
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = inventory.GetAllProducts();
        }

        private void dgvProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow != null)
            {
                Product? product = (Product)dgvProducts.CurrentRow.DataBoundItem;

                lblName.Text = product.Name;
                lblPrice.Text = product.GetFinalPrice().ToString("C");
                lblType.Text = product.GetProductType();
                lblDescription.Text = product.Description;
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

        //This is the end of my sample data
    }
}
