using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class mainform : Form
    {
        private Button currentButton;
        private Form activeForm;

        public mainform()
        {
            InitializeComponent();
            // Don't load form here, wait for Load event
        }

        private void OpenChildForm(Form childForm)
        {
            try
            {
                // Check if panel_child exists
                if (panel_child == null)
                {
                    MessageBox.Show("panel_child is not initialized. Check your designer code.");
                    return;
                }

                // Close the current active form if it exists
                if (activeForm != null)
                {
                    activeForm.Close();
                    activeForm = null;
                }

                // Configure the new child form
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;

                // Clear existing controls and add the new form
                panel_child.Controls.Clear();
                panel_child.Controls.Add(childForm);
                panel_child.Tag = childForm;

                // Show the form
                childForm.Show();
                childForm.BringToFront();

                // Set as active form
                activeForm = childForm;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Dashboard());
        }

       

        // Add this method to debug the panel_child
        private void CheckPanelChild()
        {
            if (panel_child == null)
            {
                MessageBox.Show("panel_child is null!");
            }
            else
            {
                MessageBox.Show($"panel_child size: {panel_child.Size}, Location: {panel_child.Location}");
            }
        }
        private void mainform_Load(object sender, EventArgs e)
        {
            // Load default form when mainform loads
            OpenChildForm(new Forms.Dashboard());
        }
        private void button_member_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Member());
        }
    }
}