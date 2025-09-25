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
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(66, 46);
            label1.Name = "label1";
            label1.Size = new Size(74, 17);
            label1.TabIndex = 0;
            label1.Text = "First Name:";
            // 
            // textBox_FirstName
            // 
            textBox_FirstName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_FirstName.Location = new Point(139, 43);
            textBox_FirstName.Name = "textBox_FirstName";
            textBox_FirstName.Size = new Size(136, 25);
            textBox_FirstName.TabIndex = 1;
            // 
            // textBox_LastName
            // 
            textBox_LastName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_LastName.Location = new Point(388, 43);
            textBox_LastName.Name = "textBox_LastName";
            textBox_LastName.Size = new Size(136, 25);
            textBox_LastName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(311, 46);
            label2.Name = "label2";
            label2.Size = new Size(73, 17);
            label2.TabIndex = 2;
            label2.Text = "Last Name:";
            label2.Click += label2_Click;
            // 
            // textBox_email
            // 
            textBox_email.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_email.Location = new Point(616, 43);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(136, 25);
            textBox_email.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(539, 46);
            label3.Name = "label3";
            label3.Size = new Size(42, 17);
            label3.TabIndex = 4;
            label3.Text = "Email:";
            // 
            // textBox_Contact
            // 
            textBox_Contact.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Contact.Location = new Point(854, 43);
            textBox_Contact.Name = "textBox_Contact";
            textBox_Contact.Size = new Size(136, 25);
            textBox_Contact.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(777, 46);
            label4.Name = "label4";
            label4.Size = new Size(74, 17);
            label4.TabIndex = 6;
            label4.Text = "Contact no:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(66, 112);
            label5.Name = "label5";
            label5.Size = new Size(54, 17);
            label5.TabIndex = 8;
            label5.Text = "Gender:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(300, 112);
            label6.Name = "label6";
            label6.Size = new Size(84, 17);
            label6.TabIndex = 10;
            label6.Text = "Date of Birth:";
            // 
            // comboBox_Gender
            // 
            comboBox_Gender.FormattingEnabled = true;
            comboBox_Gender.Items.AddRange(new object[] { "Male", "Female" });
            comboBox_Gender.Location = new Point(139, 109);
            comboBox_Gender.Name = "comboBox_Gender";
            comboBox_Gender.Size = new Size(136, 23);
            comboBox_Gender.TabIndex = 14;
            comboBox_Gender.Text = "Select Gender...";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(381, 112);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 15;
            // 
            // Members
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 632);
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
            Name = "Members";
            Text = "Members";
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
        private DateTimePicker dateTimePicker1;
    }
}