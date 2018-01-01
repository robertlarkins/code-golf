using System;

namespace CodeGolf.NumberProcessing
{
    /// <summary>
    /// https://codegolf.stackexchange.com/questions/150936/is-it-a-pleasing-number
    /// </summary>
    public class PleasingNumber
    {
        public bool IsPleasing(char[] input)
        {
            // count the number of trailing identical numbers (B)
            var count = 0;
            var c = input.Length - 1; // the current last position
            var last = input[c];

            for (int i = c; i >= 0 && input[i] == last; i--)
            {
                count++;
                Array.Resize(ref input, c--);
            }

            // sort the digits
            Array.Sort(input);
            var maxA = input[c] - 48;

            // take the maximum digit (A)

            // if N^B = A is true for any integer, then return 1, else return 0
            var n = Math.Pow(maxA, 1d / count);



            //return n - (int) n < 1e-12 ? 1 : 0;
            return n % 1 == 0;
        }

        public bool IsPleasing2(char[] input)
        {
            // count the number of trailing identical numbers (B)
            var B = 0;
            var c = input.Length - 1; // the current last position
            var same = true;
            var A = 0;

            for (int i = c; i >= 0; i--)
            {
                // count number of trailing digits that are the same
                if (input[i] == input[c] && same)
                {
                    B++;
                }
                else // get the largest digit of digits remaining in array
                {
                    A = A > input[i] ? A : input[i];
                    same = false;
                }
            }

            // take the maximum digit (A)

            // if N^B = A is true for any integer, then return 1, else return 0
            var n = Math.Pow(A-48, 1d / B);



            //return n - (int) n < 1e-12 ? 1 : 0;
            return n % 1 == 0;
        }

        public bool IsPleasing3(char[] n)
        {
            // count the number of trailing identical numbers (B)
            int A = 0, // maximum digit
                B = 1, // count of trailing identical numbers 
                s = 1, // looking at trailing numbers
                i = n.Length - 2;

            for (; i >= 0; i--)
            {
                // count number of trailing digits that are the same
                if (n[i] == n[i + 1] && s>0)
                {
                    B++;
                }
                else
                {
                    A = n[i] > A ? n[i] : A;
                    s = 0;
                }
            }

            // take the maximum digit (A)
            // if N^B = A is true for any integer, then return 1, else return 0

            //return n - (int) n < 1e-12 ? 1 : 0;
            return Math.Pow(A - 48, 1d / B) % 1 == 0;
        }

        public bool IsPleasingGolfed(char[] n)
        {
            int A=0,B=1,s=1,i=n.Length-2;
            for (;i>=0;i--)
                if(n[i]==n[i+1]&&s>0)B++;
                else{A=n[i]>A?n[i]:A;s=0;}
            return Math.Pow(A - 48, 1d / B)%1==0;
        }
    }
}