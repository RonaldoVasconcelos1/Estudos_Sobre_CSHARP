using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Oficina.Dominio.Tests
{
    [TestClass()]
    public class FreteTests
    {
        [TestMethod()]
        public void FreteTest()
        {
            var frete = new Frete(100, UF.SP);

            Assert.AreEqual(frete.Percentual, 0.2m);
            Assert.IsTrue(frete.Total == 120);


        }
    }
}