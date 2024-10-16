using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinanceTracker
{
    public class Budget
    {
        public int Month { get; set; }
        public int Year { get; set; }
        public decimal IncomeGoal { get; set; }
        public decimal ExpenseLimit { get; set; }
        public decimal ActualIncome { get; set; }
        public decimal ActualExpenses { get; set; }
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();

        public decimal CalculateSavings()
        {
            return ActualIncome - ActualExpenses;
        }
    }
}
