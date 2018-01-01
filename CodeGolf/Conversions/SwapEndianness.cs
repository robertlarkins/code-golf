using System;
using System.Linq;

namespace CodeGolf.Conversions
{
    /// <summary>
    /// https://codegolf.stackexchange.com/questions/149051/swap-the-endianness
    /// </summary>
    public class SwapEndianness
    {
        public uint Swap(uint value)
        {
            return BitConverter.ToUInt32(BitConverter.GetBytes(value).Reverse().ToArray(), 0);
        }

        public uint ReadableSwap(uint value)
        {
            var a = BitConverter.GetBytes(value);
            Array.Reverse(a);
            return BitConverter.ToUInt32(a, 0);
        }

        public uint BitOperationsSwap(uint value)
        {
            value = value >> 16 | value << 16; // swap the uint halves
            return (value & 0xFF00FF00) >> 8 | (value & 0xFF00FF) << 8; // swap the individual bytes
        }
    }
}