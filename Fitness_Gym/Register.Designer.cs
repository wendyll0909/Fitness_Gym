namespace Fitness_Gym
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            panel7 = new Panel();
            loginPanel = new Panel();
            roleCb = new ComboBox();
            confirmPassTb = new TextBox();
            passTb = new TextBox();
            ShowPasswordBtn = new Button();
            createNewAccBtn = new Button();
            panel2 = new Panel();
            usernameTb = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            backtologin = new Button();
            panel7.SuspendLayout();
            loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(loginPanel);
            panel7.Location = new Point(634, -1);
            panel7.Name = "panel7";
            panel7.Size = new Size(633, 703);
            panel7.TabIndex = 9;
            // 
            // loginPanel
            // 
            loginPanel.BackColor = Color.Goldenrod;
            loginPanel.BorderStyle = BorderStyle.FixedSingle;
            loginPanel.Controls.Add(backtologin);
            loginPanel.Controls.Add(roleCb);
            loginPanel.Controls.Add(confirmPassTb);
            loginPanel.Controls.Add(passTb);
            loginPanel.Controls.Add(ShowPasswordBtn);
            loginPanel.Controls.Add(createNewAccBtn);
            loginPanel.Controls.Add(panel2);
            loginPanel.Controls.Add(usernameTb);
            loginPanel.Location = new Point(118, 101);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(422, 438);
            loginPanel.TabIndex = 0;
            // 
            // roleCb
            // 
            roleCb.FormattingEnabled = true;
            roleCb.Items.AddRange(new object[] { "Member", "Admin" });
            roleCb.Location = new Point(17, 92);
            roleCb.Name = "roleCb";
            roleCb.Size = new Size(88, 23);
            roleCb.TabIndex = 12;
            roleCb.SelectedIndexChanged += roleCb_SelectedIndexChanged;
            // 
            // confirmPassTb
            // 
            confirmPassTb.BorderStyle = BorderStyle.FixedSingle;
            confirmPassTb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmPassTb.Location = new Point(17, 172);
            confirmPassTb.Multiline = true;
            confirmPassTb.Name = "confirmPassTb";
            confirmPassTb.PlaceholderText = "Confirm Password";
            confirmPassTb.Size = new Size(387, 34);
            confirmPassTb.TabIndex = 11;
            confirmPassTb.TextChanged += confirmPassTb_TextChanged;
            // 
            // passTb
            // 
            passTb.BorderStyle = BorderStyle.FixedSingle;
            passTb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passTb.Location = new Point(17, 132);
            passTb.Multiline = true;
            passTb.Name = "passTb";
            passTb.PlaceholderText = "Password";
            passTb.Size = new Size(313, 34);
            passTb.TabIndex = 10;
            passTb.TextChanged += passTb_TextChanged;
            // 
            // ShowPasswordBtn
            // 
            ShowPasswordBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowPasswordBtn.Location = new Point(330, 132);
            ShowPasswordBtn.Name = "ShowPasswordBtn";
            ShowPasswordBtn.Size = new Size(74, 34);
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
            createNewAccBtn.Location = new Point(102, 258);
            createNewAccBtn.Name = "createNewAccBtn";
            createNewAccBtn.Size = new Size(212, 55);
            createNewAccBtn.TabIndex = 5;
            createNewAccBtn.Text = "Create";
            createNewAccBtn.UseVisualStyleBackColor = false;
            createNewAccBtn.Click += createNewAccBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Goldenrod;
            panel2.Location = new Point(17, 258);
            panel2.Name = "panel2";
            panel2.Size = new Size(390, 1);
            panel2.TabIndex = 4;
            // 
            // usernameTb
            // 
            usernameTb.BorderStyle = BorderStyle.FixedSingle;
            usernameTb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameTb.Location = new Point(17, 39);
            usernameTb.Multiline = true;
            usernameTb.Name = "usernameTb";
            usernameTb.PlaceholderText = "Username";
            usernameTb.Size = new Size(387, 34);
            usernameTb.TabIndex = 1;
            usernameTb.TextChanged += usernameTb_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(120, 29);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(310, 211);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(104, 274);
            label2.Name = "label2";
            label2.Size = new Size(300, 65);
            label2.TabIndex = 11;
            label2.Text = "Fitness Gym";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(13, 411);
            label3.Name = "label3";
            label3.Size = new Size(553, 70);
            label3.TabIndex = 12;
            label3.Text = "Regular exercise provides significant physical \r\nand mental health advantages. ";
            // 
            // backtologin
            // 
            backtologin.BackColor = SystemColors.ScrollBar;
            backtologin.FlatStyle = FlatStyle.Flat;
            backtologin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backtologin.ForeColor = Color.MidnightBlue;
            backtologin.Location = new Point(102, 341);
            backtologin.Name = "backtologin";
            backtologin.Size = new Size(212, 38);
            backtologin.TabIndex = 13;
            backtologin.Text = "Go Back To Login";
            backtologin.UseVisualStyleBackColor = false;
            backtologin.Click += backtologin_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            ClientSize = new Size(1267, 704);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(panel7);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            panel7.ResumeLayout(false);
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel7;
        private Panel loginPanel;
        private Button ShowPasswordBtn;
        private Button createNewAccBtn;
        private Panel panel2;
        private TextBox usernameTb;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private TextBox passTb;
        private TextBox confirmPassTb;
        private ComboBox roleCb;
        private Button backtologin;
    }
}