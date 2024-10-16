using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PersonalFinanceTracker
{
    public class FinanceTracker
    {
        public List<Budget> Budgets { get; set; } = new List<Budget>();

        public void AddTransaction(int month, int year, Transaction transaction)
        {
            var budget = Budgets.FirstOrDefault(b => b.Month == month && b.Year == year);
            if (budget == null)
            {
                budget = new Budget { Month = month, Year = year };
                Budgets.Add(budget);
            }

            budget.Transactions.Add(transaction);
            if (transaction.Type == "Income")
                budget.ActualIncome += transaction.Amount;
            else if (transaction.Type == "Expense")
                budget.ActualExpenses += transaction.Amount;
        }

        public void SetBudget(int month, int year, decimal incomeGoal, decimal expenseLimit)
        {
            var budget = Budgets.FirstOrDefault(b => b.Month == month && b.Year == year);
            if (budget == null)
            {
                budget = new Budget { Month = month, Year = year };
                Budgets.Add(budget);
            }
            budget.IncomeGoal = incomeGoal;
            budget.ExpenseLimit = expenseLimit;
        }

        public List<Transaction> ListTransactionsByMonth(int month, int year)
        {
            return Budgets.FirstOrDefault(b => b.Month == month && b.Year == year)?.Transactions;
        }
    }
}

