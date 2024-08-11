namespace WitchSaga.Core
{
    /// <summary>
    /// Represents the witch who controls the village and determines the number of villagers killed each year.
    /// </summary>
    public class Witch
    {
        static int fib(int n)
        {
            int[,] F = new int[,] { { 1, 1 }, { 1, 0 } };
            if (n == 0)
                return 0;
            power(F, n - 1);

            return F[0, 0];
        }

        static void multiply(int[,] F, int[,] M)
        {
            int x = F[0, 0] * M[0, 0] + F[0, 1] * M[1, 0];
            int y = F[0, 0] * M[0, 1] + F[0, 1] * M[1, 1];
            int z = F[1, 0] * M[0, 0] + F[1, 1] * M[1, 0];
            int w = F[1, 0] * M[0, 1] + F[1, 1] * M[1, 1];

            F[0, 0] = x;
            F[0, 1] = y;
            F[1, 0] = z;
            F[1, 1] = w;
        }

        /* Optimized version of
        power() in method 4 */
        static void power(int[,] F, int n)
        {
            if (n == 0 || n == 1)
                return;
            int[,] M = new int[,] { { 1, 1 }, { 1, 0 } };

            power(F, n / 2);
            multiply(F, F);

            if (n % 2 != 0)
                multiply(F, M);
        }

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

            return fib(year + 2) - 1;
        }
    }
}