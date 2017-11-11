namespace CodeGolf.AsciiArt.KolmogorovComplexity
{
    /// <summary>
    /// https://codegolf.stackexchange.com/questions/146499/confirm-the-illuminati
    /// https://codegolf.stackexchange.com/questions/146499/confirm-the-illuminati/146542#146542
    /// </summary>
    public class IlluminatiPyramid
    {
        public string BuildPyramid()
        {
            return
                "         ^\n" +
                "        /_\\\n" +
                "       /_|_\\\n" +
                "      /_|_|_\\\n" +
                "     /_|/o\\|_\\\n" +
                "    /_|_\\_/_|_\\\n" +
                "   /_|_|_|_|_|_\\\n" +
                "  /_|_|_|_|_|_|_\\\n" +
                " /_|_|_|_|_|_|_|_\\\n" +
                "/_|_|_|_|_|_|_|_|_\\\n";
        }

        public string BuildPyramid2()
        {
            string n = "\\\n",
                w = "|_",
                w2 = w+w,
                wn = w + n,
                xn = w2 + w2 + wn,
                f = "/_";

            return $"         ^\n        {f}{n}       {f}{wn}      {f}{w2}{n}     {f}|/o\\{wn}    {f}{w}\\_{f}{wn}   {f}{xn}  {f}{w}{xn} {f}{w2}{xn}{f}{w2}{w}{xn}";
        }

        public string BuildPyramid3()
        {
            return string.Format("{3,10}\n{1,10}\\\n{1,9}{4}{5,10}{4}{1,7}|/o\\{4}{5,8}\\_{1}{4}{1,5}{2}{4}  {5}{2}{4} {5}{0}{2}{4}{5}{0}{0}{2}{4}", "|_", "/_", "|_|_|_|_", "^", "|_\\\n", "/_|_");
        }
    }
}