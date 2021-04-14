using Microsoft.VisualStudio.TestTools.UnitTesting;
using LimMath;
using System;
using System.Collections.Generic;
using LimMath.Fraction;

namespace UnitTest
{
    [TestClass]
    public class FractionTest
    {
        readonly SimpleFraction sf = new SimpleFraction("2/3");
        readonly SimpleFraction sf2 = new SimpleFraction("7/4");
        
            
        [TestMethod]
        public void SimpleFractionTest()
        {

            Assert.AreEqual(2, sf.Numer);
            Assert.AreEqual(3, sf.Denom);
            SimpleFraction sf3 = sf + sf2;
            Assert.AreEqual(29, sf3.Numer);
    




        }



        [TestMethod]
        public void FractionSumNumbers()
        {

           
            



        }

        [TestMethod]
        public void FractionSumObject()
        {

            



        }



        [TestMethod]
        public void myTest()
        {

        

        }
    }
}
