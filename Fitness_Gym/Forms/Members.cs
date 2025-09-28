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
    public partial class Member : Form
    {
        public Member()
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
            // Optional: set defaults on load
            comboBox_Gender.SelectedIndex = -1;
            memplanCB.SelectedIndex = -1;
        }

        private void button_add_Member_Click(object sender, EventArgs e)
        {
            string fullName = textBox_FirstName.Text.Trim() + " " + textBox_LastName.Text.Trim();
            string email = textBox_email.Text.Trim();
            string dob = datepicker_Birthday.Value.ToShortDateString();
            string plan = memplanCB.SelectedItem?.ToString() ?? "";
            string status = "Active"; // you can set this manually or from another control

            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please fill out required fields (Name, Email).", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add values directly into DataGridView
            dataGridView_members_lists.Rows.Add(fullName, email, dob, plan, status);

            ClearFields();
        }

        private void button_update_member_Click(object sender, EventArgs e)
        {
            if(dataGridView_members_lists.CurrentRow != null)
            {
                DataGridViewRow row = dataGridView_members_lists.CurrentRow;

                string fullName = textBox_FirstName.Text.Trim() + " " + textBox_LastName.Text.Trim();
                row.Cells["nameColumn"].Value = fullName;
                row.Cells["emailColumn"].Value = textBox_email.Text.Trim();
                row.Cells["dobColumn"].Value = datepicker_Birthday.Value.ToShortDateString();
                row.Cells["planColumn"].Value = memplanCB.SelectedItem?.ToString() ?? "";
                row.Cells["statusColumn"].Value = "Active";

                ClearFields();
            }
            else
            {
                MessageBox.Show("Please select a member to update.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_delete_member_Click(object sender, EventArgs e)
        {
            if(dataGridView_members_lists.CurrentRow != null)
            {
                dataGridView_members_lists.Rows.RemoveAt(dataGridView_members_lists.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("Please select a member to delete.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView_members_lists_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Populate fields when clicking a row
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_members_lists.Rows[e.RowIndex];

                string[] nameParts = row.Cells["nameColumn"].Value?.ToString().Split(' ');
                if (nameParts.Length > 0) textBox_FirstName.Text = nameParts[0];
                if (nameParts.Length > 1) textBox_LastName.Text = nameParts[1];

                textBox_email.Text = row.Cells["emailColumn"].Value?.ToString();
                datepicker_Birthday.Value = Convert.ToDateTime(row.Cells["dobColumn"].Value);
                memplanCB.Text = row.Cells["planColumn"].Value?.ToString();
            }
        }

        private void ClearFields()
        {
            textBox_FirstName.Clear();
            textBox_LastName.Clear();
            textBox_email.Clear();
            textBox_Contact.Clear();
            comboBox_Gender.SelectedIndex = -1;
            memplanCB.SelectedIndex = -1;
        }
>>>>>>> Stashed changes
    }
}
