using System;
using System.Collections.Generic;

namespace CodeGolf.NumberSequences
{
    public class ReconstructArithmeticSequence
    {
        /// <summary>
        /// This approach contains no use of System.Collections.Generic
        /// </summary>
        /// <param name="incompleteSequence"></param>
        /// <returns></returns>
        public int[] Reconstruct(int[] incompleteSequence)
        {
            var d1 = incompleteSequence[1] - incompleteSequence[0];

            // difference between second and third numbers, instead of last and second to last numbers,
            // this works because only a consecutive set of elements have been removed from the incompleteSequence
            var d2 = incompleteSequence[2] - incompleteSequence[1];

            var diff = Math.Abs(d1) < Math.Abs(d2) ? d1 : d2;


            var stepCount = Math.Abs((incompleteSequence[incompleteSequence.Length - 1] - incompleteSequence[0]) / diff);

            var ts = new int[stepCount + 1];

            for (int i = 0, d = incompleteSequence[0]; i <= stepCount; i++, d += diff)
            {
                ts[i] = d;
            }

            return ts;
        }

        /// <summary>
        /// The combined approaches to minimise byte count
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public int[] ReconstructGolfed(int[] a)
        {
            int x = a[1] - a[0],       // difference between second and first numbers
                // difference between third and second numbers, instead of last and second to last numbers,
                // this works because only a consecutive set of elements have been removed from the incompleteSequence
                y = a[2] - a[1],      
                d = x*x < y*y ? x : y, // smallest absolute value difference
                s = Math.Abs((a[a.Length - 1] - a[0]) / d), // number of steps in the reconstructed sequence (not the number of elements)
                i = 0,                 // step position
                j = a[0];              // next number in reconstructed sequence

            var r = new int[s + 1];

            // reconstruct the sequence
            for (; i <= s; i++, j += d)
                r[i] = j;

            return r;
        }

        /// <summary>
        /// This approach contains no use of the System.Math library
        /// </summary>
        /// <param name="incompleteSequence"></param>
        /// <returns></returns>
        public List<int> ReconstructUsingList(int[] incompleteSequence)
        {
            var length = incompleteSequence.Length;

            var d1 = incompleteSequence[1] - incompleteSequence[0];
            var d2 = incompleteSequence[length - 1] - incompleteSequence[length - 2];

            // of the two difference, identify the one with the smallest absolute value
            // and select it
            var diff = d1*d1 < d2*d2 ? d1 : d2;

            var ts = new List<int>();

            for (int i = incompleteSequence[0]; i != incompleteSequence[length - 1] + diff; i += diff)
            {
                ts.Add(i);
            }

            return ts;
        }
    }
}