using System;
using System.Collections.Generic;

namespace LimMath
{ 
    public class Fraction<N, D>
    {

        private List<N> numerator = new List<N>();
        private List<D> denominator = new List<D>();

        bool numPositive;
        bool denPositive;






        public Fraction()
        {

        }

        ////////////////////////////////// ПЕРЕГРУЗКА ОПЕРАТОРОВ /////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Сумма дробей
        /// </summary>
        /// <param name="f1">Дробь 1</param>
        /// <param name="f2">Дробь 2</param>
        /// <param name="">Дробь 2</param>
        /// <returns>Обьект типа Fraction</returns>
        public static Fraction<N, D> operator +(Fraction<N, D> f1, Fraction<N, D> f2)

        {
            if ((typeof(N) == typeof(double)) && (typeof(D) == typeof(double)))
            {

                return Sum(f1, f2);
            }
            else
            {
                return Add(f1, f2);
            }


        }

        private static Fraction<N, D> Add(Fraction<N, D> f1, Fraction<N, D> f2)
        {



            List<N> newNum = f1.Numerator;

            foreach (var i in f2.Numerator)
            {

                newNum.Add(i);
            }

            return new Fraction<N, D> { Numerator = newNum, Denominator = f1.Denominator };

        }

        private static Fraction<N, D> Sum(Fraction<N, D> f1, Fraction<N, D> f2)
        {

            dynamic sum = 0;
            dynamic denom1 = f1.Denominator;
            dynamic denom2 = f2.Denominator;

            foreach (var i in f1.Numerator)
            {
                sum = sum + i;
            }

            foreach (var i in f2.Numerator)
            {
                sum = sum + i;
            }


            Fraction<N, D> result = new Fraction<N, D>();
            result.Numerator.Add((N)Convert.ChangeType(sum, typeof(N)));
            result.Denominator = f1.Denominator;

            return result;

        }




        /// <summary>
        /// Вычитание дробей
        /// </summary>
        /// <param name="f1"></param>
        /// <param name="f2"></param>
        /// <returns></returns>
        public static Fraction<N, D> operator -(Fraction<N, D> f1, Fraction<N, D> f2)

        {
            if ((typeof(N) == typeof(double)) && (typeof(D) == typeof(double)))
            {

                return Dif(f1, f2);
            }
            else
            {
                return Add(f1, f2);
            }


        }



        private static Fraction<N, D> Dif(Fraction<N, D> f1, Fraction<N, D> f2)
        {
            throw new NotImplementedException();
        }


        ////////////////////////////////// ВСПОМОГАТЕЛЬНЫЕ МЕТОДЫ /////////////////////////////////////////////////////
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////







        private static Fraction<N, D> Simplify(Fraction<N, D> f)
        {


            return null;


        }


        public string toString()
        {

            string s = "{";

            foreach (var i in Numerator)
            {
                s = s + i.ToString() + " ";
            }

            s = s + " / ";
            foreach (var i in Denominator)
            {
                s = s + i.ToString() + " ";
            }

            s = s + "}";
            return s;

        }



        public List<N> Numerator { get => numerator; set => numerator = value; }
        public List<D> Denominator { get => denominator; set => denominator = value; }
        public bool NumPositive { get => numPositive; set => numPositive = value; }
        public bool DenPositive { get => denPositive; set => denPositive = value; }
    }
}
