using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using CodeGolf.AsciiArt.FractalAsciiArt;

namespace CodeGolf
{
    class Program
    {
        static void Main(string[] args)
        {
            var sierpinskiCarpet = new SierpinskiCarpet();
            sierpinskiCarpet.Run();
        }
    }
}
