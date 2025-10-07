using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Fitness_Gym.Forms
{
    public partial class Feedback : Form
    {
        private readonly string connectionString = "Data Source=PC32\\SQLEXPRESS;Initial Catalog=PalenersGym;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public Feedback()
        {
            InitializeComponent();
        }

        private void Feedback_Load(object sender, EventArgs e)
        {
            if (this.DesignMode) return;

            try
            {
                // Configure DataGridView
                dataGridView_feedback_list.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView_feedback_list.MultiSelect = false;
                dataGridView_feedback_list.ReadOnly = true;

                // Load members for combobox
                LoadMembers();

                // Setup ratings combobox
                comboBox_ratings.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
                comboBox_ratings.SelectedIndex = -1;

                // Load existing feedback
                LoadFeedback();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing form: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMembers()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT MemberID, FirstName + ' ' + LastName AS FullName FROM Members WHERE Status = 'Active'";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable membersTable = new DataTable();
                        adapter.Fill(membersTable);

                        comboBox_members.DataSource = null;
                        comboBox_members.DataSource = membersTable;
                        comboBox_members.DisplayMember = "FullName";
                        comboBox_members.ValueMember = "MemberID";
                        comboBox_members.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading members: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadFeedback()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                SELECT 
                    f.FeedbackID,
                    f.MemberID,
                    m.FirstName + ' ' + m.LastName AS MemberName,
                    f.FeedbackText,
                    f.Rating,
                    f.FeedbackDate,
                    f.CreatedAt
                FROM Feedback f
                JOIN Members m ON f.MemberID = m.MemberID
                ORDER BY f.FeedbackDate DESC, f.FeedbackID DESC"; // Added FeedbackID DESC

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable feedbackTable = new DataTable();
                        adapter.Fill(feedbackTable);
                        dataGridView_feedback_list.DataSource = feedbackTable;

                        // Configure column visibility and headers
                        if (dataGridView_feedback_list.Columns.Contains("FeedbackID"))
                            dataGridView_feedback_list.Columns["FeedbackID"].Visible = false;
                        if (dataGridView_feedback_list.Columns.Contains("MemberID"))
                            dataGridView_feedback_list.Columns["MemberID"].Visible = false;

                        // Set header texts to match your requested columns
                        if (dataGridView_feedback_list.Columns.Contains("MemberName"))
                            dataGridView_feedback_list.Columns["MemberName"].HeaderText = "Member";
                        if (dataGridView_feedback_list.Columns.Contains("FeedbackText"))
                            dataGridView_feedback_list.Columns["FeedbackText"].HeaderText = "Feedback";
                        if (dataGridView_feedback_list.Columns.Contains("Rating"))
                            dataGridView_feedback_list.Columns["Rating"].HeaderText = "Rating";
                        if (dataGridView_feedback_list.Columns.Contains("FeedbackDate"))
                            dataGridView_feedback_list.Columns["FeedbackDate"].HeaderText = "Date";
                        if (dataGridView_feedback_list.Columns.Contains("CreatedAt"))
                            dataGridView_feedback_list.Columns["CreatedAt"].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading feedback: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox_members_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: Add validation or additional logic when member changes
            if (comboBox_members.SelectedIndex >= 0)
            {
                // You can add logic here to validate or update UI based on selected member
            }
        }

        private void comboBox_ratings_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: Add validation or additional logic when rating changes
            if (comboBox_ratings.SelectedIndex >= 0)
            {
                // You can add logic here to validate or update UI based on selected rating
            }
        }

        private void textBox_feedback_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add real-time validation for feedback text
            // For example, you could enable/disable the add button based on input length
            if (!string.IsNullOrWhiteSpace(textBox_feedback.Text) &&
                comboBox_members.SelectedIndex >= 0 &&
                comboBox_ratings.SelectedIndex >= 0)
            {
                // Enable add button if all fields are filled
                button_add_feedback.Enabled = true;
            }
            else
            {
                button_add_feedback.Enabled = false;
            }
        }

        private void button_add_feedback_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (comboBox_members.SelectedIndex == -1 || comboBox_members.SelectedValue == null)
                {
                    MessageBox.Show("Please select a member.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (comboBox_ratings.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a rating.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBox_feedback.Text))
                {
                    MessageBox.Show("Please enter feedback text.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (textBox_feedback.Text.Length > 500)
                {
                    MessageBox.Show("Feedback text cannot exceed 500 characters.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int memberID = Convert.ToInt32(comboBox_members.SelectedValue);
                int rating = Convert.ToInt32(comboBox_ratings.SelectedItem);
                string feedbackText = textBox_feedback.Text.Trim();

                // Insert new feedback
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string insertQuery = @"
                        INSERT INTO Feedback (MemberID, FeedbackText, Rating, FeedbackDate)
                        VALUES (@MemberID, @FeedbackText, @Rating, @FeedbackDate)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@MemberID", memberID);
                        cmd.Parameters.AddWithValue("@FeedbackText", feedbackText);
                        cmd.Parameters.AddWithValue("@Rating", rating);
                        cmd.Parameters.AddWithValue("@FeedbackDate", DateTime.Today);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Feedback added successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Refresh the data and clear form
                            LoadFeedback();
                            ClearForm();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding feedback: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_feedback_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dataGridView_feedback_list.Rows[e.RowIndex].Cells["MemberID"].Value != null)
                {
                    DataGridViewRow row = dataGridView_feedback_list.Rows[e.RowIndex];

                    // Populate form fields with selected feedback data
                    comboBox_members.SelectedValue = Convert.ToInt32(row.Cells["MemberID"].Value);
                    comboBox_ratings.SelectedItem = row.Cells["Rating"].Value?.ToString();
                    textBox_feedback.Text = row.Cells["FeedbackText"].Value?.ToString() ?? "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting feedback: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            comboBox_members.SelectedIndex = -1;
            comboBox_ratings.SelectedIndex = -1;
            textBox_feedback.Clear();
            button_add_feedback.Enabled = false;
        }

        // Keep all your existing empty event handlers below - they won't interfere
        private void label1_Click(object sender, EventArgs e)
        {
            // Your existing empty handler
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Your existing empty handler
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Your existing empty handler
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // Your existing empty handler
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Your existing empty handler
        }

        private void label7_Click(object sender, EventArgs e)
        {
            // Your existing empty handler
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // Your existing empty handler
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Your existing empty handler
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}