using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PersonalFinanceTracker
{
    public class Report
    {
        public void GenerateReportByMonth(Budget budget)
        {
            Console.WriteLine($"Report for {budget.Month}/{budget.Year}");
            Console.WriteLine($"Income Goal: {budget.IncomeGoal}, Expense Limit: {budget.ExpenseLimit}");
            Console.WriteLine($"Actual Income: {budget.ActualIncome}, Actual Expenses: {budget.ActualExpenses}");
            Console.WriteLine("Transactions:");
            foreach (var transaction in budget.Transactions)
            {
                Console.WriteLine($"{transaction.Date.ToShortDateString()} - {transaction.Type}: {transaction.Amount} - {transaction.Category}");
            }
        }
    }
}
