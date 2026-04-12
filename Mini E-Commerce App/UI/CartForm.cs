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
            StyleForm();

            StyleGrid(dgvCartItems);
            StyleGroupBox(grpCartDetails);

            StyleButton(btnRemoveItem, Color.FromArgb(231, 76, 60));
            StyleButton(btnCheckout, Color.FromArgb(46, 204, 113));
            StyleButton(btnReturnToShop, Color.FromArgb(108, 117, 125));
            StyleButton(btnUpdateItem, Color.FromArgb(243, 156, 18));

            lblTotal.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(44, 62, 80);

            numericUpDown1.BackColor = Color.White;
            numericUpDown1.ForeColor = Color.FromArgb(44, 62, 80);

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
            if (dgvCartItems.Rows.Count == 0 || dgvCartItems.CurrentRow == null)
            {
                MessageBox.Show("Please select an item to remove.");
                return;
            }

            int rowIndex = dgvCartItems.CurrentRow.Index;

            if (rowIndex < 0 || rowIndex >= cart.items.Count)
                return;

            cart.items.RemoveAt(rowIndex);

            dgvCartItems.DataSource = null;
            dgvCartItems.DataSource = cart.items;

            lblTotal.Text = cart.GetTotal().ToString("C");

            if (cart.items.Count == 0)
            {
                grpCartDetails.Hide();
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            CheckoutForm form = new CheckoutForm(cart, currentCustomer);
            if (dgvCartItems.Rows.Count == 0 || dgvCartItems.CurrentRow == null)
            {
                MessageBox.Show("Please select an item to checkout.");
                return;
            }
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
            if (dgvCartItems.Rows.Count == 0 || dgvCartItems.CurrentRow == null)
            {
                grpCartDetails.Hide();
                return;
            }

            int rowIndex = dgvCartItems.CurrentRow.Index;

            if (rowIndex < 0 || rowIndex >= cart.items.Count)
            {
                grpCartDetails.Hide();
                return;
            }

            CartItem selectedItem = cart.items[rowIndex];

            grpCartDetails.Show();
            lblName.Text = selectedItem.Product.Name;
            lblPrice.Text = selectedItem.Product.GetFinalPrice().ToString("C");
            lblSubTotal.Text = selectedItem.GetSubtotal().ToString("C");
            numericUpDown1.Value = selectedItem.Quantity;
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
    }
}
