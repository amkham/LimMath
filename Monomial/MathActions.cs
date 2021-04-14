using System;
using System.Collections.Generic;
using System.Text;

namespace LimMath
{
    class MathActions
    {

        static public int Min(int x, int y)
        {
            return x < y ? x : y;
        }

        static public int Max(int x, int y)
        {
            return x > y ? x : y;
        }

 

        static public double GCF(double a, double b)
        {
            while (b != 0)
            {
                var temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

     

        static public double LCM(double a, double b)
        {

            return a * b / GCF(a, b);
        }
    }
}
