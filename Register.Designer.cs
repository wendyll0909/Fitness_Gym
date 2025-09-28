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
            ShowPasswordBtn = new Button();
            createNewAccBtn = new Button();
            panel2 = new Panel();
            usernameTb = new TextBox();
            passwordTb = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
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
            panel7.Location = new Point(725, -1);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(723, 937);
            panel7.TabIndex = 9;
            // 
            // loginPanel
            // 
            loginPanel.BackColor = Color.Goldenrod;
            loginPanel.BorderStyle = BorderStyle.FixedSingle;
            loginPanel.Controls.Add(textBox1);
            loginPanel.Controls.Add(textBox2);
            loginPanel.Controls.Add(ShowPasswordBtn);
            loginPanel.Controls.Add(createNewAccBtn);
            loginPanel.Controls.Add(panel2);
            loginPanel.Controls.Add(usernameTb);
            loginPanel.Controls.Add(passwordTb);
            loginPanel.Location = new Point(135, 135);
            loginPanel.Margin = new Padding(3, 4, 3, 4);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(482, 584);
            loginPanel.TabIndex = 0;
            // 
            // ShowPasswordBtn
            // 
            ShowPasswordBtn.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowPasswordBtn.Location = new Point(383, 208);
            ShowPasswordBtn.Margin = new Padding(3, 4, 3, 4);
            ShowPasswordBtn.Name = "ShowPasswordBtn";
            ShowPasswordBtn.Size = new Size(78, 45);
            ShowPasswordBtn.TabIndex = 6;
            ShowPasswordBtn.Text = "👁️";
            ShowPasswordBtn.UseVisualStyleBackColor = true;
            // 
            // createNewAccBtn
            // 
            createNewAccBtn.BackColor = Color.Black;
            createNewAccBtn.FlatStyle = FlatStyle.Flat;
            createNewAccBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createNewAccBtn.ForeColor = Color.White;
            createNewAccBtn.Location = new Point(116, 429);
            createNewAccBtn.Margin = new Padding(3, 4, 3, 4);
            createNewAccBtn.Name = "createNewAccBtn";
            createNewAccBtn.Size = new Size(242, 73);
            createNewAccBtn.TabIndex = 5;
            createNewAccBtn.Text = "Create";
            createNewAccBtn.UseVisualStyleBackColor = false;
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
            // usernameTb
            // 
            usernameTb.BorderStyle = BorderStyle.FixedSingle;
            usernameTb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameTb.Location = new Point(19, 52);
            usernameTb.Margin = new Padding(3, 4, 3, 4);
            usernameTb.Multiline = true;
            usernameTb.Name = "usernameTb";
            usernameTb.PlaceholderText = "Username";
            usernameTb.Size = new Size(442, 45);
            usernameTb.TabIndex = 1;
            // 
            // passwordTb
            // 
            passwordTb.BorderStyle = BorderStyle.FixedSingle;
            passwordTb.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordTb.Location = new Point(19, 291);
            passwordTb.Margin = new Padding(3, 4, 3, 4);
            passwordTb.Multiline = true;
            passwordTb.Name = "passwordTb";
            passwordTb.PasswordChar = '*';
            passwordTb.PlaceholderText = "Confirm Password";
            passwordTb.Size = new Size(442, 45);
            passwordTb.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(137, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(354, 281);
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
            label2.Location = new Point(119, 366);
            label2.Name = "label2";
            label2.Size = new Size(372, 81);
            label2.TabIndex = 11;
            label2.Text = "Fitness Gym";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(15, 548);
            label3.Name = "label3";
            label3.Size = new Size(704, 90);
            label3.TabIndex = 12;
            label3.Text = "Regular exercise provides significant physical \r\nand mental health advantages. ";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(19, 208);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "Password";
            textBox2.Size = new Size(358, 45);
            textBox2.TabIndex = 8;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(19, 122);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Phone Number";
            textBox1.Size = new Size(442, 45);
            textBox1.TabIndex = 9;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Goldenrod;
            ClientSize = new Size(1448, 939);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(panel7);
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
        private TextBox passwordTb;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}