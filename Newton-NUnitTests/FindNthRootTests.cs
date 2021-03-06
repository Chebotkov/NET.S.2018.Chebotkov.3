﻿using NUnit.Framework;

namespace Newton_NUnitTests
{
    /// <summary>
    /// Test class for FindNthRoot
    /// </summary>
    [TestFixture]
    public class FindNthRootTests
    {
        /// <summary>
        /// Test method for FindNthRoot 
        /// </summary>
        /// <param name="number">Number</param>
        /// <param name="root">Root</param>
        /// <param name="precision">Precision</param>
        /// <param name="expectedResult">Expected Result</param>
        [TestCase(1, 5, 0.0001, 1)]
        [TestCase(8, 3, 0.0001, 2)]
        [TestCase(0.001, 3, 0.0001, 0.1)]
        [TestCase(0.04100625, 4, 0.0001, 0.45)]
        [TestCase(8, 3, 0.0001, 2)]
        [TestCase(0.0279936, 7, 0.0001, 0.6)]
        [TestCase(0.0081, 4, 0.1, 0.3)]
        public void TestsForFindNthRoot(double number, int root, double precision, double expectedResult)
        {
            double result = Newton.Newton.FindNthRoot(number, root, precision);
            Assert.AreEqual(expectedResult, result, precision);
        }
    }
}
