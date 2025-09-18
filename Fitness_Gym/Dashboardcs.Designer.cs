namespace Fitness_Gym
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            sidebar = new Panel();
            logout = new Button();
            reportsSideBar = new Button();
            feedbackSideBar = new Button();
            referralSideBar = new Button();
            billingSideBar = new Button();
            memberSideBar = new Button();
            fnameLbl = new Label();
            lnameLbl = new Label();
            emailLbl = new Label();
            phoneLbl = new Label();
            addressLbl = new Label();
            joinDateLbl = new Label();
            memPlanLbl = new Label();
            emergencyLbl = new Label();
            dataGridView1 = new DataGridView();
            MemberID = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            fnameTxtBox = new TextBox();
            lnameTxtBox = new TextBox();
            emailTxtBox = new TextBox();
            phoneTxtBox = new TextBox();
            addressTxtBox = new TextBox();
            joinDateDateTimePicker1 = new DateTimePicker();
            file = new ToolStripMenuItem();
            help = new ToolStripMenuItem();
            about = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            memPlanComboBox1 = new ComboBox();
            emgncyContactTxtBox = new TextBox();
            saveBtn = new Button();
            clearBtn = new Button();
            backBtn = new Button();
            sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
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
            sidebar.TabIndex = 4;
            sidebar.Paint += sidebar_Paint;
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
            logout.Click += logout_Click;
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
            reportsSideBar.Click += reportsSideBar_Click;
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
            feedbackSideBar.Click += feedbackSideBar_Click;
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
            referralSideBar.Click += referralSideBar_Click;
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
            billingSideBar.Click += billingSideBar_Click;
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
            memberSideBar.Click += memberSideBar_Click;
            // 
            // fnameLbl
            // 
            fnameLbl.AutoSize = true;
            fnameLbl.Font = new Font("Segoe UI", 11F);
            fnameLbl.Location = new Point(256, 120);
            fnameLbl.Name = "fnameLbl";
            fnameLbl.Size = new Size(97, 25);
            fnameLbl.TabIndex = 8;
            fnameLbl.Text = "FirstName";
            fnameLbl.Click += fnameLbl_Click;
            // 
            // lnameLbl
            // 
            lnameLbl.AutoSize = true;
            lnameLbl.Font = new Font("Segoe UI", 11F);
            lnameLbl.Location = new Point(256, 179);
            lnameLbl.Name = "lnameLbl";
            lnameLbl.Size = new Size(95, 25);
            lnameLbl.TabIndex = 9;
            lnameLbl.Text = "LastName";
            lnameLbl.Click += lnameLbl_Click;
            // 
            // emailLbl
            // 
            emailLbl.AutoSize = true;
            emailLbl.Font = new Font("Segoe UI", 11F);
            emailLbl.Location = new Point(256, 237);
            emailLbl.Name = "emailLbl";
            emailLbl.Size = new Size(58, 25);
            emailLbl.TabIndex = 10;
            emailLbl.Text = "Email";
            emailLbl.Click += emailLbl_Click;
            // 
            // phoneLbl
            // 
            phoneLbl.AutoSize = true;
            phoneLbl.Font = new Font("Segoe UI", 11F);
            phoneLbl.Location = new Point(256, 295);
            phoneLbl.Name = "phoneLbl";
            phoneLbl.Size = new Size(66, 25);
            phoneLbl.TabIndex = 11;
            phoneLbl.Text = "Phone";
            phoneLbl.Click += phoneLbl_Click;
            // 
            // addressLbl
            // 
            addressLbl.AutoSize = true;
            addressLbl.Font = new Font("Segoe UI", 11F);
            addressLbl.Location = new Point(256, 351);
            addressLbl.Name = "addressLbl";
            addressLbl.Size = new Size(79, 25);
            addressLbl.TabIndex = 12;
            addressLbl.Text = "Address";
            addressLbl.Click += addressLbl_Click;
            // 
            // joinDateLbl
            // 
            joinDateLbl.AutoSize = true;
            joinDateLbl.Font = new Font("Segoe UI", 11F);
            joinDateLbl.Location = new Point(256, 412);
            joinDateLbl.Name = "joinDateLbl";
            joinDateLbl.Size = new Size(90, 25);
            joinDateLbl.TabIndex = 13;
            joinDateLbl.Text = "Join Date";
            joinDateLbl.Click += joinDateLbl_Click;
            // 
            // memPlanLbl
            // 
            memPlanLbl.AutoSize = true;
            memPlanLbl.Font = new Font("Segoe UI", 11F);
            memPlanLbl.Location = new Point(256, 467);
            memPlanLbl.Name = "memPlanLbl";
            memPlanLbl.Size = new Size(160, 25);
            memPlanLbl.TabIndex = 14;
            memPlanLbl.Text = "Membership Plan";
            memPlanLbl.Click += memPlanLbl_Click;
            // 
            // emergencyLbl
            // 
            emergencyLbl.AutoSize = true;
            emergencyLbl.Font = new Font("Segoe UI", 11F);
            emergencyLbl.Location = new Point(238, 521);
            emergencyLbl.Name = "emergencyLbl";
            emergencyLbl.Size = new Size(175, 25);
            emergencyLbl.TabIndex = 15;
            emergencyLbl.Text = "Emergency Contact";
            emergencyLbl.Click += emergencyLbl_Click;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MemberID, Column4, Column1, Column2, Column5, Address, Column3 });
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(229, 582);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1189, 357);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // MemberID
            // 
            MemberID.FillWeight = 150F;
            MemberID.HeaderText = "MemberID";
            MemberID.MinimumWidth = 6;
            MemberID.Name = "MemberID";
            MemberID.ReadOnly = true;
            MemberID.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "First Name";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // Column1
            // 
            Column1.FillWeight = 150F;
            Column1.HeaderText = "Last Name";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.FillWeight = 150F;
            Column2.HeaderText = "Email";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column5
            // 
            Column5.HeaderText = "Phone";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 150;
            // 
            // Address
            // 
            Address.HeaderText = "Address";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            Address.Width = 150;
            // 
            // Column3
            // 
            Column3.FillWeight = 150F;
            Column3.HeaderText = "Join Date";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // fnameTxtBox
            // 
            fnameTxtBox.BorderStyle = BorderStyle.FixedSingle;
            fnameTxtBox.Font = new Font("Segoe UI", 12F);
            fnameTxtBox.Location = new Point(367, 112);
            fnameTxtBox.Margin = new Padding(3, 4, 3, 4);
            fnameTxtBox.Multiline = true;
            fnameTxtBox.Name = "fnameTxtBox";
            fnameTxtBox.Size = new Size(252, 39);
            fnameTxtBox.TabIndex = 17;
            fnameTxtBox.TextChanged += fnameTxtBox_TextChanged;
            // 
            // lnameTxtBox
            // 
            lnameTxtBox.BorderStyle = BorderStyle.FixedSingle;
            lnameTxtBox.Font = new Font("Segoe UI", 12F);
            lnameTxtBox.Location = new Point(367, 171);
            lnameTxtBox.Margin = new Padding(3, 4, 3, 4);
            lnameTxtBox.Multiline = true;
            lnameTxtBox.Name = "lnameTxtBox";
            lnameTxtBox.Size = new Size(252, 39);
            lnameTxtBox.TabIndex = 18;
            lnameTxtBox.TextChanged += lnameTxtBox_TextChanged;
            // 
            // emailTxtBox
            // 
            emailTxtBox.BorderStyle = BorderStyle.FixedSingle;
            emailTxtBox.Font = new Font("Segoe UI", 12F);
            emailTxtBox.Location = new Point(367, 229);
            emailTxtBox.Margin = new Padding(3, 4, 3, 4);
            emailTxtBox.Multiline = true;
            emailTxtBox.Name = "emailTxtBox";
            emailTxtBox.Size = new Size(252, 39);
            emailTxtBox.TabIndex = 19;
            emailTxtBox.TextChanged += emailTxtBox_TextChanged;
            // 
            // phoneTxtBox
            // 
            phoneTxtBox.BorderStyle = BorderStyle.FixedSingle;
            phoneTxtBox.Font = new Font("Segoe UI", 12F);
            phoneTxtBox.Location = new Point(367, 287);
            phoneTxtBox.Margin = new Padding(3, 4, 3, 4);
            phoneTxtBox.Multiline = true;
            phoneTxtBox.Name = "phoneTxtBox";
            phoneTxtBox.Size = new Size(252, 39);
            phoneTxtBox.TabIndex = 20;
            phoneTxtBox.TextChanged += phoneTxtBox_TextChanged;
            // 
            // addressTxtBox
            // 
            addressTxtBox.BorderStyle = BorderStyle.FixedSingle;
            addressTxtBox.Font = new Font("Segoe UI", 12F);
            addressTxtBox.Location = new Point(367, 344);
            addressTxtBox.Margin = new Padding(3, 4, 3, 4);
            addressTxtBox.Multiline = true;
            addressTxtBox.Name = "addressTxtBox";
            addressTxtBox.Size = new Size(252, 39);
            addressTxtBox.TabIndex = 21;
            addressTxtBox.TextChanged += addressTxtBox_TextChanged;
            // 
            // joinDateDateTimePicker1
            // 
            joinDateDateTimePicker1.Font = new Font("Segoe UI", 12F);
            joinDateDateTimePicker1.Location = new Point(367, 404);
            joinDateDateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            joinDateDateTimePicker1.Name = "joinDateDateTimePicker1";
            joinDateDateTimePicker1.Size = new Size(252, 34);
            joinDateDateTimePicker1.TabIndex = 22;
            joinDateDateTimePicker1.ValueChanged += joinDateDateTimePicker1_ValueChanged;
            // 
            // file
            // 
            file.Name = "file";
            file.Size = new Size(56, 32);
            file.Text = "File";
            file.Click += file_Click;
            // 
            // help
            // 
            help.Name = "help";
            help.Size = new Size(67, 32);
            help.Text = "Help";
            help.Click += help_Click;
            // 
            // about
            // 
            about.Name = "about";
            about.Size = new Size(81, 32);
            about.Text = "About";
            about.Click += about_Click;
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
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // memPlanComboBox1
            // 
            memPlanComboBox1.FormattingEnabled = true;
            memPlanComboBox1.Location = new Point(410, 468);
            memPlanComboBox1.Margin = new Padding(3, 4, 3, 4);
            memPlanComboBox1.Name = "memPlanComboBox1";
            memPlanComboBox1.Size = new Size(209, 28);
            memPlanComboBox1.TabIndex = 23;
            memPlanComboBox1.SelectedIndexChanged += memPlanComboBox1_SelectedIndexChanged;
            // 
            // emgncyContactTxtBox
            // 
            emgncyContactTxtBox.BorderStyle = BorderStyle.FixedSingle;
            emgncyContactTxtBox.Font = new Font("Segoe UI", 12F);
            emgncyContactTxtBox.Location = new Point(419, 516);
            emgncyContactTxtBox.Margin = new Padding(3, 4, 3, 4);
            emgncyContactTxtBox.Multiline = true;
            emgncyContactTxtBox.Name = "emgncyContactTxtBox";
            emgncyContactTxtBox.Size = new Size(200, 39);
            emgncyContactTxtBox.TabIndex = 24;
            emgncyContactTxtBox.TextChanged += emgncyContactTxtBox_TextChanged;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(680, 108);
            saveBtn.Margin = new Padding(3, 4, 3, 4);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(86, 31);
            saveBtn.TabIndex = 25;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(680, 172);
            clearBtn.Margin = new Padding(3, 4, 3, 4);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(86, 31);
            clearBtn.TabIndex = 26;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // backBtn
            // 
            backBtn.Location = new Point(680, 239);
            backBtn.Margin = new Padding(3, 4, 3, 4);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(86, 31);
            backBtn.TabIndex = 27;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            backBtn.Click += backBtn_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1418, 939);
            Controls.Add(backBtn);
            Controls.Add(clearBtn);
            Controls.Add(saveBtn);
            Controls.Add(emgncyContactTxtBox);
            Controls.Add(memPlanComboBox1);
            Controls.Add(joinDateDateTimePicker1);
            Controls.Add(addressTxtBox);
            Controls.Add(phoneTxtBox);
            Controls.Add(emailTxtBox);
            Controls.Add(lnameTxtBox);
            Controls.Add(fnameTxtBox);
            Controls.Add(dataGridView1);
            Controls.Add(emergencyLbl);
            Controls.Add(memPlanLbl);
            Controls.Add(joinDateLbl);
            Controls.Add(addressLbl);
            Controls.Add(phoneLbl);
            Controls.Add(emailLbl);
            Controls.Add(lnameLbl);
            Controls.Add(fnameLbl);
            Controls.Add(sidebar);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox fnameTxtBox;
        private Panel sidebar;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button billingSideBar;
        private Button memberSideBar;
        private Button reportsSideBar;
        private Button feedbackSideBar;
        private Button referralSideBar;
        private Button logout;
        private Label fnameLbl;
        private Label lnameLbl;
        private Label emailLbl;
        private Label phoneLbl;
        private Label addressLbl;
        private Label joinDateLbl;
        private Label memPlanLbl;
        private Label emergencyLbl;
        private DataGridView dataGridView1;
        private TextBox lnameTxtBox;
        private TextBox emailTxtBox;
        private TextBox phoneTxtBox;
        private TextBox addressTxtBox;
        private DateTimePicker joinDateDateTimePicker1;
        private ToolStripMenuItem file;
        private ToolStripMenuItem help;
        private ToolStripMenuItem about;
        private MenuStrip menuStrip1;
        private ComboBox memPlanComboBox1;
        private TextBox emgncyContactTxtBox;
        private DataGridViewTextBoxColumn MemberID;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn Column3;
        private Button saveBtn;
        private Button clearBtn;
        private Button backBtn;
    }
}