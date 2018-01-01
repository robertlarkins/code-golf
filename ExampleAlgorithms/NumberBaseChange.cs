using System;

namespace ExampleAlgorithms
{
    /// <summary>
    /// http://mathforum.org/library/drmath/view/64867.html
    /// https://stackoverflow.com/questions/923771/quickest-way-to-convert-a-base-10-number-to-any-base-in-net
    /// https://www.tools4noobs.com/online_tools/base_convert/
    /// http://www.purplemath.com/modules/numbbase2.htm
    /// 
    /// </summary>
    public class NumberBaseChange
    {
        /// <summary>
        /// Convert a number in string representation into a different base
        /// </summary>
        /// <param name="number"></param>
        /// <param name="numberBase"></param>
        /// <returns></returns>
        public string BaseChange(string number, int numberBase)
        {
            return "";
        }

        /// <summary>
        /// Convert an int (in base 10) to a string representation in a different base
        /// </summary>
        /// <param name="number"></param>
        /// <param name="numberBase"></param>
        /// <returns></returns>
        public string BaseChange(int number, int numberBase)
        {
            var symbols = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

            var newNumber = "";

            do
            {
                newNumber = symbols[number % numberBase] + newNumber;
                number /= numberBase;

            } while (number > 0);

            return newNumber;
        }

        /// <summary>
        /// Convert an int (in base 10) to a string representation in a different base
        /// </summary>
        /// <param name="number"></param>
        /// <param name="numberBase"></param>
        /// <returns></returns>
        public string BaseChangeRecursive(int number, int numberBase)
        {
            var symbols = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };

            return RecurseNumber(number);

            string RecurseNumber(int no) => no > 0 ? RecurseNumber(no / numberBase) + symbols[no % numberBase] : "";
        }

        public int IntBaseChange(int number, int toBase)
        {
            var convertedNumber = BaseChangeRecursive(number, toBase);

            return int.Parse(convertedNumber);
        }

        public string Base4Change(int number)
        {
            return number > 0 ? Base4Change(number / 4) + number % 4 : "";
        }

        /// <summary>
        /// Convert an int to the given base, the base has to be 2, 8, 10, or 16
        /// </summary>
        /// <param name="number"></param>
        /// <param name="toBase"></param>
        /// <returns></returns>
        public string BuiltInBaseChange(int number, int toBase)
        {
            return Convert.ToString(number, toBase);
        }

        /// <summary>
        /// Convert an long to the given base, the base has to be 2, 8, 10, or 16
        /// </summary>
        /// <param name="number"></param>
        /// <param name="toBase"></param>
        /// <returns></returns>
        public string BuiltInBaseChange(long number, int toBase)
        {
            return Convert.ToString(number, toBase);
        }
    }
}
