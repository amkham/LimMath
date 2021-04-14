using System;
using System.Collections.Generic;
using System.Text;

namespace LimMath.Fraction
{
   public class SimpleFraction
    {
        private double numer;
        private double denom;

        public SimpleFraction(string s)
        {
            string[] mass = s.Split("/");
            numer = Convert.ToDouble(mass[0]);
            denom = Convert.ToDouble(mass[1]);
        }

        public SimpleFraction(double n, double d)
        {
            numer = n;
            denom = d;
        }

        public static SimpleFraction operator +(SimpleFraction sf1, SimpleFraction sf2)
        {

            if (sf1.Denom == sf2.Denom)
            {

                return new SimpleFraction(sf1.Numer + sf2.Numer, sf1.Denom);
            }
            else
            {
                double d = MathActions.LCM(sf1.Denom, sf2.Denom);

                return new SimpleFraction(sf1.Numer * (d / sf1.Denom) + sf2.Numer * (d / sf2.Denom), d);
            }
        }

      
        public double Numer { get => Numer; set => Numer = value; }
        public double Denom { get => Denom; set => Denom = value; }
    }
}
