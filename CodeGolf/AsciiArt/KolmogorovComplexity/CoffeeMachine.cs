using System;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace CodeGolf.AsciiArt.KolmogorovComplexity
{
    public class CoffeeMachine
    {
        public string Draw()
        {
            return
@"________._________
|      | \   -   /
|  ||  |  \  -  /
|  ||  |___\___/
|  ||  |     X
|      |    ___
|      |   / - \
|______|  /  -  \
| ____ | /_______\
||7:30||__________
||____|           |
|_________________|";
        }

        public string Draw2()
        {
            return
@"uu__.uuu
|ss| \s-s/
|  ||  |  \  -  /
|  ||  |u\u/
|  ||  |s  X
|ss| su
|ss|s/ - \
|uu|  /  -  \
| u_ | /u_u\
||7:30||uuu_
||u_|  sss|
|uuuuu__|".Replace("u", "___").Replace("s", "   ");
        }

        public string CompressString()
        {
            var coffeeMachine = Draw();

            var compressedStream = new MemoryStream();
            var uncompressedStream = new MemoryStream(Encoding.UTF8.GetBytes(coffeeMachine));

            using (var compressorStream = new DeflateStream(compressedStream, CompressionMode.Compress, true))
            {
                uncompressedStream.CopyTo(compressorStream);
            }

            var compressedString = Convert.ToBase64String(compressedStream.ToArray());

            return compressedString;
        }

        public string DecompressString()
        {
            var compressedString = CompressString();

            var decompressedStream = new MemoryStream();
            var compressedStream = new MemoryStream(Convert.FromBase64String(compressedString));

            using (var decompressorStream = new DeflateStream(compressedStream, CompressionMode.Decompress))
            {
                decompressorStream.CopyTo(decompressedStream);
            }

            var decompressedString = Encoding.UTF8.GetString(decompressedStream.ToArray());

            return decompressedString;
        }

        public string RunLengthEncoding()
        {
            var coffeeMachine = Draw();
            var compressed = "";

            for (int i = 0, c = 1; i < coffeeMachine.Length - 1; i++)
            {
                if (coffeeMachine[i] == coffeeMachine[i + 1])
                {      //When same increment counter
                    c++;
                }
                else
                {

                    compressed += coffeeMachine[i];
                    compressed += c;
                    c = 1;
                }
            }

            return compressed;
        }
    }
}