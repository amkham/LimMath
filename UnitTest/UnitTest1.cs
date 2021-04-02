using Microsoft.VisualStudio.TestTools.UnitTesting;
using MonomialNS;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {

        Monomial<double> m1 = new Monomial<double>("232,5*2,5*a^2*b^4*c^3*2,5");
        Monomial<int> m2 = new Monomial<int>("4*32*3*a^2*b^4*c^3");


        [TestMethod]
        public void coeffTest()
        {

          Assert.AreEqual(1453.125, m1.Coefficient);
       
            Assert.AreEqual(384, m2.Coefficient);

            foreach (var i in m1.Variables)
            {
                Console.WriteLine(i);
            }
       

        }
    }
}
