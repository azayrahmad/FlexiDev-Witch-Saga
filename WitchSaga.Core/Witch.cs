namespace WitchSaga.Core
{
    /// <summary>
    /// Represents the witch who controls the village and determines the number of villagers killed each year.
    /// </summary>
    public class Witch
    {
        /// <summary>
        /// Returns the Fibonacci number at specific position.
        /// </summary>
        /// <param name="n">Position of the Fibonacci number</param>
        /// <returns>Fibonacci number at the position</returns>
        private int FibonacciAt(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return FibonacciAt(n - 1) + FibonacciAt(n - 2);
            }
        }

        /// <summary>
        /// Decides the number of villagers to be killed in a specific year.
        /// </summary>
        /// <param name="year">The year to calculate for (1-based index).</param>
        /// <returns>The number of villagers killed in the specified year.</returns>
        /// <exception cref="ArgumentException">Thrown when the year is less than 1.</exception>
        public int GetKilledInYear(int year)
        {
            if (year < 1)
                throw new ArgumentException("Year must be positive", nameof(year));

            return FibonacciAt(year + 2) - 1;
        }
    }
}