using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace letyTests2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string result = FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Form_Dashboard.something();
            Assert.AreEqual("Algo",result);
        }

        [TestMethod]
        public void TestLoginTrue() {
            bool result = FundamentosdeSoftware_ProyectoSoftwareLetiFinal.Form_Login.Login("fulanito","12345");

        }
    }
}
