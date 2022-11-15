using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.Shapes
{
    public class Rectangle : IShape
    {
        private double _height;

        private double _width;

        public Rectangle(double height, double width)
        {
            _height = height;
            _width = width;
        }

        public double CalculateSurfaceArea()
        {
            return _height * _width;
        }
    }
}
