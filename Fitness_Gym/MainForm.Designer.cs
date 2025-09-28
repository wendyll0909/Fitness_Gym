namespace Fitness_Gym
{
    partial class MainForm
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
            panel1 = new Panel();
            label1 = new Label();
            sidebar_button_plan = new Button();
            sidebar_button_logout = new Button();
            sidebar_button_reports = new Button();
            sidebar_button_feedback = new Button();
            sidebar_button_refferal = new Button();
            sidebar_button_payments = new Button();
            sidebar_button_members = new Button();
            sidebar_button_dashboard = new Button();
            panel_child = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 51, 70);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(sidebar_button_plan);
            panel1.Controls.Add(sidebar_button_logout);
            panel1.Controls.Add(sidebar_button_reports);
            panel1.Controls.Add(sidebar_button_feedback);
            panel1.Controls.Add(sidebar_button_refferal);
            panel1.Controls.Add(sidebar_button_payments);
            panel1.Controls.Add(sidebar_button_members);
            panel1.Controls.Add(sidebar_button_dashboard);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(207, 681);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(18, 12);
            label1.Name = "label1";
            label1.Size = new Size(178, 31);
            label1.TabIndex = 11;
            label1.Text = "PalenersGym";
            // 
            // sidebar_button_plan
            // 
            sidebar_button_plan.FlatStyle = FlatStyle.Flat;
            sidebar_button_plan.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sidebar_button_plan.ForeColor = SystemColors.Control;
            sidebar_button_plan.Location = new Point(18, 395);
            sidebar_button_plan.Margin = new Padding(3, 15, 3, 3);
            sidebar_button_plan.Name = "sidebar_button_plan";
            sidebar_button_plan.Size = new Size(156, 36);
            sidebar_button_plan.TabIndex = 10;
            sidebar_button_plan.Text = "Management Membership Plan";
            sidebar_button_plan.Click += sidebar_button_plan_Click;
            sidebar_button_plan.MouseEnter += ButtonHoverEnter;
            sidebar_button_plan.MouseLeave += ButtonHoverLeave;
            // 
            // sidebar_button_logout
            // 
            sidebar_button_logout.FlatStyle = FlatStyle.Flat;
            sidebar_button_logout.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sidebar_button_logout.ForeColor = SystemColors.Control;
            sidebar_button_logout.Location = new Point(25, 577);
            sidebar_button_logout.Name = "sidebar_button_logout";
            sidebar_button_logout.Size = new Size(156, 36);
            sidebar_button_logout.TabIndex = 9;
            sidebar_button_logout.Text = "Log Out";
            sidebar_button_logout.Click += sidebar_button_logout_Click;
            sidebar_button_logout.MouseEnter += ButtonHoverEnter;
            sidebar_button_logout.MouseLeave += ButtonHoverLeave;
            // 
            // sidebar_button_reports
            // 
            sidebar_button_reports.FlatStyle = FlatStyle.Flat;
            sidebar_button_reports.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sidebar_button_reports.ForeColor = SystemColors.Control;
            sidebar_button_reports.Location = new Point(25, 341);
            sidebar_button_reports.Margin = new Padding(3, 15, 3, 3);
            sidebar_button_reports.Name = "sidebar_button_reports";
            sidebar_button_reports.Size = new Size(156, 36);
            sidebar_button_reports.TabIndex = 7;
            sidebar_button_reports.Text = "Reports";
            sidebar_button_reports.Click += sidebar_button_reports_Click;
            sidebar_button_reports.MouseEnter += ButtonHoverEnter;
            sidebar_button_reports.MouseLeave += ButtonHoverLeave;
            // 
            // sidebar_button_feedback
            // 
            sidebar_button_feedback.FlatStyle = FlatStyle.Flat;
            sidebar_button_feedback.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sidebar_button_feedback.ForeColor = SystemColors.Control;
            sidebar_button_feedback.Location = new Point(25, 287);
            sidebar_button_feedback.Margin = new Padding(3, 15, 3, 3);
            sidebar_button_feedback.Name = "sidebar_button_feedback";
            sidebar_button_feedback.Size = new Size(156, 36);
            sidebar_button_feedback.TabIndex = 6;
            sidebar_button_feedback.Text = "Feedback Management";
            sidebar_button_feedback.Click += sidebar_button_feedback_Click;
            sidebar_button_feedback.MouseEnter += ButtonHoverEnter;
            sidebar_button_feedback.MouseLeave += ButtonHoverLeave;
            // 
            // sidebar_button_refferal
            // 
            sidebar_button_refferal.FlatStyle = FlatStyle.Flat;
            sidebar_button_refferal.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sidebar_button_refferal.ForeColor = SystemColors.Control;
            sidebar_button_refferal.Location = new Point(25, 233);
            sidebar_button_refferal.Margin = new Padding(3, 15, 3, 3);
            sidebar_button_refferal.Name = "sidebar_button_refferal";
            sidebar_button_refferal.Size = new Size(156, 36);
            sidebar_button_refferal.TabIndex = 5;
            sidebar_button_refferal.Text = "Referal Program";
            sidebar_button_refferal.Click += sidebar_button_refferal_Click;
            sidebar_button_refferal.MouseEnter += ButtonHoverEnter;
            sidebar_button_refferal.MouseLeave += ButtonHoverLeave;
            // 
            // sidebar_button_payments
            // 
            sidebar_button_payments.FlatStyle = FlatStyle.Flat;
            sidebar_button_payments.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sidebar_button_payments.ForeColor = SystemColors.Control;
            sidebar_button_payments.Location = new Point(25, 179);
            sidebar_button_payments.Margin = new Padding(3, 15, 3, 3);
            sidebar_button_payments.Name = "sidebar_button_payments";
            sidebar_button_payments.Size = new Size(156, 36);
            sidebar_button_payments.TabIndex = 4;
            sidebar_button_payments.Text = "Billing and Payments";
            sidebar_button_payments.Click += sidebar_button_payments_Click;
            sidebar_button_payments.MouseEnter += ButtonHoverEnter;
            sidebar_button_payments.MouseLeave += ButtonHoverLeave;
            // 
            // sidebar_button_members
            // 
            sidebar_button_members.FlatStyle = FlatStyle.Flat;
            sidebar_button_members.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sidebar_button_members.ForeColor = SystemColors.Control;
            sidebar_button_members.Location = new Point(25, 125);
            sidebar_button_members.Margin = new Padding(3, 15, 3, 3);
            sidebar_button_members.Name = "sidebar_button_members";
            sidebar_button_members.Size = new Size(156, 36);
            sidebar_button_members.TabIndex = 3;
            sidebar_button_members.Text = "Members Registraion";
            sidebar_button_members.Click += sidebar_button_members_Click;
            sidebar_button_members.MouseEnter += ButtonHoverEnter;
            sidebar_button_members.MouseLeave += ButtonHoverLeave;
            // 
            // sidebar_button_dashboard
            // 
            sidebar_button_dashboard.FlatStyle = FlatStyle.Flat;
            sidebar_button_dashboard.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sidebar_button_dashboard.ForeColor = SystemColors.Control;
            sidebar_button_dashboard.Location = new Point(25, 71);
            sidebar_button_dashboard.Margin = new Padding(3, 15, 3, 3);
            sidebar_button_dashboard.Name = "sidebar_button_dashboard";
            sidebar_button_dashboard.Size = new Size(156, 36);
            sidebar_button_dashboard.TabIndex = 2;
            sidebar_button_dashboard.Text = "Dashboard";
            sidebar_button_dashboard.Click += sidebar_button_dashboard_Click;
            sidebar_button_dashboard.MouseEnter += ButtonHoverEnter;
            sidebar_button_dashboard.MouseLeave += ButtonHoverLeave;
            // 
            // panel_child
            // 
            panel_child.Location = new Point(206, 0);
            panel_child.Name = "panel_child";
            panel_child.Size = new Size(1078, 681);
            panel_child.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1285, 681);
            Controls.Add(panel_child);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button sidebar_button_dashboard;
        private Button sidebar_button_feedback;
        private Button sidebar_button_refferal;
        private Button sidebar_button_payments;
        private Button sidebar_button_members;
        private Button sidebar_button_reports;
        private Button sidebar_button_logout;
        private Panel panel_child;
        private Button sidebar_button_plan;
        private Label label1;
    }
}