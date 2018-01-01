using System.Runtime.InteropServices;

namespace CodeGolf.AsciiArt
{
    /// <summary>
    /// https://codegolf.stackexchange.com/questions/149672/mark-my-mail-ascii-barcodes
    /// </summary>
    public class FourStateBarcode
    {
        public string ConstructBarcode(int number)
        {
            var base4No = B(number);

            var stringToEncode = $"10{base4No}10";

            var array = "";

            for (int y = 0; y < 3; y++)
            {
                for (int x = 0; x < stringToEncode.Length; x++)
                {
                    array += SelectBarOrSpace(y, stringToEncode[x]);
                }
                array += "\n";
            }

            return array;

            string B(int n) => n > 0 ? B(n / 4) + n % 4 : "";
        }

        private string SelectBarOrSpace(int y, char digit)
        {
            if (y == 0 && (digit == '0' || digit == '2') ||
                y == 2 && (digit == '0' || digit == '1'))
            {
                return "  ";
            }

            return "| ";

            // Alternatively, the if be done like this:
            //if (digit != '3' && (y == 0 && digit != '1' || y == 2 && digit != '2'))
            //{
            //    return "  ";
            //}

            // chars use integer arthimetic, so we can swap
            // '0' for 48
            // '1' for 49
            // '2' for 50
            // '3' for 51
            // To get
            //if (digit != 51 && (y == 0 && digit != 49 || y == 2 && digit != 50))
            //{
            //    return "  ";
            //}
            // alternatively
            // if (digit < 51 && y != 1 && digit-(y>>1) != 49) return "  ";
        }

        public string BarOrSpaceGolfed(int y, char digit)
        {
            if (digit < 51 && y != 1 && digit-(y>>1) != 49)
                return "  ";

            return "| ";
        }

        public string ConstructBarcodeGolfed(int i)
        {
            string s = $"10{B(i)}10", // prepend and append 10 to the base 4 number
                   a = "";

            for (int y = 0; y < 3; y++, a += "\n")
                foreach (var t in s)
                    //  checks that the char isn't '3', not the second row,
                    // and then some binary magic to see if the first or third row should contain the space.
                    a += t < 51 & y != 1 & t - (y >> 1) != 49 ? "  " : "| ";

            return a;

            string B(int n) => n > 0 ? B(n / 4) + n % 4 : "";
        }
    }
}