﻿namespace LimMath
{
    public abstract class Fraction
    {
        public Fraction(Polynomial numerator, Polynomial denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public Polynomial Numerator { get; set; }
        public Polynomial Denominator { get; set; }




        ///////////////////////////////////////////////////////////////////////////////////////////////
        //////////////////      АРИФМИТИЧЕСКИЕ И ЛОГИЧЕСКИЕ ДЕЙСТВИЯ     //////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////



        ///////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////          ДЕЙСТВИЯ С ДРОБЬЮ         ///////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////





        public override string ToString()
        {
            string result = "";

            return result;

        }




    }
}
