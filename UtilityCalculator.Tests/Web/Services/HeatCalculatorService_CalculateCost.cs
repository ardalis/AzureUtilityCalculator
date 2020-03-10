using System;
using UtilityCalculator.Web.Services;
using Xunit;

namespace UtilityCalculator.Tests
{
    public class HeatCalculatorService_CalculateCost
    {
        [Theory]
        [InlineData(1500, "M", 52.74)]
        [InlineData(2500, "M", 87.9)]
        [InlineData(2500, "D", 175.8)]
        public void ReturnsXGiven1500AndMild(int size, string climate, decimal expectedResult)
        {
            var result = HeatCalculatorService.CalculateCost(size, climate);

            Assert.Equal(expectedResult, result);
        }
    }
}
