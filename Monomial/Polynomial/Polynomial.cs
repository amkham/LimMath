using System;
using System.Collections.Generic;
using System.Text;
using LimMath;

namespace LimMath
{
    public class Polynomial
    {
        public Polynomial(List<Monomial> pol)
        {
            Pol = pol;
        }
        public Polynomial()
        {
            Pol = new List<Monomial>();
        }

        public static Polynomial operator +(Polynomial p) => p;
        public static Polynomial operator +(Polynomial p1, Polynomial p2) => new Polynomial(Sum(p1,p2));
        public static Polynomial operator +(Polynomial p, int n) => new Polynomial(Sum(p,n));
        public static Polynomial operator +(int n, Polynomial p) => p+n;

        private static List<Monomial> Sum(Polynomial p1, Polynomial p2)
        {
            List<Monomial> result = new List<Monomial>();

            foreach (var i in p1.Pol) 
            {
                foreach (var j in p2.Pol)
                {
                    if (!Monomial.Similar(i, j))
                    {
                        result.Add(i);
                        result.Add(j);
                    }
                    else result.Add(i + j);
                  
                }
            }
            return result;
        
        }
        private static List<Monomial> Sum(Polynomial p1, int n)
        {
            List<Monomial> monomials = p1.Pol;
            monomials.Add(new Monomial(n));
            return monomials;
        }

        public List<Monomial> Pol { get; set; }
    }
}
