using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.Shapes
{
    public class Square : IShape
    {
        private double _side;
        public Square(double side)
        {
            _side = side;
        }

        public double CalculateSurfaceArea()
        {
            return _side * _side;
        }
    }
}
