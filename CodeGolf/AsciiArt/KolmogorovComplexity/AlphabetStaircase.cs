using System.Collections.Generic;
using System.Linq;

namespace CodeGolf.AsciiArt.KolmogorovComplexity
{
    /// <summary>
    /// https://codegolf.stackexchange.com/questions/147469/alphabet-staircase
    /// </summary>
    public class AlphabetStaircase
    {
        public string DrawStaircase()
        {
            return A(1);
            string A(int n) => new string((char)(n+96), n) + (n<26? "\n" + A(++n) : "\n");
        }

        public string DrawStaircase2()
        {
            return string.Join("\n",
                Enumerable.Range(97, 26).Select(x => string.Concat(Enumerable.Repeat((char) x, x - 96)))) + "\n";
        }

        public string DrawStaircase3()
        {
            var s = "";
            for (int i = 1; i < 27;)
                s += new string((char)(i+96),i++)+"\n";

            return s;
        }

        public string DrawStaircase4()
        {
            // for each element in the int[27] Select((value, index) => ...
            // the keyword _ is a discard, using an _ here isn't a discard, but just a local variable
            // but because value isn't needed it doesn't get used
            // https://blogs.msdn.microsoft.com/mazhou/2017/06/27/c-7-series-part-4-discards/
            var stairs = new int[27].Select((_, i) => new string((char) (i + 96), i));

            // the Where clause is added to remove the first element of the int[],
            // which is an empty string. By doing this, a leading newline is not added
            return string.Join("\n", stairs.Where(s => !string.IsNullOrEmpty(s))) + "\n";
        }
    }
}