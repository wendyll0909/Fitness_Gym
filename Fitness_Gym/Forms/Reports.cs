using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.Data.SqlClient;

namespace Fitness_Gym.Forms
{
    public partial class Reports : Form
    {
        private readonly string connectionString = "Data Source=PC05\\SQLEXPRESS;Initial Catalog=PalenersGym;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        private Chart reportChart;

        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            if (this.DesignMode) return;

            try
            {
                // Initialize report type combobox
                comboBox_Report_type.Items.AddRange(new object[] {
                    "Feedback Rating Distribution",
                    "Membership Plan Distribution",
                    "Revenue Report",
                    "Attendance Report",
                    "Referral Rewards Status",
                    "Member Growth Report"
                });
                comboBox_Report_type.SelectedIndex = 0;

                // Set default date range (last 30 days)
                date_from.Value = DateTime.Today.AddDays(-30);
                date_to.Value = DateTime.Today;

                // Initialize chart first
                InitializeChart();

                // Update report title
                UpdateReportTitle();

                // Generate report will be called by the SelectedIndexChanged event
                // which fires automatically after setting SelectedIndex = 0
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing reports: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeChart()
        {
            try
            {
                // Remove existing chart if any
                if (panel2 != null)
                {
                    foreach (Control control in panel2.Controls.OfType<Chart>().ToList())
                    {
                        panel2.Controls.Remove(control);
                        control.Dispose();
                    }

                    // Create new chart
                    reportChart = new Chart();
                    reportChart.Dock = DockStyle.Fill;
                    reportChart.Location = new Point(0, 0);
                    reportChart.Size = new Size(panel2.Width, panel2.Height);

                    // Create chart area
                    ChartArea chartArea = new ChartArea();
                    chartArea.AxisX.MajorGrid.Enabled = false;
                    chartArea.AxisY.MajorGrid.Enabled = false;
                    chartArea.AxisX.LabelStyle.Angle = -45;
                    reportChart.ChartAreas.Add(chartArea);

                    // Create legend
                    Legend legend = new Legend();
                    legend.Docking = Docking.Bottom;
                    reportChart.Legends.Add(legend);

                    panel2.Controls.Add(reportChart);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing chart: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateReportTitle()
        {
            if (comboBox_Report_type.SelectedItem != null && label3 != null)
            {
                label3.Text = comboBox_Report_type.SelectedItem.ToString();
            }
        }

        private void GenerateReport()
        {
            // Check if chart is initialized
            if (reportChart == null)
            {
                MessageBox.Show("Chart is not initialized. Please wait...", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (comboBox_Report_type.SelectedItem == null) return;

            try
            {
                string reportType = comboBox_Report_type.SelectedItem.ToString();
                DateTime fromDate = date_from.Value;
                DateTime toDate = date_to.Value;

                // Clear existing data
                reportChart.Series.Clear();
                reportChart.Titles.Clear();

                switch (reportType)
                {
                    case "Feedback Rating Distribution":
                        GenerateFeedbackRatingReport(fromDate, toDate);
                        break;
                    case "Membership Plan Distribution":
                        GenerateMembershipPlanReport();
                        break;
                    case "Revenue Report":
                        GenerateRevenueReport(fromDate, toDate);
                        break;
                    case "Attendance Report":
                        GenerateAttendanceReport(fromDate, toDate);
                        break;
                    case "Referral Rewards Status":
                        GenerateReferralRewardsReport();
                        break;
                    case "Member Growth Report":
                        GenerateMemberGrowthReport(fromDate, toDate);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating report: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateFeedbackRatingReport(DateTime fromDate, DateTime toDate)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT Rating, COUNT(*) as Count 
                    FROM Feedback 
                    WHERE FeedbackDate BETWEEN @FromDate AND @ToDate
                    GROUP BY Rating 
                    ORDER BY Rating";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FromDate", fromDate);
                    cmd.Parameters.AddWithValue("@ToDate", toDate);

                    DataTable dt = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }

                    Series series = new Series("Ratings");
                    series.ChartType = SeriesChartType.Column;
                    series.IsValueShownAsLabel = true;

                    foreach (DataRow row in dt.Rows)
                    {
                        int rating = Convert.ToInt32(row["Rating"]);
                        int count = Convert.ToInt32(row["Count"]);
                        series.Points.AddXY($"{rating} Star", count);
                    }

                    reportChart.Series.Add(series);
                    reportChart.Titles.Add($"Feedback Ratings ({fromDate:MM/dd/yyyy} to {toDate:MM/dd/yyyy})");
                }
            }
        }

        private void GenerateMembershipPlanReport()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT mp.PlanName, COUNT(m.MemberID) as MemberCount
                    FROM MembershipPlans mp
                    LEFT JOIN Members m ON mp.PlanID = m.PlanID AND m.Status = 'Active'
                    GROUP BY mp.PlanID, mp.PlanName
                    ORDER BY MemberCount DESC";

                DataTable dt = new DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(dt);
                }

                Series series = new Series("Membership Plans");
                series.ChartType = SeriesChartType.Pie;
                series.IsValueShownAsLabel = true;

                foreach (DataRow row in dt.Rows)
                {
                    string planName = row["PlanName"].ToString();
                    int memberCount = Convert.ToInt32(row["MemberCount"]);
                    series.Points.AddXY(planName, memberCount);
                }

                reportChart.Series.Add(series);
                reportChart.Titles.Add("Active Members by Membership Plan");
            }
        }

        private void GenerateRevenueReport(DateTime fromDate, DateTime toDate)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT 
                        CAST(PaymentDate AS DATE) as PaymentDay,
                        SUM(Amount) as DailyRevenue
                    FROM Payments 
                    WHERE PaymentDate BETWEEN @FromDate AND @ToDate
                    GROUP BY CAST(PaymentDate AS DATE)
                    ORDER BY PaymentDay";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FromDate", fromDate);
                    cmd.Parameters.AddWithValue("@ToDate", toDate);

