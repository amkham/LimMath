using System;
using System.Collections.Generic;

namespace MonomialNS
{
    public class Monomial<T>
    {


        private T coefficient;
        private int monomialPower;
        private List<string> variables = new List<string>();



        public Monomial(string monomial)
        {
            string[] elem = monomial.Split('*');

            double coefDouble = 1;

            foreach (var i in elem)
            {
                if (Double.TryParse(i, out double m))
                {
                    coefDouble *= m;
                }

                else 
                {

                    Variables.Add(i);
                }
            }

            coefficient = (T)Convert.ChangeType(coefDouble, typeof(T));




        }

        public T Coefficient { get => coefficient; set => coefficient = value; }
        public int MonomialPower { get => monomialPower; set => monomialPower = value; }
        public List<string> Variables { get => variables; set => variables = value; }
    }
}
