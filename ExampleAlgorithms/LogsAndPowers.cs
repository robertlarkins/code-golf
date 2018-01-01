using System;

namespace ExampleAlgorithms
{
    /// <summary>
    /// Exponent, logarithm, and base value
    /// 
    /// a = b^c
    /// b = a^(1/c)
    /// c = log_b(a)
    /// </summary>
    public class LogsAndPowers
    {
        /// <summary>
        /// The baseVal raised to the power of the exponent
        /// </summary>
        /// <param name="baseVal">the base value that is raised to some power</param>
        /// <param name="exponent">the power that the the baseValue is raised to</param>
        /// <returns>the result of raising the base raised to the power</returns>
        public double Power(double baseVal, double exponent)
        {
            return Math.Pow(baseVal, exponent);
        }

        /// <summary>
        /// The logarithm value that relates the baseVal to the product
        /// </summary>
        /// <param name="product">The product of the baseVal raised to some exponent</param>
        /// <param name="baseVal">The product that is raised to some exponent</param>
        /// <returns>The exponent that relates the base to the product</returns>
        public double Logarithm(double product, double baseVal)
        {
            return Math.Log(product, baseVal);
        }

        /// <summary>
        /// Get the nth root of product. This gets the baseVal that relates a product and an exponent
        /// </summary>
        /// <param name="product">The result of a baseVal raised to some exponent</param>
        /// <param name="nthRoot">The nth root. This is the exponent but used as the root rather than the power</param>
        /// <returns>The nth root of the product, which is also the baseVal</returns>
        public double Root(double product, double nthRoot)
        {
            return Math.Pow(product, 1 / nthRoot);
        }
    }
}