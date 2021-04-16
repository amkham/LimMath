using LimMath;
using System;
using System.Collections.Generic;

namespace LimMath
{
    public struct Monomial
    {


        private SimpleFraction coef;
        public List<char> Variables { get; set; }

        public Monomial(SimpleFraction coef, List<char> variables)
        {
            this.coef = coef;
            Variables = variables;
            Variables.Sort();
        }
        public Monomial(int coef, List<char> variables)
        {
            this.coef = new SimpleFraction(coef, 1);
            Variables = variables;
            Variables.Sort();
        }

        /// <summary>
        /// Сложение
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        /// 
        public static Monomial operator +(Monomial m) => m;
        public static Monomial operator +(Monomial m1, Monomial m2) => Monomial.Similar(m1.Variables, m2.Variables)
            ? new Monomial(m1.Coef + m2.Coef, m1.Variables)
            : throw new ArgumentException("Одночлены не подобны. Сложение не возможно");

        /// <summary>
        /// Разность
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        /// 
        public static Monomial operator -(Monomial m) => new Monomial(-m.Coef, m.Variables);
        public static Monomial operator -(Monomial m1, Monomial m2) => m1 + (-m2);


        public static Monomial operator *(Monomial m1, Monomial m2) => new Monomial(m1.Coef * m2.Coef, Add(m1.Variables, m2.Variables));
        public static Monomial operator *(int n, Monomial m) => new Monomial(n, new List<char> { }) * m;
        public static Monomial operator *(Monomial m, int n) => new Monomial(n, new List<char> { }) * m;


        public static bool operator ==(Monomial m1, Monomial m2) => Similar(m1.Variables, m2.Variables) && m1.Coef == m2.Coef;
        public static bool operator !=(Monomial m1, Monomial m2) => Similar(m1.Variables, m2.Variables) || m1.Coef != m2.Coef;

        /// <summary>
        /// Проверка на подобие 
        /// </summary>
        /// <param name="m1"></param>
        /// <param name="m2"></param>
        /// <returns></returns>
        public static bool Similar(List<char> m1, List<char> m2)
        {


         

                int result = 0;

                foreach (var i in m2)
                {
                m1.Find(m2.);

                }
                Console.WriteLine(0);
                return result == m1.Count;
            }

          

        }

        private static List<char> Add(List<char> l1, List<char> l2)
        {
            l1.AddRange(l2);
            return l1;

        }

        public SimpleFraction Coef { get => coef; set => coef = value; }
        


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
                   EqualityComparer<SimpleFraction>.Default.Equals(coef, monomial.coef) &&
                   EqualityComparer<SimpleFraction>.Default.Equals(Coef, monomial.Coef) &&
                   EqualityComparer<List<char>>.Default.Equals(Variables, monomial.Variables);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(coef, Coef, Variables);
        }
    }
    }
