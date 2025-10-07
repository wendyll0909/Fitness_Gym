namespace Fitness_Gym.Forms
{
    partial class Members
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
<<<<<<< Updated upstream
            dateTimePicker1 = new DateTimePicker();
=======
            datepicker_Birthday = new DateTimePicker();
            panel1 = new Panel();
            button_delete_member = new Button();
            button_update_member = new Button();
            Button_add_Member = new Button();
            comboBox_plan = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel2 = new Panel();
            dataGridView_members_lists = new DataGridView();
            nameColumn = new DataGridViewTextBoxColumn();
            emailColumn = new DataGridViewTextBoxColumn();
            dobColumn = new DataGridViewTextBoxColumn();
            planColumn = new DataGridViewTextBoxColumn();
            statusColumn = new DataGridViewTextBoxColumn();
            label9 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_members_lists).BeginInit();
>>>>>>> Stashed changes
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            label1.Location = new Point(75, 61);
=======
            label1.Location = new Point(35, 77);
>>>>>>> Stashed changes
=======
            label1.Location = new Point(35, 77);
>>>>>>> Stashed changes
            label1.Name = "label1";
            label1.Size = new Size(96, 23);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // textBox_FirstName
            // 
            textBox_FirstName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            textBox_FirstName.Location = new Point(159, 57);
            textBox_FirstName.Margin = new Padding(3, 4, 3, 4);
            textBox_FirstName.Name = "textBox_FirstName";
            textBox_FirstName.Size = new Size(155, 29);
=======
            textBox_FirstName.Location = new Point(35, 104);
            textBox_FirstName.Margin = new Padding(3, 4, 3, 4);
            textBox_FirstName.Name = "textBox_FirstName";
            textBox_FirstName.Size = new Size(175, 29);
>>>>>>> Stashed changes
=======
            textBox_FirstName.Location = new Point(35, 104);
            textBox_FirstName.Margin = new Padding(3, 4, 3, 4);
            textBox_FirstName.Name = "textBox_FirstName";
            textBox_FirstName.Size = new Size(175, 29);
>>>>>>> Stashed changes
            textBox_FirstName.TabIndex = 1;
            // 
            // textBox_LastName
            // 
            textBox_LastName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            textBox_LastName.Location = new Point(443, 57);
            textBox_LastName.Margin = new Padding(3, 4, 3, 4);
            textBox_LastName.Name = "textBox_LastName";
            textBox_LastName.Size = new Size(155, 29);
=======
            textBox_LastName.Location = new Point(298, 104);
            textBox_LastName.Margin = new Padding(3, 4, 3, 4);
            textBox_LastName.Name = "textBox_LastName";
            textBox_LastName.Size = new Size(181, 29);
>>>>>>> Stashed changes
=======
            textBox_LastName.Location = new Point(298, 104);
            textBox_LastName.Margin = new Padding(3, 4, 3, 4);
            textBox_LastName.Name = "textBox_LastName";
            textBox_LastName.Size = new Size(181, 29);
>>>>>>> Stashed changes
            textBox_LastName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            label2.Location = new Point(355, 61);
=======
            label2.Location = new Point(298, 77);
>>>>>>> Stashed changes
=======
            label2.Location = new Point(298, 77);
>>>>>>> Stashed changes
            label2.Name = "label2";
            label2.Size = new Size(95, 23);
            label2.TabIndex = 2;
            label2.Text = "Last Name:";
            label2.Click += label2_Click;
            // 
            // textBox_email
            // 
            textBox_email.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            textBox_email.Location = new Point(704, 57);
=======
            textBox_email.Location = new Point(563, 104);
>>>>>>> Stashed changes
=======
            textBox_email.Location = new Point(563, 104);
>>>>>>> Stashed changes
            textBox_email.Margin = new Padding(3, 4, 3, 4);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(155, 29);
            textBox_email.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            label3.Location = new Point(616, 61);
=======
            label3.Location = new Point(563, 77);
>>>>>>> Stashed changes
=======
            label3.Location = new Point(563, 77);
>>>>>>> Stashed changes
            label3.Name = "label3";
            label3.Size = new Size(55, 23);
            label3.TabIndex = 4;
            label3.Text = "Email:";
            // 
            // textBox_Contact
            // 
            textBox_Contact.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            textBox_Contact.Location = new Point(976, 57);
=======
            textBox_Contact.Location = new Point(801, 104);
>>>>>>> Stashed changes
=======
            textBox_Contact.Location = new Point(801, 104);
>>>>>>> Stashed changes
            textBox_Contact.Margin = new Padding(3, 4, 3, 4);
            textBox_Contact.Name = "textBox_Contact";
            textBox_Contact.Size = new Size(155, 29);
            textBox_Contact.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            label4.Location = new Point(888, 61);
