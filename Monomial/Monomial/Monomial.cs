using LimMath.Fraction;
using System;

namespace LimMath.Monomial
{
    public struct Monomial
    {
       

        private SimpleFraction coef;
        private char[] variables;

        public Monomial(SimpleFraction coef, char[] variables)
        {
            this.coef = coef;
            this.variables = variables;
        }

        public static Monomial operator +(Monomial m) => m;


        public static bool Similar(Monomial m1, Monomial m2)
        {
            int result = 0;
            if (m1.Variables.Length == m2.Variables.Length)
            {
                foreach (int i in m1.Variables)
                {
                    if (Array.IndexOf(m1.Variables, i) >= 0)
                    {
                        result++;
                    }
                }
                if (result == m1.Variables.Length)
                {
                    return true;
                }
                else return false;

            }
            else return false;


        }

        public SimpleFraction Coef { get => coef; set => coef = value; }
        public char[] Variables { get => variables; set => variables = value; }

    }
}
