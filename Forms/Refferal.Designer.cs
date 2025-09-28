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
            dataGridView_referrals = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            button_add_referral = new Button();
            comboBox_referrer = new ComboBox();
            comboBox_referred = new ComboBox();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_referrals).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold);
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(216, 35);
            label1.TabIndex = 12;
            label1.Text = "Referral Program";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(34, 60);
            label5.Name = "label5";
            label5.Size = new Size(105, 21);
            label5.TabIndex = 31;
            label5.Text = "Add Referral";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F);
            label6.Location = new Point(87, 104);
            label6.Name = "label6";
            label6.Size = new Size(59, 16);
            label6.TabIndex = 32;
            label6.Text = "Referrer:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F);
            label2.Location = new Point(451, 107);
            label2.Name = "label2";
            label2.Size = new Size(116, 16);
            label2.TabIndex = 33;
            label2.Text = "Referred Member:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 15);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 34;
            label3.Text = "Referrals";
            // 
            // dataGridView_referrals
            // 
            dataGridView_referrals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_referrals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_referrals.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView_referrals.Location = new Point(12, 53);
            dataGridView_referrals.Margin = new Padding(3, 2, 3, 2);
            dataGridView_referrals.Name = "dataGridView_referrals";
            dataGridView_referrals.RowHeadersWidth = 51;
            dataGridView_referrals.Size = new Size(1000, 286);
            dataGridView_referrals.TabIndex = 35;
            // 
            // Column1
            // 
            Column1.HeaderText = "Referrer";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Referred";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Date";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Status";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(comboBox_referred);
            panel1.Controls.Add(button_add_referral);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboBox_referrer);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1028, 230);
            panel1.TabIndex = 39;
            // 
            // button_add_referral
            // 
            button_add_referral.BackColor = Color.LimeGreen;
            button_add_referral.ForeColor = SystemColors.ButtonHighlight;
            button_add_referral.Location = new Point(87, 151);
            button_add_referral.Margin = new Padding(3, 2, 3, 2);
            button_add_referral.Name = "button_add_referral";
            button_add_referral.Size = new Size(136, 42);
            button_add_referral.TabIndex = 47;
            button_add_referral.Text = "Add Referral";
            button_add_referral.UseVisualStyleBackColor = false;
            // 
            // comboBox_referrer
            // 
            comboBox_referrer.FormattingEnabled = true;
            comboBox_referrer.Location = new Point(182, 100);
            comboBox_referrer.Margin = new Padding(3, 2, 3, 2);
            comboBox_referrer.Name = "comboBox_referrer";
            comboBox_referrer.Size = new Size(178, 23);
            comboBox_referrer.TabIndex = 36;
            // 
            // comboBox_referred
            // 
            comboBox_referred.FormattingEnabled = true;
            comboBox_referred.Location = new Point(573, 104);
            comboBox_referred.Margin = new Padding(3, 2, 3, 2);
            comboBox_referred.Name = "comboBox_referred";
            comboBox_referred.Size = new Size(178, 23);
            comboBox_referred.TabIndex = 48;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridView_referrals);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(12, 265);
            panel2.Name = "panel2";
            panel2.Size = new Size(1028, 355);
            panel2.TabIndex = 40;
            // 
            // Refferal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 632);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Refferal";
            Text = "Refferal";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_referrals).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bindingSource1;
        private ColorDialog colorDialog1;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label2;
        private Label label3;
        private DataGridView dataGridView_referrals;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Panel panel1;
        private ComboBox comboBox_referred;
        private Button button_add_referral;
        private ComboBox comboBox_referrer;
        private Panel panel2;
    }
}