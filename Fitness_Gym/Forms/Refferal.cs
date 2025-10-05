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
    public partial class Refferal : Form
    {
        private readonly string connectionString = "Data Source=PC05\\SQLEXPRESS;Initial Catalog=PalenersGym;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public Refferal()
        {
            InitializeComponent();
        }

        private void Refferal_Load(object sender, EventArgs e)
        {
            if (this.DesignMode) return;

            try
            {
                // Configure DataGridView
                dataGridView_referrals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView_referrals.MultiSelect = false;
                dataGridView_referrals.ReadOnly = true;

                // Load members for both comboboxes
                LoadMembers();

                // Load existing referrals
                LoadReferrals();
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

                        // Load referrer combo box
                        comboBox_referrer.DataSource = null;
                        comboBox_referrer.DataSource = membersTable.Copy();
                        comboBox_referrer.DisplayMember = "FullName";
                        comboBox_referrer.ValueMember = "MemberID";
                        comboBox_referrer.SelectedIndex = -1;

                        // Load referred member combo box
                        comboBox_referred.DataSource = null;
                        comboBox_referred.DataSource = membersTable.Copy();
                        comboBox_referred.DisplayMember = "FullName";
                        comboBox_referred.ValueMember = "MemberID";
                        comboBox_referred.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading members: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadReferrals()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT 
                            r.ReferralID,
                            r.ReferrerID,
                            referrer.FirstName + ' ' + referrer.LastName AS ReferrerName,
                            r.ReferredMemberID,
                            referred.FirstName + ' ' + referred.LastName AS ReferredMemberName,
                            r.ReferralDate,
                            r.RewardStatus,
                            r.CreatedAt
                        FROM Referrals r
                        JOIN Members referrer ON r.ReferrerID = referrer.MemberID
                        JOIN Members referred ON r.ReferredMemberID = referred.MemberID
                        ORDER BY r.ReferralDate DESC";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable referralsTable = new DataTable();
                        adapter.Fill(referralsTable);
                        dataGridView_referrals.DataSource = referralsTable;

                        // Configure column visibility and headers
                        if (dataGridView_referrals.Columns.Contains("ReferralID"))
                            dataGridView_referrals.Columns["ReferralID"].Visible = false;
                        if (dataGridView_referrals.Columns.Contains("ReferrerID"))
                            dataGridView_referrals.Columns["ReferrerID"].Visible = false;
                        if (dataGridView_referrals.Columns.Contains("ReferredMemberID"))
                            dataGridView_referrals.Columns["ReferredMemberID"].Visible = false;

                        // Set header texts
                        if (dataGridView_referrals.Columns.Contains("ReferrerName"))
                            dataGridView_referrals.Columns["ReferrerName"].HeaderText = "Referrer";
                        if (dataGridView_referrals.Columns.Contains("ReferredMemberName"))
                            dataGridView_referrals.Columns["ReferredMemberName"].HeaderText = "Referred Member";
                        if (dataGridView_referrals.Columns.Contains("ReferralDate"))
                            dataGridView_referrals.Columns["ReferralDate"].HeaderText = "Referral Date";
                        if (dataGridView_referrals.Columns.Contains("RewardStatus"))
                            dataGridView_referrals.Columns["RewardStatus"].HeaderText = "Reward Status";
                        if (dataGridView_referrals.Columns.Contains("CreatedAt"))
                            dataGridView_referrals.Columns["CreatedAt"].HeaderText = "Created Date";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading referrals: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox_referrer_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: Add validation or additional logic when referrer changes
            if (comboBox_referrer.SelectedIndex >= 0)
            {
                // You can add logic here to validate or update UI based on selected referrer
            }
        }

        private void comboBox_referred_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional: Add validation or additional logic when referred member changes
            if (comboBox_referred.SelectedIndex >= 0)
            {
                // You can add logic here to validate or update UI based on selected referred member
            }
        }

        private void button_add_referral_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (comboBox_referrer.SelectedIndex == -1 || comboBox_referrer.SelectedValue == null)
                {
                    MessageBox.Show("Please select a referrer.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (comboBox_referred.SelectedIndex == -1 || comboBox_referred.SelectedValue == null)
                {
                    MessageBox.Show("Please select a referred member.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int referrerID = Convert.ToInt32(comboBox_referrer.SelectedValue);
                int referredMemberID = Convert.ToInt32(comboBox_referred.SelectedValue);

                // Check if referrer and referred member are the same
                if (referrerID == referredMemberID)
                {
                    MessageBox.Show("Referrer and referred member cannot be the same person.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check if referral already exists
                if (ReferralExists(referrerID, referredMemberID))
                {
                    MessageBox.Show("This referral already exists.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check if the referred member has been referred before
                if (MemberAlreadyReferred(referredMemberID))
                {
                    MessageBox.Show("This member has already been referred by someone else.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Insert new referral using current date
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string insertQuery = @"
                        INSERT INTO Referrals (ReferrerID, ReferredMemberID, ReferralDate, RewardStatus)
                        VALUES (@ReferrerID, @ReferredMemberID, @ReferralDate, @RewardStatus)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@ReferrerID", referrerID);
                        cmd.Parameters.AddWithValue("@ReferredMemberID", referredMemberID);
                        cmd.Parameters.AddWithValue("@ReferralDate", DateTime.Today); // Use current date
                        cmd.Parameters.AddWithValue("@RewardStatus", "Pending");

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Referral added successfully!", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Refresh the data and clear form
                            LoadReferrals();
                            ClearForm();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding referral: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_referrals_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dataGridView_referrals.Rows[e.RowIndex].Cells["ReferrerID"].Value != null)
                {
                    DataGridViewRow row = dataGridView_referrals.Rows[e.RowIndex];

                    // Populate form fields with selected referral data
                    comboBox_referrer.SelectedValue = Convert.ToInt32(row.Cells["ReferrerID"].Value);
                    comboBox_referred.SelectedValue = Convert.ToInt32(row.Cells["ReferredMemberID"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting referral: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ReferralExists(int referrerID, int referredMemberID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Referrals WHERE ReferrerID = @ReferrerID AND ReferredMemberID = @ReferredMemberID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ReferrerID", referrerID);
                        cmd.Parameters.AddWithValue("@ReferredMemberID", referredMemberID);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        private bool MemberAlreadyReferred(int referredMemberID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Referrals WHERE ReferredMemberID = @ReferredMemberID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ReferredMemberID", referredMemberID);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        private void ClearForm()
        {
            comboBox_referrer.SelectedIndex = -1;
            comboBox_referred.SelectedIndex = -1;
        }

        // Keep all your existing empty event handlers below - they won't interfere
        private void label3_Click(object sender, EventArgs e)
        {
            // Your existing empty handler
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
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
    }
}