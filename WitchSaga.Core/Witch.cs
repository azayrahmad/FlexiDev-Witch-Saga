using System.Numerics;

namespace WitchSaga.Core
{
    /// <summary>
    /// Represents the witch who controls the village and determines the number of villagers killed each year.
    /// </summary>
    public class Witch
    {
        #region Fibonacci

        /// <summary>
        /// Returns the Fibonacci number at specific position using Nth Power of Matrix Approach.
        /// </summary>
        /// <param name="n">Position of the Fibonacci number</param>
        /// <returns>Fibonacci number at the position</returns>
        static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 31; i >= 0; i--)
            {
                int d = a * (b * 2 - a);
                int e = a * a + b * b;
                a = d;
                b = e;
                if ((((uint)n >> i) & 1) != 0)
                {
                    int c = a + b;
                    a = b;
                    b = c;
                }
            }
            return a;
        }

        /// <summary>
        /// Multiply a matrix
        /// </summary>
        /// <param name="F">Matrix to multiply</param>
        /// <param name="M">Matrix multiplier</param>
        static void Multiply(int[,] F, int[,] M)
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

        /// <summary>
        /// Power of Matrix
        /// </summary>
        /// <param name="F">Matrix</param>
        /// <param name="n">Power</param>
        static void Power(int[,] F, int n)
        {
            if (n == 0 || n == 1)
                return;
            int[,] M = new int[,] { { 1, 1 }, { 1, 0 } };

            Power(F, n / 2);
            Multiply(F, F);

            if (n % 2 != 0)
                Multiply(F, M);
        }
        #endregion

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

            return Fibonacci(year + 2) - 1;
        }
    }
}