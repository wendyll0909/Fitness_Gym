namespace Fitness_Gym.Forms
{
    partial class Feedback
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
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            dataGridView_feedback_list = new DataGridView();
            comboBox_ratings = new ComboBox();
            comboBox_members = new ComboBox();
            label2 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox_feedback = new TextBox();
            button_add_feedback = new Button();
            panel1 = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView_feedback_list).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18.75F, FontStyle.Bold);
            label1.Location = new Point(7, 6);
            label1.Name = "label1";
            label1.Size = new Size(289, 35);
            label1.TabIndex = 13;
            label1.Text = "Feedback Management";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 21);
            label3.TabIndex = 36;
            label3.Text = "Feedback List";
            label3.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(30, 47);
            label5.Name = "label5";
            label5.Size = new Size(117, 21);
            label5.TabIndex = 35;
            label5.Text = "Add Feedback";
            label5.Click += label5_Click;
            // 
            // dataGridView_feedback_list
            // 
            dataGridView_feedback_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_feedback_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_feedback_list.Location = new Point(11, 38);
            dataGridView_feedback_list.Margin = new Padding(3, 2, 3, 2);
            dataGridView_feedback_list.Name = "dataGridView_feedback_list";
            dataGridView_feedback_list.RowHeadersWidth = 51;
            dataGridView_feedback_list.Size = new Size(1003, 249);
            dataGridView_feedback_list.TabIndex = 37;
            dataGridView_feedback_list.CellContentClick += dataGridView1_CellContentClick;
            // 
            // comboBox_ratings
            // 
            comboBox_ratings.FormattingEnabled = true;
            comboBox_ratings.Location = new Point(525, 84);
            comboBox_ratings.Margin = new Padding(3, 2, 3, 2);
            comboBox_ratings.Name = "comboBox_ratings";
            comboBox_ratings.Size = new Size(184, 23);
            comboBox_ratings.TabIndex = 41;
            comboBox_ratings.SelectedIndexChanged += comboBox_ratings_SelectedIndexChanged;
            // 
            // comboBox_members
            // 
            comboBox_members.FormattingEnabled = true;
            comboBox_members.Location = new Point(105, 84);
            comboBox_members.Margin = new Padding(3, 2, 3, 2);
            comboBox_members.Name = "comboBox_members";
            comboBox_members.Size = new Size(184, 23);
            comboBox_members.TabIndex = 40;
            comboBox_members.SelectedIndexChanged += comboBox_members_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F);
            label2.Location = new Point(470, 84);
            label2.Name = "label2";
            label2.Size = new Size(49, 16);
            label2.TabIndex = 39;
            label2.Text = "Rating:";
            label2.Click += label2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F);
            label6.Location = new Point(39, 84);
            label6.Name = "label6";
            label6.Size = new Size(60, 16);
            label6.TabIndex = 38;
            label6.Text = "Member:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F);
            label7.Location = new Point(39, 132);
            label7.Name = "label7";
            label7.Size = new Size(72, 16);
            label7.TabIndex = 43;
            label7.Text = "Feedback:";
            label7.Click += label7_Click;
            // 
            // textBox_feedback
            // 
            textBox_feedback.Location = new Point(117, 132);
            textBox_feedback.Margin = new Padding(3, 2, 3, 2);
            textBox_feedback.Multiline = true;
            textBox_feedback.Name = "textBox_feedback";
            textBox_feedback.Size = new Size(637, 104);
            textBox_feedback.TabIndex = 44;
            textBox_feedback.TextChanged += textBox_feedback_TextChanged;
            // 
            // button_add_feedback
            // 
            button_add_feedback.BackColor = Color.LimeGreen;
            button_add_feedback.ForeColor = SystemColors.ButtonHighlight;
            button_add_feedback.Location = new Point(39, 251);
            button_add_feedback.Margin = new Padding(3, 2, 3, 2);
            button_add_feedback.Name = "button_add_feedback";
            button_add_feedback.Size = new Size(136, 42);
            button_add_feedback.TabIndex = 45;
            button_add_feedback.Text = "Submit Feedback";
            button_add_feedback.UseVisualStyleBackColor = false;
            button_add_feedback.Click += button_add_feedback_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button_add_feedback);
            panel1.Controls.Add(comboBox_ratings);
            panel1.Controls.Add(textBox_feedback);
            panel1.Controls.Add(comboBox_members);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(12, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(1028, 303);
            panel1.TabIndex = 46;
            panel1.Paint += panel1_Paint;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(dataGridView_feedback_list);
            panel2.Location = new Point(12, 334);
            panel2.Name = "panel2";
            panel2.Size = new Size(1028, 295);
            panel2.TabIndex = 47;
            panel2.Paint += panel2_Paint;
            // 
            // Feedback
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 632);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Feedback";
            Text = "Feedback";
            Load += Feedback_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_feedback_list).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label5;
        private DataGridView dataGridView_feedback_list;
        private ComboBox comboBox_ratings;
        private ComboBox comboBox_members;
        private Label label2;
        private Label label6;
        private Label label7;
        private TextBox textBox_feedback;
        private Button button_add_feedback;
        private Panel panel1;
        private ContextMenuStrip contextMenuStrip1;
        private Panel panel2;
    }
}