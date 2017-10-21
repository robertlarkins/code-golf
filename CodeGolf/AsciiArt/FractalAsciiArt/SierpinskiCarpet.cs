using System;

namespace CodeGolf.AsciiArt.FractalAsciiArt
{
    /// <summary>
    /// https://codegolf.stackexchange.com/questions/40104/sierpinski-carpets/143780
    /// </summary>
    public class SierpinskiCarpet
    {
        public void Run()
        {
            var n = 2;

            //var output = CreateCarpet(n);
            var output = CreateCarpetGolfed2(n);

            Console.Write(output);
            Console.Read();
        }

        public string CreateCarpetGolfed(int n)
        {
            var f = "";
            var s = Math.Pow(3, n);

            for (int y = 0; y < s; y++, f += "\n")
            for (int x = 0; x < s; x++)
            {
                int a=x,b=y,h=1;
                for (;a>0|b>0;b/=3,a/=3)
                    if (b%3==1&a%3==1)
                        h = 0;
                f += " #"[h] + " ";
            }

            return f;
        }

        /// this is written using a 1d array, where
        /// i%width gets column i/width gets row
        public string CreateCarpetGolfed2(int n)
        {
            var f="";
            int s=(int)Math.Pow(3,n),z=0;

            while(z<s*s)
            {
                int x=z%s,y=z/s,h=1;
                for(;x>0|y>0;y/=3,x/=3)
                    if(y%3==1&x%3==1)
                        h = 0;
                f+=" #"[h]+(z++%s<s-1?" ":"\n");
            }

            return f;
        }

        public string CreateCarpet(int n)
        {
            var output = "";
            var sideLength = (int) Math.Pow(3, n); // * 2 - 1;

            for (int y = 0; y < sideLength; y++)
            {
                for (int x = 0; x < sideLength; x++)
                {
                    output += GetPixelValue(sideLength, y, x) + " ";
                }
                output += "\n";
            }

            return output;
        }

        public char GetPixelValue(int sideLength, int y, int x)
        {
            for (var m = 1; m < sideLength; m *= 3)
            {
                if (y/m % 3 == 1 && x/m % 3 == 1)
                {
                    return ' ';
                }
            }

            return '#';
        }

        public char GetPixelValue(int y, int x)
        {
            while (x > 0 || y > 0)
            {
                if (y % 3 == 1 && x % 3 == 1)
                {
                    return ' ';
                }

                y /= 3;
                x /= 3;
            }

            return '#';
        }
    }
}