=======
            label4.Location = new Point(801, 77);
>>>>>>> Stashed changes
=======
            label4.Location = new Point(801, 77);
>>>>>>> Stashed changes
            label4.Name = "label4";
            label4.Size = new Size(99, 23);
            label4.TabIndex = 6;
            label4.Text = "Contact no:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            label5.Location = new Point(75, 149);
=======
            label5.Location = new Point(39, 173);
>>>>>>> Stashed changes
=======
            label5.Location = new Point(39, 173);
>>>>>>> Stashed changes
            label5.Name = "label5";
            label5.Size = new Size(70, 23);
            label5.TabIndex = 8;
            label5.Text = "Gender:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            label6.Location = new Point(343, 149);
=======
            label6.Location = new Point(298, 173);
>>>>>>> Stashed changes
=======
            label6.Location = new Point(298, 173);
>>>>>>> Stashed changes
            label6.Name = "label6";
            label6.Size = new Size(111, 23);
            label6.TabIndex = 10;
            label6.Text = "Date of Birth:";
            // 
            // comboBox_Gender
            // 
            comboBox_Gender.FormattingEnabled = true;
<<<<<<< Updated upstream
            comboBox_Gender.Items.AddRange(new object[] { "Male", "Female" });
<<<<<<< Updated upstream
            comboBox_Gender.Location = new Point(159, 145);
=======
            comboBox_Gender.Location = new Point(39, 200);
>>>>>>> Stashed changes
=======
            comboBox_Gender.Location = new Point(39, 200);
>>>>>>> Stashed changes
            comboBox_Gender.Margin = new Padding(3, 4, 3, 4);
            comboBox_Gender.Name = "comboBox_Gender";
            comboBox_Gender.Size = new Size(155, 28);
            comboBox_Gender.TabIndex = 14;
            comboBox_Gender.Text = "Select Gender...";
            // 
            // dateTimePicker1
            // 
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            dateTimePicker1.Location = new Point(460, 145);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 27);
            dateTimePicker1.TabIndex = 15;
=======
=======
>>>>>>> Stashed changes
            datepicker_Birthday.Location = new Point(298, 200);
            datepicker_Birthday.Margin = new Padding(3, 4, 3, 4);
            datepicker_Birthday.Name = "datepicker_Birthday";
            datepicker_Birthday.Size = new Size(228, 27);
            datepicker_Birthday.TabIndex = 15;
>>>>>>> Stashed changes
            // 
            // Members
            // 
<<<<<<< Updated upstream
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 843);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox_Gender);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox_Contact);
            Controls.Add(label4);
            Controls.Add(textBox_email);
            Controls.Add(label3);
            Controls.Add(textBox_LastName);
            Controls.Add(label2);
            Controls.Add(textBox_FirstName);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Members";
=======
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button_delete_member);
            panel1.Controls.Add(button_update_member);
            panel1.Controls.Add(Button_add_Member);
            panel1.Controls.Add(comboBox_plan);
            panel1.Controls.Add(label8);
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
            panel1.Location = new Point(14, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1175, 337);
            panel1.TabIndex = 16;
            // 
            // button_delete_member
            // 
            button_delete_member.BackColor = Color.Salmon;
            button_delete_member.ForeColor = SystemColors.ButtonHighlight;
            button_delete_member.Location = new Point(360, 252);
            button_delete_member.Name = "button_delete_member";
            button_delete_member.Size = new Size(155, 56);
            button_delete_member.TabIndex = 48;
            button_delete_member.Text = "Delete";
            button_delete_member.UseVisualStyleBackColor = false;
<<<<<<< Updated upstream
=======
            button_delete_member.Click += button_delete_member_Click;
>>>>>>> Stashed changes
            // 
            // button_update_member
            // 
            button_update_member.BackColor = Color.Gold;
            button_update_member.ForeColor = SystemColors.ButtonHighlight;
            button_update_member.Location = new Point(198, 252);
            button_update_member.Name = "button_update_member";
            button_update_member.Size = new Size(155, 56);
            button_update_member.TabIndex = 47;
            button_update_member.Text = "Update";
            button_update_member.UseVisualStyleBackColor = false;
<<<<<<< Updated upstream
=======
            button_update_member.Click += button_update_member_Click;
>>>>>>> Stashed changes
            // 
            // Button_add_Member
            // 
