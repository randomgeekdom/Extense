using System;
using System.Runtime.CompilerServices;

namespace Extense
{
    /// <summary>
    /// Extensions used for randomization
    /// </summary>
    public static class RandomExtensions
    {
        /// <summary>
        /// Returns true based on a percent chance
        /// </summary>
        /// <param name="random">The random object</param>
        /// <param name="percentage">Percent chance that the method will return true</param>
        /// <returns></returns>
        /// <exception cref="NullReferenceException">Random must not be null</exception>
        /// <exception cref="ArgumentOutOfRangeException">Percentage must be between 1 and 99</exception>
        public static bool NextBool(this Random random, int percentage = 50)
        {
            if (random == null)
            {
                throw new NullReferenceException(nameof(random) + " cannot be null.");
            }

            if (percentage < 1 || percentage > 99)
            {
                throw new ArgumentOutOfRangeException(nameof(percentage) + " must be between 1 and 99");
            }

            return random.Next(0, 101) < percentage;
        }
    }
}