using System;
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
    public partial class Members : Form
    {
<<<<<<< Updated upstream
        public Members()
=======
        //sql
        string connectionString = "Data Source=DESKTOP-IL390HQ\\SQLEXPRESS04;Initial Catalog=PalenersGym;Integrated Security=True;Trust Server Certificate=True;";

        public Member()
>>>>>>> Stashed changes
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
<<<<<<< Updated upstream
=======

        private void Member_Load(object sender, EventArgs e)
        {
            dataGridView_members_lists.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_members_lists.MultiSelect = false;
            dataGridView_members_lists.ReadOnly = true;

            LoadMembers();
        }
        private void LoadMembers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT MemberID, FirstName, LastName, Email, ContactNo, Gender, DateOfBirth, MembershipPlan, Status 
                                 FROM Members";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView_members_lists.DataSource = dt;
            }
        }

        private void Button_add_Member_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // ✅ Generate next MemberID
                string getIdQuery = "SELECT ISNULL(MAX(MemberID), 0) + 1 FROM Members";
                SqlCommand getIdCmd = new SqlCommand(getIdQuery, conn);
                int newMemberId = (int)getIdCmd.ExecuteScalar();

                string query = @"INSERT INTO Members 
                                (MemberID, FirstName, LastName, Email, ContactNo, Gender, DateOfBirth, MembershipPlan, Status)
                                VALUES (@MemberID, @FirstName, @LastName, @Email, @ContactNo, @Gender, @DateOfBirth, @MembershipPlan, 'Active')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MemberID", newMemberId);
                cmd.Parameters.AddWithValue("@FirstName", textBox_FirstName.Text);
                cmd.Parameters.AddWithValue("@LastName", textBox_LastName.Text);
                cmd.Parameters.AddWithValue("@Email", textBox_email.Text);
                cmd.Parameters.AddWithValue("@ContactNo", textBox_Contact.Text);
                cmd.Parameters.AddWithValue("@Gender", comboBox_Gender.Text);
                cmd.Parameters.AddWithValue("@DateOfBirth", datepicker_Birthday.Value);
                cmd.Parameters.AddWithValue("@MembershipPlan", comboBox_plan.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Member added successfully!");
                LoadMembers();
                ClearFields();
            }

        }

        private void button_update_member_Click(object sender, EventArgs e)
        {
            if (dataGridView_members_lists.CurrentRow != null)
            {
                int memberId = Convert.ToInt32(dataGridView_members_lists.CurrentRow.Cells["MemberID"].Value);

                MessageBox.Show("Selected MemberID: " + memberId); // ✅ Debugging

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE Members 
                                     SET FirstName=@FirstName, LastName=@LastName, Email=@Email, ContactNo=@ContactNo, 
                                         Gender=@Gender, DateOfBirth=@DateOfBirth, MembershipPlan=@MembershipPlan 
                                     WHERE MemberID=@MemberID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FirstName", textBox_FirstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", textBox_LastName.Text);
                    cmd.Parameters.AddWithValue("@Email", textBox_email.Text);
                    cmd.Parameters.AddWithValue("@ContactNo", textBox_Contact.Text);
                    cmd.Parameters.AddWithValue("@Gender", comboBox_Gender.Text);
                    cmd.Parameters.AddWithValue("@DateOfBirth", datepicker_Birthday.Value);
                    cmd.Parameters.AddWithValue("@MembershipPlan", comboBox_plan.Text);
                    cmd.Parameters.AddWithValue("@MemberID", memberId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    MessageBox.Show("Rows updated: " + rowsAffected);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Member updated successfully!");
                        LoadMembers();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Update failed. No rows affected.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a member to update.");
            }
        }

        private void button_delete_member_Click(object sender, EventArgs e)
        {
            if (dataGridView_members_lists.CurrentRow != null)
            {
                int memberId = Convert.ToInt32(dataGridView_members_lists.CurrentRow.Cells["MemberID"].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Members WHERE MemberID=@MemberID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@MemberID", memberId);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    MessageBox.Show("Rows deleted: " + rowsAffected);

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Member deleted successfully!");
                        LoadMembers();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Delete failed. No rows affected.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a member to delete.");
            }
        }

        private void dataGridView_members_lists_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_members_lists.Rows[e.RowIndex];

                textBox_FirstName.Text = row.Cells["FirstName"].Value.ToString();
                textBox_LastName.Text = row.Cells["LastName"].Value.ToString();
                textBox_email.Text = row.Cells["Email"].Value.ToString();
                textBox_Contact.Text = row.Cells["ContactNo"].Value.ToString();
                comboBox_Gender.Text = row.Cells["Gender"].Value.ToString();
                datepicker_Birthday.Value = Convert.ToDateTime(row.Cells["DateOfBirth"].Value);
                comboBox_plan.Text = row.Cells["MembershipPlan"].Value.ToString();
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
            datepicker_Birthday.Value = DateTime.Now;
        }
>>>>>>> Stashed changes
    }
}
