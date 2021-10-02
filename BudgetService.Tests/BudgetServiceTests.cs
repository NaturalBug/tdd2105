using System;
using System.Collections.Generic;
using Moq;
using Xunit;

namespace BudgetService.Tests
{
    public class BudgetServiceTests
    {
        private readonly Mock<IBudgetRepo> _fakeBudgetRepo;
        private readonly BudgetService _budgetService;

        public BudgetServiceTests()
        {
            _fakeBudgetRepo = new Mock<IBudgetRepo>();
            _budgetService = new BudgetService(_fakeBudgetRepo.Object);
        }


        [Fact]
        public void Query_EmptyBudgetRepo_ReturnZero()
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

        [Fact]
        public void Query_NoBudget_ReturnZero()
        {
            _fakeBudgetRepo
                .Setup(x => x.GetAll())
                .Returns(new List<Budget>
                {
                    new Budget { YearMonth = "202101", Amount = 310 }
                });

            var amount = _budgetService.Query(new DateTime(2021, 2, 1), new DateTime(2021, 2, 1));

            Assert.Equal(0, amount);
        }

        [Fact]
        public void Query_FullMonthWithBudget_ReturnBudgetAmount()
        {
            _fakeBudgetRepo
                .Setup(x => x.GetAll())
                .Returns(new List<Budget>
                {
                    new Budget { YearMonth = "202103", Amount = 620 }
                });

            var amount = _budgetService.Query(new DateTime(2021, 1, 1), new DateTime(2021, 1, 31));

            Assert.Equal(620, amount);
        }
    }
}
