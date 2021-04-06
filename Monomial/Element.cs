using Monomial;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace LimMath
{
    public class Element<T>
    {


        private List<T> coefficient = new List<T>();
        private List<char> variables = new List<char>();

        public Element()
        {
           
        }


        public Element(string monomial)
        {
            string[] elem = monomial.Split('*');
            List<string> v = new List<string>();

            double coefDouble = 1;

            foreach (var i in elem)
            {
                if (Double.TryParse(i, out double m))
                {
                    coefDouble *= m;
                }
                else
                {
                    v.Add(i);
                }
            }

        }

       
        public List<char> Variables { get => variables; set => variables = value; }
        public List<T> Coefficient { get => coefficient; set => coefficient = value; }

        public static Element<T> operator +(Element<T> e1, Element<T> e2)
        {

            return Add(e1, e2);

        }

        private static Element<T> Add(Element<T> e1, Element<T> e2)
        {

            List<T> result = e1.Coefficient;
            if (e1.Variables.Equals(e2.Variables))
            {
                foreach (var i in e2.Coefficient)
                {

                    result.Add(i);
                }

                return new Element<T> { Coefficient = result, Variables = e1.Variables };
            }
            else 
            {
                // сумма элементов 
                throw new NotImplementedException();
            }
           
        }
    }
}
