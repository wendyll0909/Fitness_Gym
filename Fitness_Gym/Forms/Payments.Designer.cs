namespace Fitness_Gym.Forms
{
    partial class Payments
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
            dataGridView_payments_list = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            number_amount = new NumericUpDown();
            comboBox_member = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            comboBox_paymen_method = new ComboBox();
            label3 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            button_add_payment = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_payments_list).BeginInit();
            ((System.ComponentModel.ISupportInitialize)number_amount).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView_payments_list
            // 
            dataGridView_payments_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_payments_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_payments_list.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column8 });
            dataGridView_payments_list.Location = new Point(15, 56);
            dataGridView_payments_list.Margin = new Padding(3, 2, 3, 2);
            dataGridView_payments_list.Name = "dataGridView_payments_list";
            dataGridView_payments_list.RowHeadersWidth = 51;
            dataGridView_payments_list.Size = new Size(996, 261);
            dataGridView_payments_list.TabIndex = 10;
            // 
            // Column1
            // 
            Column1.HeaderText = "MemberID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Plan";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Amount";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Payment Date";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Payment Method";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Created At";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // Column8
            // 
            Column8.HeaderText = "Updated At";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(259, 35);
            label1.TabIndex = 11;
            label1.Text = "Billing and Payments";
            // 
            // number_amount
            // 
            number_amount.Location = new Point(662, 100);
            number_amount.Margin = new Padding(3, 2, 3, 2);
            number_amount.Name = "number_amount";
            number_amount.Size = new Size(131, 23);
            number_amount.TabIndex = 27;
            // 
            // comboBox_member
            // 
            comboBox_member.FormattingEnabled = true;
            comboBox_member.Location = new Point(104, 98);
            comboBox_member.Margin = new Padding(3, 2, 3, 2);
            comboBox_member.Name = "comboBox_member";
            comboBox_member.Size = new Size(163, 23);
            comboBox_member.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F);
            label4.Location = new Point(588, 100);
            label4.Name = "label4";
            label4.Size = new Size(55, 16);
            label4.TabIndex = 25;
            label4.Text = "Amount:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F);
            label2.Location = new Point(36, 100);
            label2.Name = "label2";
            label2.Size = new Size(60, 16);
            label2.TabIndex = 24;
            label2.Text = "Member:";
            // 
            // comboBox_paymen_method
            // 
            comboBox_paymen_method.FormattingEnabled = true;
            comboBox_paymen_method.Location = new Point(415, 98);
            comboBox_paymen_method.Margin = new Padding(3, 2, 3, 2);
            comboBox_paymen_method.Name = "comboBox_paymen_method";
            comboBox_paymen_method.Size = new Size(133, 23);
            comboBox_paymen_method.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F);
            label3.Location = new Point(298, 100);
            label3.Name = "label3";
            label3.Size = new Size(111, 16);
            label3.TabIndex = 28;
            label3.Text = "Payment Method:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 13);
            label5.Name = "label5";
            label5.Size = new Size(187, 30);
            label5.TabIndex = 30;
            label5.Text = "Payment History";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button_add_payment);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(comboBox_paymen_method);
            panel1.Controls.Add(comboBox_member);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(number_amount);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1028, 241);
            panel1.TabIndex = 33;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(dataGridView_payments_list);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(12, 283);
            panel2.Name = "panel2";
            panel2.Size = new Size(1028, 331);
            panel2.TabIndex = 34;
            // 
            // button_add_payment
            // 
            button_add_payment.BackColor = Color.LimeGreen;
            button_add_payment.ForeColor = SystemColors.ButtonHighlight;
            button_add_payment.Location = new Point(66, 167);
            button_add_payment.Margin = new Padding(3, 2, 3, 2);
            button_add_payment.Name = "button_add_payment";
            button_add_payment.Size = new Size(136, 42);
            button_add_payment.TabIndex = 47;
            button_add_payment.Text = "Add Payment";
            button_add_payment.UseVisualStyleBackColor = false;
            // 
            // Payments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 632);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Payments";
            Text = "Payments";
            ((System.ComponentModel.ISupportInitialize)dataGridView_payments_list).EndInit();
            ((System.ComponentModel.ISupportInitialize)number_amount).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView_payments_list;
        private Label label1;
        private NumericUpDown number_amount;
        private ComboBox comboBox_member;
        private Label label4;
        private Label label2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column8;
        private ComboBox comboBox_paymen_method;
        private Label label3;
        private Label label5;
        private Panel panel1;
        private Panel panel2;
        private Button button_add_payment;
    }
}