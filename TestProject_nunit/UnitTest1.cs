using NUnit.Framework;
using transportcalculator;

namespace TestProject_nunit
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(4999, 4000, 0)]
        [TestCase(4999, 11000, 50)]
        [TestCase(5000, 4000, 75)]
        [TestCase(5000, 11000, 100)]
        public void CalculationsTest(int DistanceMeters, decimal WeightGrams, decimal ExpectedResult)
        {
            var result = transportcalculator.TransportCalculation.CalculateTransportcost(DistanceMeters, WeightGrams);

            Assert.AreEqual(result, ExpectedResult);
        }
    }
}