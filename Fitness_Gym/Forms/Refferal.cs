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
using System.Configuration;


namespace Fitness_Gym.Forms
{
    public partial class Refferal : Form
    {
        string connectionString = "Data Source=DESKTOP-IL390HQ\\SQLEXPRESS;Initial Catalog=PalenersGym;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;";

        public Refferal()
        {
            InitializeComponent();
            this.Load += Refferal_Load;
        }


        private void Refferal_Load(object sender, EventArgs e)
        {
            LoadMembers();
            LoadReferrals();
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
                    CONCAT(M1.FirstName, ' ', M1.LastName) AS Referrer,
                    CONCAT(M2.FirstName, ' ', M2.LastName) AS ReferredMember,
                    R.ReferralDate,
                    R.RewardStatus
                FROM Referrals R
                JOIN Members M1 ON R.ReferrerID = M1.MemberID
                JOIN Members M2 ON R.ReferredMemberID = M2.MemberID
                ORDER BY R.CreatedAt DESC;";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView_referrals.Rows.Clear();

                    foreach (DataRow row in dt.Rows)
                    {
                        dataGridView_referrals.Rows.Add(
                            row["Referrer"],
                            row["ReferredMember"],
                            Convert.ToDateTime(row["ReferralDate"]).ToString("yyyy-MM-dd"),
                            row["RewardStatus"]
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading referrals: " + ex.Message);
            }
        }


        private void LoadMembers()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT MemberID, CONCAT(FirstName, ' ', LastName) AS FullName FROM Members";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable members = new DataTable();
                    adapter.Fill(members);

                    comboBox_referrer.DataSource = members.Copy();
                    comboBox_referrer.DisplayMember = "FullName";
                    comboBox_referrer.ValueMember = "MemberID";

                    comboBox_referred.DataSource = members;
                    comboBox_referred.DisplayMember = "FullName";
                    comboBox_referred.ValueMember = "MemberID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading members: " + ex.Message);
            }
        }

        private void button_add_referral_Click(object sender, EventArgs e)
        {
            if (comboBox_referrer.SelectedValue == null || comboBox_referred.SelectedValue == null)
            {
                MessageBox.Show("Please select both a referrer and a referred member.");
                return;
            }

            int referrerID = Convert.ToInt32(comboBox_referrer.SelectedValue);
            int referredID = Convert.ToInt32(comboBox_referred.SelectedValue);

            if (referrerID == referredID)
            {
                MessageBox.Show("A member cannot refer themselves.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                INSERT INTO Referrals 
                (ReferrerID, ReferredMemberID, ReferralDate, RewardStatus, CreatedAt, UpdatedAt)
                VALUES (@ReferrerID, @ReferredMemberID, @ReferralDate, @RewardStatus, GETDATE(), GETDATE())";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ReferrerID", referrerID);
                        cmd.Parameters.AddWithValue("@ReferredMemberID", referredID);
                        cmd.Parameters.AddWithValue("@ReferralDate", DateTime.Now.Date);
                        cmd.Parameters.AddWithValue("@RewardStatus", "Pending");
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Referral added successfully!");
                    LoadReferrals();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding referral: " + ex.Message);
            }
        }


    }
}
