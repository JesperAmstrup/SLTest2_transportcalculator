using System;
using Xunit;
using transportcalculator;

namespace TestProject1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(4999, 4000, 0)]
        [InlineData(4999, 11000, 50)]
        [InlineData(5000, 4000, 75)]
        [InlineData(5000, 11000, 100)]
        public void CalculationsTest(int DistanceMeters, decimal WeightGrams, decimal ExpectedResult)
        {
            var result = transportcalculator.TransportCalculation.CalculateTransportcost(DistanceMeters, WeightGrams);

            Assert.Equal(result, ExpectedResult);
        }
    }
}
