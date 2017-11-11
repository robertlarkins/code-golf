namespace CodeGolf.AsciiArt
{
    /// <summary>
    /// https://codegolf.stackexchange.com/questions/145858/draw-the-lambda-blazon
    /// </summary>
    public class LambdaBlazon
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="n">Positive</param>
        /// <returns></returns>
        public string Draw(int n)
        {

            var width = n * 2 + 4;
            var shield = "";

            for (int y = 0; y < n; y++)
            {
                var row = new char[width];

                row[width / 2 - y - 1] = '/';
                row[width / 2 + y] = '\\';
                row[0] = y == 0 || y == n-1? '(' : '|';
                row[width-1] = y == 0 || y == n - 1 ? ')' : '|';

                shield += new string(row);

                if (y < n - 1)
                    shield += "\n";
            }

            return shield.Replace("\0"," ");
        }

        public string Draw2(int n)
        {
            int y=0,i=-1;
            var s = "";

            while (y < n)
            {
                var r=new char[n*2+4];
                r[n+1-y]='/';
                r[n+2+y]='\\';
                if(y<2|y++>n-2)i++;
                r[0]="(|("[i];
                r[n*2+3]=")|)"[i];
                s+=new string(r)+"\n";
            }

            return s.Replace("\0", " ");
        }
    }
}

