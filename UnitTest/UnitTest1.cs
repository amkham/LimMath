using Microsoft.VisualStudio.TestTools.UnitTesting;
using LimMath;
using System;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        Fraction<int, int> f1 = new Fraction<int, int> { Numerator = new List<int> { 1}, Denominator = new List<int> { 3} };
       
        Fraction<int, int> f2 = new Fraction<int, int> { Numerator = new List<int> { 2 }, Denominator = new List<int> { 3 } };




        [TestMethod]
        public void coeffTest()
        {

            Fraction<int, int> f3 = new Fraction<int, int>();

            f3 = f1 + f2;

            Console.WriteLine(f3.toString());

        }
    }
}
