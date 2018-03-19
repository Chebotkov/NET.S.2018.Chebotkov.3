using System;

namespace Newton
{
    /// <summary>
    /// This class contains method for extraction of a root.
    /// </summary>
    public class Newton
    {
        #region FindNthRoot
        /// <summary>
        /// This method extracts a root from the number with method of Newton.
        /// </summary>
        /// <param name="number">Number</param>
        /// <param name="root">Root</param>
        /// <param name="precision">Precision</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <returns>Root of a number</returns>
        public static double FindNthRoot(double number, int root, double precision)
        {
            if (precision > 1 || precision < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if(root <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if(number <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            double xk = number / root;
            Console.WriteLine("xk=", xk);
            double xk1 = 1.0 / root * (((root - 1) * xk) + (number / Math.Pow(xk, root - 1)));

            while (Math.Abs(xk1 - xk) >= precision)
            {
                xk = xk1;
                xk1 = 1.0 / root * (((root - 1) * xk) + (number / Math.Pow(xk, root - 1)));

                Console.WriteLine(xk1);
            }

            return xk1;
        }
        #endregion
    }
}
