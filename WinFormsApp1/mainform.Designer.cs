namespace WinFormsApp1
{
    partial class mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel_child = new Panel();
            button_dashboard = new Button();
            button_member = new Button();
            panel_sidebar = new Panel();
            button_feedback = new Button();
            button_paymennt = new Button();
            panel2 = new Panel();
            panel_sidebar.SuspendLayout();
            SuspendLayout();
            // 
            // panel_child
            // 
            panel_child.Dock = DockStyle.Fill;
            panel_child.Location = new Point(182, 61);
            panel_child.Name = "panel_child";
            panel_child.Size = new Size(826, 500);
            panel_child.TabIndex = 2;
            // 
            // button_dashboard
            // 
            button_dashboard.Location = new Point(31, 112);
            button_dashboard.Name = "button_dashboard";
            button_dashboard.Size = new Size(118, 23);
            button_dashboard.TabIndex = 0;
            button_dashboard.Text = "button_dashboard";
            button_dashboard.UseVisualStyleBackColor = true;
            button_dashboard.Click += button_dashboard_Click;
            // 
            // button_member
            // 
            button_member.Location = new Point(31, 165);
            button_member.Name = "button_member";
            button_member.Size = new Size(118, 23);
            button_member.TabIndex = 1;
            button_member.Text = "button_member";
            button_member.UseVisualStyleBackColor = true;
            button_member.Click += button_member_Click;
            // 
            // panel_sidebar
            // 
            panel_sidebar.BackColor = SystemColors.ControlDarkDark;
            panel_sidebar.Controls.Add(button_feedback);
            panel_sidebar.Controls.Add(button_paymennt);
            panel_sidebar.Controls.Add(button_member);
            panel_sidebar.Controls.Add(button_dashboard);
            panel_sidebar.Dock = DockStyle.Left;
            panel_sidebar.Location = new Point(0, 0);
            panel_sidebar.Name = "panel_sidebar";
            panel_sidebar.Size = new Size(182, 561);
            panel_sidebar.TabIndex = 0;
            // 
            // button_feedback
            // 
            button_feedback.Location = new Point(32, 261);
            button_feedback.Name = "button_feedback";
            button_feedback.Size = new Size(118, 23);
            button_feedback.TabIndex = 3;
            button_feedback.Text = "button_feedback";
            button_feedback.UseVisualStyleBackColor = true;
            // 
            // button_paymennt
            // 
            button_paymennt.Location = new Point(32, 216);
            button_paymennt.Name = "button_paymennt";
            button_paymennt.Size = new Size(118, 23);
            button_paymennt.TabIndex = 2;
            button_paymennt.Text = "button_payment";
            button_paymennt.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(182, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(826, 61);
            panel2.TabIndex = 1;
            // 
            // mainform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 561);
            Controls.Add(panel_child);
            Controls.Add(panel2);
            Controls.Add(panel_sidebar);
            Name = "mainform";
            Text = "mainform";
            Load += mainform_Load;
            panel_sidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_sidebar;
        private Panel panel2;
        private Panel panel_child;
        // Method to load child forms




        private Button button_feedback;
        private Button button_paymennt;
        private Button button_member;
        private Button button_dashboard;
    }
}