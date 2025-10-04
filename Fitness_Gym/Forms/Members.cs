using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Fitness_Gym.Forms
{
    public partial class Member : Form
    {
        string connectionString = "Data Source=PC17\\SQLEXPRESS;Initial Catalog=PalenersGym;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public Member()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Member_Load(object sender, EventArgs e)
        {
            dataGridView_members_lists.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_members_lists.MultiSelect = false;
            dataGridView_members_lists.ReadOnly = true;

            // Initialize combo boxes
            comboBox_Gender.Items.AddRange(new[] { "Male", "Female", "Other" });
            comboBox_Gender.SelectedIndex = -1;
            LoadMembershipPlans();
            LoadMembers();
        }

        private void LoadMembershipPlans()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT PlanID, PlanName FROM MembershipPlans";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable plansTable = new DataTable();
                        adapter.Fill(plansTable);
                        comboBox_plan.DataSource = plansTable;
                        comboBox_plan.DisplayMember = "PlanName";
                        comboBox_plan.ValueMember = "PlanID";
                        comboBox_plan.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading membership plans: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMembers()
        {
            // Optional: set defaults on load
            comboBox_Gender.SelectedIndex = -1;
            comboBox_plan.SelectedIndex = -1;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            m.MemberID,
                            m.FirstName + ' ' + m.LastName AS FullName,
                            m.Email,
                            m.DateOfBirth,
                            m.PhoneNumber,
                            m.Gender,
                            mp.PlanName,
                            m.Status
                        FROM Members m
                        JOIN MembershipPlans mp ON m.PlanID = mp.PlanID";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable membersTable = new DataTable();
                        adapter.Fill(membersTable);
                        dataGridView_members_lists.DataSource = membersTable;

                        // Customize column headers
                        dataGridView_members_lists.Columns["MemberID"].Visible = false; // Hide ID
                        dataGridView_members_lists.Columns["FullName"].HeaderText = "Name";
                        dataGridView_members_lists.Columns["Email"].HeaderText = "Email";
                        dataGridView_members_lists.Columns["DateOfBirth"].HeaderText = "Date of Birth";
                        dataGridView_members_lists.Columns["PhoneNumber"].HeaderText = "Phone Number";
                        dataGridView_members_lists.Columns["Gender"].HeaderText = "Gender";
                        dataGridView_members_lists.Columns["PlanName"].HeaderText = "Membership Plan";
                        dataGridView_members_lists.Columns["Status"].HeaderText = "Status";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading members: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_add_Member_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(textBox_FirstName.Text) ||
                string.IsNullOrWhiteSpace(textBox_LastName.Text) ||
                string.IsNullOrWhiteSpace(textBox_email.Text) ||
                comboBox_Gender.SelectedIndex == -1 ||
                comboBox_plan.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill out all required fields (First Name, Last Name, Email, Gender, Plan).", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (datepicker_Birthday.Value >= DateTime.Today)
            {
                MessageBox.Show("Date of Birth must be in the past.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // Check for duplicate email
                    string checkEmailQuery = "SELECT COUNT(*) FROM Members WHERE Email = @Email";
                    using (SqlCommand checkCmd = new SqlCommand(checkEmailQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Email", textBox_email.Text.Trim());
                        int emailCount = (int)checkCmd.ExecuteScalar();
                        if (emailCount > 0)
                        {
                            MessageBox.Show("Email is already in use.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Insert new member
                    string insertQuery = @"
                        INSERT INTO Members (FirstName, LastName, Gender, DateOfBirth, PhoneNumber, Email, PlanID, Status)
                        VALUES (@FirstName, @LastName, @Gender, @DateOfBirth, @PhoneNumber, @Email, @PlanID, @Status)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", textBox_FirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@LastName", textBox_LastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Gender", comboBox_Gender.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@DateOfBirth", datepicker_Birthday.Value);
                        cmd.Parameters.AddWithValue("@PhoneNumber", textBox_Contact.Text.Trim() ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Email", textBox_email.Text.Trim());
                        cmd.Parameters.AddWithValue("@PlanID", (int)comboBox_plan.SelectedValue);
                        cmd.Parameters.AddWithValue("@Status", "Active");

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Member added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMembers(); // Refresh grid
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_update_member_Click(object sender, EventArgs e)
        {
            if (dataGridView_members_lists.CurrentRow == null)
            {
                MessageBox.Show("Please select a member to update.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Validate inputs
            if (string.IsNullOrWhiteSpace(textBox_FirstName.Text) ||
                string.IsNullOrWhiteSpace(textBox_LastName.Text) ||
                string.IsNullOrWhiteSpace(textBox_email.Text) ||
                comboBox_Gender.SelectedIndex == -1 ||
                comboBox_plan.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill out all required fields (First Name, Last Name, Email, Gender, Plan).", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (datepicker_Birthday.Value >= DateTime.Today)
            {
                MessageBox.Show("Date of Birth must be in the past.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // Check for duplicate email (excluding current member)
                    int memberID = (int)dataGridView_members_lists.CurrentRow.Cells["MemberID"].Value;
                    string checkEmailQuery = "SELECT COUNT(*) FROM Members WHERE Email = @Email AND MemberID != @MemberID";
                    using (SqlCommand checkCmd = new SqlCommand(checkEmailQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Email", textBox_email.Text.Trim());
                        checkCmd.Parameters.AddWithValue("@MemberID", memberID);
                        int emailCount = (int)checkCmd.ExecuteScalar();
                        if (emailCount > 0)
                        {
                            MessageBox.Show("Email is already in use by another member.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Update member
                    string updateQuery = @"
                        UPDATE Members
                        SET FirstName = @FirstName,
                            LastName = @LastName,
                            Gender = @Gender,
                            DateOfBirth = @DateOfBirth,
                            PhoneNumber = @PhoneNumber,
                            Email = @Email,
                            PlanID = @PlanID,
                            Status = @Status
                        WHERE MemberID = @MemberID";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", textBox_FirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@LastName", textBox_LastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Gender", comboBox_Gender.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@DateOfBirth", datepicker_Birthday.Value);
                        cmd.Parameters.AddWithValue("@PhoneNumber", textBox_Contact.Text.Trim() ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@Email", textBox_email.Text.Trim());
                        cmd.Parameters.AddWithValue("@PlanID", (int)comboBox_plan.SelectedValue);
                        cmd.Parameters.AddWithValue("@Status", "Active");
                        cmd.Parameters.AddWithValue("@MemberID", memberID);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Member updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMembers(); // Refresh grid
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_delete_member_Click(object sender, EventArgs e)
        {
            if (dataGridView_members_lists.CurrentRow == null)
            {
                MessageBox.Show("Please select a member to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this member?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    int memberID = (int)dataGridView_members_lists.CurrentRow.Cells["MemberID"].Value;
                    string deleteQuery = "DELETE FROM Members WHERE MemberID = @MemberID";
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@MemberID", memberID);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Member deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMembers(); // Refresh grid
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_members_lists_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Populate fields when clicking a row
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_members_lists.Rows[e.RowIndex];

                string[] nameParts = row.Cells["FullName"].Value?.ToString().Split(' ') ?? new string[] { "", "" };
                if (nameParts.Length > 0) textBox_FirstName.Text = nameParts[0];
                if (nameParts.Length > 1) textBox_LastName.Text = nameParts[1];

                textBox_email.Text = row.Cells["Email"].Value?.ToString();
                textBox_Contact.Text = row.Cells["PhoneNumber"].Value?.ToString() ?? "";
                comboBox_Gender.Text = row.Cells["Gender"].Value?.ToString();
                comboBox_plan.Text = row.Cells["PlanName"].Value?.ToString();
                datepicker_Birthday.Value = Convert.ToDateTime(row.Cells["DateOfBirth"].Value);
            }
        }

        private void ClearFields()
        {
            textBox_FirstName.Clear();
            textBox_LastName.Clear();
            textBox_email.Clear();
            textBox_Contact.Clear();
            comboBox_Gender.SelectedIndex = -1;
            comboBox_plan.SelectedIndex = -1;
            datepicker_Birthday.Value = DateTime.Today;
        }

        private void textBox_FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_LastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Contact_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_Gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void datepicker_Birthday_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_plan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_add_Member_Click_1(object sender, EventArgs e)
        {

        }

        private void button_update_member_Click_1(object sender, EventArgs e)
        {

        }

        private void button_delete_member_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView_members_lists_CellContentClick_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Member_Load_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}