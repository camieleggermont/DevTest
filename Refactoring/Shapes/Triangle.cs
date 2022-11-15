using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.Shapes
{
    public class Triangle : IShape
    {
        private double _height;
        private double _width;
        public Triangle(double height, double width)
        {
            _height = height;
            _width = width;
        }

        public double CalculateSurfaceArea()
        {
            return 0.5 * (_height * _width);
        }
    }
}
