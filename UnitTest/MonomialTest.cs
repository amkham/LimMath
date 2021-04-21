using LimMath;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTest
{

    [TestClass]
    public class MonomialTest
    {
      

        LimMath.Monomial m1 = new LimMath.Monomial(2, new List<char>{'z','x','y'});
        LimMath.Monomial m2 = new LimMath.Monomial(2, new List<char>{ 'y','z', 'x' });
        LimMath.Monomial m3 = new LimMath.Monomial(2, new List<char>{ 'y', 'a','z' });
        LimMath.Monomial m4 = new LimMath.Monomial(4, new List<char> { 'z', 'x', 'y' });
        LimMath.Monomial m5 = new LimMath.Monomial(4, new List<char> { 'x', 'x', 'y', 'y', 'z', 'z' });


        [TestMethod]
        public void SimilarTest()
        {
         

           Assert.AreEqual(true, LimMath.Monomial.Similar(m1, m2));
          Assert.AreEqual(false, LimMath.Monomial.Similar(m1, m3));
          Assert.AreEqual(new SimpleFraction(4,1), (m1 + m2).Coef);

           Assert.AreEqual(false, m1.Equals(m2));

            

            Assert.AreEqual(true, m1 == m2);
            Assert.AreEqual(false, m1 == m3);
            Assert.AreEqual(false, m1 == m4);
            Assert.AreEqual(false, m1 != m2);
            Assert.AreEqual(true, m1 != m4);
            Assert.AreEqual(true, m1 != m3);
            Assert.AreEqual(true, m1 != m5);

            Assert.AreEqual(true, m1 < m4);
            Assert.AreEqual(false, m1 > m4);
            Assert.AreEqual(false, m4 < m1);
            Assert.AreEqual(true, m4 > m1);
            Assert.AreEqual(true, m1 < m4);

            Assert.AreEqual(m5.ToString(), (m1 * m2).ToString());


        }
    }
}
