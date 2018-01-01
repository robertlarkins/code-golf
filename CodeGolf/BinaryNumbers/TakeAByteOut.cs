using System;

namespace CodeGolf.BinaryNumbers
{
    /// <summary>
    /// https://codegolf.stackexchange.com/questions/147936/take-a-byte-out-of-it
    /// </summary>
    public class TakeAByteOut
    {
        public long ByteNumber(long number)
        {
            var binary = Convert.ToString(number, 2);
            var maxValue = 0L;

            for (int i = 0; i < binary.Length - 7; i++)
            {
                var subString = binary.Remove(i, 8);
                var newLong = Convert.ToInt64(subString, 2);

                maxValue = Math.Max(newLong, maxValue);
            }

            return maxValue;
        }

        public int ByteNumberGolfed(int number)
        {
            var binary = Convert.ToString(number, 2);
            int m=0,i=0;

            while(i<binary.Length-7)
                m = Math.Max(Convert.ToInt32(binary.Remove(i++,8),2),m);

            return m;
        }

        public int ByteNumberGolfed2(int n)
        {
            int m = 0,
                i = 0,
                t;

            // convert n to a binary string,
            // go through removing each possible byte,
            // check if this is the biggest int so far
            for (var b = Convert.ToString(n, 2); i < b.Length - 7; m = t > m ? t : m)
                t = Convert.ToInt32(b.Remove(i++, 8), 2); // remove 8 bits from position i, then convert from binary string to int

            return m;
        }
    }
}