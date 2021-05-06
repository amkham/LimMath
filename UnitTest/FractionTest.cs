using LimMath;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class FractionTest
    {
        SimpleFraction sf = new SimpleFraction(2, 3);
        SimpleFraction sf2 = new SimpleFraction(7, 4);
        SimpleFraction sf3 = new SimpleFraction(6, 4);


        [TestMethod]
        public void SimpleFractionMathActionTest()
        {


            Assert.AreEqual("29/12", (sf + sf2).ToString());
            Assert.AreEqual("13/12", (sf2 - sf).ToString());
            Assert.AreEqual("14/12", (sf2 * sf).ToString());
            Assert.AreEqual("8/21", (sf / sf2).ToString());
            Assert.AreEqual("11/3", (sf + 3).ToString());
            Assert.AreEqual(new SimpleFraction(-5, 4), sf2 - 3);
            Assert.AreEqual("21/4", (sf2 * 3).ToString());
            Assert.AreEqual("2/9", (sf / 3).ToString());
            Assert.AreEqual("11/3", (3 + sf).ToString());
            Assert.AreEqual("5/4", (3 - sf2).ToString());
            Assert.AreEqual("21/4", (3 * sf2).ToString());
            Assert.AreEqual("9/2", (3 / sf).ToString());

            sf3.Cut();
            Assert.AreEqual("3/2", sf3.ToString());

            Assert.AreEqual("2/5", new SimpleFraction("5/2").Reverse().ToString());

            Assert.AreEqual(true, new SimpleFraction(2, 3) > new SimpleFraction(1, 3));
            Assert.AreEqual(true, new SimpleFraction(5, 7) > new SimpleFraction(1, 20));
            Assert.AreEqual(true, new SimpleFraction(12, 7) > new SimpleFraction(1, 20));
            Assert.AreEqual(true, new SimpleFraction(12, 7) == new SimpleFraction(12, 7));
            Assert.AreEqual(true, new SimpleFraction(12, 7) != new SimpleFraction(1, 20));
            Assert.AreEqual(false, new SimpleFraction(12, 7) < new SimpleFraction(1, 20));
            Assert.AreEqual(false, new SimpleFraction(5, 7) < new SimpleFraction(1, 20));
            Assert.AreEqual(false, new SimpleFraction(12, 7) < new SimpleFraction(1, 20));








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
