using System;
using System.Collections.Generic;
using System.Text;
using LimMath;

namespace LimMath
{
    public class Polynomial
    {
        public List<Monomial> Pol { get; set; }

        public Polynomial(List<Monomial> pol)
        {
            Pol = pol;
        }
        public Polynomial()
        {
            Pol = new List<Monomial>();
        }

        public static Polynomial operator +(Polynomial p) => p;
        public static Polynomial operator +(Polynomial p1, Polynomial p2) => Sum(p1,p2);
        public static Polynomial operator +(Polynomial p, int n) => Sum(p,n);
        public static Polynomial operator +(int n, Polynomial p) => p+n;

        public static Polynomial operator -(Polynomial p) => Opposite(p);
        public static Polynomial operator -(Polynomial p1, Polynomial p2) => p1 + (-p2);
        public static Polynomial operator -(Polynomial p1, int n) => p1 + (-n);
        public static Polynomial operator -(int n, Polynomial p) => n + (-p);


        private static Polynomial Sum(Polynomial p1, Polynomial p2)
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
            return new Polynomial(result);
        
        }
        private static Polynomial Sum(Polynomial p1, int n)
        {
            List<Monomial> result = p1.Pol;
            result.Add(new Monomial(n));
            return new Polynomial(result);
        }

        private static Polynomial Sum<N>(Polynomial p1, N n)
        {
            List<Monomial> result = p1.Pol;
            result.Add(new Monomial(n));
            return new Polynomial(result);
        }

        private static Polynomial Opposite(Polynomial p)
        {
            Polynomial result = new Polynomial();
            foreach (var i in p.Pol)
            {
                result.Pol.Add(-i);
            }

            return result;
        }



    }
}
