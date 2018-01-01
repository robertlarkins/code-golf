using System;

namespace CodeGolf.BinaryNumbers
{
    public class RemoveSignificantBit
    {
        public int RemoveBit(int number)
        {
            // take the base 2 log of number and
            // shift the single bit in the number 1 by this amount
            // this gives the number formed by the most significant bit
            // subtract this from the full number
            // the Math.Log is the inverse operation to an exponential
            // so if x=Math.Log(number, 2) the inverse is number=2^x
            // exponent=Log(number, base) as number=base^exponent
            return number - (1 << (int) Math.Log(number, 2));
        }

        public int RemoveBitBinaryString(int number)
        {
            var t = Convert.ToString(number, 2).Remove(0, 1);
            return t.Length < 1 ? 0 : Convert.ToInt32(t, 2);
        }
    }
}