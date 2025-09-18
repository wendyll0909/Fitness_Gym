namespace Fitness_Gym
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginPanel = new Panel();
            ShowPasswordBtn = new Button();
            createNewAccBtn = new Button();
            panel2 = new Panel();
            ForgetAccLbl = new Label();
            usernameTb = new TextBox();
            passwordTb = new TextBox();
            usernamebtn = new Button();
            label2 = new Label();
            label3 = new Label();
            panel7 = new Panel();
            logout = new MenuStrip();
            profileToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            loginPanel.SuspendLayout();
            panel7.SuspendLayout();
            logout.SuspendLayout();
            SuspendLayout();
            // 
            // loginPanel
            // 
            loginPanel.BackColor = Color.Goldenrod;
            loginPanel.BorderStyle = BorderStyle.FixedSingle;
            loginPanel.Controls.Add(ShowPasswordBtn);
            loginPanel.Controls.Add(createNewAccBtn);
            loginPanel.Controls.Add(panel2);
            loginPanel.Controls.Add(ForgetAccLbl);
            loginPanel.Controls.Add(usernameTb);
            loginPanel.Controls.Add(passwordTb);
            loginPanel.Controls.Add(usernamebtn);
            loginPanel.Location = new Point(135, 232);
            loginPanel.Margin = new Padding(3, 4, 3, 4);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(482, 487);
            loginPanel.TabIndex = 0;
            loginPanel.Paint += loginPanel_Paint;
            // 
            // ShowPasswordBtn
            // 
            ShowPasswordBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowPasswordBtn.Location = new Point(376, 112);
            ShowPasswordBtn.Margin = new Padding(3, 4, 3, 4);
            ShowPasswordBtn.Name = "ShowPasswordBtn";
            ShowPasswordBtn.Size = new Size(86, 68);
            ShowPasswordBtn.TabIndex = 6;
            ShowPasswordBtn.Text = "👁️";
            ShowPasswordBtn.UseVisualStyleBackColor = true;
            ShowPasswordBtn.Click += ShowPasswordBtn_Click;
            // 
            // createNewAccBtn
            // 
            createNewAccBtn.BackColor = Color.Black;
            createNewAccBtn.FlatStyle = FlatStyle.Flat;
            createNewAccBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createNewAccBtn.ForeColor = Color.White;
            createNewAccBtn.Location = new Point(120, 377);
            createNewAccBtn.Margin = new Padding(3, 4, 3, 4);
            createNewAccBtn.Name = "createNewAccBtn";
            createNewAccBtn.Size = new Size(242, 73);
            createNewAccBtn.TabIndex = 5;
            createNewAccBtn.Text = "Create A New Account";
            createNewAccBtn.UseVisualStyleBackColor = false;
            createNewAccBtn.Click += createNewAccBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Goldenrod;
            panel2.Location = new Point(19, 344);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(446, 1);
            panel2.TabIndex = 4;
            // 
            // ForgetAccLbl
            // 
            ForgetAccLbl.AutoSize = true;
            ForgetAccLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForgetAccLbl.ForeColor = Color.White;
            ForgetAccLbl.Location = new Point(162, 288);
            ForgetAccLbl.Name = "ForgetAccLbl";
            ForgetAccLbl.Size = new Size(165, 28);
            ForgetAccLbl.TabIndex = 3;
            ForgetAccLbl.Text = "Forget Account?";
            ForgetAccLbl.Click += ForgetAccLbl_Click;
            // 
            // usernameTb
            // 
            usernameTb.BorderStyle = BorderStyle.FixedSingle;
            usernameTb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameTb.Location = new Point(19, 20);
            usernameTb.Margin = new Padding(3, 4, 3, 4);
            usernameTb.Multiline = true;
            usernameTb.Name = "usernameTb";
            usernameTb.PlaceholderText = "Email or Phone Number";
            usernameTb.Size = new Size(442, 67);
            usernameTb.TabIndex = 1;
            usernameTb.TextChanged += usernameTb_TextChanged;
            // 
            // passwordTb
            // 
            passwordTb.BorderStyle = BorderStyle.FixedSingle;
            passwordTb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordTb.Location = new Point(19, 112);
            passwordTb.Margin = new Padding(3, 4, 3, 4);
            passwordTb.Multiline = true;
            passwordTb.Name = "passwordTb";
            passwordTb.PasswordChar = '*';
            passwordTb.PlaceholderText = "Password";
            passwordTb.Size = new Size(442, 67);
            passwordTb.TabIndex = 2;
            passwordTb.TextChanged += passwordTb_TextChanged;
            // 
            // usernamebtn
            // 
            usernamebtn.BackColor = Color.Black;
            usernamebtn.FlatStyle = FlatStyle.Flat;
            usernamebtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernamebtn.ForeColor = Color.White;
            usernamebtn.Location = new Point(19, 197);
            usernamebtn.Margin = new Padding(3, 4, 3, 4);
            usernamebtn.Name = "usernamebtn";
            usernamebtn.Size = new Size(442, 73);
            usernamebtn.TabIndex = 0;
            usernamebtn.Text = "Login";
            usernamebtn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(86, 387);
            label2.Name = "label2";
            label2.Size = new Size(372, 81);
            label2.TabIndex = 6;
            label2.Text = "Fitness Gym";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(86, 500);
            label3.Name = "label3";
            label3.Size = new Size(704, 90);
            label3.TabIndex = 7;
            label3.Text = "Regular exercise provides significant physical \r\nand mental health advantages. ";
            label3.Click += label3_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(loginPanel);
            panel7.Location = new Point(725, -1);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(723, 937);
            panel7.TabIndex = 8;
            panel7.Paint += panel7_Paint;
            // 
            // logout
            // 
            logout.Dock = DockStyle.None;
            logout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logout.ImageScalingSize = new Size(20, 20);
            logout.Items.AddRange(new ToolStripItem[] { profileToolStripMenuItem, logoutToolStripMenuItem });
            logout.Location = new Point(127, 132);
            logout.Name = "logout";
            logout.Padding = new Padding(7, 3, 0, 3);
            logout.RenderMode = ToolStripRenderMode.Professional;
            logout.Size = new Size(265, 38);
            logout.TabIndex = 9;
            logout.Text = "menuStrip1";
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(14, 32);
            profileToolStripMenuItem.Click += profileToolStripMenuItem_Click_1;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(224, 32);
            toolStripMenuItem1.Text = "Profile";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(92, 32);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1448, 939);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel7);
            Controls.Add(logout);
            MainMenuStrip = logout;
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            panel7.ResumeLayout(false);
            logout.ResumeLayout(false);
            logout.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel loginPanel;
        private Button usernamebtn;
        private TextBox passwordTb;
        private TextBox usernameTb;
        private Label ForgetAccLbl;
        private Button createNewAccBtn;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private Button ShowPasswordBtn;
        private Panel panel7;
        private MenuStrip logout;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem logoutToolStripMenuItem;
    }
}
