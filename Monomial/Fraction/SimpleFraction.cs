using System;
using System.Collections.Generic;
using System.Text;

namespace LimMath.Fraction
{
   public struct SimpleFraction
    {
        public int Numer { get; set; }
        public int Denom { get; set; }

        public SimpleFraction(string s)
        {
            string[] mass = s.Split("/");
            Numer = Convert.ToInt32(mass[0]);
            Denom = Convert.ToInt32(mass[1]);
        }

        public SimpleFraction(int n, int d)
        {

            if (d == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.", nameof(d));
            }
            Numer = n;
            Denom = d;
        }







        /// <summary>
        /// Сложение 
        /// </summary>
        /// <param name="sf1"></param>
        /// <param name="sf2"></param>
        /// <returns></returns>
        public static SimpleFraction operator +(SimpleFraction sf) => sf;
        public static SimpleFraction operator +(SimpleFraction sf1, SimpleFraction sf2) 
            => new SimpleFraction(sf1.Numer * sf2.Denom + sf2.Numer * sf1.Denom, sf1.Denom * sf2.Denom);
        public static SimpleFraction operator +(SimpleFraction sf, int n) => sf + new SimpleFraction(n,1);
        public static SimpleFraction operator +(int n, SimpleFraction sf ) => sf + n;
        /// <summary>
        /// Вычитание
        /// </summary>
        /// <param name="sf1"></param>
        /// <param name="sf2"></param>
        /// <returns></returns>
        public static SimpleFraction operator -(SimpleFraction sf) => new SimpleFraction(-sf.Numer, sf.Denom);
        public static SimpleFraction operator -(SimpleFraction sf1, SimpleFraction sf2) => sf1 + (-sf2);
        public static SimpleFraction operator -(SimpleFraction sf1, int n) => sf1 + (-n);
        public static SimpleFraction operator -(int n, SimpleFraction sf1) => (-sf1) + n;

        /// <summary>
        /// Умножение
        /// </summary>
        /// <param name="sf1"></param>
        /// <param name="sf2"></param>
        /// <returns></returns>
        public static SimpleFraction operator *(SimpleFraction sf1, SimpleFraction sf2) 
            => new SimpleFraction(sf1.Numer * sf2.Numer, sf1.Denom * sf2.Denom);
        public static SimpleFraction operator *(SimpleFraction sf, int n) => sf*new SimpleFraction(n, 1);
        public static SimpleFraction operator *(int n, SimpleFraction sf) => sf*n;

        /// <summary>
        /// Деление
        /// </summary>
        /// <param name="sf1"></param>
        /// <param name="sf2"></param>
        /// <returns></returns>
        public static SimpleFraction operator /(SimpleFraction sf1, SimpleFraction sf2) => sf1 * sf2.Reverse();
        public static SimpleFraction operator /(SimpleFraction sf1, int n) =>  sf1/new SimpleFraction(n,1);
        public static SimpleFraction operator /(int n, SimpleFraction sf1) => new SimpleFraction(n,1) / sf1;





        public void Cut()
        {
            int div = MathActions.GCF(Numer, Denom);
            if (div != 1)
            {
               
                Numer /= div;
                Denom /= div;
            }

        }
        public SimpleFraction Reverse() => new SimpleFraction(Denom, Numer);
       



        public override string ToString() => Numer == Denom ? "" + Numer  : Numer + "/" + Denom;


        public double ToDecimal() => Numer / Denom;

     

    
    }
}
