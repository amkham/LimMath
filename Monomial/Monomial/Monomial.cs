using LimMath;
using System;
using System.Collections.Generic;

namespace LimMath
{
    public class Monomial
    {
        public List<char> Variables { get; set; }

        public SimpleFraction Coef { get; set; }

        public Monomial(SimpleFraction coef, List<char> variables)
        {
            Coef = coef;
            Variables = variables;
            Variables.Sort();
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
            Variables.Sort();
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
        public static Monomial operator +(Monomial m1, Monomial m2) => Similar(m1, m2)
            ? new Monomial(m1.Coef + m2.Coef, m1.Variables)
            : throw new ArgumentException("Одночлены не подобны. Сложение не возможно");

        /// <summary>
        /// Разность
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        /// 
        public static Monomial operator -(Monomial m) => new (-m.Coef, m.Variables);
        public static Monomial operator -(Monomial m1, Monomial m2) => m1 + (-m2);


        public static Monomial operator *(Monomial m1, Monomial m2) => new (m1.Coef * m2.Coef, Add(m1.Variables, m2.Variables));
        public static Monomial operator *(Monomial m, SimpleFraction sf) => new (m.Coef * sf, m.Variables);
        public static Monomial operator *(SimpleFraction sf, Monomial m) => m * sf;
        public static Monomial operator *(Monomial m, int n) => m * new SimpleFraction(n);
        public static Monomial operator *(int n, Monomial m) => m * n;

        public static Monomial operator /(Monomial m1, Monomial m2) => new(m1.Coef/m2.Coef, m1.)

        public static bool operator ==(Monomial m1, Monomial m2) => Similar(m1, m2) && m1.Coef == m2.Coef;
        public static bool operator !=(Monomial m1, Monomial m2) => !Similar(m1, m2) || m1.Coef != m2.Coef;

        public static bool operator >(Monomial m1, Monomial m2) => Similar(m1, m2) ? m1.Coef > m2.Coef
            : throw new ArgumentException("Одночлены не подобны. Сравнение невозможно");
        public static bool operator <(Monomial m1, Monomial m2) => Similar(m1, m2) ? m1.Coef < m2.Coef 
            : throw new ArgumentException("Одночлены не подобны. Сравнение невозможно");




        ///////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////          ДЕЙСТВИЯ С ОДНОЧЛЕНОМ       /////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Проверка на подобие 
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static bool Similar(Monomial m1, Monomial m2)
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
        /// <summary>
        /// Доп метод для умножения одночленов 
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        private static List<char> Add(List<char> l1, List<char> l2)
        {
            List<char> nList = l1;
           
            nList.AddRange(l2);
            return nList;

        }


        private static Monomial Div(Monomial m1, Monomial l2)
        {


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
                   EqualityComparer<SimpleFraction>.Default.Equals(Coef, monomial.Coef) &&
                   EqualityComparer<SimpleFraction>.Default.Equals(Coef, monomial.Coef) &&
                   EqualityComparer<List<char>>.Default.Equals(Variables, monomial.Variables);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Coef, Coef, Variables);
        }
    }
    }