                    DataTable dt = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }

                    Series series = new Series("Revenue");
                    series.ChartType = SeriesChartType.Line;
                    series.IsValueShownAsLabel = true;
                    series.Color = Color.Green;

                    foreach (DataRow row in dt.Rows)
                    {
                        DateTime paymentDay = Convert.ToDateTime(row["PaymentDay"]);
                        decimal revenue = Convert.ToDecimal(row["DailyRevenue"]);
                        series.Points.AddXY(paymentDay.ToString("MM/dd"), (double)revenue);
                    }

                    reportChart.Series.Add(series);
                    reportChart.Titles.Add($"Daily Revenue ({fromDate:MM/dd/yyyy} to {toDate:MM/dd/yyyy})");
                    reportChart.ChartAreas[0].AxisY.Title = "Revenue ($)";
                }
            }
        }

        private void GenerateAttendanceReport(DateTime fromDate, DateTime toDate)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT 
                        CAST(CheckInTime AS DATE) as CheckInDay,
                        COUNT(*) as DailyAttendance
                    FROM Attendance 
                    WHERE CheckInTime BETWEEN @FromDate AND @ToDate
                    GROUP BY CAST(CheckInTime AS DATE)
                    ORDER BY CheckInDay";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FromDate", fromDate);
                    cmd.Parameters.AddWithValue("@ToDate", toDate);

                    DataTable dt = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }

                    Series series = new Series("Attendance");
                    series.ChartType = SeriesChartType.Column;
                    series.IsValueShownAsLabel = true;
                    series.Color = Color.Blue;

                    foreach (DataRow row in dt.Rows)
                    {
                        DateTime checkInDay = Convert.ToDateTime(row["CheckInDay"]);
                        int attendance = Convert.ToInt32(row["DailyAttendance"]);
                        series.Points.AddXY(checkInDay.ToString("MM/dd"), attendance);
                    }

                    reportChart.Series.Add(series);
                    reportChart.Titles.Add($"Daily Attendance ({fromDate:MM/dd/yyyy} to {toDate:MM/dd/yyyy})");
                }
            }
        }

        private void GenerateReferralRewardsReport()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT RewardStatus, COUNT(*) as Count 
                    FROM Referrals 
                    GROUP BY RewardStatus";

                DataTable dt = new DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(dt);
                }

                Series series = new Series("Referral Rewards");
                series.ChartType = SeriesChartType.Doughnut;
                series.IsValueShownAsLabel = true;

                foreach (DataRow row in dt.Rows)
                {
                    string status = row["RewardStatus"].ToString();
                    int count = Convert.ToInt32(row["Count"]);
                    series.Points.AddXY(status, count);
                }

                reportChart.Series.Add(series);
                reportChart.Titles.Add("Referral Rewards Status Distribution");
            }
        }

        private void GenerateMemberGrowthReport(DateTime fromDate, DateTime toDate)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT 
                        CAST(JoinDate AS DATE) as JoinDay,
                        COUNT(*) as NewMembers
                    FROM Members 
                    WHERE JoinDate BETWEEN @FromDate AND @ToDate
                    GROUP BY CAST(JoinDate AS DATE)
                    ORDER BY JoinDay";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FromDate", fromDate);
                    cmd.Parameters.AddWithValue("@ToDate", toDate);

                    DataTable dt = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }

                    Series series = new Series("New Members");
                    series.ChartType = SeriesChartType.Area;
                    series.IsValueShownAsLabel = true;
                    series.Color = Color.Orange;

                    foreach (DataRow row in dt.Rows)
                    {
                        DateTime joinDay = Convert.ToDateTime(row["JoinDay"]);
                        int newMembers = Convert.ToInt32(row["NewMembers"]);
                        series.Points.AddXY(joinDay.ToString("MM/dd"), newMembers);
                    }

                    reportChart.Series.Add(series);
                    reportChart.Titles.Add($"Member Growth ({fromDate:MM/dd/yyyy} to {toDate:MM/dd/yyyy})");
                }
            }
        }

        // Existing event handlers - kept as requested
        private void label5_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }

        private void comboBox_Report_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateReportTitle();
            GenerateReport();
        }

        private void date_from_ValueChanged(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private void date_to_ValueChanged(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private void button_generate_Click(object sender, EventArgs e)
        {
            GenerateReport();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            // This label now shows the report title
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Empty event handler - chart is handled in InitializeChart()
        }
    }
}