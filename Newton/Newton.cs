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
        public static double FindNthRoot(double number, double root, double precision)
        {
            if (precision > 1 || precision < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            double xk = number / root;
            Console.WriteLine("xk=", xk);
            double xk1 = 1 / root * (((root - 1) * xk) + (number / Math.Pow(xk, (int)root - 1)));

            while (Math.Abs(xk1 - xk) >= precision)
            {
                xk = xk1;
                xk1 = 1 / root * (((root - 1) * xk) + (number / Math.Pow(xk, (int)root - 1)));

                Console.WriteLine(xk1);
            }

            return RoundWithPrecision(xk1, precision);
        }
        #endregion

        #region private method
        /// <summary>
        /// Method rounds number with preset precision.
        /// </summary>
        /// <param name="number">Number</param>
        /// <param name="precision">Precision</param>
        /// <returns>Rounded nubmer</returns>
        private static double RoundWithPrecision(double number, double precision)
        {
            int power = 0;
            while (precision < 1)
            {
                power++;
                precision *= 10;
            }

            return (double)(int)(number * Math.Pow(10, power)) / Math.Pow(10, power);
        }
        #endregion
    }
}
