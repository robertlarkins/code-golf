using System.Collections.Generic;

namespace CodeGolf.NumberSequences
{
    public class UniqueDenominationCombinations
    {
        public void Run()
        {
            var list = new[] { 1, 2, 5, 10, 20, 50, 100, 200, 500 };

            // 1 is 0
            // 2 is 1
            // 3 = 2
            // 4 = 3
            // 5 = 5
            // 6 = 6

            var resultList = new List<int> { 0 };
            var nonList = new List<int>();

            var n = 512;
            var result = 0;

            // Don't deal with n == 1, as this is just be 0
            if (n > 1)
            {
                // do the following n times
                for (int i = 1; i < n; i++)
                {
                    // get the next number and see if it can be composed of items from the list
                    // occuring once only
                    var next = result + 1;

                    // get going until one of these numbers is found
                    while (true)
                    {
                        var temp = next;

                        // go through checking if subtracting items from it can equal 0
                        for (int j = list.Length - 1; j >= 0; j--)
                        {
                            if (temp - list[j] < 0)
                            {
                                continue;
                            }

                            temp -= list[j];

                            if (temp == 0)
                            {
                                break;
                            }
                        }

                        // if they do, update result and move to the next number
                        if (temp == 0)
                        {
                            resultList.Add(next);
                            result = next;
                            break;
                        }

                        nonList.Add(next);

                        next++;
                    }

                    if (result == 888)
                    {
                        break;
                    }
                }
            }

            System.Console.WriteLine($"{n} -> {result}");

            var r2 = FortyNine(n);

            System.Console.WriteLine($"{n} -> {r2}");

            System.Console.ReadLine();
        }

        public static int FortyNine(int n)
        {
            var result = 0;

            for (int i = 0; i < n; i++)
            {
                var next = result + 1;

                while (true)
                {
                    if (next.ToString().Contains("4") || next.ToString().Contains("9"))
                    {
                        next++;
                        continue;
                    }

                    break;
                }

                result = next;

                if (result == 888)
                {
                    break;
                }
            }

            return result;
        }
    }
}