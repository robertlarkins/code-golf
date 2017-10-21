using System;
using System.Text;

namespace CodeGolf
{
    public class GauNumberDigits
    {
        public static void GetGauNumberDigits()
        {

            var nList = new[] { 9, 10, 11, 12, 13, 14, 15, 97, 98, 99, 100, 101, 102, 103, 104, 105 };

            for (int i = 0; i < nList.Length; i++)
            {
                var n = nList[i];
                var noExtra = n * (n + 1) * (n + 2) / 6;
                var gau = GAU(n);
                var gau2 = 0; //GAU2(n);
                var gau3 = GAU3(n);

                Console.WriteLine(n + " " + gau + " " + gau2 + " " + gau3);

                //Console.WriteLine(n + " = " + gau + " before=" + noExtra + "   diff =   " + (gau - noExtra));
            }

            Console.ReadLine();
        }


        public static int GAU3(int n)
        {
            int b = 0, a = 0, i;

            while (a++ < n)
                for (i = 0; i++ < a;)
                    b += (i+"").Length * i;

            return b;
        }

        public static int GAU(int n)
        {
            var builder = new StringBuilder();

            for (int a = 1; a <= n; a++)
            {
                for (int i = 1; i <= a; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        builder.Append(i);
                    }
                }
            }

            return builder.Length;
        }

        public static int GAU2(int n)
        {
            var b = "";
            int a = 1, i, j;
            for (; a <= n; a++)
            for (i = 1; i <= a; i++)
            for (j = 1; j++ <= i; b += i) ;

            return b.Length;
        }
    }
}