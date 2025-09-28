using Microsoft.Data.SqlClient;
using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Fitness_Gym
{
    public partial class Register : Form
    {
        private string connectionString = "Data Source=PC13\\SQLEXPRESS;Initial Catalog=PalenersGym;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public Register()
        {
            InitializeComponent();

            // Set up password masking by default
            passTb.PasswordChar = '*';
            confirmPassTb.PasswordChar = '*';

            // Set default selection to "Member" without triggering the change event
            roleCb.SelectedIndex = 0;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            // Center the form and set focus to username field
            this.StartPosition = FormStartPosition.CenterScreen;
            usernameTb.Focus();
        }

        // Check if username is already taken
        private bool IsUsernameTaken(string username)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                string query = "SELECT COUNT(*) FROM Account WHERE user_name = @username";
                using SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);

                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking username: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true; // Assume taken to prevent registration on error
            }
        }

        // Hash password using SHA256 (same as login form)
        private string HashPassword(string password)
        {
            using SHA256 sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder builder = new StringBuilder();
            foreach (byte b in bytes)
            {
                builder.Append(b.ToString("x2"));
            }
            return builder.ToString();
        }

        // Validate all input fields
        private bool ValidateInputs()
        {
            // Check for empty fields
            if (string.IsNullOrWhiteSpace(usernameTb.Text) ||
                string.IsNullOrWhiteSpace(passTb.Text) ||
                string.IsNullOrWhiteSpace(confirmPassTb.Text) ||
                roleCb.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields.", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Check username length
            if (usernameTb.Text.Length < 3)
            {
                MessageBox.Show("Username must be at least 3 characters long.",
                    "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usernameTb.Focus();
                usernameTb.SelectAll();
                return false;
            }

            // Check username availability
            if (IsUsernameTaken(usernameTb.Text))
            {
                MessageBox.Show("Username is already taken. Please choose a different username.",
                    "Username Taken", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usernameTb.Focus();
                usernameTb.SelectAll();
                return false;
            }

            // Check password match
            if (passTb.Text != confirmPassTb.Text)
            {
                MessageBox.Show("Passwords do not match. Please confirm your password.",
                    "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                confirmPassTb.Focus();
                confirmPassTb.SelectAll();
                return false;
            }

            // Check password strength
            if (passTb.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.",
                    "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                passTb.Focus();
                passTb.SelectAll();
                return false;
            }

            return true;
        }

        // Register new user account
        private void RegisterUserAccount()
        {
            if (!ValidateInputs())
                return;

            try
            {
                using SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                // Insert into Account table
                string query = @"INSERT INTO Account (user_name, user_password, user_role) 
                               VALUES (@username, @password, @role)";
                using SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", usernameTb.Text);
                cmd.Parameters.AddWithValue("@password", HashPassword(passTb.Text));
                cmd.Parameters.AddWithValue("@role", roleCb.SelectedItem.ToString());

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Registration successful! You can now login with your credentials.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Close this form and return to login
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Registration failed. Please try again.",
                        "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during registration: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Create Account Button Click
        private void createNewAccBtn_Click(object sender, EventArgs e)
        {
            RegisterUserAccount();
        }

        // Username Text Changed - Real-time validation
        private void usernameTb_TextChanged(object sender, EventArgs e)
        {
            if (usernameTb.Text.Length > 0)
            {
                // Visual feedback for username length
                if (usernameTb.Text.Length < 3)
                {
                    usernameTb.ForeColor = Color.Red;
                }
                else
                {
                    usernameTb.ForeColor = Color.Black;
                }
            }
            else
            {
                usernameTb.ForeColor = Color.Black;
            }
        }

        // Show/Hide Password Button
        private void ShowPasswordBtn_Click(object sender, EventArgs e)
        {
            passTb.PasswordChar = passTb.PasswordChar == '*' ? '\0' : '*';
            ShowPasswordBtn.Text = passTb.PasswordChar == '*' ? "👁️" : "🙈";
        }

        // Password Text Changed - Real-time strength indicator
        private void passTb_TextChanged(object sender, EventArgs e)
        {
            if (passTb.Text.Length > 0)
            {
                // Visual feedback for password strength
                if (passTb.Text.Length < 6)
                {
                    passTb.ForeColor = Color.Red;
                }
                else if (passTb.Text.Length < 8)
                {
                    passTb.ForeColor = Color.Orange;
                }
                else
                {
                    passTb.ForeColor = Color.Green;
                }
            }
            else
            {
                passTb.ForeColor = Color.Black;
            }
        }

        // Confirm Password Text Changed - Real-time validation
        private void confirmPassTb_TextChanged(object sender, EventArgs e)
        {
            if (confirmPassTb.Text.Length > 0 && passTb.Text.Length > 0)
            {
                if (confirmPassTb.Text != passTb.Text)
                {
                    confirmPassTb.ForeColor = Color.Red;
                }
                else
                {
                    confirmPassTb.ForeColor = Color.Green;
                }
            }
            else
            {
                confirmPassTb.ForeColor = Color.Black;
            }
        }

        // Role ComboBox Changed
        private void roleCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Back to Login button (add this method if you have a back button)
        private void backToLoginBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            // Optional: Custom painting for panel7 if needed
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // If this is another field, add appropriate validation
        }

        private void backtologin_Click(object sender, EventArgs e)
        {
            // Ask for confirmation if user has entered any data
            if (!string.IsNullOrEmpty(usernameTb.Text) || !string.IsNullOrEmpty(passTb.Text))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to go back to login? Any unsaved data will be lost.",
                    "Confirm Exit",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }
            else
            {
                // No data entered, just close directly
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}