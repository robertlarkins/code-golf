using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeGolf.Equations
{
    public class VectorNormalisation
    {
        public double[] Normalise(double[] vector)
        {
            var v = vector.ToList();

            var s = Math.Sqrt(v.Select(x => x * x).Sum());

            return v.Select(d => d / s).ToArray();
        }

        public List<double> Normalise(List<double> vector)
        {
            return vector.Select(d => d / Math.Sqrt(vector.Select(x => x * x).Sum())).ToList();
        }

        public double[] NormaliseVectorArray(double[] vector)
        {
            var magnitude = 0d;

            foreach (var x in vector)
            {
                magnitude += x * x;
            }

            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] /= Math.Sqrt(magnitude);
            }

            return vector;
        }
    }
}