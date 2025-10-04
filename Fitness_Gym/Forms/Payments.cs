using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Fitness_Gym.Forms
{
    public partial class Payments : Form
    {
        string connectionString = "Data Source=PC06\\SQLEXPRESS;Initial Catalog=PalenersGym;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public Payments()
        {
            InitializeComponent();
            Console.WriteLine("Payments: Constructor called at {0}", DateTime.Now);
        }

        private void Payments_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                Console.WriteLine("Payments_Load: Skipping in Design Mode at {0}", DateTime.Now);
                return;
            }

            try
            {
                Console.WriteLine("Payments_Load: Initializing form at {0}", DateTime.Now);
                dataGridView_payments_list.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView_payments_list.MultiSelect = false;
                dataGridView_payments_list.ReadOnly = true;

                // Populate comboBox_paymen_method
                comboBox_paymen_method.Items.AddRange(new[] { "Cash", "Credit Card", "Online" });
                comboBox_paymen_method.SelectedIndex = -1;
                Console.WriteLine("Payments_Load: Initialized comboBox_paymen_method with {0} items at {1}", comboBox_paymen_method.Items.Count, DateTime.Now);

                LoadMembers();
                LoadPayments();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in Payments_Load: {ex.Message}\nStackTrace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Payments_Load Error: {ex.Message}\nStackTrace: {ex.StackTrace} at {DateTime.Now}");
            }
        }

        private void LoadMembers()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    Console.WriteLine("LoadMembers: Attempting to connect to database at {0} with connection string: {1}", DateTime.Now, connectionString);
                    conn.Open();
                    Console.WriteLine("LoadMembers: Database connection opened successfully at {0}", DateTime.Now);
                    string query = "SELECT MemberID, FirstName + ' ' + LastName AS FullName FROM Members";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable membersTable = new DataTable();
                        adapter.Fill(membersTable);
                        Console.WriteLine($"LoadMembers: Retrieved {membersTable.Rows.Count} members at {DateTime.Now}");

                        // Temporarily remove event handler to avoid triggering during data binding
                        comboBox_member.SelectedIndexChanged -= comboBox_member_SelectedIndexChanged;

                        comboBox_member.DataSource = null;
                        comboBox_member.DataSource = membersTable;
                        comboBox_member.DisplayMember = "FullName";
                        comboBox_member.ValueMember = "MemberID";
                        comboBox_member.SelectedIndex = -1;

                        // Re-attach event handler
                        comboBox_member.SelectedIndexChanged += comboBox_member_SelectedIndexChanged;

                        Console.WriteLine("LoadMembers: Bound data to comboBox_member, SelectedIndex: {0}, ItemCount: {1} at {2}", comboBox_member.SelectedIndex, comboBox_member.Items.Count, DateTime.Now);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading members: {ex.Message}\nStackTrace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"LoadMembers Error: {ex.Message}\nStackTrace: {ex.StackTrace} at {DateTime.Now}");
            }
        }

        private void LoadPayments()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    Console.WriteLine("LoadPayments: Attempting to connect to database at {0} with connection string: {1}", DateTime.Now, connectionString);
                    conn.Open();
                    Console.WriteLine("LoadPayments: Database connection opened successfully at {0}", DateTime.Now);
                    string query = @"
                        SELECT 
                            p.PaymentID,
                            m.FirstName + ' ' + m.LastName AS MemberName,
                            mp.PlanName,
                            p.Amount,
                            p.PaymentDate,
                            p.PaymentMethod
                        FROM Payments p
                        JOIN Members m ON p.MemberID = m.MemberID
                        JOIN MembershipPlans mp ON p.PlanID = mp.PlanID";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable paymentsTable = new DataTable();
                        adapter.Fill(paymentsTable);
                        Console.WriteLine($"LoadPayments: Retrieved {paymentsTable.Rows.Count} payments at {DateTime.Now}");
                        dataGridView_payments_list.DataSource = null;
                        dataGridView_payments_list.DataSource = paymentsTable;

                        if (dataGridView_payments_list.Columns.Contains("PaymentID"))
                            dataGridView_payments_list.Columns["PaymentID"].Visible = false;
                        if (dataGridView_payments_list.Columns.Contains("MemberName"))
                            dataGridView_payments_list.Columns["MemberName"].HeaderText = "Member Name";
                        if (dataGridView_payments_list.Columns.Contains("PlanName"))
                            dataGridView_payments_list.Columns["PlanName"].HeaderText = "Plan";
                        if (dataGridView_payments_list.Columns.Contains("Amount"))
                            dataGridView_payments_list.Columns["Amount"].HeaderText = "Amount";
                        if (dataGridView_payments_list.Columns.Contains("PaymentDate"))
                            dataGridView_payments_list.Columns["PaymentDate"].HeaderText = "Payment Date";
                        if (dataGridView_payments_list.Columns.Contains("PaymentMethod"))
                            dataGridView_payments_list.Columns["PaymentMethod"].HeaderText = "Payment Method";
                        Console.WriteLine("LoadPayments: Bound data to dataGridView_payments_list, RowCount: {0} at {1}", dataGridView_payments_list.RowCount, DateTime.Now);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading payments: {ex.Message}\nStackTrace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"LoadPayments Error: {ex.Message}\nStackTrace: {ex.StackTrace} at {DateTime.Now}");
            }
        }

        private void comboBox_member_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine($"comboBox_member_SelectedIndexChanged: Triggered at {DateTime.Now}, SelectedIndex: {comboBox_member.SelectedIndex}, SelectedValue: {comboBox_member.SelectedValue}");
                if (comboBox_member.SelectedIndex >= 0 && comboBox_member.SelectedValue != null)
                {
                    // Cast SelectedValue to DataRowView and get MemberID
                    var selectedRow = (comboBox_member.SelectedValue as DataRowView);
                    if (selectedRow != null)
                    {
                        int memberID = Convert.ToInt32(selectedRow["MemberID"]);
                        Console.WriteLine($"comboBox_member_SelectedIndexChanged: Selected MemberID {memberID} at {DateTime.Now}");
                        LoadPaymentsForMember(memberID);
                    }
                    else
                    {
                        Console.WriteLine("comboBox_member_SelectedIndexChanged: SelectedValue is null, loading all payments at {0}", DateTime.Now);
                        LoadPayments();
                    }
                }
                else
                {
                    Console.WriteLine("comboBox_member_SelectedIndexChanged: No member selected, loading all payments at {0}", DateTime.Now);
                    LoadPayments();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error filtering payments: {ex.Message}\nStackTrace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"comboBox_member_SelectedIndexChanged Error: {ex.Message}\nStackTrace: {ex.StackTrace} at {DateTime.Now}");
            }
        }

        private void LoadPaymentsForMember(int memberID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    Console.WriteLine($"LoadPaymentsForMember: Attempting to connect to database for MemberID {memberID} at {DateTime.Now} with connection string: {connectionString}");
                    conn.Open();
                    Console.WriteLine("LoadPaymentsForMember: Database connection opened successfully at {0}", DateTime.Now);
                    string query = @"
                        SELECT 
                            p.PaymentID,
                            m.FirstName + ' ' + m.LastName AS MemberName,
                            mp.PlanName,
                            p.Amount,
                            p.PaymentDate,
                            p.PaymentMethod
                        FROM Payments p
                        JOIN Members m ON p.MemberID = m.MemberID
                        JOIN MembershipPlans mp ON p.PlanID = mp.PlanID
                        WHERE p.MemberID = @MemberID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MemberID", memberID);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable paymentsTable = new DataTable();
                            adapter.Fill(paymentsTable);
                            Console.WriteLine($"LoadPaymentsForMember: Retrieved {paymentsTable.Rows.Count} payments for MemberID {memberID} at {DateTime.Now}");
                            dataGridView_payments_list.DataSource = null;
                            dataGridView_payments_list.DataSource = paymentsTable;

                            if (dataGridView_payments_list.Columns.Contains("PaymentID"))
                                dataGridView_payments_list.Columns["PaymentID"].Visible = false;
                            if (dataGridView_payments_list.Columns.Contains("MemberName"))
                                dataGridView_payments_list.Columns["MemberName"].HeaderText = "Member Name";
                            if (dataGridView_payments_list.Columns.Contains("PlanName"))
                                dataGridView_payments_list.Columns["PlanName"].HeaderText = "Plan";
                            if (dataGridView_payments_list.Columns.Contains("Amount"))
                                dataGridView_payments_list.Columns["Amount"].HeaderText = "Amount";
                            if (dataGridView_payments_list.Columns.Contains("PaymentDate"))
                                dataGridView_payments_list.Columns["PaymentDate"].HeaderText = "Payment Date";
                            if (dataGridView_payments_list.Columns.Contains("PaymentMethod"))
                                dataGridView_payments_list.Columns["PaymentMethod"].HeaderText = "Payment Method";
                            Console.WriteLine("LoadPaymentsForMember: Bound data to dataGridView_payments_list, RowCount: {0} at {1}", dataGridView_payments_list.RowCount, DateTime.Now);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading payments for member: {ex.Message}\nStackTrace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"LoadPaymentsForMember Error: {ex.Message}\nStackTrace: {ex.StackTrace} at {DateTime.Now}");
            }
        }

        private void comboBox_paymen_method_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine($"comboBox_paymen_method_SelectedIndexChanged: Selected {comboBox_paymen_method.SelectedItem} at {DateTime.Now}");
            // No action needed for now; kept for future validation
        }

        private void button_add_payment_Click(object sender, EventArgs e)
        {
            try
            {
                Console.WriteLine($"button_add_payment_Click: Triggered at {DateTime.Now}");
                Console.WriteLine($"button_add_payment_Click: Initial state - SelectedIndex: {comboBox_member.SelectedIndex}, SelectedValue: {comboBox_member.SelectedValue} at {DateTime.Now}");

                if (comboBox_member.SelectedIndex == -1 || comboBox_member.SelectedValue == null)
                {
                    MessageBox.Show("Please select a member.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Console.WriteLine("button_add_payment_Click: Validation failed - No member selected, SelectedIndex: {0}, SelectedValue: {1} at {2}", comboBox_member.SelectedIndex, comboBox_member.SelectedValue, DateTime.Now);
                    return;
                }

                if (comboBox_paymen_method.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a payment method.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Console.WriteLine("button_add_payment_Click: Validation failed - No payment method selected, SelectedIndex: {0} at {1}", comboBox_paymen_method.SelectedIndex, DateTime.Now);
                    return;
                }

                if (number_amount.Value <= 0)
                {
                    MessageBox.Show("Please enter a valid payment amount.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Console.WriteLine($"button_add_payment_Click: Validation failed - Invalid amount: {number_amount.Value} at {DateTime.Now}");
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    Console.WriteLine("button_add_payment_Click: Attempting to connect to database at {0} with connection string: {1}", DateTime.Now, connectionString);
                    conn.Open();
                    Console.WriteLine("button_add_payment_Click: Database connection opened at {0}", DateTime.Now);

                    // Get MemberID safely
                    int memberID;
                    if (comboBox_member.SelectedValue is DataRowView dataRowView)
                    {
                        memberID = Convert.ToInt32(dataRowView["MemberID"]);
                        Console.WriteLine($"button_add_payment_Click: Extracted MemberID {memberID} from DataRowView at {DateTime.Now}");
                    }
                    else if (comboBox_member.SelectedValue is int)
                    {
                        memberID = (int)comboBox_member.SelectedValue;
                        Console.WriteLine($"button_add_payment_Click: Extracted MemberID {memberID} directly from SelectedValue at {DateTime.Now}");
                    }
                    else
                    {
                        // Try to parse as string or get from display text as last resort
                        string memberIDStr = comboBox_member.SelectedValue?.ToString();
                        if (!int.TryParse(memberIDStr, out memberID))
                        {
                            throw new Exception("Unable to determine MemberID from selection.");
                        }
                        Console.WriteLine($"button_add_payment_Click: Parsed MemberID {memberID} from string at {DateTime.Now}");
                    }

                    // Get PlanID for the selected member
                    int planID;
                    string planQuery = "SELECT PlanID FROM Members WHERE MemberID = @MemberID";
                    using (SqlCommand planCmd = new SqlCommand(planQuery, conn))
                    {
                        planCmd.Parameters.AddWithValue("@MemberID", memberID);

                        object result = planCmd.ExecuteScalar();
                        if (result == null || result == DBNull.Value)
                        {
                            throw new Exception("No PlanID found for the selected member.");
                        }
                        planID = (int)result;
                        Console.WriteLine($"button_add_payment_Click: Retrieved PlanID {planID} for MemberID {memberID} at {DateTime.Now}");
                    }

                    string insertQuery = @"
                        INSERT INTO Payments (MemberID, PlanID, Amount, PaymentDate, PaymentMethod)
                        VALUES (@MemberID, @PlanID, @Amount, @PaymentDate, @PaymentMethod)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@MemberID", memberID);
                        cmd.Parameters.AddWithValue("@PlanID", planID);
                        cmd.Parameters.AddWithValue("@Amount", number_amount.Value);
                        cmd.Parameters.AddWithValue("@PaymentDate", DateTime.Today);
                        cmd.Parameters.AddWithValue("@PaymentMethod", comboBox_paymen_method.SelectedItem.ToString());

                        int rowsAffected = cmd.ExecuteNonQuery();
                        Console.WriteLine($"button_add_payment_Click: Insert query executed, {rowsAffected} rows affected at {DateTime.Now}");
                    }

                    MessageBox.Show("Payment added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.WriteLine("button_add_payment_Click: Payment added successfully at {0}", DateTime.Now);
                    LoadPayments();
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding payment: {ex.Message}\nStackTrace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"button_add_payment_Click Error: {ex.Message}\nStackTrace: {ex.StackTrace} at {DateTime.Now}");
            }
        }

        private void dataGridView_payments_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Console.WriteLine($"dataGridView_payments_list_CellContentClick: Triggered at {DateTime.Now}, RowIndex: {e.RowIndex}");
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView_payments_list.Rows[e.RowIndex];
                    Console.WriteLine($"dataGridView_payments_list_CellContentClick: Selected row {e.RowIndex}, MemberName: {row.Cells["MemberName"].Value} at {DateTime.Now}");

                    // Temporarily remove event handler to avoid triggering during population
                    comboBox_member.SelectedIndexChanged -= comboBox_member_SelectedIndexChanged;

                    comboBox_member.Text = row.Cells["MemberName"].Value?.ToString() ?? "";
                    number_amount.Value = row.Cells["Amount"].Value != null ? Convert.ToDecimal(row.Cells["Amount"].Value) : 0;
                    comboBox_paymen_method.Text = row.Cells["PaymentMethod"].Value?.ToString() ?? "";

                    // Re-attach event handler
                    comboBox_member.SelectedIndexChanged += comboBox_member_SelectedIndexChanged;

                    Console.WriteLine($"dataGridView_payments_list_CellContentClick: Populated fields - Member: {comboBox_member.Text}, Amount: {number_amount.Value}, Method: {comboBox_paymen_method.Text} at {DateTime.Now}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting payment: {ex.Message}\nStackTrace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"dataGridView_payments_list_CellContentClick Error: {ex.Message}\nStackTrace: {ex.StackTrace} at {DateTime.Now}");
            }
        }

        private void ClearFields()
        {
            try
            {
                // Temporarily remove event handler to avoid triggering during clear
                comboBox_member.SelectedIndexChanged -= comboBox_member_SelectedIndexChanged;

                // Safe way to clear combo box selection
                comboBox_member.SelectedIndex = -1;
                comboBox_member.Text = "";

                // Re-attach event handler
                comboBox_member.SelectedIndexChanged += comboBox_member_SelectedIndexChanged;

                comboBox_paymen_method.SelectedIndex = -1;
                number_amount.Value = 0;
                Console.WriteLine("ClearFields: Form fields cleared at {0}", DateTime.Now);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ClearFields Error: {ex.Message} at {DateTime.Now}");
                // If there's an error, ensure event handler is re-attached
                comboBox_member.SelectedIndexChanged += comboBox_member_SelectedIndexChanged;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void number_amount_ValueChanged(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }
    }
}