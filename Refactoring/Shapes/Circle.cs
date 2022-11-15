using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.Shapes
{
    public class Circle : IShape
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double CalculateSurfaceArea()
        {
            return Math.Round(Math.PI * (_radius * _radius), 2);
        }
    }
}
