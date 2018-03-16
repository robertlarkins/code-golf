using System.Linq;

namespace CodeGolf.NumberSequences
{
    /// <summary>
    /// https://codegolf.stackexchange.com/questions/152114/output-the-hours-at-90-degrees
    /// </summary>
    public class TimeAt90Degrees
    {
        public int[] TimeShiftWithLoop(int hour)
        {
            var a = new int[3];

            for (int i = 0; i < 3; i++)
            {
                var val = (hour + i * 3 + 3) % 12;
                a[i] = val == 0 ? 12 : val;
            }

            return a;
        }

        public int[] TimeShift(int hour) => new[]
        {
            (2 + hour) % 12 + 1,
            (5 + hour) % 12 + 1,
            (8 + hour) % 12 + 1
        };

        public int[] TimeShift2(int hour) => new[] { 2, 5, 8 }.Select(x => (x + hour) % 12 + 1).ToArray();
    }
}