<<<<<<< Updated upstream
            Button_add_Member.BackColor = Color.LimeGreen;
            Button_add_Member.ForeColor = SystemColors.ButtonHighlight;
            Button_add_Member.Location = new Point(35, 252);
            Button_add_Member.Name = "Button_add_Member";
            Button_add_Member.Size = new Size(155, 56);
            Button_add_Member.TabIndex = 46;
            Button_add_Member.Text = "Add";
            Button_add_Member.UseVisualStyleBackColor = false;
=======
            button_add_Member.BackColor = Color.LimeGreen;
            button_add_Member.ForeColor = SystemColors.ButtonHighlight;
            button_add_Member.Location = new Point(35, 252);
            button_add_Member.Name = "button_add_Member";
            button_add_Member.Size = new Size(155, 56);
            button_add_Member.TabIndex = 46;
            button_add_Member.Text = "Add";
            button_add_Member.UseVisualStyleBackColor = false;
            button_add_Member.Click += button_add_Member_Click;
>>>>>>> Stashed changes
            // 
            // comboBox_plan
            // 
            comboBox_plan.FormattingEnabled = true;
<<<<<<< Updated upstream
            comboBox_plan.Items.AddRange(new object[] { "Daily Pass", "Monthly Basic", "Quarterly Basic", "Annual Basic" });
=======
>>>>>>> Stashed changes
            comboBox_plan.Location = new Point(587, 200);
            comboBox_plan.Margin = new Padding(3, 4, 3, 4);
            comboBox_plan.Name = "comboBox_plan";
            comboBox_plan.Size = new Size(155, 28);
            comboBox_plan.TabIndex = 38;
            comboBox_plan.Text = "Select Plan..";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(587, 173);
            label8.Name = "label8";
            label8.Size = new Size(147, 23);
            label8.TabIndex = 37;
            label8.Text = "Membership Plan:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(25, 25);
            label7.Name = "label7";
            label7.Size = new Size(184, 28);
            label7.TabIndex = 36;
            label7.Text = "Add New Member";
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
            panel2.Location = new Point(16, 373);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1173, 453);
            panel2.TabIndex = 17;
            // 
            // dataGridView_members_lists
            // 
            dataGridView_members_lists.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_members_lists.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
<<<<<<< Updated upstream
            dataGridView_members_lists.Columns.AddRange(new DataGridViewColumn[] { nameColumn, emailColumn, dobColumn, planColumn, statusColumn });
=======
>>>>>>> Stashed changes
            dataGridView_members_lists.Location = new Point(23, 64);
            dataGridView_members_lists.Margin = new Padding(3, 4, 3, 4);
            dataGridView_members_lists.Name = "dataGridView_members_lists";
            dataGridView_members_lists.RowHeadersWidth = 51;
            dataGridView_members_lists.Size = new Size(1122, 360);
            dataGridView_members_lists.TabIndex = 50;
            // 
            // nameColumn
            // 
            nameColumn.HeaderText = "Name";
            nameColumn.MinimumWidth = 6;
            nameColumn.Name = "nameColumn";
            // 
            // emailColumn
            // 
            emailColumn.HeaderText = "Email";
            emailColumn.MinimumWidth = 6;
            emailColumn.Name = "emailColumn";
            // 
            // dobColumn
            // 
            dobColumn.HeaderText = "Date of Birth";
            dobColumn.MinimumWidth = 6;
            dobColumn.Name = "dobColumn";
            // 
            // planColumn
            // 
            planColumn.HeaderText = "Plan";
            planColumn.MinimumWidth = 6;
            planColumn.Name = "planColumn";
            // 
            // statusColumn
            // 
            statusColumn.HeaderText = "Status";
            statusColumn.MinimumWidth = 6;
            statusColumn.Name = "statusColumn";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(23, 17);
            label9.Name = "label9";
            label9.Size = new Size(148, 28);
            label9.TabIndex = 49;
            label9.Text = "Members Lists";
            // 
            // Member
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 843);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Member";
>>>>>>> Stashed changes
            Text = "Members";
<<<<<<< Updated upstream
=======
            Load += Member_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_members_lists).EndInit();
>>>>>>> Stashed changes
            ResumeLayout(false);
            PerformLayout();
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
<<<<<<< Updated upstream
        private DateTimePicker dateTimePicker1;
=======
        private DateTimePicker datepicker_Birthday;
        private Panel panel1;
        private Label label7;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ComboBox comboBox_plan;
        private Label label8;
        private Button button_delete_member;
        private Button button_update_member;
        private Button Button_add_Member;
        private Panel panel2;
        private DataGridView dataGridView_members_lists;
        private Label label9;
        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn emailColumn;
        private DataGridViewTextBoxColumn dobColumn;
        private DataGridViewTextBoxColumn planColumn;
        private DataGridViewTextBoxColumn statusColumn;
>>>>>>> Stashed changes
    }
}