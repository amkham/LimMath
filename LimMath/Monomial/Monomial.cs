
using System;
using System.Collections.Generic;

namespace LimMath
{
    public class Monomial
    {
        public SimpleFraction Coef { get; set; }
        public List<char> Variables { get; set; } = new List<char>();

        public Monomial(SimpleFraction coef, List<char> variables)
        {
            Coef = coef;
            Variables = variables;

        }

        public Monomial(SimpleFraction coef)
        {
            Coef = coef;
            Variables = new List<char>();

        }
        public Monomial(int coef, List<char> variables)
        {
            Coef = new SimpleFraction(coef, 1);
            Variables = variables;

        }
        public Monomial(List<char> variables)
        {
            Coef = new SimpleFraction(1, 1);
            Variables = variables;

        }

        public Monomial(int coef)
        {
            Coef = new SimpleFraction(coef, 1);
            Variables = new List<char>();

        }
        public Monomial()
        {
        }



        ///////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////      АРИФМИТИЧЕСКИЕ И ЛОГИЧЕСКИЕ ДЕЙСТВИЯ     //////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Сложение
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        /// 
        public static Monomial operator +(Monomial m) => m;
        public static object operator +(Monomial m1, Monomial m2) => Similar(m1, m2)
            ? new Monomial(m1.Coef + m2.Coef, m1.Variables)
            : new Polynomial(new List<Monomial> { m1, m2 });

        /// <summary>
        /// Разность
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        /// 
        public static Monomial operator -(Monomial m) => new Monomial(-m.Coef, m.Variables);
        public static object operator -(Monomial m1, Monomial m2) => m1 + (-m2);

        /// <summary>
        /// Умножение
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static Monomial operator *(Monomial m1, Monomial m2) => new Monomial(m1.Coef * m2.Coef, Add(m1.Variables, m2.Variables));
        public static Monomial operator *(Monomial m, SimpleFraction sf) => new Monomial(m.Coef * sf, m.Variables);
        public static Monomial operator *(SimpleFraction sf, Monomial m) => m * sf;
        public static Monomial operator *(Monomial m, int n) => m * new SimpleFraction(n);
        public static Monomial operator *(int n, Monomial m) => m * n;

        /// <summary>
        /// Деление
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static Monomial operator /(Monomial m1, Monomial m2)
        {
            return new Monomial(m1.Coef / m2.Coef, Div(m1.Variables, m2.Variables));
        }
        public static Monomial operator /(Monomial m, int n) => m / new Monomial(n);
        public static Monomial operator /(int n, Monomial m) => new Monomial(n) / m;
        public static Monomial operator /(Monomial m, SimpleFraction s) => m / new Monomial(s);
        public static Monomial operator /(SimpleFraction s, Monomial m) => new Monomial(s) / m;

        /// <summary>
        /// Сравнение
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static bool operator ==(Monomial m1, Monomial m2)
        {
            if (m1 is null)
            {
                throw new ArgumentNullException(nameof(m1));
            }

            return Similar(m1, m2) && m1.Coef == m2.Coef;
        }
        public static bool operator !=(Monomial m1, Monomial m2) => !Similar(m1, m2) || m1.Coef != m2.Coef;
        public static bool operator >(Monomial m1, Monomial m2) => Similar(m1, m2) ? m1.Coef > m2.Coef
            : throw new ArgumentException("Одночлены не подобны. Сравнение невозможно");
        public static bool operator <(Monomial m1, Monomial m2) => Similar(m1, m2) ? m1.Coef < m2.Coef
            : throw new ArgumentException("Одночлены не подобны. Сравнение невозможно");




        ///////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////          ДЕЙСТВИЯ PRIVATE      ////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Сложение переменных многочлена
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        private static List<char> Add(in List<char> l1, in List<char> l2)
        {

            l1.AddRange(l2);
            return l1;

        }

        private static List<char> Div(in List<char> l1, in List<char> l2)
        {
            if (l1 is null)
            {
                throw new ArgumentNullException(nameof(l1));
            }

            if (l2 is null)
            {
                throw new ArgumentNullException(nameof(l2));
            }

            List<char> result = new List<char>();
            result.AddRange(l1);
            result.AddRange(l2);

            foreach (var i in l1)
            {
                foreach (var j in l2)
                {

                    if (i == j)
                    {
                        result.Remove(i);
                        result.Remove(j);

                    }
                }
            }


            return result;

        }


        ///////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////         ДЕЙСТВИЯ PUBLIC  ////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Проверка на подобие 
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static bool Similar(in Monomial m1, in Monomial m2)
        {


            int result = 0;

            if (m1.Variables.Count == m2.Variables.Count)
            {
                foreach (var i in m2.Variables)
                {

                    foreach (var j in m1.Variables)
                    {

                        if (i == j)
                        {

                            result++;
                        }
                    }

                }

                return result == m1.Variables.Count;
            }
            else return false;







        }

        ///////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////         ПЕРЕОПРЕДЕЛЕННЫЕ МЕТОДЫ              /////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////
        public override string ToString()
        {
            string result = "";
            foreach (var i in Variables)
            {
                result += i;
            }
            return Coef + result;
        }

        public override bool Equals(object obj)
        {
            return obj is Monomial monomial &&
                Similar(this, monomial) &&
                Coef == monomial.Coef;

        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Coef, Coef, Variables);
        }
    }
}
