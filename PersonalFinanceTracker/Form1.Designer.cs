namespace PersonalFinanceTracker
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button buttonAddTransaction;
        private System.Windows.Forms.Button buttonSetBudget;
        private System.Windows.Forms.TextBox textBoxIncomeGoal;
        private System.Windows.Forms.TextBox textBoxExpenseLimit;
        private System.Windows.Forms.Button buttonGenerateReport;
        private System.Windows.Forms.DataGridView dataGridViewTransactions;

        private void InitializeComponent()
        {
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonAddTransaction = new System.Windows.Forms.Button();
            this.buttonSetBudget = new System.Windows.Forms.Button();
            this.textBoxIncomeGoal = new System.Windows.Forms.TextBox();
            this.textBoxExpenseLimit = new System.Windows.Forms.TextBox();
            this.buttonGenerateReport = new System.Windows.Forms.Button();
            this.dataGridViewTransactions = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).BeginInit();
            this.SuspendLayout();

            // textBoxAmount
            this.textBoxAmount.Location = new System.Drawing.Point(12, 12);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(100, 23);
            this.textBoxAmount.TabIndex = 0;

            // textBoxCategory
            this.textBoxCategory.Location = new System.Drawing.Point(12, 41);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(100, 23);
            this.textBoxCategory.TabIndex = 1;

            // textBoxDescription
            this.textBoxDescription.Location = new System.Drawing.Point(12, 70);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(100, 23);
            this.textBoxDescription.TabIndex = 2;

            // comboBoxType
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] { "Income", "Expense" });
            this.comboBoxType.Location = new System.Drawing.Point(12, 99);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(100, 23);
            this.comboBoxType.TabIndex = 3;

            // dateTimePicker
            this.dateTimePicker.Location = new System.Drawing.Point(12, 128);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker.TabIndex = 4;

            // buttonAddTransaction
            this.buttonAddTransaction.Location = new System.Drawing.Point(12, 157);
            this.buttonAddTransaction.Name = "buttonAddTransaction";
            this.buttonAddTransaction.Size = new System.Drawing.Size(200, 23);
            this.buttonAddTransaction.TabIndex = 5;
            this.buttonAddTransaction.Text = "Add Transaction";
            this.buttonAddTransaction.UseVisualStyleBackColor = true;
            this.buttonAddTransaction.Click += new System.EventHandler(this.buttonAddTransaction_Click);

            // buttonSetBudget
            this.buttonSetBudget.Location = new System.Drawing.Point(12, 216);
            this.buttonSetBudget.Name = "buttonSetBudget";
            this.buttonSetBudget.Size = new System.Drawing.Size(200, 23);
            this.buttonSetBudget.TabIndex = 6;
            this.buttonSetBudget.Text = "Set Budget";
            this.buttonSetBudget.UseVisualStyleBackColor = true;
            this.buttonSetBudget.Click += new System.EventHandler(this.buttonSetBudget_Click);

            // textBoxIncomeGoal
            this.textBoxIncomeGoal.Location = new System.Drawing.Point(12, 186);
            this.textBoxIncomeGoal.Name = "textBoxIncomeGoal";
            this.textBoxIncomeGoal.Size = new System.Drawing.Size(100, 23);
            this.textBoxIncomeGoal.TabIndex = 7;

            // textBoxExpenseLimit
            this.textBoxExpenseLimit.Location = new System.Drawing.Point(118, 186);
            this.textBoxExpenseLimit.Name = "textBoxExpenseLimit";
            this.textBoxExpenseLimit.Size = new System.Drawing.Size(100, 23);
            this.textBoxExpenseLimit.TabIndex = 8;

            // buttonGenerateReport
            this.buttonGenerateReport.Location = new System.Drawing.Point(12, 245);
            this.buttonGenerateReport.Name = "buttonGenerateReport";
            this.buttonGenerateReport.Size = new System.Drawing.Size(200, 23);
            this.buttonGenerateReport.TabIndex = 9;
            this.buttonGenerateReport.Text = "Generate Report";
            this.buttonGenerateReport.UseVisualStyleBackColor = true;
            this.buttonGenerateReport.Click += new System.EventHandler(this.buttonGenerateReport_Click);

            // dataGridViewTransactions
            this.dataGridViewTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransactions.Location = new System.Drawing.Point(12, 274);
            this.dataGridViewTransactions.Name = "dataGridViewTransactions";
            this.dataGridViewTransactions.RowTemplate.Height = 25;
            this.dataGridViewTransactions.Size = new System.Drawing.Size(500, 150);
            this.dataGridViewTransactions.TabIndex = 10;

            // Form1
            this.ClientSize = new System.Drawing.Size(524, 436);
            this.Controls.Add(this.dataGridViewTransactions);
            this.Controls.Add(this.buttonGenerateReport);
            this.Controls.Add(this.textBoxExpenseLimit);
            this.Controls.Add(this.textBoxIncomeGoal);
            this.Controls.Add(this.buttonSetBudget);
            this.Controls.Add(this.buttonAddTransaction);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.textBoxAmount);
            this.Name = "Form1";
            this.Text = "Personal Finance Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
