using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenge2;

namespace Challenge2Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void TestMaxProfit_PositiveScenario()
        {
            int[] prices = {100, 180, 260, 310, 40, 535, 695};
            string result = Program.MaxProfit(prices);
            Assert.AreEqual("Buy on day 5 at price 40\nSell on day 7 at price 695\nMax profit: 655", result);
        }

        [TestMethod]
        public void TestMaxProfit_NoProfitScenario()
        {
            int[] prices = {695, 535, 310, 260, 180, 100};
            string result = Program.MaxProfit(prices);
            Assert.AreEqual("-1", result);
        }

        [TestMethod]
        public void TestMaxProfit_EmptyArray()
        {
            int[] prices = {};
            string result = Program.MaxProfit(prices);
            Assert.AreEqual("-1", result);
        }
    }
}