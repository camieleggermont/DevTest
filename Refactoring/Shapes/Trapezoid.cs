using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.Shapes
{
    public class Trapezoid : IShape
    {
        private double _base1;
        private double _base2;
        private double _height;


        public Trapezoid(double base1, double base2, double height)
        {
            _base1 = base1;
            _base2 = base2;
            _height = height;
        }

        public double CalculateSurfaceArea()
        {
            return (0.5 * _height) * (_base1 + _base2);
        }
    }
}
