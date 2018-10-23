using ClassLibraryCalculateTheArea;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CalculateLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCircles()
        {
            int[] radiuses = new int[] { 2, 3, 4 };
            double[] areas = new double[] { 12.5663706144, 28.2743338823, 50.2654824574 };
            for (int i = 0; i < radiuses.Length; i++)
            {
                Circle a = new Circle(radiuses[i]);
                double result = a.CalculateTheArea();
                Assert.AreEqual(result, areas[i], 0.000001, String.Format("Expected for '{0}'; Actual: {1}",
                                     result, areas[i]));
            }
        }

        [TestMethod]
        public void TestRectangles()
        {
            int [,] values = new int[,] { { 4, 5, 6 }, { 3, 4, 5 }, { 5, 6, 7 } };
            double[] areas = new double[] { 9.921567416, 6.0, 14.69693845 };
            for (int i = 0; i < 3; i++)
            {
                Rectangle a = new Rectangle(values[i, 0], values[i, 1], values[i, 2]);
                double result = a.CalculateTheArea();
                Assert.AreEqual(result, areas[i], 0.000001, String.Format("Expected for {0}; Actual: {1}",
                                     areas[i], result));
            }
        }
    }
}