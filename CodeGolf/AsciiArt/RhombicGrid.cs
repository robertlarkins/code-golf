using System;

namespace CodeGolf.AsciiArt
{
    public class RhombicGrid
    {
        /// <summary>
        /// https://codegolf.stackexchange.com/questions/146747/ascii-rhombic-grid
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="columns"></param>
        /// <param name="size"></param>
        /// <param name="nesting"></param>
        /// <returns></returns>
        public string DrawGrid(int rows, int columns, int size, int nesting)
        {
            var gridWidth = 2 * (size + nesting) * columns + 1;
            var gridHeight = 2 * (size + nesting) * rows;

            var s = gridWidth * gridHeight;

            var grid = new char[s];

            for (int r = 0; r < rows * 2; r++)
            {
                for (int c = 0; c < columns * 2; c++)
                {
                    var start = r * (size + nesting) * gridWidth + c * (size + nesting);

                    // gives the alternating rows and columns, adding the values together
                    // determines whether forward or back slashes should be drawn
                    if ((c % 2 + r % 2) % 2 == 0)
                    {
                        DrawRhombusPart(size, nesting, grid, start, gridWidth, gridHeight);
                    }
                    else
                    {
                        DrawRhombusPart2(size, nesting, grid, start, gridWidth, gridHeight);
                    }

                }
            }

            for (int i = 0; i < gridHeight; i++)
            {
                grid[i * gridWidth + gridWidth - 1] = '\n';
            }

            return new string(grid);
        }

        public void DrawRhombusPart(int size, int nesting, char[] grid, int start, int gw, int gh)
        {
            var s = size + nesting;

            // loop through the rhombus
            for (int y = 0; y < s; y++)
            {
                for (int x = 0; x < s; x++)
                {
                    grid[start + x + y * gw] = x < size - y - 1 || x > 2 * nesting + size - y - 1 ? ' ' : '/';
                }
            }
        }

        public void DrawRhombusPart2(int size, int nesting, char[] grid, int start, int gw, int gh)
        {
            var s = size + nesting;

            // loop through the rhombus
            for (int y = 0; y < s; y++)
            {
                for (int x = 0; x < s; x++)
                {
                    grid[start + x + y * gw] = x > nesting + y || x < y - nesting ? ' ' : '\\';
                }
            }
        }

        public string DrawGrid2(int rows, int columns, int size, int nesting)
        {
            var w = size + nesting;
            var gridHeight = 2 * w * rows;

            var grid = "";

            for (int r = 0; r < gridHeight; r++)
            {
                grid += DrawRow(size, nesting, w, columns, r) + "\n";
            }

            return grid;
        }

        public string DrawRow(int size, int nesting, int w, int columns, int r)
        {
            var row = "";

            int y = r % w;

            for (int c = 0; c < columns * 2; c++)
            {
                for (int x = 0; x < w; x++)
                {
                    if ((c % 2 + r / w % 2) % 2 == 0)
                    {
                        row += x < size - y - 1 || x > 2 * nesting + size - y - 1 ? ' ' : '/';
                    }
                    else
                    {
                        row += x > y + nesting || x < y - nesting ? ' ' : '\\';
                    }
                }
            }

            return row;
        }

        public string DrawGrid3(int rows, int columns, int size, int nesting)
        {
            var w = size + nesting;

            var grid = "";

            for (int r = 0; r < rows * 2 * w; r++)
            {
                int y = r % w;

                for (var c = 0; c < columns * 2 * w; c++)
                {
                    var x = c % w;

                    if ((c / w + r / w) % 2 == 1)
                    {
                        grid += x > y + nesting || x < y - nesting ? ' ' : '\\';
                    }
                    else
                    {
                        grid += x < size - y - 1 || x > 2 * nesting + size - y - 1 ? ' ' : '/';
                    }

                }

                grid += "\n";
            }

            return grid;
        }

        public string DrawGrid4(int rows, int columns, int size, int nesting)
        {
            var w = size + nesting;

            var grid = "";

            for (int r = 0; r < rows * 2 * w; r++)
            {
                for (int c = 0; c < columns * 2 * w; c++)
                {
                    int y = r % w; // the y location in the quadrant (0 to w-1)
                    var q = (c / w + r / w + 1) % 2; // the rhombas quadrant

                    // depending of the rhombus quadrant, this will have increasing values
                    // 0,1,2,3,4,...,w-1
                    // or decreasing values w-1,w-1-1, w-1-2,...0,
                    // allowing the same ternary operator to be used for all sides of a rhombus,
                    // as it mirrors one side
                    var x2 = ~-w * q + c % w * (1 - 2 * q);

                    grid += x2 > y + nesting || x2 < y - nesting ? ' ' : "\\/"[q];
                }

                grid += "\n";
            }

            return grid;
        }

        public string GolfedGrid(int r, int c, int s, int n)
        {
            int w = s + n, i = 0, j;

            var g = "";

            for (; i < r * 2 * w; i++, g += "\n")
                for (j=0; j < c * 2 * w;)
                {
                    int y = i % w, q = (j / w + i / w + 1) % 2, p = ~-w * q + j++ % w * (1 - 2 * q);

                    g += p > y + n | p < y - n ? ' ' : "\\/"[q];
                }


            return g;
        }
    }
}