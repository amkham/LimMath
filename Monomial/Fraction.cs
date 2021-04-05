using System;
using System.Collections.Generic;
using System.Text;

namespace LimMath
{
   public class Fraction<N,D>
    {
        private List<N> numerator;
        private List<D> denominator;

     

        public Fraction(List<N> numerator, List<D> denominator)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
            
        }

        public Fraction()
        {
           
        }

        public static Fraction<N, D> operator +(Fraction<N, D> f1, Fraction<N, D> f2)

        {

            return Sum(f1, f2);
        }


       


        private static Fraction<N,D> Sum(Fraction<N, D> f1, Fraction<N, D> f2)
        {

          
                List<N> newNum = f1.Numerator;

                foreach (var i in f2.Numerator)
                {

                    newNum.Add(i);
                }

                return new Fraction<N, D> { Numerator = newNum, Denominator = f1.Denominator };

        }


        public string toString()
        {

            string s = "";

            foreach (var i in Numerator)
            {
                s = s + i.ToString();
            }

            s = s + " / ";
            foreach (var i in Denominator)
            {
                s = s + i.ToString();
            }

            return s;

        }



        public List<N> Numerator { get => numerator; set => numerator = value; }
        public List<D> Denominator { get => denominator; set => denominator = value; }

    }
}
