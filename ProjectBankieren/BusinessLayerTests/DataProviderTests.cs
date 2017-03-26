using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Businesslayer;

namespace BusinessLayerTests
{
    [TestClass]
    public class DataProviderTests
    {
        [TestMethod]
        public void LijstBankrekeninghoudersvullenTest()
        {
            //ACT
            DataProvider.VulLijst();

            //ASSERT
            Assert.IsNotNull(DataProvider.Allebankrekeninghouders);
        }

        [TestMethod]
        public void ElfProefTest()
        {
            //ARRANGE
            string context = "877355307";

            //ACT
            bool ElfProef = DataProvider.ElfProef(context);

            //ASSERT
            Assert.IsTrue(ElfProef);
        }
    }
}
