using System.Linq;

namespace CodeGolf.Equations
{
    /// <summary>
    /// https://codegolf.stackexchange.com/questions/146176/implement-the-ios-11-calculator
    /// </summary>
    public class Ios11Calculator
    {
        /// <summary>
        /// https://codegolf.stackexchange.com/a/146320/73579
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public int Summation(int[] values)
        {
            return values.OrderBy(x => x).SequenceEqual(new[] { 1, 2, 3 }) ? 24 : values.Sum();
        }
    }
}