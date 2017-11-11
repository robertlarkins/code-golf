using System.Collections.Generic;
using System.Linq;

namespace CodeGolf.ArraySearching
{
    /// <summary>
    /// https://codegolf.stackexchange.com/questions/146972/find-the-unique-twins
    /// </summary>
    public class UniqueTwins
    {
        public int FindUniqueTwin(int[] arrayA, int[] arrayB)
        {
            var onceA = arrayA.GroupBy(x => x).Where(x => x.Count() == 1).Select(x => x.Key);
            var onceB = arrayB.GroupBy(x => x).Where(x => x.Count() == 1).Select(x=>x.Key);
            return onceA.Intersect(onceB).Max();
        }

        public int FindUniqueTwin2(int[] arrayA, int[] arrayB)
        {
            var onceA = arrayA.Where(x => arrayA.Count(b=>b==x)<2);
            var onceB = arrayB.Where(x => arrayB.Count(b => b == x) < 2);
            return onceA.Intersect(onceB).Max();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// instead of searching for unique values in both arrays,
        /// I inverted the order of operations so that intersect is first,
        /// and then find the max value of the items that occur twice when the arrays are concatenated
        /// and are in their intersect.
        /// I can use &lt;3 as Count will be at least 2 for any value, as it will be in both arrays.
        /// </remarks>
        /// <param name="arrayA"></param>
        /// <param name="arrayB"></param>
        /// <returns></returns>
        public int FindUniqueTwin3(int[] arrayA, int[] arrayB)
        {
            return arrayA.Intersect(arrayB).Where(x => arrayA.Concat(arrayB).Count(y => y == x) < 3).Max();
        }
    }
}