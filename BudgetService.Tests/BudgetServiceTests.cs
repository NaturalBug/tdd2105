using System;
using Xunit;

namespace BudgetService.Tests
{
    public class BudgetServiceTests
    {
        private readonly BudgetService _budgetService = new BudgetService();

        [Fact]
        public void Query_NoData_ReturnZero()
        {
            var amount = _budgetService.Query(new DateTime(), new DateTime());

            Assert.Equal(0, amount);
        }

        [Fact]
        public void Query_InvalidTimePeriod_ReturnZero()
        {
            var amount = _budgetService.Query(new DateTime(2021, 10, 1), new DateTime(2021, 9, 30));

            Assert.Equal(0, amount);
        }
    }
}
