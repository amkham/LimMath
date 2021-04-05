using Monomial;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace LimMath
{
    public class ElemMulti<T>
    {


        private T coefficient;
        private int monomialPower;     
        private List<ElemPow<int,char,Fraction<int,int>>> powers = new List<ElemPow<int, char, Fraction<int, int>>>();



        public ElemMulti(string monomial)
        {
            string[] elem = monomial.Split('*');
            List<string> variables = new List<string>();

        double coefDouble = 1;

            foreach (var i in elem)
            {
                if (Double.TryParse(i, out double m))
                {
                    coefDouble *= m;
                }
                else 
                {
                   //Variables.Add(i);
                }
            }

            coefficient = (T)Convert.ChangeType(coefDouble, typeof(T));
            foreach (var i in variables)
            {

               int pozition = i.IndexOf("^") + 1;
            }




        }

        public T Coefficient { get => coefficient; set => coefficient = value; }
        public int MonomialPower { get => monomialPower; set => monomialPower = value; }
       
    }
}
