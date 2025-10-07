namespace Fitness_Gym.Forms
{
    partial class Refferal
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
            components = new System.ComponentModel.Container();
            bindingSource1 = new BindingSource(components);
            colorDialog1 = new ColorDialog();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
<<<<<<< Updated upstream
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button1 = new Button();
=======
            panel1 = new Panel();
            comboBox_referred = new ComboBox();
            button_add_referral = new Button();
            comboBox_referrer = new ComboBox();
            panel2 = new Panel();
>>>>>>> Stashed changes
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold);
<<<<<<< Updated upstream
            label1.Location = new Point(53, 56);
=======
            label1.Location = new Point(14, 19);
>>>>>>> Stashed changes
            label1.Name = "label1";
            label1.Size = new Size(279, 45);
            label1.TabIndex = 12;
            label1.Text = "Referral Program";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
<<<<<<< Updated upstream
            label5.Location = new Point(53, 141);
=======
            label5.Location = new Point(39, 80);
>>>>>>> Stashed changes
            label5.Name = "label5";
            label5.Size = new Size(132, 28);
            label5.TabIndex = 31;
            label5.Text = "Add Referral";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F);
<<<<<<< Updated upstream
            label6.Location = new Point(53, 222);
=======
            label6.Location = new Point(99, 139);
>>>>>>> Stashed changes
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 32;
            label6.Text = "Referrer:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F);
<<<<<<< Updated upstream
            label2.Location = new Point(555, 222);
=======
            label2.Location = new Point(515, 143);
>>>>>>> Stashed changes
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 33;
            label2.Text = "Referred Member:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
<<<<<<< Updated upstream
            label3.Location = new Point(24, 478);
=======
            label3.Location = new Point(14, 20);
>>>>>>> Stashed changes
            label3.Name = "label3";
            label3.Size = new Size(97, 28);
            label3.TabIndex = 34;
            label3.Text = "Referrals";
            // 
            // dataGridView1
            // 
<<<<<<< Updated upstream
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(1, 519);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1201, 324);
            dataGridView1.TabIndex = 35;
=======
            dataGridView_referrals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_referrals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_referrals.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView_referrals.Location = new Point(14, 71);
            dataGridView_referrals.Name = "dataGridView_referrals";
            dataGridView_referrals.RowHeadersWidth = 51;
            dataGridView_referrals.Size = new Size(1143, 381);
            dataGridView_referrals.TabIndex = 35;
>>>>>>> Stashed changes
            // 
            // Column1
            // 
            Column1.HeaderText = "Referrer";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Referred";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Date";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Status";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // comboBox1
            // 
<<<<<<< Updated upstream
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(150, 214);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 36;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(720, 214);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 37;
=======
            panel1.BackColor = Color.White;
            panel1.Controls.Add(comboBox_referred);
            panel1.Controls.Add(button_add_referral);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboBox_referrer);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(14, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1175, 307);
            panel1.TabIndex = 39;
            // 
            // comboBox_referred
            // 
            comboBox_referred.FormattingEnabled = true;
            comboBox_referred.Location = new Point(655, 139);
            comboBox_referred.Name = "comboBox_referred";
            comboBox_referred.Size = new Size(203, 28);
            comboBox_referred.TabIndex = 48;
            // 
            // button_add_referral
            // 
            button_add_referral.BackColor = Color.LimeGreen;
            button_add_referral.ForeColor = SystemColors.ButtonHighlight;
            button_add_referral.Location = new Point(99, 201);
            button_add_referral.Name = "button_add_referral";
            button_add_referral.Size = new Size(155, 56);
            button_add_referral.TabIndex = 47;
            button_add_referral.Text = "Add Referral";
            button_add_referral.UseVisualStyleBackColor = false;
            button_add_referral.Click += button_add_referral_Click;
>>>>>>> Stashed changes
            // 
            // button1
            // 
<<<<<<< Updated upstream
            button1.BackColor = Color.LimeGreen;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(49, 293);
            button1.Name = "button1";
            button1.Size = new Size(136, 29);
            button1.TabIndex = 38;
            button1.Text = "Add Referral";
            button1.UseVisualStyleBackColor = false;
=======
            comboBox_referrer.FormattingEnabled = true;
            comboBox_referrer.Location = new Point(208, 133);
            comboBox_referrer.Name = "comboBox_referrer";
            comboBox_referrer.Size = new Size(203, 28);
            comboBox_referrer.TabIndex = 36;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridView_referrals);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(14, 353);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1175, 473);
            panel2.TabIndex = 40;
>>>>>>> Stashed changes
            // 
            // Refferal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 843);
<<<<<<< Updated upstream
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
=======
            Controls.Add(panel1);
            Controls.Add(panel2);
>>>>>>> Stashed changes
            Name = "Refferal";
            Text = "Refferal";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BindingSource bindingSource1;
        private ColorDialog colorDialog1;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button button1;
    }
}