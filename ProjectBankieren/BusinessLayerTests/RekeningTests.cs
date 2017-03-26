using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Businesslayer;

namespace BusinessLayerTests
{
    [TestClass]
    public class RekeningTests
    {
        [TestMethod]
        public void BijschrijvenTest()
        {
            //ARRANGE
            Betaalrekening testRekening = new Betaalrekening("NL44 ABNA 0659 5906 55", 100, -1000);

            //ACT
            testRekening.Bijschrijven = 50;

            //ASSERT
            Assert.AreEqual(150, testRekening.bankSaldo);
        }

        [TestMethod]
        public void AfschrijvenBetaalRekeningTest()
        {
            //ARRANGE
            Betaalrekening testRekening = new Betaalrekening("NL44 ABNA 0659 5906 55", 100, -1000);

            //ACT
            testRekening.Afschrijven(50);

            //ASSERT
            Assert.AreEqual(50, testRekening.bankSaldo);
        }

        [TestMethod]
        public void AfschrijvenSpaarRekeningTest()
        {
            //ARRANGE
            Spaarrekening testRekening = new Spaarrekening("NL44 ABNA 0659 5906 55", 1000, 2);

            //ACT
            testRekening.Afschrijven(50);

            //ASSERT
            Assert.AreEqual(950, testRekening.bankSaldo);
        }
    }
}
