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
        /// <exception cref="ArgumentOutOfRangeException">Throws when was entered wrong precision or root and number are wrong.</exception>
        /// <returns>Root of a number</returns>
        public static double FindNthRoot(double number, int root, double precision)
        {
            if (precision > 1 || precision < 0)
            {
                throw new ArgumentOutOfRangeException("Wrong precision.");
            }

            if(root <= 0)
            {
                throw new ArgumentOutOfRangeException("Wrong root. Root must be positive.");
            }

            if(number <= 0 && root%2==0)
            {
                throw new ArgumentOutOfRangeException("Can't get even root from negative number.");
            }

            double XPrevious = number / root;
            Console.WriteLine("XPrevious=", XPrevious);
            double XNext = 1.0 / root * (((root - 1) * XPrevious) + (number / Math.Pow(XPrevious, root - 1)));

            while (Math.Abs(XNext - XPrevious) >= precision)
            {
                XPrevious = XNext;
                XNext = 1.0 / root * (((root - 1) * XPrevious) + (number / Math.Pow(XPrevious, root - 1)));

                Console.WriteLine(XNext);
            }

            return XNext;
        }
        #endregion
    }
}
