using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryCalculateTheArea
{
    public class Rectangle: Figure
    {
        private int a;
        private int b;
        private int c;
        public Rectangle(int A, int B, int C)
        {
            if ((A > 0) && (B > 0) && (C > 0))
            {
                a = A;
                b = B;
                c = C;
            }
            else throw new Exception("Sides should be a positive numbers!");
        }

        public override double CalculateTheArea() //calculate the area of a rectangle
        {
            int temp = 0; // for changing values
            int hypotenuse = a;
            int cathet1 = b;
            int cathet2 = c;
            if (cathet1 > hypotenuse) // Start to search the hypotenuse, the longest = biggest side
            {
                temp = hypotenuse;
                hypotenuse = cathet1; // changing values
                cathet1 = temp;
            }
            if (cathet2 > hypotenuse)
            {
                temp = hypotenuse;
                hypotenuse = cathet2;
                cathet2 = temp;
            }
            if ((hypotenuse * hypotenuse) == (cathet1 * cathet1 + cathet2 * cathet2)) //Pifagor theorema
                return cathet1 * cathet2 / 2;
            else // Geron method
            {
                double p = (a + b + c) / 2.0; // half-perimeter
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }
    }
}
