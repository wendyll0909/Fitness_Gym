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
    public partial class Membership : Form
    {
        // 🔹 CHANGE this to your own SQL Server connection string
        private string connectionString = @"Data Source=Rendon\SQLEXPRESS;Initial Catalog=PalenersGym;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public Membership()
        {
            InitializeComponent();
            LoadPlansFromDatabase();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // You can leave this empty unless you want to draw custom graphics
        }

        // ✅ Load all plans into DataGridView
        private void LoadPlansFromDatabase()
        {
            dataGridView_plan_list.Rows.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT PlanName, Price, DurationInMonths FROM MembershipPlans";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            dataGridView_plan_list.Rows.Add(reader["PlanName"], reader["Price"], reader["DurationInMonths"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading plans: " + ex.Message);
            }
        }

        // ✅ Add Plan
        private void button_add_plan_Click(object sender, EventArgs e)
        {
            string name = textBox_plan_name.Text.Trim();
            string price = textBox_plan_price.Text.Trim();
            string duration = textBox_plan_duration.Text.Trim();

            if (name == "" || price == "" || duration == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO MembershipPlans (PlanName, Price, DurationInMonths) VALUES (@name, @price, @duration)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@price", decimal.Parse(price));
                        cmd.Parameters.AddWithValue("@duration", int.Parse(duration));

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Plan added successfully!");
                ClearFields();
                LoadPlansFromDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding plan: " + ex.Message);
            }
        }

        // ✅ Update Plan
        private void button_update_plan_Click(object sender, EventArgs e)
        {
            if (dataGridView_plan_list.CurrentRow == null)
            {
                MessageBox.Show("Please select a plan to update.");
                return;
            }

            string oldName = dataGridView_plan_list.CurrentRow.Cells[0].Value.ToString();
            string newName = textBox_plan_name.Text.Trim();
            string price = textBox_plan_price.Text.Trim();
            string duration = textBox_plan_duration.Text.Trim();

            if (newName == "" || price == "" || duration == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"UPDATE MembershipPlans 
                                     SET PlanName = @newName, Price = @price, DurationInMonths = @duration 
                                     WHERE PlanName = @oldName";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@newName", newName);
                        cmd.Parameters.AddWithValue("@price", decimal.Parse(price));
                        cmd.Parameters.AddWithValue("@duration", int.Parse(duration));
                        cmd.Parameters.AddWithValue("@oldName", oldName);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Plan updated successfully!");
                ClearFields();
                LoadPlansFromDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating plan: " + ex.Message);
            }
        }

        // ✅ Delete Plan
        private void button_delete_plan_Click(object sender, EventArgs e)
        {
            if (dataGridView_plan_list.CurrentRow == null)
            {
                MessageBox.Show("Please select a plan to delete.");
                return;
            }

            string planName = dataGridView_plan_list.CurrentRow.Cells[0].Value.ToString();

            DialogResult confirm = MessageBox.Show($"Are you sure you want to delete '{planName}'?",
                                                    "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.No)
                return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM MembershipPlans WHERE PlanName = @name";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", planName);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Plan deleted successfully!");
                LoadPlansFromDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting plan: " + ex.Message);
            }
        }

        // ✅ Clear textboxes after operations
        private void ClearFields()
        {
            textBox_plan_name.Clear();
            textBox_plan_price.Clear();
            textBox_plan_duration.Clear();
        }
    }
}