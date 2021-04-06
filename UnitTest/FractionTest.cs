using Microsoft.VisualStudio.TestTools.UnitTesting;
using LimMath;
using System;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class FractionTest
    {
        Fraction<double, double> f1 = new Fraction<double, double> { Numerator = new List<double> { 1}, Denominator = new List<double> { 3} };

        Fraction<double, double> f2 = new Fraction<double, double> { Numerator = new List<double> { 2 }, Denominator = new List<double> { 3 } };

        Fraction<double, double> f5 = new Fraction<double, double>("-3/4");
        Fraction<double, double> f4 = new Fraction<double, double>("2/4");

        Fraction<Element<double>, double> f7 = new Fraction<Element<double>, double>("2*a/4");
        Fraction<Element<double>, double> f8 = new Fraction<Element<double>, double>("3*a/4");



        [TestMethod]
        public void FractionSumNumbers()
        {

           
            Fraction<double, double> f3 = f1 + f2;
            Fraction<double, double> f6 = f4 + f5;
            Fraction<Element<double>, double> f9 = f7 + f8;
            Assert.AreEqual(3, f3.Numerator[0]);
            Assert.AreEqual(3, f3.Denominator[0]);

            Assert.AreEqual(0, f6.Numerator[0]);
            Assert.AreEqual(4, f6.Denominator[0]);

            Console.WriteLine("....");
            foreach (var i in f9.Numerator[0].Coefficient)

            {
               
                Console.WriteLine(i);
            }
            



        }

        [TestMethod]
        public void FractionSumObject()
        {

            



        }



        [TestMethod]
        public void myTest()
        {

            double a = 2;
            double b = 4;

            Assert.AreEqual(6, a + b);

        }
    }
}
