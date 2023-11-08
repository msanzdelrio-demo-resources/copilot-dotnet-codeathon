using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenge3;

namespace Challenge3Tests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void TestValidateIPAddress_ValidIP()
        {
            string ip = "192.168.1.1";
            bool result = Program.ValidateIPAddress(ip);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestValidateIPAddress_InvalidIP()
        {
            string ip = "999.999.999.999";
            bool result = Program.ValidateIPAddress(ip);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestValidateIPAddress_EmptyString()
        {
            string ip = "";
            bool result = Program.ValidateIPAddress(ip);
            Assert.IsFalse(result);
        }
    }
}