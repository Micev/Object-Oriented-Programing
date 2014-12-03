using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Circle : BasicShape, IShape
    {
        public Circle(int width)
            : base(width, width)
        {

        }

        public override double CalculateArea()
        {
            return Math.PI * (this.Width / 2) * (this.Width / 2);
        }
        public override double CalculatePerimeter()
        {
            return Math.PI * this.Width;
        }
    }
}
