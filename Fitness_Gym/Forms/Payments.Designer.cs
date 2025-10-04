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
            label1 = new Label();
            number_amount = new NumericUpDown();
            comboBox_member = new ComboBox();
            label4 = new Label();
            label2 = new Label();
            comboBox_paymen_method = new ComboBox();
            label3 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            button_add_payment = new Button();
            panel2 = new Panel();
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
            dataGridView_payments_list.Location = new Point(15, 56);
            dataGridView_payments_list.Margin = new Padding(3, 2, 3, 2);
            dataGridView_payments_list.Name = "dataGridView_payments_list";
            dataGridView_payments_list.RowHeadersWidth = 51;
            dataGridView_payments_list.Size = new Size(996, 261);
            dataGridView_payments_list.TabIndex = 10;
            dataGridView_payments_list.CellContentClick += dataGridView_payments_list_CellContentClick;
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
            label1.Click += label1_Click;
            // 
            // number_amount
            // 
            number_amount.Location = new Point(662, 100);
            number_amount.Margin = new Padding(3, 2, 3, 2);
            number_amount.Name = "number_amount";
            number_amount.Size = new Size(131, 23);
            number_amount.TabIndex = 27;
            number_amount.ValueChanged += number_amount_ValueChanged;
            // 
            // comboBox_member
            // 
            comboBox_member.FormattingEnabled = true;
            comboBox_member.Location = new Point(104, 98);
            comboBox_member.Margin = new Padding(3, 2, 3, 2);
            comboBox_member.Name = "comboBox_member";
            comboBox_member.Size = new Size(163, 23);
            comboBox_member.TabIndex = 26;
            comboBox_member.SelectedIndexChanged += comboBox_member_SelectedIndexChanged;
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
            label4.Click += label4_Click;
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
            label2.Click += label2_Click;
            // 
            // comboBox_paymen_method
            // 
            comboBox_paymen_method.FormattingEnabled = true;
            comboBox_paymen_method.Location = new Point(415, 98);
            comboBox_paymen_method.Margin = new Padding(3, 2, 3, 2);
            comboBox_paymen_method.Name = "comboBox_paymen_method";
            comboBox_paymen_method.Size = new Size(133, 23);
            comboBox_paymen_method.TabIndex = 29;
            comboBox_paymen_method.SelectedIndexChanged += comboBox_paymen_method_SelectedIndexChanged;
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
            label3.Click += label3_Click;
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
            label5.Click += label5_Click;
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
            panel1.Paint += panel1_Paint;
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
            button_add_payment.Click += button_add_payment_Click;
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
            panel2.Paint += panel2_Paint;
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
            Load += Payments_Load;
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
        private ComboBox comboBox_paymen_method;
        private Label label3;
        private Label label5;
        private Panel panel1;
        private Panel panel2;
        private Button button_add_payment;
    }
}