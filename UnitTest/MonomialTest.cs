using LimMath;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTest
{

    [TestClass]
    public class MonomialTest
    {
        
        
        List<char> variables1 = new List<char> { 'a', 'b', 'c', 'd' };
        List<char> variables2 = new List<char> { 'b', 'c', 'a', 'd' };
        List<char> variables3 = new List<char> { 'b', 'c', 'a', 'd' };
        

        [TestMethod]
        public void EqualsTest()
        {

            Monomial m1 = new Monomial(2, new List<char> { 'z', 'x', 'y' });
            Monomial m2 = new Monomial(2, new List<char> { 'y', 'z', 'x' });
            Assert.AreEqual(true, m1.Equals(m2));

        }


        [TestMethod]
        public void SimilarTest()
        {
            Monomial m1 = new Monomial(2, new List<char> { 'z', 'x', 'y' });
            Monomial m2 = new Monomial(2, new List<char> { 'y', 'z', 'x' });
            Monomial m3 = new Monomial(2, new List<char> { 'y', 'a', 'z' });
            Monomial m4 = new Monomial(4, new List<char> { 'z', 'x', 'y' });
            Monomial m5 = new Monomial(4, new List<char> { 'x', 'x', 'y', 'y', 'z', 'z' });

            Assert.AreEqual(true, Monomial.Similar(m1, m2));
            Assert.AreEqual(false, Monomial.Similar(m1, m3));

            Assert.AreEqual(true, m1.Equals(m2));



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




        }

        [TestMethod]
        public void MonomialActionTest()
        {
            Random random = new Random();
            char[] variables = { 'a', 'b', 'c', 'd' };

            Console.WriteLine(random.Next(variables.Length));

            LimMath.Monomial m1 = new LimMath.Monomial
            {

                Coef = new SimpleFraction(25),
                Variables = variables1
            };
            LimMath.Monomial m2 = new LimMath.Monomial
            {

                Coef = new SimpleFraction(24),
                Variables = variables2
            };

        }

        [TestMethod]
        public void MonomialSetTest()
        {
            LimMath.Monomial monomial = new LimMath.Monomial
            {
                Variables = new List<char>() { 'x', 'a', 'n', }
            };

            Console.WriteLine(monomial.ToString());
        }


    }
}
