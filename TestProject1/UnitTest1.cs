using System;
using Xunit;
using transportcalculator;

namespace TestProject1_xunit
{
    public class UnitTest1
    {
        /// <summary>
        /// A test showing that check if an exception is raised
        /// </summary>
        [Fact]
        public void NumbersNeedToBeHigherThanZero()
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => transportcalculator.TransportCalculation.CalculateTransportcost(0, 0));

            Assert.Equal("Numbers need to be more than 0", ex.ParamName);
        }


        /// <summary>
        /// A test checking if the CalculateTransportcost calculates correctly
        /// </summary>
        /// <param name="DistanceMeters"></param>
        /// <param name="WeightGrams"></param>
        /// <param name="ExpectedResult"></param>
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
