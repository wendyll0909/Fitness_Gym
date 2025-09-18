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
    public partial class Dashboard : Form
    {
        private List<Member> members; // In-memory storage for members
        private int nextMemberId = 1; // Simple ID generator

        public Dashboard()
        {
            InitializeComponent();
            members = new List<Member>();
            InitializeMembershipPlans();
            LoadMembersToGrid();
        }

        // Member class to store member data
        private class Member
        {
            public int MemberID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
            public DateTime JoinDate { get; set; }
            public string MembershipPlan { get; set; }
            public string EmergencyContact { get; set; }
        }

        private void InitializeMembershipPlans()
        {
            memPlanComboBox1.Items.AddRange(new string[] { "Basic", "Premium", "Family" });
            memPlanComboBox1.SelectedIndex = 0; // Default selection
        }

        private void LoadMembersToGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (var member in members)
            {
                dataGridView1.Rows.Add(member.MemberID, member.FirstName, member.LastName,
                    member.Email, member.Phone, member.Address, member.JoinDate.ToShortDateString(),
                    member.MembershipPlan, member.EmergencyContact);
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Set default values or load initial data
            joinDateDateTimePicker1.Value = DateTime.Now;
        }

        private void file_Click(object sender, EventArgs e)
        {
            MessageBox.Show("File menu clicked. Implement file operations like save/load here.",
                "File Menu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Help: Use this dashboard to manage gym members. Contact support at support@fitnessgym.com.",
                "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fitness Gym Dashboard v1.0\nDeveloped for gym management.\n© 2025 Fitness Gym",
                "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void logo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fitness Gym Logo clicked!", "Logo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {
            // Optional: Custom painting for sidebar if needed
        }

        private void memberSideBar_Click(object sender, EventArgs e)
        {
            // Already on Member Registration, just highlight or reset form
            ClearForm();
            MessageBox.Show("Member Registration section is active.", "Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void billingSideBar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Navigating to Billing and Payments section (to be implemented).",
                "Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Implement navigation to Billing form if exists
        }

        private void referralSideBar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Navigating to Referral Program section (to be implemented).",
                "Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Implement navigation to Referral form if exists
        }

        private void feedbackSideBar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Navigating to Feedback Management section (to be implemented).",
                "Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Implement navigation to Feedback form if exists
        }

        private void reportsSideBar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Navigating to Reports Dashboard section (to be implemented).",
                "Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Implement navigation to Reports form if exists
        }

        private void logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close(); // Close the dashboard, or navigate to login form
            }
        }

        private void fnameLbl_Click(object sender, EventArgs e)
        {
            fnameTxtBox.Focus(); // Focus on corresponding text box
        }

        private void lnameLbl_Click(object sender, EventArgs e)
        {
            lnameTxtBox.Focus();
        }

        private void emailLbl_Click(object sender, EventArgs e)
        {
            emailTxtBox.Focus();
        }

        private void phoneLbl_Click(object sender, EventArgs e)
        {
            phoneTxtBox.Focus();
        }

        private void addressLbl_Click(object sender, EventArgs e)
        {
            addressTxtBox.Focus();
        }

        private void joinDateLbl_Click(object sender, EventArgs e)
        {
            joinDateDateTimePicker1.Focus();
        }

        private void memPlanLbl_Click(object sender, EventArgs e)
        {
            memPlanComboBox1.Focus();
        }

        private void emergencyLbl_Click(object sender, EventArgs e)
        {
            emgncyContactTxtBox.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var member = members[e.RowIndex];
                fnameTxtBox.Text = member.FirstName;
                lnameTxtBox.Text = member.LastName;
                emailTxtBox.Text = member.Email;
                phoneTxtBox.Text = member.Phone;
                addressTxtBox.Text = member.Address;
                joinDateDateTimePicker1.Value = member.JoinDate;
                memPlanComboBox1.SelectedItem = member.MembershipPlan;
                emgncyContactTxtBox.Text = member.EmergencyContact;
            }
        }

        private void fnameTxtBox_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add real-time validation
            if (string.IsNullOrWhiteSpace(fnameTxtBox.Text))
                fnameLbl.ForeColor = Color.Red;
            else
                fnameLbl.ForeColor = SystemColors.ControlText;
        }

        private void lnameTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(lnameTxtBox.Text))
                lnameLbl.ForeColor = Color.Red;
            else
                lnameLbl.ForeColor = SystemColors.ControlText;
        }

        private void emailTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (!IsValidEmail(emailTxtBox.Text) && !string.IsNullOrWhiteSpace(emailTxtBox.Text))
                emailLbl.ForeColor = Color.Red;
            else
                emailLbl.ForeColor = SystemColors.ControlText;
        }

        private void phoneTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (!IsValidPhone(phoneTxtBox.Text) && !string.IsNullOrWhiteSpace(phoneTxtBox.Text))
                phoneLbl.ForeColor = Color.Red;
            else
                phoneLbl.ForeColor = SystemColors.ControlText;
        }

        private void addressTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addressTxtBox.Text))
                addressLbl.ForeColor = Color.Red;
            else
                addressLbl.ForeColor = SystemColors.ControlText;
        }

        private void joinDateDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (joinDateDateTimePicker1.Value > DateTime.Now)
                joinDateLbl.ForeColor = Color.Red;
            else
                joinDateLbl.ForeColor = SystemColors.ControlText;
        }

        private void memPlanComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (memPlanComboBox1.SelectedIndex == -1)
                memPlanLbl.ForeColor = Color.Red;
            else
                memPlanLbl.ForeColor = SystemColors.ControlText;
        }

        private void emgncyContactTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emgncyContactTxtBox.Text))
                emergencyLbl.ForeColor = Color.Red;
            else
                emergencyLbl.ForeColor = SystemColors.ControlText;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                MessageBox.Show("Please fill all required fields correctly.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var member = new Member
            {
                MemberID = nextMemberId++,
                FirstName = fnameTxtBox.Text,
                LastName = lnameTxtBox.Text,
                Email = emailTxtBox.Text,
                Phone = phoneTxtBox.Text,
                Address = addressTxtBox.Text,
                JoinDate = joinDateDateTimePicker1.Value,
                MembershipPlan = memPlanComboBox1.SelectedItem.ToString(),
                EmergencyContact = emgncyContactTxtBox.Text
            };

            members.Add(member);
            LoadMembersToGrid();
            ClearForm();
            MessageBox.Show("Member saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            // Navigate back to previous form or main menu
            MessageBox.Show("Returning to main menu (to be implemented).",
                "Navigation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Implement navigation to previous form if exists
        }

        private bool ValidateForm()
        {
            return !string.IsNullOrWhiteSpace(fnameTxtBox.Text) &&
                   !string.IsNullOrWhiteSpace(lnameTxtBox.Text) &&
                   IsValidEmail(emailTxtBox.Text) &&
                   IsValidPhone(phoneTxtBox.Text) &&
                   !string.IsNullOrWhiteSpace(addressTxtBox.Text) &&
                   joinDateDateTimePicker1.Value <= DateTime.Now &&
                   memPlanComboBox1.SelectedIndex != -1 &&
                   !string.IsNullOrWhiteSpace(emgncyContactTxtBox.Text);
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsValidPhone(string phone)
        {
            // Simple phone validation (accepts 10-digit numbers or formats like (123) 456-7890)
            return System.Text.RegularExpressions.Regex.IsMatch(phone, @"^(\+?\d{1,4}[\s-]?)?(\(?\d{3}\)?[\s-]?)?\d{3}[\s-]?\d{4}$");
        }

        private void ClearForm()
        {
            fnameTxtBox.Clear();
            lnameTxtBox.Clear();
            emailTxtBox.Clear();
            phoneTxtBox.Clear();
            addressTxtBox.Clear();
            joinDateDateTimePicker1.Value = DateTime.Now;
            memPlanComboBox1.SelectedIndex = 0;
            emgncyContactTxtBox.Clear();
            fnameLbl.ForeColor = SystemColors.ControlText;
            lnameLbl.ForeColor = SystemColors.ControlText;
            emailLbl.ForeColor = SystemColors.ControlText;
            phoneLbl.ForeColor = SystemColors.ControlText;
            addressLbl.ForeColor = SystemColors.ControlText;
            joinDateLbl.ForeColor = SystemColors.ControlText;
            memPlanLbl.ForeColor = SystemColors.ControlText;
            emergencyLbl.ForeColor = SystemColors.ControlText;
        }
    }
}