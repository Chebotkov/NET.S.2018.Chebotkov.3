﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Newton_MSTests
{
    /// <summary>
    /// Test class for FindNthRoot
    /// </summary>
    [TestClass]
    public class FindNthRootTests
    {
        /// <summary>
        /// Test method
        /// </summary>
        [TestMethod]
        public void TestsForFindNthRoot1()
        {
            //Arange
            double number = 1;
            int root = 5;
            double precision = 0.0001;
            double expectedResult = 1;

            //Act
            double result = Newton.Newton.FindNthRoot(number, root, precision);

            //Assert
            Assert.AreEqual(expectedResult, result, precision);
        }

        /// <summary>
        /// Test method
        /// </summary>
        [TestMethod]
        public void TestsForFindNthRoot2()
        {
            //Arange
            double number = 8;
            int root = 3;
            double precision = 0.0001;
            double expectedResult = 2;

            //Act
            double result = Newton.Newton.FindNthRoot(number, root, precision);

            //Assert
            Assert.AreEqual(expectedResult, result, precision);
        }

        /// <summary>
        /// Test method
        /// </summary>
        [TestMethod]
        public void TestsForFindNthRoot3()
        {
            //Arange
            double number = 0.001;
            int root = 3;
            double precision = 0.0001;
            double expectedResult = 0.1;

            //Act
            double result = Newton.Newton.FindNthRoot(number, root, precision);

            //Assert
            Assert.AreEqual(expectedResult, result, precision);
        }

        /// <summary>
        /// Test method
        /// </summary>
        [TestMethod]
        public void TestsForFindNthRoot4()
        {
            //Arange
            double number = 0.04100625;
            int root = 4;
            double precision = 0.0001;
            double expectedResult = 0.45;

            //Act
            double result = Newton.Newton.FindNthRoot(number, root, precision);

            //Assert
            Assert.AreEqual(expectedResult, result, precision);
        }

        /// <summary>
        /// Test method
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestsForFindNthRoot5()
        {
            //Arange
            double number = 8;
            int root = -15;
            double precision = 0.001;
            double expectedResult = -5;

            //Act
            double result = Newton.Newton.FindNthRoot(number, root, precision);

            //Assert
            Assert.AreEqual(expectedResult, result, precision);
        }

        /// <summary>
        /// Test method
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestsForFindNthRoot6()
        {
            //Arange
            double number = 8;
            int root = 15;
            double precision = -7;
            double expectedResult = -5;

            //Act
            double result = Newton.Newton.FindNthRoot(number, root, precision);

            //Assert
            Assert.AreEqual(expectedResult, result, precision);
        }

        /// <summary>
        /// Test method
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestsForFindNthRoot7()
        {
            //Arange
            double number = 8;
            int root = 15;
            double precision = -0.6;
            double expectedResult = -0.1;

            //Act
            double result = Newton.Newton.FindNthRoot(number, root, precision);

            //Assert
            Assert.AreEqual(expectedResult, result, precision);
        }

        /// <summary>
        /// Test method
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestsForFindNthRoot8()
        {
            //Arange
            double number = -3;
            int root = 32;
            double precision = 0.001;
            double expectedResult = -5;

            //Act
            double result = Newton.Newton.FindNthRoot(number, root, precision);

            //Assert
            Assert.AreEqual(expectedResult, result, precision);
        }
    }
}
