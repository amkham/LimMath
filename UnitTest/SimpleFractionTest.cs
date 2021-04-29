using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using LimMath;

namespace UnitTest
{
    [TestClass]
    public class SimpleFractionTest
    {
        [TestMethod]
        public void ActionTest()



        {
            SimpleFraction sf1 = new SimpleFraction("2/4");
            SimpleFraction sf2 = new SimpleFraction("8/16");

            Assert.AreEqual<SimpleFraction>(sf1, sf2);

        }
        [TestMethod]
        public void CutTest()
        {
            var sf1 = new SimpleFraction(14,58);
            sf1.Cut();
            Assert.AreEqual(new SimpleFraction(7,29), sf1);

            var sf2 = new SimpleFraction(-14,58);
         
            sf2.Cut();
            Assert.AreEqual(new SimpleFraction(-7, 29), sf2);


        }
    }
}
