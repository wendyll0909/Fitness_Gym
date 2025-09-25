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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            loginPanel = new Panel();
            ShowPasswordBtn = new Button();
            panel2 = new Panel();
            ForgetAccLbl = new Label();
            usernameTb = new TextBox();
            passwordTb = new TextBox();
            usernamebtn = new Button();
            label2 = new Label();
            label3 = new Label();
            panel7 = new Panel();
            pictureBox1 = new PictureBox();
            loginPanel.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loginPanel
            // 
            loginPanel.BackColor = Color.Goldenrod;
            loginPanel.BorderStyle = BorderStyle.FixedSingle;
            loginPanel.Controls.Add(ShowPasswordBtn);
            loginPanel.Controls.Add(panel2);
            loginPanel.Controls.Add(ForgetAccLbl);
            loginPanel.Controls.Add(usernameTb);
            loginPanel.Controls.Add(passwordTb);
            loginPanel.Controls.Add(usernamebtn);
            loginPanel.Location = new Point(118, 174);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(422, 366);
            loginPanel.TabIndex = 0;
            loginPanel.Paint += loginPanel_Paint;
            // 
            // ShowPasswordBtn
            // 
            ShowPasswordBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowPasswordBtn.Location = new Point(329, 84);
            ShowPasswordBtn.Name = "ShowPasswordBtn";
            ShowPasswordBtn.Size = new Size(75, 51);
            ShowPasswordBtn.TabIndex = 6;
            ShowPasswordBtn.Text = "👁️";
            ShowPasswordBtn.UseVisualStyleBackColor = true;
            ShowPasswordBtn.Click += ShowPasswordBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Goldenrod;
            panel2.Location = new Point(17, 258);
            panel2.Name = "panel2";
            panel2.Size = new Size(390, 1);
            panel2.TabIndex = 4;
            // 
            // ForgetAccLbl
            // 
            ForgetAccLbl.AutoSize = true;
            ForgetAccLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForgetAccLbl.ForeColor = Color.White;
            ForgetAccLbl.Location = new Point(133, 276);
            ForgetAccLbl.Name = "ForgetAccLbl";
            ForgetAccLbl.Size = new Size(132, 21);
            ForgetAccLbl.TabIndex = 3;
            ForgetAccLbl.Text = "Forget Account?";
            ForgetAccLbl.Click += ForgetAccLbl_Click;
            // 
            // usernameTb
            // 
            usernameTb.BorderStyle = BorderStyle.FixedSingle;
            usernameTb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameTb.Location = new Point(17, 15);
            usernameTb.Multiline = true;
            usernameTb.Name = "usernameTb";
            usernameTb.PlaceholderText = "Username";
            usernameTb.Size = new Size(387, 51);
            usernameTb.TabIndex = 1;
            usernameTb.TextChanged += usernameTb_TextChanged;
            // 
            // passwordTb
            // 
            passwordTb.BorderStyle = BorderStyle.FixedSingle;
            passwordTb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordTb.Location = new Point(17, 84);
            passwordTb.Multiline = true;
            passwordTb.Name = "passwordTb";
            passwordTb.PasswordChar = '*';
            passwordTb.PlaceholderText = "Password";
            passwordTb.Size = new Size(387, 51);
            passwordTb.TabIndex = 2;
            passwordTb.TextChanged += passwordTb_TextChanged;
            // 
            // usernamebtn
            // 
            usernamebtn.BackColor = Color.Black;
            usernamebtn.FlatStyle = FlatStyle.Flat;
            usernamebtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernamebtn.ForeColor = Color.White;
            usernamebtn.Location = new Point(17, 148);
            usernamebtn.Name = "usernamebtn";
            usernamebtn.Size = new Size(387, 55);
            usernamebtn.TabIndex = 0;
            usernamebtn.Text = "Login";
            usernamebtn.UseVisualStyleBackColor = false;
            usernamebtn.Click += usernamebtn_Click;
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
            label3.Location = new Point(13, 411);
            label3.Name = "label3";
            label3.Size = new Size(553, 70);
            label3.TabIndex = 7;
            label3.Text = "Regular exercise provides significant physical \r\nand mental health advantages. ";
            label3.Click += label3_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(loginPanel);
            panel7.Location = new Point(634, -1);
            panel7.Name = "panel7";
            panel7.Size = new Size(633, 703);
            panel7.TabIndex = 8;
            panel7.Paint += panel7_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(120, 29);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(310, 211);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1264, 681);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel7);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += LoginForm_Load;
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel loginPanel;
        private Button usernamebtn;
        private TextBox passwordTb;
        private TextBox usernameTb;
        private Label ForgetAccLbl;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private Button ShowPasswordBtn;
        private Panel panel7;
        private PictureBox pictureBox1;
    }
}
