namespace LimMath
{
    static public class MathActions
    {

        static public int Min(int x, int y)
        {
            return x < y ? x : y;
        }

        static public int Max(int x, int y)
        {
            return x > y ? x : y;
        }



        static public int GCF(int a, int b)
        {
            while (b != 0)
            {
                var temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }



        static public int LCM(int a, int b)
        {

            return a * b / GCF(a, b);
        }
    }
}
