using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Gym
{

    public partial class MainForm : Form
    {
        private Form? activeForm;
        public MainForm()
        {
            InitializeComponent();

        }
        private void OpenChildForm(Form childForm)
        {
            try
            {
                // Check if panel_child exists
                if (panel_child == null)
                {
                    MessageBox.Show("panel_child is not initialized. Check your designer code.");
                    return;
                }

                // Close the current active form if it exists
                if (activeForm != null)
                {
                    activeForm.Close();
                    activeForm = null;
                }

                // Configure the new child form
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;

                // Clear existing controls and add the new form
                panel_child.Controls.Clear();
                panel_child.Controls.Add(childForm);
                panel_child.Tag = childForm;

                // Show the form
                childForm.Show();
                childForm.BringToFront();

                // Set as active form
                activeForm = childForm;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Dashboard());
        }

        private void sidebar_button_dashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Dashboard());
        }

        private void sidebar_button_payments_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Payments());
        }

        private void sidebar_button_members_Click(object sender, EventArgs e)
        {
                OpenChildForm(new Forms.Member());
        }

        private void sidebar_button_refferal_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Refferal());
        }

        private void sidebar_button_feedback_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Feedback());
        }

        private void sidebar_button_reports_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Reports());
        }

        private void sidebar_button_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Find the existing LoginForm instance or create a new one
                LoginForm loginForm = Application.OpenForms.OfType<LoginForm>().FirstOrDefault();

                if (loginForm == null)
                {
                    loginForm = new LoginForm();
                }

                loginForm.Show(); // Show the login form
                this.Hide(); // Hide the main form instead of closing it
            }
        }

        private void sidebar_button_plan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Membership());
        }

        private void ButtonHoverEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.FromArgb(255, 217, 64);
            btn.ForeColor = Color.Black;
        }

        private void ButtonHoverLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Transparent;
            btn.ForeColor = SystemColors.Control;
        }

    }
}
