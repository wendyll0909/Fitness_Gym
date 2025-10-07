namespace Fitness_Gym.Forms
{
    partial class Member
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
            label1 = new Label();
            textBox_FirstName = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            textBox_LastName = new TextBox();
            label2 = new Label();
            textBox_email = new TextBox();
            label3 = new Label();
            textBox_Contact = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBox_Gender = new ComboBox();
            datepicker_Birthday = new DateTimePicker();
            panel1 = new Panel();
            comboBox_plan = new ComboBox();
            button_delete_member = new Button();
            button_update_member = new Button();
            button_add_Member = new Button();
            label7 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel2 = new Panel();
            dataGridView_members_lists = new DataGridView();
            label9 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_members_lists).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 58);
            label1.Name = "label1";
            label1.Size = new Size(74, 17);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            label1.Click += label1_Click;
            // 
            // textBox_FirstName
            // 
            textBox_FirstName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_FirstName.Location = new Point(31, 78);
            textBox_FirstName.Name = "textBox_FirstName";
            textBox_FirstName.Size = new Size(154, 25);
            textBox_FirstName.TabIndex = 1;
            textBox_FirstName.TextChanged += textBox_FirstName_TextChanged;
            // 
            // textBox_LastName
            // 
            textBox_LastName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_LastName.Location = new Point(261, 78);
            textBox_LastName.Name = "textBox_LastName";
            textBox_LastName.Size = new Size(159, 25);
            textBox_LastName.TabIndex = 3;
            textBox_LastName.TextChanged += textBox_LastName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(261, 58);
            label2.Name = "label2";
            label2.Size = new Size(73, 17);
            label2.TabIndex = 2;
            label2.Text = "Last Name:";
            label2.Click += label2_Click;
            // 
            // textBox_email
            // 
            textBox_email.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_email.Location = new Point(493, 78);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(136, 25);
            textBox_email.TabIndex = 5;
            textBox_email.TextChanged += textBox_email_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(493, 58);
            label3.Name = "label3";
            label3.Size = new Size(42, 17);
            label3.TabIndex = 4;
            label3.Text = "Email:";
            label3.Click += label3_Click;
            // 
            // textBox_Contact
            // 
            textBox_Contact.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Contact.Location = new Point(701, 78);
            textBox_Contact.Name = "textBox_Contact";
            textBox_Contact.Size = new Size(136, 25);
            textBox_Contact.TabIndex = 7;
            textBox_Contact.TextChanged += textBox_Contact_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(701, 58);
            label4.Name = "label4";
            label4.Size = new Size(74, 17);
            label4.TabIndex = 6;
            label4.Text = "Contact no:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(34, 130);
            label5.Name = "label5";
            label5.Size = new Size(54, 17);
            label5.TabIndex = 8;
            label5.Text = "Gender:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(261, 130);
            label6.Name = "label6";
            label6.Size = new Size(84, 17);
            label6.TabIndex = 10;
            label6.Text = "Date of Birth:";
            label6.Click += label6_Click;
            // 
            // comboBox_Gender
            // 
            comboBox_Gender.FormattingEnabled = true;
            comboBox_Gender.Location = new Point(34, 150);
            comboBox_Gender.Name = "comboBox_Gender";
            comboBox_Gender.Size = new Size(136, 23);
            comboBox_Gender.TabIndex = 14;
            comboBox_Gender.Text = "Select Gender...";
            comboBox_Gender.SelectedIndexChanged += comboBox_Gender_SelectedIndexChanged;
            // 
            // datepicker_Birthday
            // 
            datepicker_Birthday.Location = new Point(261, 150);
            datepicker_Birthday.Name = "datepicker_Birthday";
            datepicker_Birthday.Size = new Size(200, 23);
            datepicker_Birthday.TabIndex = 15;
            datepicker_Birthday.ValueChanged += datepicker_Birthday_ValueChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(comboBox_plan);
            panel1.Controls.Add(button_delete_member);
            panel1.Controls.Add(button_update_member);
            panel1.Controls.Add(button_add_Member);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(datepicker_Birthday);
            panel1.Controls.Add(textBox_LastName);
            panel1.Controls.Add(comboBox_Gender);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBox_FirstName);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox_Contact);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox_email);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1028, 253);
            panel1.TabIndex = 16;
            panel1.Paint += panel1_Paint;
            // 
            // comboBox_plan
            // 
            comboBox_plan.FormattingEnabled = true;
            comboBox_plan.Location = new Point(585, 159);
            comboBox_plan.Name = "comboBox_plan";
            comboBox_plan.Size = new Size(121, 23);
            comboBox_plan.TabIndex = 49;
            comboBox_plan.SelectedIndexChanged += comboBox_plan_SelectedIndexChanged;
            // 
            // button_delete_member
            // 
            button_delete_member.BackColor = Color.Salmon;
            button_delete_member.ForeColor = SystemColors.ButtonHighlight;
            button_delete_member.Location = new Point(315, 189);
            button_delete_member.Margin = new Padding(3, 2, 3, 2);
            button_delete_member.Name = "button_delete_member";
            button_delete_member.Size = new Size(136, 42);
            button_delete_member.TabIndex = 48;
            button_delete_member.Text = "Delete";
            button_delete_member.UseVisualStyleBackColor = false;
            button_delete_member.Click += button_delete_member_Click;
            // 
            // button_update_member
            // 
            button_update_member.BackColor = Color.Gold;
            button_update_member.ForeColor = SystemColors.ButtonHighlight;
            button_update_member.Location = new Point(173, 189);
            button_update_member.Margin = new Padding(3, 2, 3, 2);
            button_update_member.Name = "button_update_member";
            button_update_member.Size = new Size(136, 42);
            button_update_member.TabIndex = 47;
            button_update_member.Text = "Update";
            button_update_member.UseVisualStyleBackColor = false;
            button_update_member.Click += button_update_member_Click;
            // 
            // button_add_Member
            // 
            button_add_Member.BackColor = Color.LimeGreen;
            button_add_Member.ForeColor = SystemColors.ButtonHighlight;
            button_add_Member.Location = new Point(31, 189);
            button_add_Member.Margin = new Padding(3, 2, 3, 2);
            button_add_Member.Name = "button_add_Member";
            button_add_Member.Size = new Size(136, 42);
            button_add_Member.TabIndex = 46;
            button_add_Member.Text = "Add";
            button_add_Member.UseVisualStyleBackColor = false;
            button_add_Member.Click += button_add_Member_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(22, 19);
            label7.Name = "label7";
            label7.Size = new Size(148, 21);
            label7.TabIndex = 36;
            label7.Text = "Add New Member";
            label7.Click += label7_Click;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridView_members_lists);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(14, 280);
            panel2.Name = "panel2";
            panel2.Size = new Size(1026, 340);
            panel2.TabIndex = 17;
            panel2.Paint += panel2_Paint;
            // 
            // dataGridView_members_lists
            // 
            dataGridView_members_lists.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_members_lists.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_members_lists.Location = new Point(20, 48);
            dataGridView_members_lists.Name = "dataGridView_members_lists";
            dataGridView_members_lists.Size = new Size(982, 270);
            dataGridView_members_lists.TabIndex = 50;
            dataGridView_members_lists.CellContentClick += dataGridView_members_lists_CellContentClick_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(20, 13);
            label9.Name = "label9";
            label9.Size = new Size(118, 21);
            label9.TabIndex = 49;
            label9.Text = "Members Lists";
            label9.Click += label9_Click;
            // 
            // Member
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 632);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Member";
            Text = "Members";
            Load += Member_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_members_lists).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox textBox_FirstName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox textBox_LastName;
        private Label label2;
        private TextBox textBox_email;
        private Label label3;
        private TextBox textBox_Contact;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBox_Gender;
        private DateTimePicker datepicker_Birthday;
        private Panel panel1;
        private Label label7;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button button_delete_member;
        private Button button_update_member;
        private Button button_add_Member;
        private Panel panel2;
        private DataGridView dataGridView_members_lists;
        private Label label9;
        private ComboBox comboBox_plan;
    }
}