namespace Fitness_Gym.Forms
{
    partial class Reports
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
            comboBox_Report_type = new ComboBox();
            label2 = new Label();
            report_typelbl = new Label();
            label5 = new Label();
            label1 = new Label();
            FeedBackRatings = new Label();
            panel1 = new Panel();
            label7 = new Label();
            label4 = new Label();
            date_to = new DateTimePicker();
            date_from = new DateTimePicker();
            button_generate_report = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox_Report_type
            // 
            comboBox_Report_type.FormattingEnabled = true;
            comboBox_Report_type.Location = new Point(141, 98);
            comboBox_Report_type.Margin = new Padding(3, 2, 3, 2);
            comboBox_Report_type.Name = "comboBox_Report_type";
            comboBox_Report_type.Size = new Size(133, 23);
            comboBox_Report_type.TabIndex = 50;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F);
            label2.Location = new Point(425, 52);
            label2.Name = "label2";
            label2.Size = new Size(83, 16);
            label2.TabIndex = 49;
            label2.Text = "Date Range:";
            label2.Click += label2_Click;
            // 
            // report_typelbl
            // 
            report_typelbl.AutoSize = true;
            report_typelbl.Font = new Font("Microsoft Sans Serif", 9.75F);
            report_typelbl.Location = new Point(28, 103);
            report_typelbl.Name = "report_typelbl";
            report_typelbl.Size = new Size(89, 16);
            report_typelbl.TabIndex = 48;
            report_typelbl.Text = "Report Type: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(28, 48);
            label5.Name = "label5";
            label5.Size = new Size(134, 21);
            label5.TabIndex = 47;
            label5.Text = "Generate Report";
            label5.Click += label5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold);
            label1.Location = new Point(3, 1);
            label1.Name = "label1";
            label1.Size = new Size(107, 35);
            label1.TabIndex = 46;
            label1.Text = "Reports";
            // 
            // FeedBackRatings
            // 
            FeedBackRatings.AutoSize = true;
            FeedBackRatings.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FeedBackRatings.Location = new Point(38, 254);
            FeedBackRatings.Name = "FeedBackRatings";
            FeedBackRatings.Size = new Size(267, 21);
            FeedBackRatings.TabIndex = 52;
            FeedBackRatings.Text = "Sample Report: Feedback Ratings ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(date_to);
            panel1.Controls.Add(date_from);
            panel1.Controls.Add(button_generate_report);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboBox_Report_type);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(report_typelbl);
            panel1.Location = new Point(10, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1022, 224);
            panel1.TabIndex = 54;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F);
            label7.Location = new Point(653, 84);
            label7.Name = "label7";
            label7.Size = new Size(27, 16);
            label7.TabIndex = 56;
            label7.Text = "To:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F);
            label4.Location = new Point(407, 79);
            label4.Name = "label4";
            label4.Size = new Size(41, 16);
            label4.TabIndex = 55;
            label4.Text = "From:";
            // 
            // date_to
            // 
            date_to.Location = new Point(653, 103);
            date_to.Name = "date_to";
            date_to.Size = new Size(200, 23);
            date_to.TabIndex = 54;
            // 
            // date_from
            // 
            date_from.Location = new Point(407, 103);
            date_from.Name = "date_from";
            date_from.Size = new Size(200, 23);
            date_from.TabIndex = 53;
            // 
            // button_generate_report
            // 
            button_generate_report.BackColor = Color.LimeGreen;
            button_generate_report.ForeColor = SystemColors.ButtonHighlight;
            button_generate_report.Location = new Point(45, 147);
            button_generate_report.Margin = new Padding(3, 2, 3, 2);
            button_generate_report.Name = "button_generate_report";
            button_generate_report.Size = new Size(136, 42);
            button_generate_report.TabIndex = 52;
            button_generate_report.Text = "Generate Report";
            button_generate_report.UseVisualStyleBackColor = false;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 632);
            Controls.Add(FeedBackRatings);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Reports";
            Text = "Reports";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox_Report_type;
        private Label label2;
        private Label report_typelbl;
        private Label label5;
        private Label label1;
        private Label FeedBackRatings;
        private Panel panel1;
        private Button button_generate_report;
        private Label label4;
        private DateTimePicker date_to;
        private DateTimePicker date_from;
        private Label label7;
    }
}