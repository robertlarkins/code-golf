using System;

namespace ExampleAlgorithms
{
    public class AlternateBetweenNumbers
    {
        public int[] AlternateBetween3And1()
        {
            int t = 1;

            var repeat = 4;
            var result = new int[repeat];

            for (int i = 0; i < repeat; i++)
            {
                result[i] = t ^= 2;
            }

            return result;
        }
    }
}