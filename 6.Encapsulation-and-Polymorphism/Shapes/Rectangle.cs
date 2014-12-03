using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rectangle : BasicShape, IShape
    {
        public Rectangle(int width, int height)
            : base(width,height)
        {

        }

        public override double CalculateArea()
        {
            return this.Width * this.Height;
        }
        public override double CalculatePerimeter()
        {
            return this.Height * 2 + this.Width * 2;
        }
    }
}
