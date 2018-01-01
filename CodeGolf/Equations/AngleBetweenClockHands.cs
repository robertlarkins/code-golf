using System;

namespace CodeGolf.Equations
{
    /// <summary>
    /// https://codegolf.stackexchange.com/questions/26/angle-between-the-hands-on-a-clock
    /// </summary>
    public class AngleBetweenClockHands
    {
        public double CalculateAngleInDegrees(string time)
        {
            var timeInt = int.Parse(time);
            var hour = timeInt / 100 % 12;
            var min = timeInt % 100;

            var hourAngle = 30 * hour + min / 2d;
            var minAngle = 6 * min;
            var result = Math.Abs(hourAngle - minAngle);

            if (result > 180)
            {
                result = 360 - result;
            }

            return result;
        }

        public double CalculateAngleInDegreesGolfed(string time)
        {
            var timeInt = int.Parse(time);
            // hour can be found using any of these forms:
            // var hour = timeInt / 100 % 12 * 30;
            // var hour = timeInt / 100 * 30 % 360;
            // var hour = timeInt % 1200 / 100 * 30;

            var hour = timeInt / 100 % 12 * 30;
            var min = timeInt % 100 * 5.5;

            var result = Math.Abs(hour - min);

            return result > 180 ? 360 - result : result;
        }

        public double CalculateAngleInDegreesGolfed2(string time)
        {
            var t = int.Parse(time);
            double d = t / 100 % 12 * 30 - t % 100 * 5.5,
                   r = d < 0 ? -d : d;
            return r > 180 ? 360 - r : r;
        }
    }
}