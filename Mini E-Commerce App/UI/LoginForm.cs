using Mini_E_Commerce_App.Models;
using Mini_E_Commerce_App.Services;

namespace Mini_E_Commerce_App
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        AuthService AuthService = new AuthService();

        private void LoginForm_Load(object sender, EventArgs e)
        {
            StyleForm();

            StyleTextBox(txtUsername);
            StyleTextBox(txtEmail);
            StyleTextBox(txtPassword);

            StyleButton(btnLogin, Color.FromArgb(52, 152, 219));
            StyleButton(button2, Color.FromArgb(46, 204, 113));

            label1.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            label2.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            label3.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            lblErrorMessage.ForeColor = Color.Red;
            txtPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try 
            {
                var user = AuthService.Login(txtEmail.Text, txtPassword.Text);
                if (user != null)
                {
                    Cart cart = new Cart();
                    MainShoppingForm mainForm = new MainShoppingForm(user, cart);
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
            catch (Exception ex) 
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

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
    }
}
