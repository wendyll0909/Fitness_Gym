namespace Fitness_Gym.Forms
{
    partial class Dashboard
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel4 = new Panel();
            label_totalmembers_title = new Label();
            label_totalmember_value = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            label5 = new Label();
            label_total_revenue_value = new Label();
            label_total_revenue_title = new Label();
            panel5 = new Panel();
            panel6 = new Panel();
            label3 = new Label();
            label_active_subcription_value = new Label();
            panel7 = new Panel();
            panel8 = new Panel();
            label_topMemberPlan_value = new Label();
            label2 = new Label();
            panel9 = new Panel();
            panel10 = new Panel();
            dataGridView_recent_act = new DataGridView();
            Action = new DataGridViewTextBoxColumn();
            Details = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            label1 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_recent_act).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(label_totalmember_value);
            panel1.Location = new Point(29, 59);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10, 0, 0, 0);
            panel1.Size = new Size(170, 100);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gold;
            panel4.Controls.Add(label_totalmembers_title);
            panel4.Location = new Point(-1, 67);
            panel4.Name = "panel4";
            panel4.Size = new Size(170, 32);
            panel4.TabIndex = 4;
            // 
            // label_totalmembers_title
            // 
            label_totalmembers_title.AutoSize = true;
            label_totalmembers_title.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_totalmembers_title.Location = new Point(29, 6);
            label_totalmembers_title.Name = "label_totalmembers_title";
            label_totalmembers_title.Size = new Size(110, 20);
            label_totalmembers_title.TabIndex = 1;
            label_totalmembers_title.Text = "Total Members";
            label_totalmembers_title.Click += label_totalmembers_title_Click;
            // 
            // label_totalmember_value
            // 
            label_totalmember_value.AutoSize = true;
            label_totalmember_value.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_totalmember_value.Location = new Point(78, 26);
            label_totalmember_value.Name = "label_totalmember_value";
            label_totalmember_value.Size = new Size(17, 20);
            label_totalmember_value.TabIndex = 0;
            label_totalmember_value.Text = "0";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label_total_revenue_value);
            panel2.Location = new Point(290, 59);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10, 0, 0, 0);
            panel2.Size = new Size(170, 100);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gold;
            panel3.Controls.Add(label5);
            panel3.Location = new Point(-1, 67);
            panel3.Name = "panel3";
            panel3.Size = new Size(170, 32);
            panel3.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(46, 6);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 1;
            label5.Text = "Avg. Rating";
            // 
            // label_total_revenue_value
            // 
            label_total_revenue_value.AutoSize = true;
            label_total_revenue_value.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_total_revenue_value.Location = new Point(75, 26);
            label_total_revenue_value.Name = "label_total_revenue_value";
            label_total_revenue_value.Size = new Size(17, 20);
            label_total_revenue_value.TabIndex = 0;
            label_total_revenue_value.Text = "0";
            // 
            // label_total_revenue_title
            // 
            label_total_revenue_title.AutoSize = true;
            label_total_revenue_title.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_total_revenue_title.Location = new Point(35, 6);
            label_total_revenue_title.Name = "label_total_revenue_title";
            label_total_revenue_title.Size = new Size(105, 20);
            label_total_revenue_title.TabIndex = 1;
            label_total_revenue_title.Text = "Total Revenue";
            label_total_revenue_title.Click += label1_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(label_active_subcription_value);
            panel5.Location = new Point(563, 59);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(10, 0, 0, 0);
            panel5.Size = new Size(170, 100);
            panel5.TabIndex = 6;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Gold;
            panel6.Controls.Add(label3);
            panel6.Location = new Point(-1, 67);
            panel6.Name = "panel6";
            panel6.Size = new Size(170, 32);
            panel6.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 6);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 1;
            label3.Text = "Active Members";
            label3.Click += label3_Click;
            // 
            // label_active_subcription_value
            // 
            label_active_subcription_value.AutoSize = true;
            label_active_subcription_value.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_active_subcription_value.Location = new Point(72, 26);
            label_active_subcription_value.Name = "label_active_subcription_value";
            label_active_subcription_value.Size = new Size(17, 20);
            label_active_subcription_value.TabIndex = 0;
            label_active_subcription_value.Text = "0";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(panel8);
            panel7.Controls.Add(label_topMemberPlan_value);
            panel7.Location = new Point(802, 59);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(10, 0, 0, 0);
            panel7.Size = new Size(170, 100);
            panel7.TabIndex = 7;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Gold;
            panel8.Controls.Add(label_total_revenue_title);
            panel8.Location = new Point(-1, 67);
            panel8.Name = "panel8";
            panel8.Size = new Size(170, 32);
            panel8.TabIndex = 4;
            // 
            // label_topMemberPlan_value
            // 
            label_topMemberPlan_value.AutoSize = true;
            label_topMemberPlan_value.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_topMemberPlan_value.Location = new Point(82, 26);
            label_topMemberPlan_value.Name = "label_topMemberPlan_value";
            label_topMemberPlan_value.Size = new Size(17, 20);
            label_topMemberPlan_value.TabIndex = 0;
            label_topMemberPlan_value.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold);
            label2.Location = new Point(19, 14);
            label2.Name = "label2";
            label2.Size = new Size(141, 35);
            label2.TabIndex = 12;
            label2.Text = "Dashboard";
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Controls.Add(label2);
            panel9.Controls.Add(panel7);
            panel9.Controls.Add(panel5);
            panel9.Controls.Add(panel1);
            panel9.Controls.Add(panel2);
            panel9.Location = new Point(16, 12);
            panel9.Name = "panel9";
            panel9.Size = new Size(1024, 182);
            panel9.TabIndex = 13;
            // 
            // panel10
            // 
            panel10.BackColor = Color.White;
            panel10.Controls.Add(dataGridView_recent_act);
            panel10.Controls.Add(label1);
            panel10.Location = new Point(16, 223);
            panel10.Name = "panel10";
            panel10.Size = new Size(1024, 250);
            panel10.TabIndex = 14;
            // 
            // dataGridView_recent_act
            // 
            dataGridView_recent_act.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_recent_act.BackgroundColor = SystemColors.ControlLight;
            dataGridView_recent_act.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_recent_act.Columns.AddRange(new DataGridViewColumn[] { Action, Details, Date });
            dataGridView_recent_act.Location = new Point(19, 70);
            dataGridView_recent_act.Name = "dataGridView_recent_act";
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView_recent_act.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_recent_act.Size = new Size(986, 153);
            dataGridView_recent_act.TabIndex = 13;
            // 
            // Action
            // 
            Action.HeaderText = "Action";
            Action.Name = "Action";
            // 
            // Details
            // 
            Details.HeaderText = "Details";
            Details.Name = "Details";
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.Name = "Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold);
            label1.Location = new Point(19, 12);
            label1.Name = "label1";
            label1.Size = new Size(193, 35);
            label1.TabIndex = 12;
            label1.Text = "Recent Activity";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 632);
            Controls.Add(panel10);
            Controls.Add(panel9);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_recent_act).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label_totalmember_value;
        private Label label_totalmembers_title;
        private Panel panel4;
        private Panel panel2;
        private Panel panel3;
        private Label label_total_revenue_title;
        private Label label_total_revenue_value;
        private Panel panel5;
        private Panel panel6;
        private Label label3;
        private Label label_active_subcription_value;
        private Panel panel7;
        private Panel panel8;
        private Label label5;
        private Label label_topMemberPlan_value;
        private Label label2;
        private Panel panel9;
        private Panel panel10;
        private Label label1;
        private DataGridView dataGridView_recent_act;
        private DataGridViewTextBoxColumn Action;
        private DataGridViewTextBoxColumn Details;
        private DataGridViewTextBoxColumn Date;
    }
}