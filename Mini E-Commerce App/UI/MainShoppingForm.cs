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
        List<Product> allProducts = new List<Product>();

        private void MainShoppingForm_Load(object sender, EventArgs e)
        {
            StyleForm();

            StyleTextBox(txtSearch);
            StyleComboBox(cboCategory);
            StyleGroupBox(grpProductDetails);
            StyleGrid(dgvProducts);

            StyleButton(btnAddCart, Color.FromArgb(46, 204, 113));
            StyleButton(btnViewCart, Color.FromArgb(52, 152, 219));
            StyleButton(btnSearch, Color.FromArgb(52, 73, 94));
            StyleButton(btnLogout, Color.FromArgb(231, 76, 60));

            lblWelcome.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(44, 62, 80);

            inventory.Load();
            allProducts = inventory.Products;

            dgvProducts.DataSource = allProducts;
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
        private void StyleGrid(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.EnableHeadersVisualStyles = false;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(44, 62, 80);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(174, 214, 241);
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgv.RowHeadersVisible = false;
            dgv.GridColor = Color.LightGray;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.ToLower();

            var filtered = allProducts
                .Where(p => p.Name.ToLower().Contains(keyword))
                .ToList();

            dgvProducts.DataSource = null;
            dgvProducts.DataSource = filtered;

        }

        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    
