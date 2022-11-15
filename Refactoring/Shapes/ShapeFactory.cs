using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.Shapes
{
    public class ShapeFactory
    {
        private Circle CreateCircle(string[] param)
        {
            if (param == null || param.Length == 0) throw new ArgumentException("No radius provided");
            if (double.TryParse(param[0], out double radius))
            {
                return new Circle(radius);
            }
            else
            {
                throw new ArgumentException($"Incorrect radius {param[0]}");
            }
        }

        private Rectangle CreateRectangle(string[] param)
        {
            if (param == null || param.Length < 2) throw new ArgumentException("Height and/or width not provided");
            if ((double.TryParse(param[0], out double height)) && (double.TryParse(param[1], out double width)))
            {
                return new Rectangle(height, width);            }
            else
            {
                throw new ArgumentException($"Incorrect height dimenenstions for {typeof(Rectangle).Name}");
            }
        }

        private Square CreateSquare(string[] param)
        {
            if (param == null || param.Length < 1) throw new ArgumentException("Side not provided");
            if (double.TryParse(param[0], out double side))
            {
                return new Square(side);
            }
            else
            {
                throw new ArgumentException($"Incorrect side {param[0]}");
            }
        }


        private Triangle CreateTriangle(string[] param)
        {
            if (param == null || param.Length < 2) throw new ArgumentException("Height and/or width not provided");
            if ((double.TryParse(param[0], out double height)) && (double.TryParse(param[1], out double width)))
            {
                return new Triangle(height, width);
            }
            else
            {
                throw new ArgumentException($"Incorrect height dimenenstions for {typeof(Triangle).Name}");
            }
        }

        private Trapezoid CreateTrapezoid(string[] param)
        {
            if (param == null || param.Length < 3) throw new ArgumentException("Base1, base2 and/or height not provided");
            if ((double.TryParse(param[0], out double base1)) && (double.TryParse(param[1], out double base2)) && (double.TryParse(param[2], out double height)))
            {
                return new Trapezoid(base1, base2, height);
            }
            else
            {
                throw new ArgumentException($"Incorrect height dimenenstions for {typeof(Trapezoid).Name}");
            }
        }


        public IShape GetShape(string shape, string[] param)
        {
            switch (shape)
            {
                case "circle":
                    return CreateCircle(param);
                case "rectangle":
                    return CreateRectangle(param);
                case "square":
                    return CreateSquare(param);
                case "triangle":
                    return CreateTriangle(param);
                case "trapezoid":
                    return CreateTrapezoid(param);

                default:
                    throw new ArgumentException("Unknown shape");
            }
        }

        public IShape GetShape(string[] param)
        {
            if (param == null || param.Length == 0) throw new ArgumentException("No shape provided.");
            return GetShape(param[0], param.Skip(1).ToArray());
        }
    }
}
