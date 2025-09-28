using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Gym.Forms
{
    public partial class Membership : Form
    {
        string connectionString =
            @"Data Source=DESKTOP-IL390HQ\SQLEXPRESS04;
              Initial Catalog=PalenersGym;
              Integrated Security=True;
              TrustServerCertificate=True;";

        public Membership()
        {
            InitializeComponent();
            LoadPlansFromDatabase();
        }
<<<<<<< Updated upstream
=======

        private void LoadPlansFromDatabase()
        {
            dataGridView_plan_list.Rows.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString)) { 

            string query = @"SELECT PlanID, PlanName, Price, DurationDays FROM MembershipPlans";
            
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int rowIndex = dataGridView_plan_list.Rows.Add(
                        reader["PlanName"].ToString(),
                        reader["Price"].ToString(),
                        reader["DurationDays"].ToString());

                    // Store PlanID in the hidden Tag property for updates/deletes
                    dataGridView_plan_list.Rows[rowIndex].Tag = reader["PlanID"];
                }
            }
        }

        private void button_add_plan_Click(object sender, EventArgs e)
        {

            using (SqlConnection conn = new SqlConnection(connectionString)) {

                conn.Open();

            string query = @"INSERT INTO MembershipPlans (PlanName, Price, DurationDays) VALUES (@n,@p,@d)";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@n", textBox_plan_name.Text);
            cmd.Parameters.AddWithValue("@p", textBox_plan_price.Text);
            cmd.Parameters.AddWithValue("@d", int.Parse(textBox_plan_duration.Text));
       
            cmd.ExecuteNonQuery();
            MessageBox.Show("Membership Plan added successfully!");
            LoadPlansFromDatabase();
            ClearInputs();

            }

           
        }

        private void button_update_plan_Click(object sender, EventArgs e)
        {
            if (dataGridView_plan_list.CurrentRow == null || InvalidInput()) return;

            if (dataGridView_plan_list.CurrentRow.Tag == null)
            {
                MessageBox.Show("This row has no database ID. Reload and try again.");
                return;
            }

            int planId = Convert.ToInt32(dataGridView_plan_list.CurrentRow.Tag);

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(
                "UPDATE MembershipPlans SET PlanName=@n, Price=@p, DurationDays=@d WHERE PlanID=@id", con))
            {
                cmd.Parameters.AddWithValue("@n", textBox_plan_name.Text);
                cmd.Parameters.AddWithValue("@p", textBox_plan_price.Text);
                cmd.Parameters.AddWithValue("@d", int.Parse(textBox_plan_duration.Text));
                cmd.Parameters.AddWithValue("@id", planId);
                con.Open();
                cmd.ExecuteNonQuery();
            }

            LoadPlansFromDatabase();
            ClearInputs();
        }

        private void button_delete_plan_Click(object sender, EventArgs e)
        {
            if (dataGridView_plan_list.CurrentRow == null) return;

            if (dataGridView_plan_list.CurrentRow.Tag == null)
            {
                MessageBox.Show("This row has no database ID. Reload and try again.");
                return;
            }

            int planId = Convert.ToInt32(dataGridView_plan_list.CurrentRow.Tag);

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(
                "DELETE FROM MembershipPlans WHERE PlanID=@id", con))
            {
                cmd.Parameters.AddWithValue("@id", planId);
                con.Open();
                cmd.ExecuteNonQuery();
            }

            LoadPlansFromDatabase();
            ClearInputs();
        }

        private bool InvalidInput()
        {
            if (string.IsNullOrWhiteSpace(textBox_plan_name.Text) ||
                string.IsNullOrWhiteSpace(textBox_plan_price.Text) ||
                string.IsNullOrWhiteSpace(textBox_plan_duration.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return true;
            }
            return false;
        }

        private void ClearInputs()
        {
            textBox_plan_name.Clear();
            textBox_plan_price.Clear();
            textBox_plan_duration.Clear();
        }

        private void panel2_Paint(object sender, PaintEventArgs e) { }
>>>>>>> Stashed changes
    }
}
