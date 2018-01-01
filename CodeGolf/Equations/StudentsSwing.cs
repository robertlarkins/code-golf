using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;

namespace CodeGolf.Equations
{
    /// <summary>
    /// https://codegolf.meta.stackexchange.com/a/14256/73579
    /// </summary>
    public class StudentsSwing
    {
        public double DrillHoleSeparation(double d, double h, double v, double s)
        {
            var h2 = h - v;
            var s2 = s - v;
            var a = h2 / ((d / 2)* (d / 2));

            return 2 * Math.Sqrt(s2 / a);
        }

        public double DrillHoleSeparationSimplified(double d, double h, double v, double s)
        {
            var h2 = h - v;
            var s2 = s - v;

            return d * Math.Sqrt(s2 / h2);
        }

        /// <summary>
        /// The formula for drawing the parabola that fits d, h and v
        /// </summary>
        /// <param name="d"></param>
        /// <param name="h"></param>
        /// <param name="v"></param>
        public void Parabola(double d, double h, double v)
        {
            var x = 1;
            var y = 4 * (h - v) * x * x / (d * d) + v;
        }

        public void Test()
        {
            var v = new[] {1, 2, 3, 4, 5, 6};

            var ts = new List<int>();
            for (int i = v[0]; i <= v.Last(); i += v.Zip(v.Skip(1), (y, z) => z - y).Min())
            {
                ts.Add(i);
            }

        }
    }
}