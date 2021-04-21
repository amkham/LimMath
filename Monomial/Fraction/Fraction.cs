using System;
using System.Collections.Generic;

namespace LimMath
{ 
    public class Fraction<N, D>
    {
        public Fraction(List<N> numerator, List<D> denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public List<N> Numerator { get; set; } = new List<N>();
        public List<D> Denominator { get; set; } = new List<D>();




        ///////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////      АРИФМИТИЧЕСКИЕ И ЛОГИЧЕСКИЕ ДЕЙСТВИЯ     //////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////
      




        public override string ToString()
        {

            string s = "{";

            foreach (var i in Numerator)
            {
                s = s + i.ToString() + " ";
            }

            s += " / ";
            foreach (var i in Denominator)
            {
                s = s + i.ToString() + " ";
            }

            s += "}";
            return s;

        }



   
    }
}
