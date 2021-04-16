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
         

           //Assert.AreEqual(true, LimMath.Monomial.Similar(m1.Variables, m2.Variables));
          // Assert.AreEqual(false, LimMath.Monomial.Similar(m1.Variables, m3.Variables));
          // Assert.AreEqual(new SimpleFraction(4,1), (m1 + m2).Coef);

           Assert.AreEqual(false, m1.Equals(m2));

            Assert.AreEqual(m5.ToString(),  (m1 * m2).ToString());

            Console.WriteLine(m1.Variables.Count);
            Console.WriteLine(m2.Variables.Count);


            Assert.AreEqual(true, m1 == m2);
            Assert.AreEqual(false, m1 == m3);
            Assert.AreEqual(false, m1 == m4);
            Assert.AreEqual(false, m1 != m2);
            Assert.AreEqual(true, m1 != m4);
            Assert.AreEqual(true, m1 != m3);




        }
    }
}
