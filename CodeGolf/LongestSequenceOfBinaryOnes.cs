using System;
using System.Linq;

namespace CodeGolf
{
    public class LongestSequenceOfBinaryOnes
    {
        public static void GetLongestSequence()
        {
            var number = 750;

            var s = Convert.ToString(number, 2);

            //s = "111110";

            Console.WriteLine(s);

            int c = 0, l = 0, p = 0, k = 0, j = s.Length - 1, i = j;

            for (; i >= 0; i--)
            {
                if (s[i] > '0')
                {
                    if (i == j || s[i + 1] < '1')
                    {
                        p = i;
                        c = 0;
                    }

                    if (++c >= l)
                    {
                        l = c;
                        k = p;
                    }
                }
            }

            var result = j - k;

            Console.WriteLine(result);

            Console.WriteLine("Approach Two");

            ApproachTwo(number);

            Console.WriteLine("Recursive Approach");

            var rar = RecursiveApproach(number);

            Console.WriteLine(rar);
            Console.ReadLine();
        }

        public static void ApproachTwo(int number)
        {
            var s = Convert.ToString(number, 2);
            Console.WriteLine(s);

            var t = s.Split('0').OrderBy(x => x.Length).Last();

            var finalResult = number < 1 ? 0 : s.Length - s.IndexOf(t) - t.Length;

            Console.WriteLine(finalResult);
        }

        public static int RecursiveApproach(int number)
        {
            int k = number & number / 2, x = (int)Math.Log(number, 2);

            return k > 0 ? RecursiveApproach(k) : x < 0 ? 0 : x;
        }
    }
}