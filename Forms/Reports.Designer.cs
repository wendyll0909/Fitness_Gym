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
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            comboBox2.Location = new Point(654, 111);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 51;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(150, 111);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 50;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F);
            label2.Location = new Point(545, 119);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 49;
            label2.Text = "Date Range:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F);
            label6.Location = new Point(43, 119);
            label6.Name = "label6";
            label6.Size = new Size(110, 20);
            label6.TabIndex = 48;
            label6.Text = "Report Type: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(43, 64);
            label5.Name = "label5";
            label5.Size = new Size(169, 28);
            label5.TabIndex = 47;
            label5.Text = "Generate Report";
            label5.Click += label5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(137, 45);
            label1.TabIndex = 46;
            label1.Text = "Reports";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(43, 251);
            label3.Name = "label3";
            label3.Size = new Size(334, 28);
            label3.TabIndex = 52;
            label3.Text = "Sample Report: Feedback Ratings ";
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(43, 205);
            button1.Name = "button1";
            button1.Size = new Size(140, 29);
            button1.TabIndex = 53;
            button1.Text = "Submit Feedback";
            button1.UseVisualStyleBackColor = false;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 843);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "Reports";
            Text = "Reports";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label1;
        private Label label3;
        private Button button1;
    }
}