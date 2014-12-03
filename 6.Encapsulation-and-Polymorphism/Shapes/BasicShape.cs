using System;

namespace Shapes
{
    public abstract class BasicShape : IShape
    {
        public BasicShape(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public int Width { get; set; }
        public int Height { get; set; }

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();
    }
}
