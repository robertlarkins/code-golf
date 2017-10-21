namespace CodeGolf
{
    /// <summary>
    /// https://codegolf.stackexchange.com/questions/143919/build-a-checkerboard
    /// </summary>
    /// <returns></returns>
    public class BuildCheckerBoard
    {
        public static void Run()
        {
            var r = BuildCheckerBoard1();
            System.Console.WriteLine(r);
            //BuildCheckerBoard2();
            //BuildCheckerBoard5();
            //BuildCheckerBoard6();
            System.Console.ReadLine();
        }

        public static string BuildCheckerBoard1()
        {
            var r = "";

            for (int i = 0; i < 8; i++)
            {
                var w = i > 4 ? "b" : "r";

                if (i < 3 || i > 4)
                {
                    for (int j = i % 2; j < 8; j += 2)
                    {
                        r += i + "," + j + w + "\n";
                    }
                }
            }

            return r;
        }

        public static void BuildCheckerBoard2()
        {
            for (int i = 0; i < 8; i++)
                if (i < 3 | i > 4)
                    for (int j = i % 2; j < 8; j += 2)
                        System.Console.WriteLine(i + "," + j + (i > 4 ? "b" : "r"));
        }

        public static void BuildCheckerBoard3()
        {
            for (int i = 0; i < 8; i += i != 2 ? 1 : 3)
            for (int j = i % 2; j < 8; j += 2)
                System.Console.WriteLine(i + "," + j + (i > 4 ? "b" : "r"));
        }

        public static void BuildCheckerBoard4()
        {
            for (int i = 0; i < 24;)
                System.Console.Write($"{i / 4 + i / 12 * 2},{i * 2 % 8 + i / 4 % 2}{(i++ > 11 ? "b" : "r")}\n");
        }

        public static string BuildCheckerBoard5()
        {
            var r = "";
            for (int i = 0; i < 24; i++)
                r += $"{i / 4 + i / 12 * 2},{i * 2 % 8 + i / 4 % 2}{(i > 11 ? "b" : "r")}\n";
            return r;
        }

        public static string BuildCheckerBoard6()
        {
            var r = "";
            for (int i = 0; i < 24; i++)
                r += i / 4 + i / 12 * 2 + "," + (i * 2 % 8 + i / 4 % 2) + (i > 11 ? "b\n" : "r\n");
            return r;
        }
    }
}