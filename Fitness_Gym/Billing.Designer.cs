namespace Fitness_Gym
{
    partial class Billing
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
            menuStrip1 = new MenuStrip();
            file = new ToolStripMenuItem();
            help = new ToolStripMenuItem();
            about = new ToolStripMenuItem();
            sidebar = new Panel();
            logout = new Button();
            reportsSideBar = new Button();
            feedbackSideBar = new Button();
            referralSideBar = new Button();
            billingSideBar = new Button();
            memberSideBar = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            menuStrip1.SuspendLayout();
            sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { file, help, about });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(1418, 38);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // file
            // 
            file.Name = "file";
            file.Size = new Size(56, 32);
            file.Text = "File";
            // 
            // help
            // 
            help.Name = "help";
            help.Size = new Size(67, 32);
            help.Text = "Help";
            // 
            // about
            // 
            about.Name = "about";
            about.Size = new Size(81, 32);
            about.Text = "About";
            // 
            // sidebar
            // 
            sidebar.BackColor = SystemColors.ActiveCaptionText;
            sidebar.Controls.Add(logout);
            sidebar.Controls.Add(reportsSideBar);
            sidebar.Controls.Add(feedbackSideBar);
            sidebar.Controls.Add(referralSideBar);
            sidebar.Controls.Add(billingSideBar);
            sidebar.Controls.Add(memberSideBar);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 38);
            sidebar.Margin = new Padding(3, 4, 3, 4);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(229, 901);
            sidebar.TabIndex = 8;
            // 
            // logout
            // 
            logout.BackColor = Color.Black;
            logout.FlatAppearance.BorderSize = 0;
            logout.FlatStyle = FlatStyle.Flat;
            logout.Font = new Font("Microsoft Sans Serif", 9.75F);
            logout.ForeColor = SystemColors.ButtonHighlight;
            logout.Location = new Point(13, 760);
            logout.Margin = new Padding(3, 4, 3, 4);
            logout.Name = "logout";
            logout.Size = new Size(177, 32);
            logout.TabIndex = 7;
            logout.Text = "Logout";
            logout.TextAlign = ContentAlignment.MiddleLeft;
            logout.UseVisualStyleBackColor = false;
            // 
            // reportsSideBar
            // 
            reportsSideBar.BackColor = Color.Black;
            reportsSideBar.FlatAppearance.BorderSize = 0;
            reportsSideBar.FlatStyle = FlatStyle.Flat;
            reportsSideBar.Font = new Font("Microsoft Sans Serif", 9.75F);
            reportsSideBar.ForeColor = SystemColors.ButtonHighlight;
            reportsSideBar.Location = new Point(13, 543);
            reportsSideBar.Margin = new Padding(3, 4, 3, 4);
            reportsSideBar.Name = "reportsSideBar";
            reportsSideBar.Size = new Size(177, 32);
            reportsSideBar.TabIndex = 6;
            reportsSideBar.Text = "Reports Dashboard";
            reportsSideBar.TextAlign = ContentAlignment.MiddleLeft;
            reportsSideBar.UseVisualStyleBackColor = false;
            // 
            // feedbackSideBar
            // 
            feedbackSideBar.BackColor = Color.Black;
            feedbackSideBar.FlatAppearance.BorderSize = 0;
            feedbackSideBar.FlatStyle = FlatStyle.Flat;
            feedbackSideBar.Font = new Font("Microsoft Sans Serif", 9.75F);
            feedbackSideBar.ForeColor = SystemColors.ButtonHighlight;
            feedbackSideBar.Location = new Point(13, 476);
            feedbackSideBar.Margin = new Padding(3, 4, 3, 4);
            feedbackSideBar.Name = "feedbackSideBar";
            feedbackSideBar.Size = new Size(177, 32);
            feedbackSideBar.TabIndex = 5;
            feedbackSideBar.Text = "Feedback Managment";
            feedbackSideBar.TextAlign = ContentAlignment.MiddleLeft;
            feedbackSideBar.UseVisualStyleBackColor = false;
            // 
            // referralSideBar
            // 
            referralSideBar.BackColor = Color.Black;
            referralSideBar.FlatAppearance.BorderSize = 0;
            referralSideBar.FlatStyle = FlatStyle.Flat;
            referralSideBar.Font = new Font("Microsoft Sans Serif", 9.75F);
            referralSideBar.ForeColor = SystemColors.ButtonHighlight;
            referralSideBar.Location = new Point(13, 403);
            referralSideBar.Margin = new Padding(3, 4, 3, 4);
            referralSideBar.Name = "referralSideBar";
            referralSideBar.Size = new Size(177, 32);
            referralSideBar.TabIndex = 4;
            referralSideBar.Text = "Referral Program";
            referralSideBar.TextAlign = ContentAlignment.MiddleLeft;
            referralSideBar.UseVisualStyleBackColor = false;
            // 
            // billingSideBar
            // 
            billingSideBar.BackColor = Color.Black;
            billingSideBar.FlatAppearance.BorderSize = 0;
            billingSideBar.FlatStyle = FlatStyle.Flat;
            billingSideBar.Font = new Font("Microsoft Sans Serif", 9.75F);
            billingSideBar.ForeColor = SystemColors.ButtonHighlight;
            billingSideBar.Location = new Point(13, 333);
            billingSideBar.Margin = new Padding(3, 4, 3, 4);
            billingSideBar.Name = "billingSideBar";
            billingSideBar.Size = new Size(177, 32);
            billingSideBar.TabIndex = 3;
            billingSideBar.Text = "Billing and Payments";
            billingSideBar.TextAlign = ContentAlignment.MiddleLeft;
            billingSideBar.UseVisualStyleBackColor = false;
            // 
            // memberSideBar
            // 
            memberSideBar.BackColor = Color.Black;
            memberSideBar.FlatAppearance.BorderSize = 0;
            memberSideBar.FlatStyle = FlatStyle.Flat;
            memberSideBar.Font = new Font("Microsoft Sans Serif", 9.75F);
            memberSideBar.ForeColor = SystemColors.ButtonHighlight;
            memberSideBar.Location = new Point(13, 263);
            memberSideBar.Margin = new Padding(3, 4, 3, 4);
            memberSideBar.Name = "memberSideBar";
            memberSideBar.Size = new Size(177, 32);
            memberSideBar.TabIndex = 2;
            memberSideBar.Text = "Member  Registration";
            memberSideBar.TextAlign = ContentAlignment.MiddleLeft;
            memberSideBar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dataGridView1.Location = new Point(229, 582);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1189, 357);
            dataGridView1.TabIndex = 9;
            // 
            // Column1
            // 
            Column1.HeaderText = "MemberID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Plan";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Amount";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Payment Date";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Payment Method";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Created At";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Created By";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.HeaderText = "Updated At";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold);
            label1.Location = new Point(642, 96);
            label1.Name = "label1";
            label1.Size = new Size(334, 45);
            label1.TabIndex = 10;
            label1.Text = "Billing and Payments";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F);
            label2.Location = new Point(278, 186);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 11;
            label2.Text = "Member:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F);
            label4.Location = new Point(278, 279);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 13;
            label4.Text = "Amount:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F);
            label5.Location = new Point(682, 186);
            label5.Name = "label5";
            label5.Size = new Size(120, 20);
            label5.TabIndex = 14;
            label5.Text = "Payment Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F);
            label6.Location = new Point(278, 377);
            label6.Name = "label6";
            label6.Size = new Size(139, 20);
            label6.TabIndex = 15;
            label6.Text = "Payment Method:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(817, 179);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 16;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(300, 418);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(61, 24);
            radioButton1.TabIndex = 18;
            radioButton1.TabStop = true;
            radioButton1.Text = "Cash";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(394, 418);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(69, 24);
            radioButton2.TabIndex = 19;
            radioButton2.TabStop = true;
            radioButton2.Text = "Gcash";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(300, 482);
            button1.Name = "button1";
            button1.Size = new Size(136, 29);
            button1.TabIndex = 20;
            button1.Text = "Save Payment";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(465, 482);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 21;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(359, 178);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 22;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(360, 272);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 23;
            // 
            // Billing
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            ClientSize = new Size(1418, 939);
            Controls.Add(numericUpDown1);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(sidebar);
            Controls.Add(menuStrip1);
            Name = "Billing";
            Text = "Billing";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem file;
        private ToolStripMenuItem help;
        private ToolStripMenuItem about;
        private Panel sidebar;
        private Button logout;
        private Button reportsSideBar;
        private Button feedbackSideBar;
        private Button referralSideBar;
        private Button billingSideBar;
        private Button memberSideBar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button1;
        private Button button2;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
    }
}