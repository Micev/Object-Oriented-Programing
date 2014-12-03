using System;

namespace Shapes
{
    public class Triangle : BasicShape, IShape
    {
        public Triangle(int width, int height)
            : base(width, height)
        {

        }

        public override double CalculateArea()
        {
            return (this.Width * this.Height) / 2;
        }
        public override double CalculatePerimeter()
        {
            double sideC = Math.Sqrt((double)Math.Pow(this.Width / 2, 2) + (double)Math.Pow(this.Height, 2));
            return sideC * 2 + this.Width;
        }
    }
}
