using System;

namespace CodeGolf.ArraySearching
{
    public class SnakesInAMatrix
    {
        /// <summary>
        /// https://codegolf.stackexchange.com/questions/143689/finding-snakes-in-a-matrix/143709#143709
        /// </summary>
        private static Func<int[,], int, int, int[], int, bool> Snake =
            (m, h, w, s, l) =>
            {
                // Go through every potential starting point
                for (int y = 0; y < h; y++)
                for (int x = 0; x < w; x++)
                    if (N(x, y, l - 1)) // start the recursive steps
                        return 0 < 1; // return true if N returns true, otherwise check the next element

                return 1 < 0; // return false as the snake doesn't fit into the matrix

                // C#7 local function in a Func
                bool N(int x, int y, int p)
                {
                    // if there is no more snake to fit return true
                    if (p < 0)
                        return 0 < 1;

                    // if m element has part of the snake or 
                    // snake part doesn't match matrix element then return false
                    if (y < 0 | x < 0 | y == h | x == w || m[y, x] > 1 || s[p] != m[y, x])
                        return 1 < 0;

                    // hold the current matrix element
                    int g = m[y, x];
                    // set the current matrix element to 2 to indicate it has a part of the snake
                    m[y, x] = 2;

                    // check each of the four neighbours and recurse down that neighbour 
                    // except if they are outside the matrix
                    if (N(x, y - 1, --p) ||
                        N(x - 1, y, p) ||
                        N(x, y + 1, p) ||
                        N(x + 1, y, p))
                        return 0 < 1; // return true if remainder of the snake fits into the matrix

                    // if snake doesn't fit then set the matrix element as not having part of the snake
                    m[y, x] = g;
                    // return false to indicate this neighbour direction doesn't fit the snake
                    return 1 < 0;
                }
            };

        public void GetSnakesInAMatrix()
        {
            int[,] m1 = {
                { 0, 1, 0, 1, 0, 1 },
                { 1, 1, 1, 0, 1, 1 },
                { 0, 1, 1, 0, 1, 0 },
                { 0, 1, 1, 0, 1, 1 }
            };

            int[,] single = { { 0 } };

            int[] s1 =
            {
                0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 0, 1
            };

            int[] s2 =
            {
                0,0,0,0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 1, 0, 1
            };

            int[] s3 = { 0 };
            int[] s4 = { 1 };

            Console.WriteLine(Snake(m1, m1.GetLength(0), m1.GetLength(1), s1, s1.Length));
            Console.WriteLine(Snake(m1, m1.GetLength(0), m1.GetLength(1), s2, s2.Length));
            Console.WriteLine(Snake(single, 1, 1, s3, 1));
            Console.WriteLine(Snake(single, 1, 1, s4, 1));
        }
    }
}