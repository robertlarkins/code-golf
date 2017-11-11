using static System.Math;

namespace CodeGolf.Equations
{
    /// <summary>
    /// https://codegolf.stackexchange.com/questions/146412/approximate-my-squares
    /// https://codegolf.stackexchange.com/questions/146412/approximate-my-squares/146531#146531
    /// </summary>
    public class ApproximateSquareRoot
    {
        public double GetRoot(double value)
        {
            return (value / (value = (int)Sqrt(value)) + value ) / 2;
        }

        public double GetRoot2(double value)
        {
            var r = Floor(Sqrt(value));
            return r + (value - r * r) / (2 * r);
        }

        public double GetRoot3(double value)
        {
            double r = (int)Sqrt(value);
            return (r + value / r) / 2;
        }
    }
}