using System;
using System.Linq;

namespace CodeGolf
{
    /// <summary>
    /// https://codegolf.stackexchange.com/questions/142729/randomly-select-from-an-array/142867#142867
    /// </summary>
    public class RandomDistributionFromSize
    {
        public void Run()
        {
            var a = new[] { 1, 4, 5 };
            var result = new int[a.Length];

            var total = 10000000;

            for (int i = 0; i < total; i++)
            {
                var val = GetRandom(a);

                result[Array.IndexOf(a, val)]++;
            }

            foreach (var i in result)
            {
                Console.WriteLine(i / (double)total);
            }

            Console.ReadLine();
        }

        public int GetRandom(int[] a)
        {
            int i = -1, r = new Random().Next(a.Sum());
            while (r >= 0)
                r -= a[++i];
            return a[i];
        }
    }
}