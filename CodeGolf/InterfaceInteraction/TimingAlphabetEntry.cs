using System;
using System.Diagnostics;

namespace CodeGolf.InterfaceInteraction
{
    public class TimingAlphabetEntry
    {
        public void EnterAlphabet()
        {
            var k = Console.ReadKey().KeyChar;
            var s = Stopwatch.StartNew();
            var f = 0;
            if (k == 97)
            {
                for (int i = 98; i < 123; i++)
                {
                    if (Console.ReadKey().KeyChar != i)
                    {
                        f = 1;
                    }
                }
                s.Stop();
            }
            else
            {
                f = 1;
            }

            Console.Write("\n"+(f>0?"Fail":$"{s.Elapsed.TotalMilliseconds}"));
            Console.ReadLine();
        }

        public void EnterAlphabet2()
        {
            var s = DateTime.Now;
            var i = 97;

            while(i<123)
            {
                if (Console.ReadKey().KeyChar != i)
                    break;

                if (i++ == 97)
                    s = DateTime.Now;
            }

            Console.Write(i==123?$"\n{(DateTime.Now-s).TotalMilliseconds}":"\nFail");
            Console.ReadLine();
        }

        public Action A = () =>
        {
            var s = DateTime.Now;
            var i = 97;
            while (i < 123)
            {
                if (Console.ReadKey().KeyChar != i) break;
                if (i++ < 98) s = DateTime.Now;
            }
            Console.Write(i == 123 ? $"\n{(DateTime.Now - s).TotalMilliseconds}" : "\nFail");
            Console.ReadLine();
        };


    }
}