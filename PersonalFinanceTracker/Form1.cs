using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PersonalFinanceTracker
{
    public partial class Form1 : Form
    {
        private FinanceTracker financeTracker = new FinanceTracker();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set placeholders for text boxes
            SetPlaceholder(textBoxAmount, "Amount");
            SetPlaceholder(textBoxCategory, "Category");
            SetPlaceholder(textBoxDescription, "Description");
            SetPlaceholder(textBoxIncomeGoal, "Income Goal");
            SetPlaceholder(textBoxExpenseLimit, "Expense Limit");
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = System.Drawing.Color.Gray;

            textBox.Enter += (s, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = System.Drawing.Color.Black;
                }
            };

            textBox.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = System.Drawing.Color.Gray;
                }
            };
        }

        private void buttonAddTransaction_Click(object sender, EventArgs e)
        {
            // Get input from the form
            decimal amount = decimal.Parse(textBoxAmount.Text);
            string category = textBoxCategory.Text;
            string description = textBoxDescription.Text;
            string type = comboBoxType.SelectedItem.ToString();
            DateTime date = dateTimePicker.Value;

            // Create a new transaction
            Transaction transaction = new Transaction
            {
                TransactionID = Guid.NewGuid().GetHashCode(),
                Amount = amount,
                Date = date,
                Type = type,
                Category = category,
                Description = description
            };

            // Add transaction to finance tracker (assuming it's for the current month and year)
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            financeTracker.AddTransaction(month, year, transaction);

            // Update the DataGridView with the new list of transactions
            dataGridViewTransactions.DataSource = null;
            dataGridViewTransactions.DataSource = financeTracker.ListTransactionsByMonth(month, year);
        }

        private void buttonSetBudget_Click(object sender, EventArgs e)
        {
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            decimal incomeGoal = decimal.Parse(textBoxIncomeGoal.Text);
            decimal expenseLimit = decimal.Parse(textBoxExpenseLimit.Text);

            // Set budget
            financeTracker.SetBudget(month, year, incomeGoal, expenseLimit);
            MessageBox.Show("Budget set successfully!");
        }

        private void buttonGenerateReport_Click(object sender, EventArgs e)
        {
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;
            var budget = financeTracker.Budgets.FirstOrDefault(b => b.Month == month && b.Year == year);

            if (budget != null)
            {
                Report report = new Report();
                report.GenerateReportByMonth(budget);
            }
            else
            {
                MessageBox.Show("No budget set for this month.");
            }
        }
    }
}
