using System.ComponentModel;

namespace CodeGolf.Equations
{
    /// <summary>
    /// https://codegolf.stackexchange.com/questions/148181/is-my-barcode-valid/148270#148270
    /// </summary>
    public class Ean8CheckSum
    {
        public bool IsBarcodeValid(int[] barcode)
        {
            // multiply digits by alternating 3 and 1
            // add the results
            var sum = 0;

            for (int i = 0; i < 8; i++)
            {
                var multiplier = (1+i) % 2 * 2 + 1;
                sum += barcode[i] * multiplier;
            }

            return sum % 10 == 0;
        }

        public bool IsBarcodeValidGolfed(int[] b)
        {
            // multiply digits by alternating 3 and 1
            // add the results
            int s = 0, i = 0;

            while (i < 8)
                s += b[i] * ((1 + i++) % 2 * 2 + 1);

            return s % 10 < 1;
        }

        public bool IsBarcodeValidGolfed2(int[] b)
        {
            // uses the exclusive-or operator to alternate between 3 and 1
            int s = 0, i = 0, t = 1;

            while (i < 8)
                s += b[i++] * (t^=2);

            return s % 10 < 1;
        }

        public bool IsBarcodeValidDirectReturn(int[] b)
        {
            return (3 * (b[0] + b[2] + b[4] + b[6]) + b[1] + b[3] + b[5] + b[7]) % 10 < 1;
        }
    }
}