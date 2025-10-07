using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Fitness_Gym.Forms
{
    public partial class Dashboard : Form
    {
        // Connection string from Login.cs
        private readonly string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=PalenersGym;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Load all dashboard data when the form loads
            UpdateTotalMembers();
            UpdateAverageRating();
            UpdateActiveMembers();
            UpdateTotalRevenue();
            LoadRecentActivities();
        }

        private void label_totalmembers_title_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label_totalmember_value_Click(object sender, EventArgs e)
        {
            // Refresh total members on click
            UpdateTotalMembers();
        }

        private void label_total_revenue_value_Click(object sender, EventArgs e)
        {
            // Refresh average rating on click
            UpdateAverageRating();
        }

        private void label_active_subcription_value_Click(object sender, EventArgs e)
        {
            // Refresh active members on click
            UpdateActiveMembers();
        }

        private void label_topMemberPlan_value_Click(object sender, EventArgs e)
        {
            // Refresh total revenue on click
            UpdateTotalRevenue();
        }

        private void dataGridView_recent_act_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Refresh recent activities on click
            LoadRecentActivities();
        }

        private void UpdateTotalMembers()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Members";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int totalMembers = (int)cmd.ExecuteScalar();
                        label_totalmember_value.Text = totalMembers.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching total members: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateAverageRating()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT AVG(CAST(Rating AS FLOAT)) FROM Feedback";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        label_total_revenue_value.Text = result != DBNull.Value ? Convert.ToDouble(result).ToString("F2") : "0.00";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching average rating: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateActiveMembers()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Members WHERE Status = 'Active'";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int activeMembers = (int)cmd.ExecuteScalar();
                        label_active_subcription_value.Text = activeMembers.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching active members: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTotalRevenue()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT SUM(Amount) FROM Payments";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        label_topMemberPlan_value.Text = result != DBNull.Value ? Convert.ToDecimal(result).ToString("C") : "$0.00";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error fetching total revenue: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadRecentActivities()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Combined query to get recent activities from Payments, Referrals, and Feedback
                    string query = @"
                -- Recent Payments
                SELECT TOP 5
                    m.FirstName + ' ' + m.LastName AS Member,
                    'Payment' AS ActivityType,
                    'Paid ' + mp.PlanName + ' membership' AS Details,
                    p.PaymentDate AS ActivityDate
                FROM Payments p
                JOIN Members m ON p.MemberID = m.MemberID
                JOIN MembershipPlans mp ON p.PlanID = mp.PlanID
                
                UNION ALL
                
                -- Recent Referrals
                SELECT TOP 5
                    referrer.FirstName + ' ' + referrer.LastName AS Member,
                    'Referral' AS ActivityType,
                    'Referred ' + referred.FirstName + ' ' + referred.LastName AS Details,
                    r.ReferralDate AS ActivityDate
                FROM Referrals r
                JOIN Members referrer ON r.ReferrerID = referrer.MemberID
                JOIN Members referred ON r.ReferredMemberID = referred.MemberID
                
                UNION ALL
                
                -- Recent Feedback
                SELECT TOP 5
                    m.FirstName + ' ' + m.LastName AS Member,
                    'Feedback' AS ActivityType,
                    'Rated ' + CAST(f.Rating AS NVARCHAR(10)) + ' stars' AS Details,
                    f.FeedbackDate AS ActivityDate
                FROM Feedback f
                JOIN Members m ON f.MemberID = m.MemberID
                
                ORDER BY ActivityDate DESC";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView_recent_act.DataSource = dataTable;

                        // Customize column headers to match your image
                        if (dataGridView_recent_act.Columns.Count > 0)
                        {
                            dataGridView_recent_act.Columns["Member"].HeaderText = "Member";
                            dataGridView_recent_act.Columns["ActivityType"].HeaderText = "Activity Type";
                            dataGridView_recent_act.Columns["Details"].HeaderText = "Details";
                            dataGridView_recent_act.Columns["ActivityDate"].HeaderText = "Date";
                        }

                        // Optional: Format the date column
                        if (dataGridView_recent_act.Columns.Contains("ActivityDate"))
                        {
                            dataGridView_recent_act.Columns["ActivityDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading recent activities: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}