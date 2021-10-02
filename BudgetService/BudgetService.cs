using System;
using System.Linq;

namespace BudgetService
{
    public class BudgetService
    {
        private IBudgetRepo BudgetRepo { get; }

        public BudgetService(IBudgetRepo budgetRepo)
        {
            BudgetRepo = budgetRepo;
        }

        public decimal Query(DateTime startTime, DateTime endTime)
        {
            if (startTime < endTime)
            {
                return BudgetRepo.GetAll().First().Amount;
            }

            return 0;
        }
    }
}
