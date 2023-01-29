using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareSolver
{
    public class SquareFinder
    {
        public SquareFinder() { }
        
        public double FindSquare(Circle circle)
        {
            var pi = 3.14;
            var squareOfCircle = (circle.Radius * circle.Radius) * pi;
            return squareOfCircle;
        }

        public double FindSquare(Triangle triangle)
        {
            var sermiPerimeter = (triangle.FirstSide + triangle.SecondSide + triangle.ThirdSide) / 2;
            var square = Math.Sqrt(sermiPerimeter * (sermiPerimeter - triangle.FirstSide) * (sermiPerimeter - triangle.SecondSide) * (sermiPerimeter - triangle.ThirdSide));

            return square;
        }
    }
}
