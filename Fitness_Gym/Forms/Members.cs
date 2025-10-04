using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Fitness_Gym.Forms
{
    public partial class Member : Form
    {
        string connectionString = "Data Source=PC06\\SQLEXPRESS;Initial Catalog=PalenersGym;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;Network Library=DBMSSOCN";

        public Member()
        {
            InitializeComponent();
            Console.WriteLine("Member: Constructor called");
        }

        private void Member_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                Console.WriteLine("Member_Load: Skipping in Design Mode");
                return;
            }

            try
            {
                Console.WriteLine("Member_Load: Initializing form");
                dataGridView_members_lists.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView_members_lists.MultiSelect = false;
                dataGridView_members_lists.ReadOnly = true;

                comboBox_Gender.Items.AddRange(new[] { "Male", "Female", "Other" });
                comboBox_Gender.SelectedIndex = -1;
                Console.WriteLine("Member_Load: Initialized comboBox_Gender");

                LoadMembershipPlans();
                LoadMembers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in Member_Load: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Member_Load Error: {ex.Message}");
            }
        }

        private void LoadMembershipPlans()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    Console.WriteLine("LoadMembershipPlans: Attempting to connect to database");
                    conn.Open();
                    Console.WriteLine("LoadMembershipPlans: Database connection opened");
                    string query = "SELECT PlanID, PlanName FROM MembershipPlans";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable plansTable = new DataTable();
                        adapter.Fill(plansTable);
                        Console.WriteLine($"LoadMembershipPlans: Retrieved {plansTable.Rows.Count} plans");
                        comboBox_plan.DataSource = null;
                        comboBox_plan.DataSource = plansTable;
                        comboBox_plan.DisplayMember = "PlanName";
                        comboBox_plan.ValueMember = "PlanID";
                        comboBox_plan.SelectedIndex = -1;
                        Console.WriteLine("LoadMembershipPlans: Bound data to comboBox_plan");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading membership plans: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"LoadMembershipPlans Error: {ex.Message}");
            }
        }

        private void LoadMembers()
        {
            try
            {
                comboBox_Gender.SelectedIndex = -1;
                if (comboBox_plan.DataSource != null)
                    comboBox_plan.SelectedIndex = -1;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    Console.WriteLine("LoadMembers: Attempting to connect to database");
                    conn.Open();
                    Console.WriteLine("LoadMembers: Database connection opened");
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
                        Console.WriteLine($"LoadMembers: Retrieved {membersTable.Rows.Count} members");
                        dataGridView_members_lists.DataSource = null;
                        dataGridView_members_lists.DataSource = membersTable;

                        if (dataGridView_members_lists.Columns.Contains("MemberID"))
                            dataGridView_members_lists.Columns["MemberID"].Visible = false;
                        if (dataGridView_members_lists.Columns.Contains("FullName"))
                            dataGridView_members_lists.Columns["FullName"].HeaderText = "Name";
                        if (dataGridView_members_lists.Columns.Contains("Email"))
                            dataGridView_members_lists.Columns["Email"].HeaderText = "Email";
                        if (dataGridView_members_lists.Columns.Contains("DateOfBirth"))
                            dataGridView_members_lists.Columns["DateOfBirth"].HeaderText = "Date of Birth";
                        if (dataGridView_members_lists.Columns.Contains("PhoneNumber"))
                            dataGridView_members_lists.Columns["PhoneNumber"].HeaderText = "Phone Number";
                        if (dataGridView_members_lists.Columns.Contains("Gender"))
                            dataGridView_members_lists.Columns["Gender"].HeaderText = "Gender";
                        if (dataGridView_members_lists.Columns.Contains("PlanName"))
                            dataGridView_members_lists.Columns["PlanName"].HeaderText = "Membership Plan";
                        if (dataGridView_members_lists.Columns.Contains("Status"))
                            dataGridView_members_lists.Columns["Status"].HeaderText = "Status";
                        Console.WriteLine("LoadMembers: Bound data to dataGridView_members_lists");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading members: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"LoadMembers Error: {ex.Message}");
            }
        }

        private void button_add_Member_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_FirstName.Text) ||
                string.IsNullOrWhiteSpace(textBox_LastName.Text) ||
                string.IsNullOrWhiteSpace(textBox_email.Text) ||
                comboBox_Gender.SelectedIndex == -1 ||
                comboBox_plan.SelectedIndex == -1 || comboBox_plan.SelectedValue == null)
            {
                MessageBox.Show("Please fill out all required fields (First Name, Last Name, Email, Gender, Plan).", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine($"button_add_Member_Click: Validation failed - FirstName: {textBox_FirstName.Text}, LastName: {textBox_LastName.Text}, Email: {textBox_email.Text}, Gender: {comboBox_Gender.SelectedIndex}, Plan: {comboBox_plan.SelectedIndex}, PlanValue: {comboBox_plan.SelectedValue}");
                return;
            }

            if (datepicker_Birthday.Value >= DateTime.Today)
            {
                MessageBox.Show("Date of Birth must be in the past.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine("button_add_Member_Click: Invalid DOB");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    Console.WriteLine("button_add_Member_Click: Attempting to connect to database");
                    conn.Open();
                    Console.WriteLine("button_add_Member_Click: Database connection opened");
                    string checkEmailQuery = "SELECT COUNT(*) FROM Members WHERE Email = @Email";
                    using (SqlCommand checkCmd = new SqlCommand(checkEmailQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@Email", textBox_email.Text.Trim());
                        int emailCount = (int)checkCmd.ExecuteScalar();
                        if (emailCount > 0)
                        {
                            MessageBox.Show("Email is already in use.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Console.WriteLine("button_add_Member_Click: Duplicate email");
                            return;
                        }
                    }

                    string insertQuery = @"
                        INSERT INTO Members (FirstName, LastName, Gender, DateOfBirth, PhoneNumber, Email, PlanID, Status)
                        VALUES (@FirstName, @LastName, @Gender, @DateOfBirth, @PhoneNumber, @Email, @PlanID, @Status)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", textBox_FirstName.Text.Trim());
                        cmd.Parameters.AddWithValue("@LastName", textBox_LastName.Text.Trim());
                        cmd.Parameters.AddWithValue("@Gender", comboBox_Gender.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@DateOfBirth", datepicker_Birthday.Value);
                        cmd.Parameters.AddWithValue("@PhoneNumber", string.IsNullOrWhiteSpace(textBox_Contact.Text) ? (object)DBNull.Value : textBox_Contact.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", textBox_email.Text.Trim());
                        cmd.Parameters.AddWithValue("@PlanID", (int)comboBox_plan.SelectedValue);
                        cmd.Parameters.AddWithValue("@Status", "Active");

                        cmd.ExecuteNonQuery();
                        Console.WriteLine("button_add_Member_Click: Insert query executed");
                    }

                    MessageBox.Show("Member added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.WriteLine("button_add_Member_Click: Member added successfully");
                    LoadMembers();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"button_add_Member_Click Error: {ex.Message}");
            }
        }

        private void button_update_member_Click(object sender, EventArgs e)
        {
            if (dataGridView_members_lists.CurrentRow == null)
            {
                MessageBox.Show("Please select a member to update.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.WriteLine("button_update_member_Click: No row selected");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox_FirstName.Text) ||
                string.IsNullOrWhiteSpace(textBox_LastName.Text) ||
                string.IsNullOrWhiteSpace(textBox_email.Text) ||
                comboBox_Gender.SelectedIndex == -1 ||
                comboBox_plan.SelectedIndex == -1 || comboBox_plan.SelectedValue == null)
            {
                MessageBox.Show("Please fill out all required fields (First Name, Last Name, Email, Gender, Plan).", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine("button_update_member_Click: Validation failed");
                return;
            }

            if (datepicker_Birthday.Value >= DateTime.Today)
            {
                MessageBox.Show("Date of Birth must be in the past.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Console.WriteLine("button_update_member_Click: Invalid DOB");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    Console.WriteLine("button_update_member_Click: Attempting to connect to database");
                    conn.Open();
                    Console.WriteLine("button_update_member_Click: Database connection opened");
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
                            Console.WriteLine("button_update_member_Click: Duplicate email");
                            return;
                        }
                    }

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
                        cmd.Parameters.AddWithValue("@PhoneNumber", string.IsNullOrWhiteSpace(textBox_Contact.Text) ? (object)DBNull.Value : textBox_Contact.Text.Trim());
                        cmd.Parameters.AddWithValue("@Email", textBox_email.Text.Trim());
                        cmd.Parameters.AddWithValue("@PlanID", (int)comboBox_plan.SelectedValue);
                        cmd.Parameters.AddWithValue("@Status", "Active");
                        cmd.Parameters.AddWithValue("@MemberID", memberID);

                        cmd.ExecuteNonQuery();
                        Console.WriteLine("button_update_member_Click: Update query executed");
                    }

                    MessageBox.Show("Member updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.WriteLine("button_update_member_Click: Member updated successfully");
                    LoadMembers();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"button_update_member_Click Error: {ex.Message}");
            }
        }

        private void button_delete_member_Click(object sender, EventArgs e)
        {
            if (dataGridView_members_lists.CurrentRow == null)
            {
                MessageBox.Show("Please select a member to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.WriteLine("button_delete_member_Click: No row selected");
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
                    Console.WriteLine("button_delete_member_Click: Attempting to connect to database");
                    conn.Open();
                    Console.WriteLine("button_delete_member_Click: Database connection opened");
                    int memberID = (int)dataGridView_members_lists.CurrentRow.Cells["MemberID"].Value;
                    string deleteQuery = "DELETE FROM Members WHERE MemberID = @MemberID";
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@MemberID", memberID);
                        cmd.ExecuteNonQuery();
                        Console.WriteLine("button_delete_member_Click: Delete query executed");
                    }

                    MessageBox.Show("Member deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.WriteLine("button_delete_member_Click: Member deleted successfully");
                    LoadMembers();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"button_delete_member_Click Error: {ex.Message}");
            }
        }

        private void dataGridView_members_lists_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView_members_lists.Rows[e.RowIndex];
                    Console.WriteLine($"dataGridView_members_lists_CellClick: Selected row {e.RowIndex}, FullName: {row.Cells["FullName"].Value}");

                    string[] nameParts = row.Cells["FullName"].Value?.ToString().Split(' ') ?? new string[] { "", "" };
                    textBox_FirstName.Text = nameParts.Length > 0 ? nameParts[0] : "";
                    textBox_LastName.Text = nameParts.Length > 1 ? nameParts[1] : "";
                    textBox_email.Text = row.Cells["Email"].Value?.ToString() ?? "";
                    textBox_Contact.Text = row.Cells["PhoneNumber"].Value?.ToString() ?? "";
                    comboBox_Gender.Text = row.Cells["Gender"].Value?.ToString() ?? "";
                    comboBox_plan.Text = row.Cells["PlanName"].Value?.ToString() ?? "";
                    datepicker_Birthday.Value = row.Cells["DateOfBirth"].Value != null ? Convert.ToDateTime(row.Cells["DateOfBirth"].Value) : DateTime.Today;
                    Console.WriteLine($"dataGridView_members_lists_CellClick: Populated fields - FirstName: {textBox_FirstName.Text}, Email: {textBox_email.Text}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"dataGridView_members_lists_CellClick Error: {ex.Message}");
            }
        }

        private void ClearFields()
        {
            textBox_FirstName.Clear();
            textBox_LastName.Clear();
            textBox_email.Clear();
            textBox_Contact.Clear();
            comboBox_Gender.SelectedIndex = -1;
            if (comboBox_plan.DataSource != null)
                comboBox_plan.SelectedIndex = -1;
            datepicker_Birthday.Value = DateTime.Today;
            Console.WriteLine("ClearFields: Form fields cleared");
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

        private void dataGridView_members_lists_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
        private void label2_Click(object sender, EventArgs e)
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