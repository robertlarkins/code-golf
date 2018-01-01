using System;

namespace CodeGolf.ArraySearching
{
    /// <summary>
    /// https://codegolf.stackexchange.com/questions/132512/where-does-the-pivot-belong
    /// This uses image moments on a 1D array to find the centre of mass
    /// </summary>
    public class ArrayPivot
    {
        public int FindPivotPoint(int[] array)
        {
            var m0 = 0;
            var m1 = 0;

            for (int i = 1; i <= array.Length; i++)
            {
                m0 += array[i-1];
                m1 += i * array[i-1];
            }

            return m1 / (m1 % m0 > 0 ? 0 : m0);

            //return m1 / m0;
        }

        public int FinPivotPointGolfChallenge(int[] a)
        {
            int p = 0, q = 0, i = 1;

            for (; i <= a.Length; p += a[i - 1], q += i * a[i++ - 1]);

            return q / (q % p > 0 ? 0 : p);
        }
    }
}