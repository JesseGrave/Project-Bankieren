using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Businesslayer;

namespace BusinessLayerTests
{
    [TestClass]
    public class BankrekeningTests
    {
        [TestMethod]
        public void BetalingTest()
        {
            //ARRANGE
            Bankrekeninghouder Test1 = new Bankrekeninghouder("Pan", "Peter", "552499183", "ppeter", "panbank", "NL14 ABNA 0659 5689 64", 100, 2,
                "NL27 ABNA 0459 8523 85", 500, -100);

            Bankrekeninghouder Test2 = new Bankrekeninghouder("Peter", "Pan", "924613440", "ppan", "peterbank", "NL16 RABO 0596 5376 84", 1000, 2,
                "NL90 RABO 0168 4596 25", 100, -100);

            //ACT
            Test1.Betalen(Test2.betaalRekening.rekeningNr, 200);

            //ASSERT
            Assert.AreEqual(300, Test1.betaalRekening.bankSaldo);
        }
    }
}
