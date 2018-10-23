using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryCalculateTheArea
{
    public class Circle : Figure
    {
        private int radius;
        public Circle (int Radius)
        {
            if (Radius > 0)
                radius = Radius;
            else throw new Exception("Radius should be a positive number");
        }

        public override double CalculateTheArea() //calculate the area of a circle
        {
            double area = 0;
            area = Math.PI * radius * radius;
            return area;
        }
    }
}
