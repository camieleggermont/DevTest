using Refactoring.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring
{
    public class SurfaceAreaCalculator
    {
        private List<IShape> _listAreas { get; set; }

        public SurfaceAreaCalculator()
        {
            _listAreas = new List<IShape>();
        }

        public void AddShape(IShape shape)
        {
            _listAreas.Add(shape);
        }

        public void Reset()
        {
            _listAreas?.Clear();
        }

        public IEnumerable<string> GetSurfaceAreasReadableOutput()
        {
            int i=0;
            foreach(IShape shape in _listAreas)
            {
                yield return $"[{i++}] {shape.GetType().Name} surface area is {shape.CalculateSurfaceArea()}";
            }
        }

        public IEnumerable<double> CalculateSurfaceAreas()
        {
            int i = 0;
            foreach (IShape shape in _listAreas)
            {
                yield return shape.CalculateSurfaceArea();
            }
        }
    }
}
