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
        SimpleFraction sf = new SimpleFraction("2/3");
        SimpleFraction sf2 = new SimpleFraction("7/4");
        SimpleFraction sf3 = new SimpleFraction("6/4");


        [TestMethod]
        public void SimpleFractionMathActionTest()
        {


            Assert.AreEqual("29/12", (sf + sf2).ToString());
            Assert.AreEqual("13/12", (sf2-sf).ToString());
            Assert.AreEqual("14/12", (sf2*sf).ToString());
            Assert.AreEqual("8/21", (sf/sf2).ToString());
            Assert.AreEqual("11/3", (sf + 3).ToString());
            Assert.AreEqual("-5/4", (sf2 - 3).ToString());
            Assert.AreEqual("21/4", (sf2 * 3).ToString());
            Assert.AreEqual("2/9", (sf / 3).ToString());
            Assert.AreEqual("11/3", (3 + sf).ToString());
            Assert.AreEqual("5/4", (3 - sf2).ToString());
            Assert.AreEqual("21/4", (3*sf2).ToString());
            Assert.AreEqual("9/2", (3/sf).ToString());

            sf3.Cut();
            Assert.AreEqual("3/2",sf3.ToString());

            Assert.AreEqual("2/5", new SimpleFraction("5/2").Reverse().ToString());


          



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
