using HelloCopilot;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestWithCopilot
{
    [TestClass]
    public class CopilotTest
    {
        [TestMethod]
        public async Task GetCapitalInfo_EuropeanCapital_ReturnsEurope()
        {
            // Arrange
            string capital = "Paris";

            // Act
            var result = await Program.GetCapitalInfo(capital);

            // Assert
            Assert.AreEqual("Europe", result.Continent);
        }

        [TestMethod]
        public async Task GetCapitalInfo_NonEuropeanCapital_ReturnsNotInEurope()
        {
            // Arrange
            string capital = "Washington";

            // Act
            var result = await Program.GetCapitalInfo(capital);

            // Assert
            Assert.AreEqual("Not in Europe", result.Continent);
        }
    }
}