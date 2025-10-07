namespace Fitness_Gym.Forms
{
    partial class Membership
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
            label7 = new Label();
            label2 = new Label();
            label6 = new Label();
            label3 = new Label();
            label5 = new Label();
            label1 = new Label();
            dataGridView_plan_list = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            panel2 = new Panel();
            textBox_plan_duration = new TextBox();
            textBox_plan_price = new TextBox();
            textBox_plan_name = new TextBox();
            button_delete_plan = new Button();
            button_update_plan = new Button();
            button_add_plan = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_plan_list).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F);
            label7.Location = new Point(129, 125);
            label7.Name = "label7";
            label7.Size = new Size(101, 16);
            label7.TabIndex = 53;
            label7.Text = "Duration (days):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F);
            label2.Location = new Point(424, 85);
            label2.Name = "label2";
            label2.Size = new Size(41, 16);
            label2.TabIndex = 50;
            label2.Text = "Price:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F);
            label6.Location = new Point(129, 85);
            label6.Name = "label6";
            label6.Size = new Size(37, 16);
            label6.TabIndex = 49;
            label6.Text = "Plan:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 16);
            label3.Name = "label3";
            label3.Size = new Size(151, 21);
            label3.TabIndex = 48;
            label3.Text = "Membership Plans";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(18, 39);
            label5.Name = "label5";
            label5.Size = new Size(118, 21);
            label5.TabIndex = 47;
            label5.Text = "Add New Plan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold);
            label1.Location = new Point(3, 2);
            label1.Name = "label1";
            label1.Size = new Size(323, 35);
            label1.TabIndex = 46;
            label1.Text = "Manage Membership Plan";
            // 
            // dataGridView_plan_list
            // 
            dataGridView_plan_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_plan_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_plan_list.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView_plan_list.Location = new Point(18, 54);
            dataGridView_plan_list.Margin = new Padding(3, 2, 3, 2);
            dataGridView_plan_list.Name = "dataGridView_plan_list";
            dataGridView_plan_list.RowHeadersWidth = 51;
            dataGridView_plan_list.Size = new Size(993, 257);
            dataGridView_plan_list.TabIndex = 57;
            // 
            // Column1
            // 
            Column1.HeaderText = "Plan Name";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Price";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Duration";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(dataGridView_plan_list);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 290);
            panel1.Name = "panel1";
            panel1.Size = new Size(1028, 330);
            panel1.TabIndex = 58;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(textBox_plan_duration);
            panel2.Controls.Add(textBox_plan_price);
            panel2.Controls.Add(textBox_plan_name);
            panel2.Controls.Add(button_delete_plan);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button_update_plan);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(button_add_plan);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(12, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(1028, 260);
            panel2.TabIndex = 59;
            panel2.Paint += panel2_Paint;
            // 
            // textBox_plan_duration
            // 
            textBox_plan_duration.Location = new Point(236, 123);
            textBox_plan_duration.Name = "textBox_plan_duration";
            textBox_plan_duration.Size = new Size(146, 23);
            textBox_plan_duration.TabIndex = 65;
            // 
            // textBox_plan_price
            // 
            textBox_plan_price.Location = new Point(471, 78);
            textBox_plan_price.Name = "textBox_plan_price";
            textBox_plan_price.Size = new Size(146, 23);
            textBox_plan_price.TabIndex = 64;
            // 
            // textBox_plan_name
            // 
            textBox_plan_name.Location = new Point(236, 83);
            textBox_plan_name.Name = "textBox_plan_name";
            textBox_plan_name.Size = new Size(146, 23);
            textBox_plan_name.TabIndex = 63;
            // 
            // button_delete_plan
            // 
            button_delete_plan.BackColor = Color.Salmon;
            button_delete_plan.ForeColor = SystemColors.ButtonHighlight;
            button_delete_plan.Location = new Point(303, 197);
            button_delete_plan.Margin = new Padding(3, 2, 3, 2);
            button_delete_plan.Name = "button_delete_plan";
            button_delete_plan.Size = new Size(136, 42);
            button_delete_plan.TabIndex = 62;
            button_delete_plan.Text = "Delete Plan";
            button_delete_plan.UseVisualStyleBackColor = false;
            button_delete_plan.Click += button_delete_plan_Click;
            // 
            // button_update_plan
            // 
            button_update_plan.BackColor = Color.Gold;
            button_update_plan.ForeColor = SystemColors.ButtonHighlight;
            button_update_plan.Location = new Point(161, 197);
            button_update_plan.Margin = new Padding(3, 2, 3, 2);
            button_update_plan.Name = "button_update_plan";
            button_update_plan.Size = new Size(136, 42);
            button_update_plan.TabIndex = 61;
            button_update_plan.Text = "Update Plan";
            button_update_plan.UseVisualStyleBackColor = false;
            button_update_plan.Click += button_update_plan_Click;
            // 
            // button_add_plan
            // 
            button_add_plan.BackColor = Color.LimeGreen;
            button_add_plan.ForeColor = SystemColors.ButtonHighlight;
            button_add_plan.Location = new Point(19, 197);
            button_add_plan.Margin = new Padding(3, 2, 3, 2);
            button_add_plan.Name = "button_add_plan";
            button_add_plan.Size = new Size(136, 42);
            button_add_plan.TabIndex = 60;
            button_add_plan.Text = "Add Plan";
            button_add_plan.UseVisualStyleBackColor = false;
            button_add_plan.Click += button_add_plan_Click;
            // 
            // Membership
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 632);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Membership";
            Text = "Membership";
            ((System.ComponentModel.ISupportInitialize)dataGridView_plan_list).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label7;
        private Label label2;
        private Label label6;
        private Label label3;
        private Label label5;
        private Label label1;
        private DataGridView dataGridView_plan_list;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBox_plan_duration;
        private TextBox textBox_plan_price;
        private TextBox textBox_plan_name;
        private Button button_delete_plan;
        private Button button_update_plan;
        private Button button_add_plan;
    }
}