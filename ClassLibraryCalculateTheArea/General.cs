using System;

namespace ClassLibraryCalculateTheArea
{
    /// <summary>
///  Calculating the area without knowing the type of the figure
/// </summary>

    public static class General 
    {
        public static double CalcTheArea(int radius) //calculate the area of a circle
        {
            double area = 0;
            area = Math.PI * radius * radius;
            return area;
        }

        public static double CalcTheArea(int a, int b, int c) //calculate the area of a rectangle
        {
            double area = 0;
            // Geron method
            double p = (a + b + c) / 2.0; // half-perimeter
            area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }

        // ...any other figures
    }
}
