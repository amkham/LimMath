using LimMath;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
        [DataTestMethod]
        [DataRow(14, 58)]
        [DataRow(-14, 58)]
        public void CutTest(int num, int denom)
        {
            var sf1 = new SimpleFraction(num, denom);
            sf1.Cut();
            Assert.AreEqual(new SimpleFraction(num, denom), sf1);


        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(14, 58)]
        [DataRow(-14, 58)]
        public void CutTest2(int num, int denom)
        {
            var sf1 = new SimpleFraction(num, denom);
            sf1.Cut(2);
            Assert.AreEqual(new SimpleFraction(num, denom), sf1);


        }
    }
}
