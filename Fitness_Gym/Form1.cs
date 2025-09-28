using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Fitness_Gym
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Center the form and set focus to username field
            this.StartPosition = FormStartPosition.CenterScreen;
            usernameTb.Focus();
        }


        private void UserLogin()
        {
            if (string.IsNullOrWhiteSpace(usernameTb.Text) || string.IsNullOrWhiteSpace(passwordTb.Text))
            {
                MessageBox.Show("Please enter both username and password.", "Input Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
<<<<<<< Updated upstream
                using SqlConnection conn = new("Data Source=DESKTOP-IL390HQ\\SQLEXPRESS;Initial Catalog = PalenersGym;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
=======
                //sql
                using SqlConnection conn = new("Data Source=DESKTOP-IL390HQ\\SQLEXPRESS;Initial Catalog=PalenersGym;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
>>>>>>> Stashed changes
                conn.Open();
                string query = "SELECT user_role FROM Account WHERE user_name=@username AND user_password=@password";
                using SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@username", usernameTb.Text);
                cmd.Parameters.AddWithValue("@password", HashPassword(passwordTb.Text)); // Hash the input password

                using SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string role = reader["user_role"].ToString();
                    if (!string.IsNullOrEmpty(role))
                    {
                        MessageBox.Show($"{role} login successful!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        usernameTb.Clear();
                        passwordTb.Clear();
                        // Navigate to Dashboard
                        MainForm mainform = new MainForm();
                        mainform.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "Login Failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string HashPassword(string password)
        {
            using SHA256 sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            StringBuilder builder = new();
            foreach (byte b in bytes)
            {
                builder.Append(b.ToString("x2"));
            }
            return builder.ToString();
        }

    

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Fitness Gym!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Stay fit, stay healthy!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void usernameTb_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add real-time validation if needed
        }

        private void passwordTb_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add real-time validation if needed
        }

        private void ShowPasswordBtn_Click(object sender, EventArgs e)
        {
            passwordTb.PasswordChar = passwordTb.PasswordChar == '*' ? '\0' : '*';
            ShowPasswordBtn.Text = passwordTb.PasswordChar == '*' ? "👁️" : "🙈";
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            // Optional: Custom painting for panel7 if needed
        }

        private void loginPanel_Paint(object sender, PaintEventArgs e)
        {
            // Optional: Custom painting for loginPanel if needed
        }

        private void ForgetAccLbl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact support at support@fitnessgym.com to reset your account.",
                "Forgot Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void createNewAccBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Navigating to Create New Account form (to be implemented).",
                "Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Implement navigation to a Create Account form if exists
            // Example: new CreateAccountForm().Show(); this.Hide();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void usernamebtn_Click(object sender, EventArgs e)
        {
            UserLogin(); // call your login method
        }

    }
}